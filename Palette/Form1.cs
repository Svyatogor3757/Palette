using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Palette
{

    public partial class Form1 : Form
    {

        private MyColor _color = new MyColor(Color.White);
        public MyColor color {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                CurrentColor.BackColor = _color.DrawingColor;
            }
        }
        Dictionary<string, string> langs = new Dictionary<string, string>();
        private string copytext = "{Copy to clipboard}";
        private string about = "Приложение для работы с цветами и копированием цвета в буфер обмена.\nДоступна история выбранных цветов и загрузка HEX цветов формата (#FFFFFF) из файла.\nПипетка - для работы с пипеткой зажмите кнопку пипетка и наведите на нужную область\nКлик по цвету:\nОдиночный клик - отобразить цвет,\nДвойной клик - скопировать в буфер обмена.\n";
        private string abouttitle = "{Reference}";
        private string currentlanguage = "English";
        private string currentlanguagefilename = "";
        private static string filesettings = "./Settings.ini";
        private static string filepalletesdir = "./Palettes";
        private static string filepalletes = $"{filepalletesdir}/history.txt";
        private static string filelocalizationdir = "./Localization";

        private int idColorType = 0;
        private int boxcolorsize = 32;
        private bool isSaveColor = true;
        Stack<Control> controls = new Stack<Control>();

        private static class NativeMethods
        {
            [DllImport("Gdi32.dll", CharSet = CharSet.Unicode)]
            public static extern int GetPixel(IntPtr hdc, int nXPos, int nYPos);
            [DllImport("Gdi32.dll", CharSet = CharSet.Unicode)]
            public static extern int SetPixel(int hdc, int X, int Y, int crColor);
            [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
            public static extern IntPtr CreateDC(string strDriver, string strDevice, string strOutput, IntPtr pData);
            [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
            public static extern bool DeleteDC(IntPtr hdc);
        }

        public Form1() {
            InitializeComponent();

            Directory.CreateDirectory(filepalletesdir);
            Directory.CreateDirectory(filelocalizationdir);
            LoadSettings();

            string[] langfiles = Directory.GetFiles(filelocalizationdir, "*.xml");
            foreach (string langfile in langfiles) {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(langfile);
                XmlElement xRoot = xDoc.DocumentElement;
                if (xRoot != null) {
                    langs.Add(xRoot.GetAttribute("name"), xRoot.GetAttribute("filename"));
                    languageToolStripMenuItem.DropDownItems.Add(xRoot.GetAttribute("name"));
                    if (currentlanguage == xRoot.GetAttribute("name"))
                        currentlanguagefilename = xRoot.GetAttribute("filename");
                }
            }

            languageLoad($"{filelocalizationdir}/{currentlanguagefilename}");
            foreach (ToolStripMenuItem item in FormatToolStripMenuItem.DropDownItems)
                item.Click += FormatOutput;
            foreach (ToolStripMenuItem item in languageToolStripMenuItem.DropDownItems)
                item.Click += LangSelect;
        }

        private void button3_Click(object sender, EventArgs e) {
            colorDialog.Color = color.DrawingColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                color = new MyColor(colorDialog.Color);
                updateColorInfo();
                SaveColor();
            }
        }
        private void button2_MouseDown(object sender, MouseEventArgs e) {
            pipette.Enabled = true;
            Cursor.Current = Cursors.Cross;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e) {
            pipette.Enabled = false;
            Cursor.Current = Cursors.Default;
            SaveColor();
        }

        private void timerClipBoard_Tick(object sender, EventArgs e) {
            labelInfoCopy.Visible = timerClipBoard.Enabled = false;
        }

        private void labelColor_Click(object sender, EventArgs e) {
            if (labelColor.Text.Length > 0)
                CopyColor();
        }

        private void pipette_Tick(object sender, EventArgs e) {
            IntPtr hdcScreen = NativeMethods.CreateDC("Display", null, null, IntPtr.Zero);
            int rgb = NativeMethods.GetPixel(hdcScreen, Cursor.Position.X, Cursor.Position.Y);
            color = new MyColor(rgb);
            NativeMethods.DeleteDC(hdcScreen);
            trackBar1.Value = 255;
            labelnum.Text = "255";
            updateColorInfo();
        }
        private void button1_Click(object sender, EventArgs e) {
            contextMenuStrip.Show(Cursor.Position);
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e) {
            groupBox1.Visible = !groupBox1.Visible;
            HideToolStripMenuItem.Checked = !groupBox1.Visible;
        }

        private void FormatOutput(object sender, EventArgs e) {
            ToolStripMenuItem me = (ToolStripMenuItem)sender;
            int a = me.GetCurrentParent().Items.IndexOf(me);
            foreach (ToolStripMenuItem b in me.GetCurrentParent().Items) {
                b.Checked = false;
            }
            me.Checked = true;
            idColorType = a >= 0 ? a : 0;
            getControlColor(CurrentColor, e);
        }

        private void LangSelect(object sender, EventArgs e) {
            ToolStripMenuItem me = (ToolStripMenuItem)sender;
            currentlanguage = me.Text;
            Application.Restart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            SaveSettings();
        }

        private void ClearHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            controls.Clear();
            flowLayoutPanelColors.Controls.Clear();
            RemoteHistoryToolStripMenuItem.Visible = true;
        }

        private void ReturnHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (File.Exists(filepalletes))
                    SaveColors(File.ReadAllText(filepalletes).Trim().Replace("\r", "").Split('\n').Reverse().ToArray());
            } catch (Exception) {

            }
            RemoteHistoryToolStripMenuItem.Visible = false;
        }

        private void LoadHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    SaveColors(File.ReadAllText(openFileDialog.FileName).Trim().Replace("\r", "").Split('\n').Reverse().ToArray());
            } catch (Exception) {

            }
        }

        private void SaveColorsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveColorToolStripMenuItem.Checked = isSaveColor = !isSaveColor;
        }

        private void CurrentColor_Click(object sender, EventArgs e) {
            updateColorInfo();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            Color c = CurrentColor.BackColor;

            color = new MyColor(Color.FromArgb(trackBar1.Value, c));
            updateColorInfo();
            labelnum.Text = trackBar1.Value.ToString();
        }

        private void ResetWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            Size = new Size(772, 580);
        }

        private void RemotetrToolStripMenuItem_Click(object sender, EventArgs e) {
            trackBar1.Visible = labelnum.Visible = RemoteTrToolStripMenuItem.Checked = !RemoteTrToolStripMenuItem.Checked;
        }
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(about, abouttitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripComboBox1_TextUpdate(object sender, EventArgs e) {
            if (toolStripComboBox1.Text.Length < 1) return;
            flowLayoutPanelColors.SuspendLayout();
            boxcolorsize = int.Parse(toolStripComboBox1.Text);
            foreach (Control a in flowLayoutPanelColors.Controls) {
                a.Size = new Size(boxcolorsize, boxcolorsize);
            }
            flowLayoutPanelColors.ResumeLayout();
            //flowLayoutPanelColors.Refresh();
        }
        private void SaveHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    //SaveColors(File.ReadAllText(saveFileDialog.FileName).Trim().Replace("\r", "").Split('\n').Reverse().ToArray());
                    string filesave = "";
                    foreach (Control control in controls)
                        filesave += MyColor.GetHexColor(control.BackColor) + "\r\n";
                    File.WriteAllText(saveFileDialog.FileName, filesave.Trim());
                }
            } catch (Exception) {

            }
        }

        private void updateColorInfo() {
            CurrentColor.BackColor = color.DrawingColor;
            labelColor.Text = getColor();
            labelColor.ForeColor = color.DrawingColor;
            if (color.DrawingColor.R > 200 || color.DrawingColor.G > 200 || color.DrawingColor.B > 200) {
                panel1.BackColor = Color.FromArgb(32, 32, 32);
                labelInfoCopy.ForeColor = labelnum.ForeColor = Color.FromArgb(240, 240, 240);
            } else {
                panel1.BackColor = Color.FromArgb(240, 240, 240);
                labelInfoCopy.ForeColor = labelnum.ForeColor = Color.FromArgb(32, 32, 32);
            }
        }
        private void CopyColor() {
            timerClipBoard.Stop();
            labelInfoCopy.Text = string.Format(copytext, labelColor.Text);
            Clipboard.SetText(labelColor.Text);
            labelInfoCopy.Visible = timerClipBoard.Enabled = true;
        }

        private string getColor() {
            switch (idColorType) {
                case 0:
                    return color.Hex;
                case 1:
                    return color.AHex;
                case 2:
                    return string.Format("{0:D3}{1:D3}{2:D3}", color.DrawingColor.R, color.DrawingColor.G, color.DrawingColor.B);
                case 3:
                    return string.Format("{0:D3}{1:D3}{2:D3}{3:D3}", color.DrawingColor.A, color.DrawingColor.R, color.DrawingColor.G, color.DrawingColor.B);
                case 4: //ARGB Visual Studio
                    return color.DrawingColor.ToArgb().ToString();

                case 5: //HSV
                    double hue, saturation, value;
                    MyColor.ColorToHSV(color.DrawingColor, out hue, out saturation, out value);
                    return string.Format("{0:D3}{1:D3}{2:D3}", (int)Math.Round(hue, 0), (int)Math.Round(saturation * 100, 0), (int)Math.Round(value * 100, 0));
                case 6: //HSL
                    return string.Format("{0:D3}{1:D3}{2:D3}", (int)Math.Round(color.DrawingColor.GetHue(), 0), (int)Math.Round(color.DrawingColor.GetSaturation() * 100, 0), (int)Math.Round(color.DrawingColor.GetBrightness() * 100, 0));
                case 7: //COLORREF (BGR)
                    return ColorTranslator.ToWin32(color.DrawingColor).ToString();
                default:
                    return color.Hex;
            }
        }
        private void getControlColor(object sender, EventArgs e) {
            Control me = (Control)sender;
            color = new MyColor(me.BackColor);
            trackBar1.Value = color.DrawingColor.A;
            labelnum.Text = trackBar1.Value.ToString();
            updateColorInfo();
        }

        private void SaveColor(Color _color) {
            if (!isSaveColor) return;
            Panel a = new Panel();
            a.Size = new Size(boxcolorsize, boxcolorsize);
            a.BackColor = _color;
            a.BorderStyle = BorderStyle.FixedSingle;
            a.Click += getControlColor;
            a.DoubleClick += labelColor_Click;
            if (!ContainsSaveColor(_color))
                controls.Push(a);
        }
        private void SaveColor() {
            if (!isSaveColor) return;
            if (!ContainsSaveColor(color.DrawingColor)) {
                SaveColor(color.DrawingColor);
                flowLayoutPanelColors.Controls.Clear();
                flowLayoutPanelColors.Controls.AddRange(controls.ToArray());
            }
        }
        private void SaveColors(Color[] colors) {
            if (!isSaveColor) return;
            foreach (Color _color in colors)
                SaveColor(_color);
            flowLayoutPanelColors.Controls.Clear();
            flowLayoutPanelColors.Controls.AddRange(controls.ToArray());

        }
        private void SaveColors(string[] colors) {
            if (!isSaveColor) return;
            foreach (string _colorstring in colors)
                SaveColor(ColorTranslator.FromHtml(_colorstring));
            flowLayoutPanelColors.Controls.Clear();
            flowLayoutPanelColors.Controls.AddRange(controls.ToArray());

        }

        bool ContainsSaveColor(Color _color) {
            foreach (Control control in controls)
                if (control.BackColor == _color) return true;
            return false;
        }

        private void SaveSettings() {
            if (!File.Exists(filesettings)) File.Create(filesettings).Close();
            INIManager FS = new INIManager(filesettings);
            FS.WritePrivateString("Main", "Language", currentlanguage);
            FS.WritePrivateString("Main", "Format", idColorType.ToString());
            FS.WritePrivateString("Main", "IsSaveColor", isSaveColor.ToString());
            FS.WritePrivateString("Main", "IsHidePalette", (!groupBox1.Visible).ToString());
            FS.WritePrivateString("Main", "IsRemoteAlpha", trackBar1.Visible.ToString());
            FS.WritePrivateString("Main", "SizeWidth", Size.Width.ToString());
            FS.WritePrivateString("Main", "SizeHeight", Size.Height.ToString());
            FS.WritePrivateString("Main", "SizeColorBox", boxcolorsize.ToString());

            if (controls.Count < 1) { if (File.Exists(filepalletes)) File.Delete(filepalletes); return; }
            FileStream fhistory = new FileStream(filepalletes, FileMode.Create);
            foreach (Control control in controls) {
                byte[] input = Encoding.Default.GetBytes(MyColor.GetHexColor(control.BackColor) + "\r\n");
                fhistory.Write(input, 0, input.Length);
            }
            fhistory.Close();
        }
        private void LoadSettings() {
            try {
                INIManager FS = new INIManager(filesettings);
                //FS.GetPrivateString();
                string _lang = FS.GetPrivateString("Main", "Language");
                if (_lang != "Default")
                    currentlanguage = _lang;
                idColorType = int.Parse(FS.GetPrivateString("Main", "Format"));
                ((ToolStripMenuItem)FormatToolStripMenuItem.DropDownItems[idColorType]).Checked = true;
                if (idColorType != 0) ((ToolStripMenuItem)FormatToolStripMenuItem.DropDownItems[0]).Checked = false;
                SaveColorToolStripMenuItem.Checked = isSaveColor = bool.Parse(FS.GetPrivateString("Main", "IsSaveColor"));
                bool isHidepalette = bool.Parse(FS.GetPrivateString("Main", "IsHidePalette"));
                groupBox1.Visible = !isHidepalette;
                HideToolStripMenuItem.Checked = isHidepalette;
                trackBar1.Visible = labelnum.Visible = RemoteTrToolStripMenuItem.Checked = bool.Parse(FS.GetPrivateString("Main", "IsRemoteAlpha"));
                string bcs = FS.GetPrivateString("Main", "SizeColorBox");
                toolStripComboBox1.Items.Add(bcs);
                toolStripComboBox1.Text = bcs;
                boxcolorsize = int.Parse(bcs);
                Size = new Size(int.Parse(FS.GetPrivateString("Main", "SizeWidth")), int.Parse(FS.GetPrivateString("Main", "SizeHeight")));
                if (File.Exists(filepalletes))
                    SaveColors(File.ReadAllText(filepalletes).Trim().Replace("\r", "").Split('\n').Reverse().ToArray());
            } catch (Exception) {

            }
        }

        public void languageLoad(string langfile = null) {
            Dictionary<string, string> currentlang = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(langfile) && File.Exists(langfile)) {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(langfile);
                XmlElement xRoot = xDoc.DocumentElement;
                if (xRoot != null)
                    foreach (XmlElement xnode in xRoot) currentlang.Add(xnode.GetAttribute("id"), xnode.GetAttribute("text"));
            }
            languageUse(currentlang, this);
            languageUse(currentlang, contextMenuStrip);
            copytext = languageGet(currentlang, copytext);
            abouttitle = languageGet(currentlang, abouttitle);
            string _tmp = languageGet(currentlang, "{About}").Replace("\\n", "\n");
            if (!string.IsNullOrEmpty(_tmp) && _tmp.Length > 20)
                about = _tmp;

            _tmp = languageGet(currentlang, "{Filter Save}");
            if (_tmp != "Filter Save" && !string.IsNullOrEmpty(_tmp))
                saveFileDialog.Filter = _tmp;
            _tmp = languageGet(currentlang, "{Filter Open}");
            if (_tmp != "Filter Open" && !string.IsNullOrEmpty(_tmp))
                openFileDialog.Filter = _tmp;
        }

        public void languageUse(Dictionary<string, string> currentlang, Control control) {
            control.Text = languageGet(currentlang, control.Text);
            if (control.GetType() == typeof(ContextMenuStrip)) {
                ContextMenuStrip ctr = (ContextMenuStrip)control;
                ctr.Text = languageGet(currentlang, ctr.Text);
                foreach (ToolStripItem item in ctr.Items) {
                    if (item.GetType() == typeof(ToolStripSeparator)) continue;
                    languageUse(currentlang, item);
                }
            } else {
                foreach (Control ctr in control.Controls) {
                    if (ctr.Controls.Count > 0) languageUse(currentlang, ctr);
                    ctr.Text = languageGet(currentlang, ctr.Text);
                }
            }
        }
        public void languageUse(Dictionary<string, string> currentlang, ToolStripItem control) {
            ToolStripMenuItem ctr = (ToolStripMenuItem)control;
            ctr.Text = languageGet(currentlang, ctr.Text);
            if (ctr.DropDownItems.Count > 0) {
                foreach (ToolStripItem item in ctr.DropDownItems) {
                    if (item.GetType() == typeof(ToolStripSeparator) || item.GetType() == typeof(ToolStripComboBox)) continue;
                    languageUse(currentlang, item);
                }
            }
        }

        public string languageGet(Dictionary<string, string> currentlang, string inputtext) {
            if (inputtext.Length > 2 && inputtext[0] == '{' && inputtext[inputtext.Length - 1] == '}') {
                string key = inputtext.Substring(1, inputtext.Length - 2);
                if (currentlang.ContainsKey(key))
                    return currentlang[key];
                else
                    return key;
            }
            return inputtext;
        }

    }

    public class MyColor
    {
        public readonly Color DrawingColor;
        public readonly string AHex;
        public readonly string Hex;
        private static readonly string sep = "#";


        public MyColor(Color _color) {
            DrawingColor = _color;
            AHex = GetHexColor(_color, true);
            Hex = GetHexColor(_color, false);
        }

        public static string GetHexColor(Color _color, bool isAlpha = false) {
            if (isAlpha)
                return string.Format("{0}{1:X2}{2:X2}{3:X2}{4:X2}",
                sep,
                _color.A,
                _color.R,
                _color.G,
                _color.B);
            else
                return string.Format("{0}{1:X2}{2:X2}{3:X2}",
                    sep,
                    _color.R,
                    _color.G,
                    _color.B);
        }
        public MyColor(string _color) : this(Color.FromName(_color)) {

        }
        public MyColor(int _color) : this(Color.FromArgb((_color & 0x000000FF), (_color & 0x0000FF00) >> 8, (_color & 0x00FF0000) >> 16)) {
            //DrawingColor = Color.FromArgb(_color);
        }
        public MyColor(int _r, int _g, int _b) : this(Color.FromArgb(_r, _g, _b)) {
            //DrawingColor = Color.FromArgb(_r, _g, _b);
        }
        public MyColor(int _a, int _r, int _g, int _b) : this(Color.FromArgb(_a, _r, _g, _b)) {
            //DrawingColor = Color.FromArgb(_a, _r, _g, _b);
        }

        public override string ToString() {
            return Hex;
        }
        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value) {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value) {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
    }
}
