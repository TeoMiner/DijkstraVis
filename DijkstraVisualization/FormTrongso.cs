using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraVisualization
{
    public partial class FormTrongso : Form
    {
        public int value = -1;
        public bool dong = false;
        public FormTrongso()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text;
            try
            {
                value = Int32.Parse(val);
                if(value < 0) 
                {
                    MessageBox.Show("Giá trị trọng số không hợp lệ");
                } 
            }
            catch (FormatException)
            {
                MessageBox.Show("Trọng số có giá trị không hợp lệ!");
                value = -1;
            }
            if( value > -1 ) 
            {
                this.Close();
            }
        }
        private void FormTrongso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (value == -1)
                {
                    dong = true;
                }
            }
        }
    }
}
