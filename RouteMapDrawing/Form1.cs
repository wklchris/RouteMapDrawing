using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RouteMapDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Route Map Drawing System " + version + " ---- by MrDong";

            // 不可缩放
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            // 默认输出到D盘
            tbPath.Text = "D:\\\\";   
            tbPath.ReadOnly = true;

            // pictureBox和panel特性
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            panel1.AutoScroll = true;

            // 回车添加站点
            AcceptButton = btnAddStation;

            // 下拉菜单不可输入内容
            cmbBoxNo.DropDownStyle = ComboBoxStyle.DropDownList;

            // ListView特性
            lstViewLine.MultiSelect = false;

            // lbFootnote的内容
            lbFootnote.Text = "注：1. 添加站点到序号对应站点的后方；";
            lbFootnote.Text += "\n    2. 选中站点右键可以编辑部分信息。";
            lbFootnote.Text += "\n    3. 中文站名+空格+英文站名再回车就能输入一个站点。";

            // 标题默认值
            tbTitle.Text = "标题想多长有多长";

            // PicShowBox
            picBoxShowColor.BackColor = theline.getColor();
            tbColorR.Text = "0";
            tbColorG.Text = "0";
            tbColorB.Text = "0";

            // 显示水印的右边距
            tbWMRightMargin.Text = watermarkrightmargin.ToString();
            tbLineLocation.Text = interchangewidth.ToString();
        }

        public static string version = "v0.11"; // 当前版本
        public static string drawingdate = DateTime.Now.ToShortDateString().ToString();
        public static string mapversion = "Ver1.0";

        public static int flag = 0;    // 判断是否创建成功
        string path, filename;     // 文件存储路径
        string filetype = ".jpg"; // 默认的文件扩展名
        public Bitmap image = new Bitmap(100, 100);
        public static string showingLine; // 正在编辑的路线
        public static Line theline = new Line("地铁", Color.FromArgb(0, 122, 204)); // 线路

        // 绘制所需的参数（填充颜色在theline.hatchcolor中）
        public static Color mapbkcolor = Color.FromArgb(255,255,255); // 图片底色
        public static Color notopencolor = Color.FromArgb(195, 187, 173); // 未开通颜色
        public static Pen stationpen = new Pen(Color.Black, 20); // 画站点的笔
        public static Pen notopenpen = new Pen(notopencolor, 20); // 未开通的笔
        public static Pen linepen = new Pen(Color.Black, 1); // 默认的笔

        public static string title = "";  // 图片标题
        public static int titlelocation = 100; // 标题到图片顶端的距离
        public static int titlefontsize = 120; // 标题字号 
        public static Font titlefont = new Font("黑体", titlefontsize, FontStyle.Regular); // 标题字体

        public static int watermarklocation = titlelocation + 220; // 水印到图片顶端的距离
        public static Font watermarkfont = new Font("宋体", 50, FontStyle.Regular); // 水印字体
        public static int watermarkrightmargin = 200; // 水印右边缘到图片右边线的距离

        public static int stchfontsize = 80;    // 中文站点字号
        public static int stenfontsize = 60;    // 英文站点字号
        public static int R = 60;               // 站点圆的半径
        public static int st_st_d = 200;        // 相邻站点圆的圆心距离
        public static int line_r = 50;      // 线路宽度的一半
        public static int st_line_d = 40;       // 站点圆右端到中文站点名左端的距离 

        public static int interchangewidth = 400; // 预设的换乘信息区域宽度
        public static int linestart = 600;      // 站点顶端线路弧到图片顶端的距离
        public static int lineend = 100;        // 站点底端线路弧到图片底端的距离

        // 保存图片，成功与否用flag标定
        private void SavePic()
        {
            // 如果勾选了“始终覆盖”，或者同名文件不存在
            if(ckBoxOverwrite.Checked || !File.Exists(path + filename + filetype))
            {
                image.Save(path + filename + filetype, System.Drawing.Imaging.ImageFormat.Jpeg);
                flag = 1;
                return;
            }

            // 如果同名文件存在
            DialogResult overwriteflag = MessageBox.Show("文件" + filename + filetype
                + "已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo);
            if (overwriteflag == DialogResult.Yes)
            {
                image.Save(path + filename + filetype);
                MessageBox.Show(path + filename + filetype + "已覆盖", "提示");
                flag = 1;
                return;
            }
            else
            {
                MessageBox.Show(path + filename + filetype + "未保存，请重命名。", "提示");
                flag = 0;
                return;
            }
        }

        // 用Graphics绘制图片（最先调用的函数）
        private void CreateImage(Line drawingline)
        {
            picBox1.Image = null;
            if (title == "")
            {
                MessageBox.Show("请在 图形信息->图片标题 中输入标题。", "提示");
                return;
            }
            linepen.Color=mapbkcolor; // 线路边线和背景颜色同色

            // 设置站点字体
            Font chfont = new Font("黑体", stchfontsize, (FontStyle.Bold));
            Font enfont = new Font("Arial", stenfontsize, (FontStyle.Regular));

            // 水印
            string wm1 = tbWMLine1.Text;
            string wm2 = tbWMLine2.Text;
            string wm3 = tbWMLine3.Text;
            if (checkBoxWaterMark.Checked)
            {
                wm1 = "同济大学交通运输工程学院 @方包子 制作";
                wm2 = "由@wklchris 绘图器RMD " + version + " 协力绘制";
                wm3 = drawingdate.Replace("/", ".") + " " + mapversion + " 版权所有";
            }

            // 计算水印区的宽度
            Bitmap bmtest = new Bitmap(100, 100);
            Graphics gtest = Graphics.FromImage(bmtest);
            int wmwidth1 = (int)Math.Ceiling(gtest.MeasureString(wm1, watermarkfont).Width);
            int wmwidth2 = (int)Math.Ceiling(gtest.MeasureString(wm2, watermarkfont).Width);
            int wmwidth3 = (int)Math.Ceiling(gtest.MeasureString(wm3, watermarkfont).Width);
            // 图片的一半宽度应该达到：
            int wm_imagewidth = Math.Max(Math.Max(wmwidth1, wmwidth2), wmwidth3);
            
            if (tbLineLocation.Text!="")
                interchangewidth = int.Parse(tbLineLocation.Text);
            // 获取图片的长和宽
            int templength = interchangewidth + line_r + st_line_d + theline.getLongest(chfont, enfont);
            int image_width = (int)Math.Ceiling(title.Length * 1.6 * titlefontsize); // 汉字两倍宽
            image_width = Math.Max(Math.Max(templength, image_width), wm_imagewidth * 2 + watermarkrightmargin);
            int image_height = linestart + line_r * 2 + R * 2 + (theline.getLength() - 1) * st_st_d + lineend;
            
            image = new Bitmap(image_width, image_height);


            //创建Graphics
            Graphics g = Graphics.FromImage(image);

            //清空图片背景颜色
            g.Clear(mapbkcolor);
            g.SmoothingMode = SmoothingMode.AntiAlias; // 去边缘

            // 绘制标题
            using (StringFormat centersf = new StringFormat())
            {
                centersf.Alignment = StringAlignment.Center;

                g.DrawString(title, titlefont, Brushes.Black,
                    new Rectangle(10, titlelocation, image_width - 10, image_height), centersf);
            }

            // 绘制水印（副标题）
            if (checkBoxWaterMark.Checked)
            {
                if (tbDate.Text!="")
                    drawingdate = tbDate.Text;
                if (tbversion.Text != "")
                    mapversion = tbversion.Text;
                if (tbWMRightMargin.Text != "")
                    watermarkrightmargin = int.Parse(tbWMRightMargin.Text);

                using (StringFormat centerwm = new StringFormat())
                {
                    centerwm.Alignment = StringAlignment.Far;

                    g.DrawString(wm1 + "\n" + wm2 + "\n" + wm3, watermarkfont, Brushes.Black,
                        new Rectangle(0, watermarklocation,
                            image_width / 2 + wm_imagewidth, image_height), centerwm);
                }
            }

            // 绘制线路中心线
            // 画顶端圆弧
            Rectangle toparc = new Rectangle(interchangewidth - line_r, linestart,
                2 * line_r, 2 * line_r);
            g.DrawEllipse(linepen, toparc);
            // 画整个线路长
            Rectangle linerect = new Rectangle(interchangewidth - line_r, linestart + line_r,
                2 * line_r, (theline.getLength() - 1) * st_st_d + R * 2);
            g.DrawRectangle(linepen, linerect);
            // 画底端圆弧
            Rectangle bottomarc = new Rectangle(interchangewidth - line_r,
                linestart + (theline.getLength() - 1) * st_st_d + R * 2, 2 * line_r, 2 * line_r);
            g.DrawEllipse(linepen, bottomarc);
            // 求它们的并集
            GraphicsPath fillpath = new GraphicsPath();
            fillpath.AddEllipse(toparc);
            fillpath.AddEllipse(bottomarc);
            Region fillreg = new Region(linerect);
            fillreg.Union(fillpath); // 求并集
            g.FillRegion(new SolidBrush(theline.getColor()), fillreg);

            // 绘制站点
            int st_leftuppoint = linestart + line_r; // 第一个站点圆的正交外切矩形的左上角Y值
            theline.gotoHead();
            while (!theline.isEnd())
            {
                // 填充白色，如果未开通则边界画灰色
                g.DrawEllipse(theline.getValue().getIsOpenSt()?stationpen:notopenpen,
                    new Rectangle(interchangewidth - R, st_leftuppoint, 2 * R, 2 * R));
                g.FillEllipse(Brushes.White,
                    new Rectangle(interchangewidth - R, st_leftuppoint, 2 * R, 2 * R));
                // 测量中英文绘制后在图上的尺寸
                SizeF stchlength = g.MeasureString(theline.getValue().getCh(), chfont);
                SizeF stenlength = g.MeasureString(theline.getValue().getEn(), enfont);

                // 绘制站点名称，英文前加一个空格
                // 中文Y方向在字的实际高度下方，约有1/3个fontsize高度的空白
                g.DrawString(theline.getValue().getCh(), chfont,
                    // 未开通则灰色
                    theline.getValue().getIsOpenSt() ? Brushes.Black : new SolidBrush(notopencolor),
                    interchangewidth + R + st_line_d,
                    st_leftuppoint + R - (stchlength.Height - stchfontsize / 3) / 2);
                g.DrawString(" " + theline.getValue().getEn(), enfont,
                    // 未开通则灰色
                    theline.getValue().getIsOpenSt() ? Brushes.Black : new SolidBrush(notopencolor),
                    interchangewidth + R + st_line_d + stchlength.Width,
                    st_leftuppoint + R + (stchlength.Height - stchfontsize / 3) / 2 - (stenlength.Height - stenfontsize / 3));
                
                // 步进
                st_leftuppoint = st_leftuppoint + st_st_d;
                theline.next();
            }

            // 尝试保存图片
            try
            {
                // 保存图片
                SavePic();
                lbWidth.Text = "图片宽度(pixel): " + image_width.ToString();
                lbHeight.Text = "图片高度(pixel): " + image_height.ToString();
            }
            catch
            {
                flag = 0;
                MessageBox.Show("绘制发生错误。", "错误");
            }
            finally
            {
                // 释放占用资源
                g.Dispose();
                image.Dispose();
            }
        }

        // 选择路径
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.ShowDialog();
            path = dir.SelectedPath + "\\";
            tbPath.Text = dir.SelectedPath + "\\";
        }

        // 显示图片
        private void btnShowpic_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Control); // 改变panel的背景色
            path = tbPath.Text;
            filename = tbFilename.Text;
            try
            {
                Image imgtemp = Image.FromFile(path + filename + filetype);
                // Fromfile不自动释放文件，需要手动操作
                Image imgfinal = new Bitmap(imgtemp);
                imgtemp.Dispose();
                picBox1.Image = imgfinal;
            }
            catch
            {
                MessageBox.Show("无效的文件位置：" + path + filename + filetype, "错误");
            }
        }

        // 添加站点
        private void btnAddStation_Click(object sender, EventArgs e)
        {
            // 空值不允许
            if (tbname.Text == "")
                return;

            // 用空格分隔汉语和英文
            string str = tbname.Text;
            int splitnum = str.IndexOf(" ");
            string strchname = str.Substring(0, splitnum);
            string strenname = str.Substring(splitnum + 1);

            // 删除句首空格
            while (true)
            {
                if (str.Substring(0, 1) == " ")
                    str = str.Remove(0, 1);
                else
                    break;
            }

            Station thestation = new Station(strchname, strenname);
            if (cmbBoxNo.Text == "")
                theline.insert(thestation);
            else
                theline.insert(thestation, int.Parse(cmbBoxNo.Text));
            showLineStation();
            tbname.Text = "";
        }

        // 显示线路上的站点，并刷新删除站点序号的下拉选单
        private void showLineStation()
        {   
            // 排序
            theline.giveNo();
            theline.gotoHead();
            lstViewLine.Items.Clear();
            cmbBoxNo.Items.Clear();
            cmbBoxNo.Items.Add(0);

            cmbBoxNo.BeginUpdate();
            while (!theline.isEnd())
            {
                // 显示到ListView
                lstViewLine.Items.Add(new ListViewItem(theline.getValue().getList(theline.getNo())));
                // 显示到ComboBox下拉选单
                cmbBoxNo.Items.Add(theline.getNo());

                theline.next();
            }
            cmbBoxNo.EndUpdate();
            // 选中ComboBox为最后一个值
            cmbBoxNo.Text = theline.getLength().ToString();
            // 保证随着数据添加自动下滚
            lstViewLine.Items[lstViewLine.Items.Count - 1].EnsureVisible();
        }

        // 删除站点
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            if (cmbBoxNo.Text == "0")
                return;
            theline.gotoSt(int.Parse(cmbBoxNo.Text)); // 将current移动到要删除的站点处

            // 删除提示框
            DialogResult deleteflag = MessageBox.Show("确认要删除以下站点吗？\n\n序号：" + cmbBoxNo.Text
                + "\t站名：" + theline.getValue().getCh(), "警告", MessageBoxButtons.YesNo);
            if (deleteflag == DialogResult.No)
                return;

            // 如果删除成功则刷新ListView
            if (theline.delete(int.Parse(cmbBoxNo.Text)))
                showLineStation();
        }

        // 选中了ListView中的某一行
        private void lstViewLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewLine.SelectedItems.Count > 0)
                cmbBoxNo.Text = lstViewLine.SelectedItems[0].Text;
        }

        // 颜色调节
        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            tbColorR.Text = trackBarR.Value.ToString();
            picBoxShowColor.BackColor = Color.FromArgb(int.Parse(tbColorR.Text),
                int.Parse(tbColorG.Text), int.Parse(tbColorB.Text));
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            tbColorG.Text = trackBarG.Value.ToString();
            picBoxShowColor.BackColor = Color.FromArgb(int.Parse(tbColorR.Text),
                int.Parse(tbColorG.Text), int.Parse(tbColorB.Text));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            tbColorB.Text = trackBarB.Value.ToString();
            picBoxShowColor.BackColor = Color.FromArgb(int.Parse(tbColorR.Text),
                int.Parse(tbColorG.Text), int.Parse(tbColorB.Text));
        }

        // 设置线路的颜色
        private void btnSetLineColor_Click(object sender, EventArgs e)
        {
            theline.setColor(Color.FromArgb(int.Parse(tbColorR.Text),
                int.Parse(tbColorG.Text), int.Parse(tbColorB.Text)));
        }

        // 设置图片的底色
        private void btnSetBkColor_Click(object sender, EventArgs e)
        {
            mapbkcolor=Color.FromArgb(int.Parse(tbColorR.Text),
                int.Parse(tbColorG.Text), int.Parse(tbColorB.Text));
        }

        // 设置未开通的颜色
        private void button1_Click(object sender, EventArgs e)
        {
            notopencolor = Color.FromArgb(int.Parse(tbColorR.Text),
                int.Parse(tbColorG.Text), int.Parse(tbColorB.Text));
        }

        // 右键弹出菜单
        private void lstViewLine_MouseClick(object sender, MouseEventArgs e)
        {
            // 移动current到目前lstLineView中选中的行
            if (lstViewLine.SelectedItems.Count > 0)
            {
                theline.gotoSt(int.Parse(lstViewLine.SelectedItems[0].Text));
                cmbBoxNo.Text = lstViewLine.SelectedItems[0].Text;
            }
            else
                return;

            if (e.Button==MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);
                LstViewMenu.Show(lstViewLine,p);
            }
        }

        // 编辑站点内容
        private void MenuEdit_Click(object sender, EventArgs e)
        {
            // current在lstViewLine_MouseClick中已经移动到lstViewLine中选中的项

            // 创建新窗体
            FormListviewEdit formedit = new FormListviewEdit();
            formedit.fatherform = this;
            formedit.editNo = int.Parse(lstViewLine.SelectedItems[0].Text); // 序号

            //Hide();
            formedit.ShowDialog();  // 使得当前窗口之外的操作不能进行
            showLineStation();      // 刷新lstView
        }

        // 清空换乘信息
        private void MenuGiveUpInter_Click(object sender, EventArgs e)
        {
            // current在lstViewLine_MouseClick中已经移动到lstViewLine中选中的项
            DialogResult clearallflag = MessageBox.Show("确认清除以下站点的换乘信息吗？\n\n序号：" + cmbBoxNo.Text
                + "\t站名：" + theline.getValue().getCh(), "警告", MessageBoxButtons.YesNo);
            if (clearallflag == DialogResult.Yes)
            {
                theline.getValue().setInterchange("", "");
            }
            showLineStation();
        }

        // 删除站点内容（调用btnDeleteStation）
        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (lstViewLine.SelectedItems.Count > 0)
                cmbBoxNo.Text = lstViewLine.SelectedItems[0].Text;
            btnDeleteStation_Click(sender, e);
        }

        // 生成图片并在picbox中显示
        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 文件名是否为空
            if (tbFilename.Text == "")
            {
                MessageBox.Show("文件名不能为空。", "错误");
                return;
            }

            // 站点数量不少于2个
            if (theline.getLength() < 2)
            {
                MessageBox.Show("站点数量太少", "错误");
                return;
            }

            path = tbPath.Text;
            filename = tbFilename.Text;

            // 绘图
            title = tbTitle.Text;
            CreateImage(theline);

            // 如果生成成功则显示图片
            if (flag == 1)
            {
                btnShowpic_Click(sender, e);
            }

        }

      
    }

}
