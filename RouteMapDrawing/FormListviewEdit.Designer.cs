namespace RouteMapDrawing
{
    partial class FormListviewEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxType = new System.Windows.Forms.ComboBox();
            this.tbInterchange = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.checkBoxIsClosedSt = new System.Windows.Forms.CheckBox();
            this.checkBoxIsClosedSection = new System.Windows.Forms.CheckBox();
            this.cmBoxEditingStation = new System.Windows.Forms.ComboBox();
            this.lbEditingStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "换乘：";
            // 
            // cmBoxType
            // 
            this.cmBoxType.FormattingEnabled = true;
            this.cmBoxType.Location = new System.Drawing.Point(102, 70);
            this.cmBoxType.Name = "cmBoxType";
            this.cmBoxType.Size = new System.Drawing.Size(113, 28);
            this.cmBoxType.TabIndex = 1;
            // 
            // tbInterchange
            // 
            this.tbInterchange.Location = new System.Drawing.Point(102, 115);
            this.tbInterchange.Name = "tbInterchange";
            this.tbInterchange.Size = new System.Drawing.Size(380, 30);
            this.tbInterchange.TabIndex = 2;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(233, 73);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(249, 20);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "换乘内容请用英文逗号分隔";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 275);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(275, 275);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(138, 47);
            this.btnGiveUp.TabIndex = 5;
            this.btnGiveUp.Text = "退出";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // checkBoxIsClosedSt
            // 
            this.checkBoxIsClosedSt.AutoSize = true;
            this.checkBoxIsClosedSt.Location = new System.Drawing.Point(30, 179);
            this.checkBoxIsClosedSt.Name = "checkBoxIsClosedSt";
            this.checkBoxIsClosedSt.Size = new System.Drawing.Size(151, 24);
            this.checkBoxIsClosedSt.TabIndex = 6;
            this.checkBoxIsClosedSt.Text = "该站尚未开通";
            this.checkBoxIsClosedSt.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsClosedSection
            // 
            this.checkBoxIsClosedSection.AutoSize = true;
            this.checkBoxIsClosedSection.Location = new System.Drawing.Point(30, 218);
            this.checkBoxIsClosedSection.Name = "checkBoxIsClosedSection";
            this.checkBoxIsClosedSection.Size = new System.Drawing.Size(331, 24);
            this.checkBoxIsClosedSection.TabIndex = 7;
            this.checkBoxIsClosedSection.Text = "该站到下一站间的线路段尚未开通";
            this.checkBoxIsClosedSection.UseVisualStyleBackColor = true;
            // 
            // cmBoxEditingStation
            // 
            this.cmBoxEditingStation.FormattingEnabled = true;
            this.cmBoxEditingStation.Location = new System.Drawing.Point(142, 23);
            this.cmBoxEditingStation.Name = "cmBoxEditingStation";
            this.cmBoxEditingStation.Size = new System.Drawing.Size(340, 28);
            this.cmBoxEditingStation.TabIndex = 8;
            this.cmBoxEditingStation.SelectedIndexChanged += new System.EventHandler(this.cmBoxEditingStation_SelectedIndexChanged);
            // 
            // lbEditingStation
            // 
            this.lbEditingStation.AutoSize = true;
            this.lbEditingStation.Location = new System.Drawing.Point(26, 26);
            this.lbEditingStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEditingStation.Name = "lbEditingStation";
            this.lbEditingStation.Size = new System.Drawing.Size(109, 20);
            this.lbEditingStation.TabIndex = 9;
            this.lbEditingStation.Text = "正在编辑：";
            // 
            // FormListviewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 363);
            this.Controls.Add(this.lbEditingStation);
            this.Controls.Add(this.cmBoxEditingStation);
            this.Controls.Add(this.checkBoxIsClosedSection);
            this.Controls.Add(this.checkBoxIsClosedSt);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.tbInterchange);
            this.Controls.Add(this.cmBoxType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormListviewEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑站点信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListviewEdit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxType;
        private System.Windows.Forms.TextBox tbInterchange;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.CheckBox checkBoxIsClosedSt;
        private System.Windows.Forms.CheckBox checkBoxIsClosedSection;
        private System.Windows.Forms.ComboBox cmBoxEditingStation;
        private System.Windows.Forms.Label lbEditingStation;
    }
}