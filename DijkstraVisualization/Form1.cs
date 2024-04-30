using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraVisualization
{
    public partial class Form1 : Form
    {
        VeDoThi vdt;
        List<Dinh> D;
        List<Canh> C;
        PointF point;
        int truoc = -10000;
        int chondinh = 0;
        PointF[] pick = new PointF[3];
        int uu;
        int vv;
        int[,] mang = new int[1000,1000];
        Pen pendraw;
        Pen penselect;
        public Form1()
        {
            InitializeComponent();
            D =  new List<Dinh>();
            C = new List<Canh>();
            vdt = new VeDoThi(SystemInformation.PrimaryMonitorSize.Width,SystemInformation.PrimaryMonitorSize.Height);
            pendraw = new Pen(Color.Black);
            penselect = new Pen(Color.Red);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 600;
        }
        private void TaoDinh_Click(object sender, EventArgs e)
        {
            TaoDinh.Enabled = false;
            TaoCanh.Enabled = true;
            XoaDinh.Enabled = true;
        }
        private void TaoCanh_Click(object sender, EventArgs e)
        {
            TaoCanh.Enabled = false;
            TaoDinh.Enabled = true;
            XoaDinh.Enabled = true;
        }
        private void XoaDinh_Click(object sender, EventArgs e)
        {
            TaoDinh.Enabled = true;
            TaoCanh.Enabled = true;
            XoaDinh.Enabled = false;
        }
        private void bang_MouseClick(object sender, MouseEventArgs e)
        {
            if(TaoDinh.Enabled == false)
            {
                D.Add(new Dinh(e.X, e.Y));
                vdt.vedinh(e.X, e.Y,D.Count);
                bang.Image = vdt.trabitmap();
                for (int i = 1; i <= (D.Count+1)* (D.Count + 1); i++) mang[i % D.Count + 1, i / (D.Count + 1)] = 0;
            }
            if (TaoCanh.Enabled == false)
            {
                if (e.Button == MouseButtons.Left) 
                {
                    for (int i = 0; i < D.Count; i++)
                    {
                        if (Math.Sqrt(Math.Pow(e.X - D[i].x-25, 2) + Math.Pow(e.Y - D[i].y - 25, 2))<=50)
                        {
                            if (truoc != i)
                            {
                                vdt.dinhdcchon(D[i].x, D[i].y,penselect);
                                chondinh++;
                                pick[chondinh] = new PointF(D[i].x, D[i].y);
                                truoc = i;
                                if (chondinh == 1) uu = i+1;
                                else if( chondinh == 2 ) vv = i+1;
                            }
                            else continue;
                        } 
                        if(chondinh == 2)
                        {
                            FormTrongso nhap = new FormTrongso();
                            nhap.ShowDialog();
                            if (nhap.dong == true)
                            {
                                vdt.dinhdcchon(pick[1].X, pick[1].Y,pendraw);
                                vdt.dinhdcchon(pick[2].X, pick[2].Y,pendraw);
                                bang.Image = vdt.trabitmap();
                                chondinh = 0;
                                truoc = -10000;
                                pick.DefaultIfEmpty();
                                return;
                            }
                            C.Add(new Canh(uu,vv,pick[1], pick[2], nhap.value));
                            C.Add(new Canh(vv,uu,pick[2], pick[1], nhap.value));
                            vdt.vecanh(pick[1], pick[2], nhap.value,pendraw);
                            chondinh = 0;
                            truoc = -10000;
                        }
                        bang.Image = vdt.trabitmap();
                    }
                }
            }
            if (XoaDinh.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < D.Count; i++)
                    {
                        if (Math.Sqrt(Math.Pow(e.X - D[i].x - 25, 2) + Math.Pow(e.Y - D[i].y - 25, 2)) <= 50)
                        {
                            bool check;
                            while (true)
                            {
                                check = false;
                                for (int j = 0; j < C.Count; ++j)
                                {
                                    PointF p = new PointF(D[i].x, D[i].y);
                                    if (C[j].ux == p || C[j].vx == p)
                                    {
                                        check = true;
                                        C.RemoveAt(j);
                                    }
                                }
                                if (check == false) break;
                            }    
                            D.RemoveAt(i);
                            break;
                        }
                    }
                    vdt.xoabang();
                    bang.Image = vdt.trabitmap();
                    for (int i = 0; i < D.Count; i++)
                    {
                        vdt.vedinh(D[i].x, D[i].y,i+1);
                    }
                    //MessageBox.Show(C.Count.ToString());
                    for(int i = 0; i < C.Count; i++)
                    {
                        vdt.vecanh(C[i].ux, C[i].vx, C[i].trongso,pendraw);
                    }
                    for(int i = 0;i < D.Count; i++)
                    {
                        for(int j = 0; j < C.Count; j++)
                        {
                            PointF p = new PointF(D[i].x, D[i].y);
                            if (C[j].ux == p) 
                            {
                                C[j].u = i + 1;
                            }
                            else if(C[j].vx == p)
                            {
                                C[j].v = i + 1;
                            }
                        }    
                    }
                }
            }
            goc.Items.Clear();
            dich.Items.Clear();
            for(int i=1; i <=D.Count;i++)
            {
                goc.Items.Add(i);
                dich.Items.Add(i);
            }
            hientrongso.Items.Clear();
            for (int i = 0; i < C.Count; ++i)
            {
                //MessageBox.Show(C[i].u.ToString() + " " + C[i].v.ToString() + " " + C[i].trongso.ToString());
                mang[C[i].u, C[i].v] = C[i].trongso;
                //MessageBox.Show(mang[C[i].u, C[i].v].ToString());

            }
            for (int i = 0 ; i <= D.Count; ++i) 
            {
                String ss = " ";
                for (int j = 0;j <= D.Count; ++j)
                {
                    if (i == 0) ss += j.ToString() + " ";
                    else if (j == 0) ss += i.ToString()+ " ";
                        else ss += mang[i, j].ToString() + " ";
                }
                hientrongso.Items.Add(ss);
            }
        }

        private void Giai_Click(object sender, EventArgs e)
        {
            Graph giai = new Graph();
            List<int> path = giai.ShortestPathFinding(mang, D.Count,Int32.Parse(goc.Text),Int32.Parse(dich.Text));
            if(path.Count == 0)
            {
                MessageBox.Show("Không tồn tại đường đi ngắn nhất");
                return;
            }
            vdt.xoabang();
            bang.Image = vdt.trabitmap();
            for (int i = 0; i < D.Count; i++)
            {
                vdt.vedinh(D[i].x, D[i].y, i + 1);
            }
            //MessageBox.Show(C.Count.ToString());
            for (int i = 0; i < C.Count; i++)
            {
                vdt.vecanh(C[i].ux, C[i].vx, C[i].trongso, pendraw);
            }
            for (int i = 0; i < path.Count-1; ++i)
            {
                for(int j = 0; j < C.Count; ++j)
                {
                    if (C[j].u == path[i] && C[j].v == path[i+1])
                    {
                        vdt.vecanh(C[j].ux, C[j].vx, C[j].trongso, penselect);
                        bang.Image = vdt.trabitmap();
                    }
                }
            }
            hienketqua.Items.Clear();
            string kq = path[0].ToString();
            for(int i = 1; i< path.Count; ++i)
            {
                kq += "->" + path[i];
            }    
            hienketqua.Items.Add(kq);
        }

        private void XđthBtn_Click(object sender, EventArgs e)
        {
            D.Clear();
            C.Clear();
            vdt.xoabang();
            bang.Image = vdt.trabitmap();
            goc.Items.Clear();
            dich.Items.Clear();
            hientrongso.Items.Clear();
            Array.Clear(mang,0,mang.Length);
        }
    }
}
