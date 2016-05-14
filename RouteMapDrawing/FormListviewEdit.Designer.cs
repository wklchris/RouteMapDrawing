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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "换乘：";
            // 
            // cmBoxType
            // 
            this.cmBoxType.FormattingEnabled = true;
            this.cmBoxType.Location = new System.Drawing.Point(102, 86);
            this.cmBoxType.Name = "cmBoxType";
            this.cmBoxType.Size = new System.Drawing.Size(113, 28);
            this.cmBoxType.TabIndex = 1;
            // 
            // tbInterchange
            // 
            this.tbInterchange.Location = new System.Drawing.Point(102, 130);
            this.tbInterchange.Name = "tbInterchange";
            this.tbInterchange.Size = new System.Drawing.Size(329, 30);
            this.tbInterchange.TabIndex = 2;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(242, 89);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(229, 20);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "换乘内容用英文逗号分隔";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 208);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(271, 208);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(138, 47);
            this.btnGiveUp.TabIndex = 5;
            this.btnGiveUp.Text = "放弃";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // FormListviewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 320);
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
    }
}