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
        public int editNo; // 需要修改的站点序号

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
            // 保存换乘信息
            Form1.theline.gotoSt(editNo);
            Form1.theline.getValue().setInterchange(cmBoxType.Text, tbInterchange.Text);
            Close();
        }

        // 放弃更改
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
