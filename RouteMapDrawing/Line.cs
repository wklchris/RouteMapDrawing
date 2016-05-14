using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RouteMapDrawing
{
    public class Line
    {
        private string name; // 名称
        // 链表
        private Node head;
        private Node tail;
        private Node current;
        private Color hatchcolor;

        public Line(string linename, Color thecolor)
        {
            name = linename;
            hatchcolor = thecolor;
            head = null;
            tail = null;
        }

        // 下一站
        public void next()
        {
            current = current.next;
        }

        // 返回线路长度
        public int getLength()
        {
            int N = 0;
            gotoHead();
            while (!isEnd())
            {
                N++;
                next();
            }
            return N;
        }

        // 线路是否为空
        public bool isEmpty()
        {
            return head == null;
        }

        // 遍历链表操作
        public void gotoHead()
        {
            current = head;
        }
        public bool isEnd()
        {
            return current == null;
        }

        // 返回站点信息（不包含No）
        public Station getValue()
        {
            return current.data;
        }

        // 返回No
        public int getNo()
        {
            return current.No;
        }

        // 返回线路名称
        public string getName()
        {
            return name;
        }

        // 返回线路填充颜色
        public Color getColor()
        {
            return hatchcolor;
        }

        // 给站点赋颜色
        public void setColor(Color thecolor)
        {
            hatchcolor = thecolor;
        }

        // 给站点编号
        public void giveNo()
        {
            gotoHead();
            int num = 1;
            while(!isEnd())
            {
                current.No=num;
                num++;
                next();
            }
        }

        // 搜索序号对应站点，current移过去（使用前giveNo）
        public bool gotoSt(int n)
        {
            gotoHead();
            while (!isEnd())
            {
                if (current.No == n)
                    return true;
                next();
            }
            return false;// (new Station("无此序号", "Null"));
        }

        // 在第n个站点后面插入站点
        public void insert(Station s, int n=-1)
        {
            Node node = new Node(s);
            if (n == -1) // 如果n==-1则加到尾部
            {
                if (isEmpty()) // 如果是空链表
                {
                    //node.data.giveNo(1); // 序号1
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                    //node.data.giveNo(getLength()); // 序号为链表总长
                }
                giveNo();
                return;
            }
            if (isEmpty()) //如果链表为空，不支持带参数n的插入
                return;

            // 如果插入到首位
            if (n==0)
            {
                node.next = head;
                head = node;
                giveNo();
                return;
            }

            if (!gotoSt(n)) // 如果搜索无结果
                return;
            gotoSt(n);
            node.next = current.next;
            current.next = node; // 此时current位于执行完getSt，即n的位置
            giveNo();
        }

        // 删除站点
        public bool delete(int delNo)
        {
            Node p = head, q = null;
            while(p!=null && p.No!=delNo)
            {
                q = p;  // q为p的前趋，一直搜索到p=tail
                p = p.next;
            }

            if (p!=null) // 如果搜索到了
            {
                if (p == head)
                {
                    head = head.next;
                }
                else if (p == tail)
                {
                    tail = q;
                    tail.next = null;
                }
                else
                {
                    q.next = p.next;
                }
                return true;
            }
            return false;
        }

        // 找到字符最长的站点，并返回这个长度
        public int getLongest(Font ch, Font en)
        {
            int L = 0, tempL = 0;
            int s = 1;
            Bitmap bm=new Bitmap(100,100);
            Graphics gg = Graphics.FromImage(bm);
            gotoHead();
            while(!isEnd())
            {
                tempL = (int)(gg.MeasureString(getValue().getCh(), ch).Width
                    + gg.MeasureString(" " + getValue().getEn(), en).Width);
                if (tempL > L)
                {
                    s = current.No;
                    L = tempL;
                }
                next(); 
            }
            return L;
        }

    }
}
