using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisualization
{
    class Canh
    {
        public PointF ux, vx;
        public int u, v;
        public int trongso;
        public Canh(int u,int v,PointF ux, PointF vx, int trongso)
        {
            this.u = u;
            this.v = v;
            this.ux = ux;
            this.vx = vx;
            this.trongso = trongso;
        }
    }
}
