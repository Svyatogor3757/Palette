
namespace Palette
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aHEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRGBVisualStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORREFBGRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PalleteParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoteTrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorCubeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.WindowResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveHistoryВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoteHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelnum = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelInfoCopy = new System.Windows.Forms.Label();
            this.CurrentColor = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelColors = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pipette = new System.Windows.Forms.Timer(this.components);
            this.timerClipBoard = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelnum);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelInfoCopy);
            this.panel1.Controls.Add(this.CurrentColor);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 166);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.labelColor_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ContextMenuStrip = this.contextMenuStrip;
            this.button1.Location = new System.Drawing.Point(649, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "{Settings}";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatToolStripMenuItem,
            this.PalleteParamsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.HelpToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 98);
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hEXToolStripMenuItem,
            this.aHEXToolStripMenuItem,
            this.rGBToolStripMenuItem,
            this.aRGBToolStripMenuItem,
            this.aRGBVisualStudioToolStripMenuItem,
            this.hSVToolStripMenuItem,
            this.hSLToolStripMenuItem,
            this.cOLORREFBGRToolStripMenuItem});
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FormatToolStripMenuItem.Text = "{Format}";
            // 
            // hEXToolStripMenuItem
            // 
            this.hEXToolStripMenuItem.Checked = true;
            this.hEXToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hEXToolStripMenuItem.Name = "hEXToolStripMenuItem";
            this.hEXToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.hEXToolStripMenuItem.Text = "HEX";
            // 
            // aHEXToolStripMenuItem
            // 
            this.aHEXToolStripMenuItem.Name = "aHEXToolStripMenuItem";
            this.aHEXToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aHEXToolStripMenuItem.Text = "AHEX";
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rGBToolStripMenuItem.Text = "RGB";
            // 
            // aRGBToolStripMenuItem
            // 
            this.aRGBToolStripMenuItem.Name = "aRGBToolStripMenuItem";
            this.aRGBToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aRGBToolStripMenuItem.Text = "ARGB";
            // 
            // aRGBVisualStudioToolStripMenuItem
            // 
            this.aRGBVisualStudioToolStripMenuItem.Name = "aRGBVisualStudioToolStripMenuItem";
            this.aRGBVisualStudioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aRGBVisualStudioToolStripMenuItem.Text = "ARGB (Visual Studio)";
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            // 
            // hSLToolStripMenuItem
            // 
            this.hSLToolStripMenuItem.Name = "hSLToolStripMenuItem";
            this.hSLToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.hSLToolStripMenuItem.Text = "HSL";
            // 
            // cOLORREFBGRToolStripMenuItem
            // 
            this.cOLORREFBGRToolStripMenuItem.Name = "cOLORREFBGRToolStripMenuItem";
            this.cOLORREFBGRToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cOLORREFBGRToolStripMenuItem.Text = "COLORREF (BGR)";
            // 
            // PalleteParamsToolStripMenuItem
            // 
            this.PalleteParamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveColorToolStripMenuItem,
            this.HideToolStripMenuItem,
            this.RemoteTrToolStripMenuItem,
            this.ColorCubeSettingsToolStripMenuItem,
            this.WindowResetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.LoadHistoryToolStripMenuItem,
            this.SaveHistoryВФайлToolStripMenuItem,
            this.ClearHistoryToolStripMenuItem,
            this.RemoteHistoryToolStripMenuItem});
            this.PalleteParamsToolStripMenuItem.Name = "PalleteParamsToolStripMenuItem";
            this.PalleteParamsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PalleteParamsToolStripMenuItem.Text = "{Palette Parameters}";
            // 
            // SaveColorToolStripMenuItem
            // 
            this.SaveColorToolStripMenuItem.Checked = true;
            this.SaveColorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveColorToolStripMenuItem.Name = "SaveColorToolStripMenuItem";
            this.SaveColorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.SaveColorToolStripMenuItem.Text = "{SaveColors}";
            this.SaveColorToolStripMenuItem.Click += new System.EventHandler(this.SaveColorsToolStripMenuItem_Click);
            // 
            // HideToolStripMenuItem
            // 
            this.HideToolStripMenuItem.Name = "HideToolStripMenuItem";
            this.HideToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.HideToolStripMenuItem.Text = "{Hide}";
            this.HideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // RemoteTrToolStripMenuItem
            // 
            this.RemoteTrToolStripMenuItem.Name = "RemoteTrToolStripMenuItem";
            this.RemoteTrToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.RemoteTrToolStripMenuItem.Text = "{Transparency Management}";
            this.RemoteTrToolStripMenuItem.Click += new System.EventHandler(this.RemotetrToolStripMenuItem_Click);
            // 
            // ColorCubeSettingsToolStripMenuItem
            // 
            this.ColorCubeSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.ColorCubeSettingsToolStripMenuItem.Name = "ColorCubeSettingsToolStripMenuItem";
            this.ColorCubeSettingsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ColorCubeSettingsToolStripMenuItem.Text = "{Color Cube size}";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "56",
            "58",
            "60"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "32";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextUpdate);
            // 
            // WindowResetToolStripMenuItem
            // 
            this.WindowResetToolStripMenuItem.Name = "WindowResetToolStripMenuItem";
            this.WindowResetToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.WindowResetToolStripMenuItem.Text = "{Reset Window size}";
            this.WindowResetToolStripMenuItem.Click += new System.EventHandler(this.ResetWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // LoadHistoryToolStripMenuItem
            // 
            this.LoadHistoryToolStripMenuItem.Name = "LoadHistoryToolStripMenuItem";
            this.LoadHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.LoadHistoryToolStripMenuItem.Text = "{Load History from a file}";
            this.LoadHistoryToolStripMenuItem.Click += new System.EventHandler(this.LoadHistoryToolStripMenuItem_Click);
            // 
            // SaveHistoryВФайлToolStripMenuItem
            // 
            this.SaveHistoryВФайлToolStripMenuItem.Name = "SaveHistoryВФайлToolStripMenuItem";
            this.SaveHistoryВФайлToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.SaveHistoryВФайлToolStripMenuItem.Text = "{Save History to a file}";
            this.SaveHistoryВФайлToolStripMenuItem.Click += new System.EventHandler(this.SaveHistoryToolStripMenuItem_Click);
            // 
            // ClearHistoryToolStripMenuItem
            // 
            this.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem";
            this.ClearHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ClearHistoryToolStripMenuItem.Text = "{Clear History}";
            this.ClearHistoryToolStripMenuItem.Click += new System.EventHandler(this.ClearHistoryToolStripMenuItem_Click);
            // 
            // RemoteHistoryToolStripMenuItem
            // 
            this.RemoteHistoryToolStripMenuItem.Name = "RemoteHistoryToolStripMenuItem";
            this.RemoteHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.RemoteHistoryToolStripMenuItem.Text = "{Undo history cleanup}";
            this.RemoteHistoryToolStripMenuItem.Visible = false;
            this.RemoteHistoryToolStripMenuItem.Click += new System.EventHandler(this.ReturnHistoryToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HelpToolStripMenuItem.Text = "{Reference}";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.Location = new System.Drawing.Point(373, 132);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(36, 20);
            this.labelnum.TabIndex = 7;
            this.labelnum.Text = "255";
            this.labelnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelnum.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(406, 127);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(240, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 255;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button3
            // 
            this.button3.Image = global::Palette.Properties.Resources.color2;
            this.button3.Location = new System.Drawing.Point(269, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "{Other}";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Palette.Properties.Resources.dropper;
            this.button2.Location = new System.Drawing.Point(160, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "{Pipette}";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // labelInfoCopy
            // 
            this.labelInfoCopy.AutoSize = true;
            this.labelInfoCopy.Location = new System.Drawing.Point(170, 10);
            this.labelInfoCopy.Name = "labelInfoCopy";
            this.labelInfoCopy.Size = new System.Drawing.Size(141, 20);
            this.labelInfoCopy.TabIndex = 1;
            this.labelInfoCopy.Text = "{Copy to clipboard}";
            this.labelInfoCopy.Visible = false;
            this.labelInfoCopy.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // CurrentColor
            // 
            this.CurrentColor.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentColor.Location = new System.Drawing.Point(9, 9);
            this.CurrentColor.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(148, 148);
            this.CurrentColor.TabIndex = 0;
            this.CurrentColor.Click += new System.EventHandler(this.CurrentColor_Click);
            this.CurrentColor.DoubleClick += new System.EventHandler(this.labelColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColor.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(160, 17);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(590, 107);
            this.labelColor.TabIndex = 2;
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColor.DoubleClick += new System.EventHandler(this.labelColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelColors);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(756, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "{Color}";
            // 
            // flowLayoutPanelColors
            // 
            this.flowLayoutPanelColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelColors.Location = new System.Drawing.Point(8, 27);
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            this.flowLayoutPanelColors.Size = new System.Drawing.Size(740, 340);
            this.flowLayoutPanelColors.TabIndex = 0;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // pipette
            // 
            this.pipette.Interval = 10;
            this.pipette.Tick += new System.EventHandler(this.pipette_Tick);
            // 
            // timerClipBoard
            // 
            this.timerClipBoard.Interval = 2400;
            this.timerClipBoard.Tick += new System.EventHandler(this.timerClipBoard_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Palette 1.txt";
            this.saveFileDialog.Filter = "Текстовые файлы|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 206);
            this.Name = "Form1";
            this.Text = "{Color palette}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelInfoCopy;
        private System.Windows.Forms.Panel CurrentColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer pipette;
        private System.Windows.Forms.Timer timerClipBoard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aHEXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PalleteParamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RemoteHistoryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem RemoteTrToolStripMenuItem;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.ToolStripMenuItem WindowResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorCubeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem SaveHistoryВФайлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem cOLORREFBGRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRGBVisualStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}

