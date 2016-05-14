using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteMapDrawing
{
    public class Node
    {
        public Station data;
        public int No;
        public Node next;
        public Node(Station s)
        {
            No = 0;
            data = s;
            next = null;
        }
    }
}
