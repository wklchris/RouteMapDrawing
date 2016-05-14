using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteMapDrawing
{
    public partial class FormListviewEdit : Form
    {
        public Form1 fatherform;
        public int editNo;
        public string editstation; // 需要修改的站点

        public FormListviewEdit()
        {
            InitializeComponent();
            // 禁止编辑
            cmBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxType.Items.Clear();
            cmBoxType.Items.Add("轨道交通");
            cmBoxType.Items.Add("公交");
            cmBoxType.Items.Add("磁悬浮");

            cmBoxType.Text = "轨道交通";

            // EditingStation
            cmBoxEditingStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxEditingStation.Items.Clear();
            Form1.theline.gotoHead();
            while (!Form1.theline.isEnd())
            {
                if (Form1.theline.getNo() == editNo)
                    editstation = Form1.theline.getValue().getCh();
                cmBoxEditingStation.Items.Add(Form1.theline.getNo().ToString() + ", " + Form1.theline.getValue().getCh());
                Form1.theline.next();
            }
            cmBoxEditingStation.SelectedIndex = editNo;
        }
        // 关闭窗口
        private void FormListviewEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            fatherform.Show();
            this.Hide();
        }

        // 保存更改
        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1.theline.gotoSt(editNo);
            Form1.theline.getValue().setIsOpen(!checkBoxIsClosedSt.Checked, !checkBoxIsClosedSection.Checked);
            Form1.theline.getValue().setInterchange(cmBoxType.Text, tbInterchange.Text);
            //Close();
        }

        // 放弃更改
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 选择的线路
        private void cmBoxEditingStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 重新赋值editNo和editline
            editNo = int.Parse(cmBoxEditingStation.Text.Split(new char[] { ',' })[0]);
            Form1.theline.gotoSt(editNo);
            editstation = Form1.theline.getValue().getCh();

            Form1.theline.gotoSt(editNo);
            tbInterchange.Text = "";
            checkBoxIsClosedSt.Checked = !Form1.theline.getValue().getIsOpenSt();
            checkBoxIsClosedSection.Checked = !Form1.theline.getValue().getIsOpenSection();
        }
    }
}
