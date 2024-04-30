using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DijkstraVisualization
{
    public class dd : IComparable<dd>
    {
        public int canh, trongso;
        public dd(int canh, int trongso)
        {
            this.canh = canh;
            this.trongso = trongso;
        }
        public int CompareTo(dd other)
        {
            return trongso - other.trongso;
        }
    }
    class Graph
    {
        public List<int> ShortestPathFinding(int[,] graph, int sodinh, int goc, int dich)
        {
            int[] prev = new int[sodinh + 1];
            int[] dist = new int[sodinh + 1];
            bool[] danhdau = new bool[sodinh + 1];
            for (int i = 1; i <= sodinh; i++)
            {
                dist[i] = Int32.MaxValue;
                danhdau[i] = false;
                prev[i] = Int32.MaxValue;
            }
            dist[goc] = 0;
            SortedSet<dd> pq = new SortedSet<dd>();
            pq.Add(new dd(goc, 0));
            while (pq.Count > 0)
            {
                dd cm = pq.First();
                pq.Remove(cm);
                danhdau[cm.canh] = true;
                for (int i = 1; i <= sodinh; i++)
                {
                    if (!danhdau[i] && graph[cm.canh, i] != 0 && dist[cm.canh] + graph[cm.canh, i] < dist[i])
                    {
                        dist[i] = dist[cm.canh] + graph[cm.canh, i];
                        pq.Add(new dd(i, dist[i]));
                        prev[i] = cm.canh;
                    }
                }
            }
            //string msg = " ";
            //for (int i = 1; i <= sodinh; ++i)
            //{
            //    msg += dist[i].ToString() + " ";
            //}
            //MessageBox.Show(msg);
            if (dist[dich] == Int32.MaxValue) //nếu không tìm được đường đi ngắn nhất
            {
                return new List<int>(); // trả về list rỗng
            }
            List<int> path = new List<int>();
            path.Add(dich);
            while (dich != goc)
            {
                int tmp = prev[dich];
                dich = tmp;
                path.Add(dich);
            }
            path.Reverse();
            for (int i = 0; i < path.Count; ++i)
            {
                Console.Write(path[i]);
                Console.Write(' ');
            }
            return path;
        }
    }
}