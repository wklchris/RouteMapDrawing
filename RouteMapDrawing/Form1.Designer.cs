namespace RouteMapDrawing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDraw = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnShowpic = new System.Windows.Forms.Button();
            this.lstViewLine = new System.Windows.Forms.ListView();
            this.colheadNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadChname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadEnname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadLineNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddStation = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbChname = new System.Windows.Forms.Label();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.lbStationNo = new System.Windows.Forms.Label();
            this.cmbBoxNo = new System.Windows.Forms.ComboBox();
            this.lbFootnote = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetBkColor = new System.Windows.Forms.Button();
            this.btnSetLineColor = new System.Windows.Forms.Button();
            this.picBoxShowColor = new System.Windows.Forms.PictureBox();
            this.tbColorB = new System.Windows.Forms.TextBox();
            this.tbColorG = new System.Windows.Forms.TextBox();
            this.tbColorR = new System.Windows.Forms.TextBox();
            this.lbColorB = new System.Windows.Forms.Label();
            this.lbColorG = new System.Windows.Forms.Label();
            this.lbColorR = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ckBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.LstViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGiveUpInter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.LstViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDraw.Location = new System.Drawing.Point(959, 126);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(121, 37);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "导出";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(0, 0);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(144, 123);
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.picBox1);
            this.panel1.Location = new System.Drawing.Point(24, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 610);
            this.panel1.TabIndex = 2;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(815, 53);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(323, 30);
            this.tbPath.TabIndex = 3;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(720, 56);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(89, 20);
            this.lbPath.TabIndex = 4;
            this.lbPath.Text = "图片路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "文件名";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(815, 89);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(378, 30);
            this.tbFilename.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("宋体", 9F);
            this.btnBrowse.Location = new System.Drawing.Point(1153, 53);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 27);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnShowpic
            // 
            this.btnShowpic.Location = new System.Drawing.Point(815, 125);
            this.btnShowpic.Name = "btnShowpic";
            this.btnShowpic.Size = new System.Drawing.Size(114, 35);
            this.btnShowpic.TabIndex = 8;
            this.btnShowpic.Text = "预览";
            this.btnShowpic.UseVisualStyleBackColor = true;
            this.btnShowpic.Click += new System.EventHandler(this.btnShowpic_Click);
            // 
            // lstViewLine
            // 
            this.lstViewLine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadNo,
            this.colheadChname,
            this.colheadEnname,
            this.colheadLineNum,
            this.colheadX,
            this.colheadY});
            this.lstViewLine.FullRowSelect = true;
            this.lstViewLine.GridLines = true;
            this.lstViewLine.Location = new System.Drawing.Point(6, 0);
            this.lstViewLine.MultiSelect = false;
            this.lstViewLine.Name = "lstViewLine";
            this.lstViewLine.Size = new System.Drawing.Size(466, 296);
            this.lstViewLine.TabIndex = 9;
            this.lstViewLine.UseCompatibleStateImageBehavior = false;
            this.lstViewLine.View = System.Windows.Forms.View.Details;
            this.lstViewLine.SelectedIndexChanged += new System.EventHandler(this.lstViewLine_SelectedIndexChanged);
            this.lstViewLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstViewLine_MouseClick);
            // 
            // colheadNo
            // 
            this.colheadNo.Text = "序号";
            // 
            // colheadChname
            // 
            this.colheadChname.Text = "站名";
            this.colheadChname.Width = 120;
            // 
            // colheadEnname
            // 
            this.colheadEnname.Text = "英文";
            this.colheadEnname.Width = 100;
            // 
            // colheadLineNum
            // 
            this.colheadLineNum.Text = "换乘";
            this.colheadLineNum.Width = 160;
            // 
            // colheadX
            // 
            this.colheadX.Text = "X";
            this.colheadX.Width = 40;
            // 
            // colheadY
            // 
            this.colheadY.Text = "Y";
            this.colheadY.Width = 40;
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(287, 346);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(104, 38);
            this.btnAddStation.TabIndex = 10;
            this.btnAddStation.Text = "添加";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(100, 308);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(369, 30);
            this.tbname.TabIndex = 11;
            // 
            // lbChname
            // 
            this.lbChname.AutoSize = true;
            this.lbChname.Location = new System.Drawing.Point(9, 311);
            this.lbChname.Name = "lbChname";
            this.lbChname.Size = new System.Drawing.Size(69, 20);
            this.lbChname.TabIndex = 13;
            this.lbChname.Text = "站点名";
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(408, 346);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(61, 38);
            this.btnDeleteStation.TabIndex = 15;
            this.btnDeleteStation.Text = "删除";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // lbStationNo
            // 
            this.lbStationNo.AutoSize = true;
            this.lbStationNo.Location = new System.Drawing.Point(6, 355);
            this.lbStationNo.Name = "lbStationNo";
            this.lbStationNo.Size = new System.Drawing.Size(149, 20);
            this.lbStationNo.TabIndex = 17;
            this.lbStationNo.Text = "添加/删除序号:";
            // 
            // cmbBoxNo
            // 
            this.cmbBoxNo.FormattingEnabled = true;
            this.cmbBoxNo.Location = new System.Drawing.Point(151, 352);
            this.cmbBoxNo.Name = "cmbBoxNo";
            this.cmbBoxNo.Size = new System.Drawing.Size(119, 28);
            this.cmbBoxNo.TabIndex = 18;
            // 
            // lbFootnote
            // 
            this.lbFootnote.AutoSize = true;
            this.lbFootnote.Location = new System.Drawing.Point(723, 609);
            this.lbFootnote.Name = "lbFootnote";
            this.lbFootnote.Size = new System.Drawing.Size(49, 20);
            this.lbFootnote.TabIndex = 19;
            this.lbFootnote.Text = "注：";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(727, 171);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(485, 430);
            this.tabControl.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lstViewLine);
            this.tabPage1.Controls.Add(this.lbChname);
            this.tabPage1.Controls.Add(this.cmbBoxNo);
            this.tabPage1.Controls.Add(this.btnAddStation);
            this.tabPage1.Controls.Add(this.lbStationNo);
            this.tabPage1.Controls.Add(this.tbname);
            this.tabPage1.Controls.Add(this.btnDeleteStation);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnSetBkColor);
            this.tabPage2.Controls.Add(this.btnSetLineColor);
            this.tabPage2.Controls.Add(this.picBoxShowColor);
            this.tabPage2.Controls.Add(this.tbColorB);
            this.tabPage2.Controls.Add(this.tbColorG);
            this.tabPage2.Controls.Add(this.tbColorR);
            this.tabPage2.Controls.Add(this.lbColorB);
            this.tabPage2.Controls.Add(this.lbColorG);
            this.tabPage2.Controls.Add(this.lbColorR);
            this.tabPage2.Controls.Add(this.trackBarB);
            this.tabPage2.Controls.Add(this.trackBarG);
            this.tabPage2.Controls.Add(this.trackBarR);
            this.tabPage2.Controls.Add(this.lbHeight);
            this.tabPage2.Controls.Add(this.lbWidth);
            this.tabPage2.Controls.Add(this.tbTitle);
            this.tabPage2.Controls.Add(this.lbTitle);
            this.tabPage2.ForeColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图形信息";
            // 
            // btnSetBkColor
            // 
            this.btnSetBkColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetBkColor.Location = new System.Drawing.Point(256, 316);
            this.btnSetBkColor.Name = "btnSetBkColor";
            this.btnSetBkColor.Size = new System.Drawing.Size(162, 49);
            this.btnSetBkColor.TabIndex = 16;
            this.btnSetBkColor.Text = "设为背景颜色";
            this.btnSetBkColor.UseVisualStyleBackColor = true;
            this.btnSetBkColor.Click += new System.EventHandler(this.btnSetBkColor_Click);
            // 
            // btnSetLineColor
            // 
            this.btnSetLineColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetLineColor.Location = new System.Drawing.Point(57, 316);
            this.btnSetLineColor.Name = "btnSetLineColor";
            this.btnSetLineColor.Size = new System.Drawing.Size(162, 49);
            this.btnSetLineColor.TabIndex = 15;
            this.btnSetLineColor.Text = "设为线路颜色";
            this.btnSetLineColor.UseVisualStyleBackColor = true;
            this.btnSetLineColor.Click += new System.EventHandler(this.btnSetLineColor_Click);
            // 
            // picBoxShowColor
            // 
            this.picBoxShowColor.Location = new System.Drawing.Point(387, 75);
            this.picBoxShowColor.Name = "picBoxShowColor";
            this.picBoxShowColor.Size = new System.Drawing.Size(75, 75);
            this.picBoxShowColor.TabIndex = 14;
            this.picBoxShowColor.TabStop = false;
            // 
            // tbColorB
            // 
            this.tbColorB.Location = new System.Drawing.Point(418, 268);
            this.tbColorB.Name = "tbColorB";
            this.tbColorB.ReadOnly = true;
            this.tbColorB.Size = new System.Drawing.Size(53, 30);
            this.tbColorB.TabIndex = 13;
            // 
            // tbColorG
            // 
            this.tbColorG.Location = new System.Drawing.Point(418, 224);
            this.tbColorG.Name = "tbColorG";
            this.tbColorG.ReadOnly = true;
            this.tbColorG.Size = new System.Drawing.Size(53, 30);
            this.tbColorG.TabIndex = 12;
            // 
            // tbColorR
            // 
            this.tbColorR.Location = new System.Drawing.Point(418, 180);
            this.tbColorR.Name = "tbColorR";
            this.tbColorR.ReadOnly = true;
            this.tbColorR.Size = new System.Drawing.Size(53, 30);
            this.tbColorR.TabIndex = 11;
            // 
            // lbColorB
            // 
            this.lbColorB.AutoSize = true;
            this.lbColorB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbColorB.Location = new System.Drawing.Point(9, 268);
            this.lbColorB.Name = "lbColorB";
            this.lbColorB.Size = new System.Drawing.Size(39, 20);
            this.lbColorB.TabIndex = 10;
            this.lbColorB.Text = "B: ";
            // 
            // lbColorG
            // 
            this.lbColorG.AutoSize = true;
            this.lbColorG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbColorG.Location = new System.Drawing.Point(9, 224);
            this.lbColorG.Name = "lbColorG";
            this.lbColorG.Size = new System.Drawing.Size(39, 20);
            this.lbColorG.TabIndex = 9;
            this.lbColorG.Text = "G: ";
            // 
            // lbColorR
            // 
            this.lbColorR.AutoSize = true;
            this.lbColorR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbColorR.Location = new System.Drawing.Point(9, 183);
            this.lbColorR.Name = "lbColorR";
            this.lbColorR.Size = new System.Drawing.Size(39, 20);
            this.lbColorR.TabIndex = 8;
            this.lbColorR.Text = "R: ";
            // 
            // trackBarB
            // 
            this.trackBarB.AutoSize = false;
            this.trackBarB.Location = new System.Drawing.Point(40, 268);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(378, 31);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.AutoSize = false;
            this.trackBarG.Location = new System.Drawing.Point(40, 225);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(378, 29);
            this.trackBarG.TabIndex = 6;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.AutoSize = false;
            this.trackBarR.Location = new System.Drawing.Point(40, 183);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(378, 27);
            this.trackBarR.TabIndex = 5;
            this.trackBarR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHeight.Location = new System.Drawing.Point(9, 116);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(179, 20);
            this.lbHeight.TabIndex = 3;
            this.lbHeight.Text = "图片高度(pixel): ";
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbWidth.Location = new System.Drawing.Point(9, 83);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(179, 20);
            this.lbWidth.TabIndex = 2;
            this.lbWidth.Text = "图片宽度(pixel): ";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(13, 32);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(449, 30);
            this.tbTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(9, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(89, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "图片标题";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(477, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "绘制参数";
            // 
            // ckBoxOverwrite
            // 
            this.ckBoxOverwrite.AutoSize = true;
            this.ckBoxOverwrite.Checked = true;
            this.ckBoxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxOverwrite.Location = new System.Drawing.Point(1097, 134);
            this.ckBoxOverwrite.Name = "ckBoxOverwrite";
            this.ckBoxOverwrite.Size = new System.Drawing.Size(111, 24);
            this.ckBoxOverwrite.TabIndex = 21;
            this.ckBoxOverwrite.Text = "始终覆盖";
            this.ckBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // LstViewMenu
            // 
            this.LstViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LstViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEdit,
            this.MenuDelete,
            this.MenuGiveUpInter});
            this.LstViewMenu.Name = "contextMenuStrip1";
            this.LstViewMenu.Size = new System.Drawing.Size(182, 110);
            // 
            // MenuEdit
            // 
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(181, 26);
            this.MenuEdit.Text = "编辑";
            this.MenuEdit.Click += new System.EventHandler(this.MenuEdit_Click);
            // 
            // MenuGiveUpInter
            // 
            this.MenuGiveUpInter.Name = "MenuGiveUpInter";
            this.MenuGiveUpInter.Size = new System.Drawing.Size(181, 26);
            this.MenuGiveUpInter.Text = "清空换乘信息";
            this.MenuGiveUpInter.Click += new System.EventHandler(this.MenuGiveUpInter_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(181, 26);
            this.MenuDelete.Text = "删除站点";
            this.MenuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 700);
            this.Controls.Add(this.ckBoxOverwrite);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbFootnote);
            this.Controls.Add(this.btnShowpic);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDraw);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "RouteMap Drawing System v0.10";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.LstViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnShowpic;
        private System.Windows.Forms.ListView lstViewLine;
        private System.Windows.Forms.ColumnHeader colheadNo;
        private System.Windows.Forms.ColumnHeader colheadChname;
        private System.Windows.Forms.ColumnHeader colheadX;
        private System.Windows.Forms.ColumnHeader colheadY;
        private System.Windows.Forms.ColumnHeader colheadLineNum;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.ColumnHeader colheadEnname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbChname;
        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.Label lbStationNo;
        private System.Windows.Forms.ComboBox cmbBoxNo;
        private System.Windows.Forms.Label lbFootnote;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label lbColorG;
        private System.Windows.Forms.Label lbColorR;
        private System.Windows.Forms.TextBox tbColorB;
        private System.Windows.Forms.TextBox tbColorG;
        private System.Windows.Forms.TextBox tbColorR;
        private System.Windows.Forms.Label lbColorB;
        private System.Windows.Forms.PictureBox picBoxShowColor;
        private System.Windows.Forms.Button btnSetLineColor;
        private System.Windows.Forms.Button btnSetBkColor;
        private System.Windows.Forms.CheckBox ckBoxOverwrite;
        private System.Windows.Forms.ContextMenuStrip LstViewMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuGiveUpInter;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
    }
}