using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DijkstraVisualization
{
    class VeDoThi
    {
        Bitmap flag;
        Graphics g;
        Pen pendraw;
        Pen penselect;
        Pen pendelete;
        Font f = new Font("Time New Roman", 13);
        PointF point;
        PointF D1;
        PointF D2;
        public VeDoThi(int w,int h)
        {
            flag = new Bitmap(w,h);
            g = Graphics.FromImage(flag);
            pendraw = new Pen(Color.Black);
            penselect = new Pen(Color.Red);
            pendelete = new Pen(Color.White);
            f = new Font("Time New Roman", 13);
        }
        public Bitmap trabitmap()
        {
            return flag;
        }
        public void xoabang()
        {
            g.Clear(Color.White);
        }
        public void vedinh(int x,int y,int dinhhientai)
        {
            g.DrawEllipse(pendraw, x - 25, y - 25, 50, 50);
            if (dinhhientai < 10) point = new PointF(x - 8, y - 8);
            else point = new PointF(x - 9, y - 8);
            g.DrawString(dinhhientai.ToString(), f, Brushes.Black, point);
        }
        public void dinhdcchon(float x,float y,Pen dc)
        {
            g.DrawEllipse(dc, x - 25, y - 25, 50, 50);
        }
        public void vecanh(PointF x, PointF y, int trongso,Pen mau)
        {
            if (x.X <= y.X)
            {
                D1.X = x.X + (float)Math.Cos(Math.Atan2(Math.Abs(x.Y - y.Y), y.X - x.X)) * 25;
                D2.X = y.X - (float)Math.Cos(Math.Atan2(Math.Abs(x.Y - y.Y), y.X - x.X)) * 25;
                if (x.Y >= y.Y)
                {
                    D2.Y = y.Y + (float)Math.Sin(Math.Atan2(x.Y - y.Y, y.X - x.X)) * 25;
                    D1.Y = x.Y - (float)Math.Sin(Math.Atan2(x.Y - y.Y, y.X - x.X)) * 25;
                }
                else
                {
                    D2.Y = y.Y + (float)Math.Cos(Math.Atan2(y.X - x.X, x.Y - y.Y)) * 25;
                    D1.Y = x.Y - (float)Math.Cos(Math.Atan2(y.X - x.X, x.Y - y.Y)) * 25;
                }
            }
            else
            {
                D1.X = x.X + (float)Math.Cos(Math.Atan2(Math.Abs(x.Y - y.Y), y.X - x.X)) * 25;
                D2.X = y.X - (float)Math.Cos(Math.Atan2(Math.Abs(x.Y - y.Y), y.X - x.X)) * 25;
                if (x.Y >= y.Y)
                {
                    D2.Y = y.Y + (float)Math.Sin(Math.Atan2(x.Y - y.Y, y.X - x.X)) * 25;
                    D1.Y = x.Y - (float)Math.Sin(Math.Atan2(x.Y - y.Y, y.X - x.X)) * 25;
                }
                else
                {
                    D2.Y = y.Y + (float)Math.Cos(Math.Atan2(y.X - x.X, x.Y - y.Y)) * 25;
                    D1.Y = x.Y - (float)Math.Cos(Math.Atan2(y.X - x.X, x.Y - y.Y)) * 25;
                }
            }
            g.DrawLine(mau, D1, D2);
            g.DrawEllipse(mau, x.X - 25, x.Y - 25, 50, 50);
            g.DrawEllipse(mau, y.X - 25, y.Y - 25, 50, 50);
            PointF ts = new PointF((D1.X + D2.X + 2) / 2, ((D1.Y + D2.Y + 2) / 2));
            g.DrawString(trongso.ToString(), f, Brushes.Black, ts);
        }
    }
}
