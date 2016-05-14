using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RouteMapDrawing
{
    public class Station
    {
        // 站点的中英文名称
        String chname, enname;

        // 站点的填充颜色
        Color fillcolor = Color.White;

        // 站点的坐标
        int x, y;

        // 绘制参数
        const int delta = 50; // 默认的距离
        string linenum;  // 途经的线路数

        public Station(String ch, String en, string Line = "", int xx = 0, int yy = 0)
        {
            chname = ch;
            enname = en;
            linenum = Line;

            x = xx;
            y = yy;
        }

        // 获取站点名称
        public string getCh()
        {
            return chname;
        }

        public string getEn()
        {
            return enname;
        }

        // 获取和设置X和Y的值
        public int getX()
        { return x; }

        public int getY()
        { return y; }

        public void setX(int newx)
        {
            x = newx;
        }

        public void setY(int newy)
        {
            y = newy;
        }

        // 更改换乘信息
        public void setInterchange(string intertype, string interline)
        {
            // intertype为空表示清空换乘信息
            if (intertype == "")
            {
                linenum = "";
                return;
            }

            string[] dealing = interline.Split(new char[] { ',' });
            string str ="";
            for (int i = 0; i < dealing.Length; i++)
            {
                str = dealing[i];
                // 删除句首空格
                while (true)
                {
                    if (str.Substring(0, 1) == " ")
                        str = str.Remove(0, 1);
                    else
                        break;
                }
                linenum += intertype + str + ";";
            }
        }

        // 输出成为导入ListView的格式
        public string[] getList(int LineStNo)
        {
            string[] thestr = new string[] { LineStNo.ToString(), chname, enname,
                linenum, x.ToString(), y.ToString()};
            return thestr;
        }

    }
}
