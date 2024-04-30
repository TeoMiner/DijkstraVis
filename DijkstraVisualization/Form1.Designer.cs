namespace DijkstraVisualization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaoDinh = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.PictureBox();
            this.TaoCanh = new System.Windows.Forms.Button();
            this.XoaDinh = new System.Windows.Forms.Button();
            this.Giai = new System.Windows.Forms.Button();
            this.hientrongso = new System.Windows.Forms.ListBox();
            this.goc = new System.Windows.Forms.ComboBox();
            this.dich = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XđthBtn = new System.Windows.Forms.Button();
            this.hienketqua = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            this.SuspendLayout();
            // 
            // TaoDinh
            // 
            this.TaoDinh.Location = new System.Drawing.Point(2, 2);
            this.TaoDinh.Name = "TaoDinh";
            this.TaoDinh.Size = new System.Drawing.Size(86, 59);
            this.TaoDinh.TabIndex = 0;
            this.TaoDinh.Text = "Tạo đỉnh";
            this.TaoDinh.UseVisualStyleBackColor = true;
            this.TaoDinh.Click += new System.EventHandler(this.TaoDinh_Click);
            // 
            // bang
            // 
            this.bang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bang.BackColor = System.Drawing.Color.White;
            this.bang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bang.Location = new System.Drawing.Point(186, 2);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(793, 644);
            this.bang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bang.TabIndex = 1;
            this.bang.TabStop = false;
            this.bang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bang_MouseClick);
            // 
            // TaoCanh
            // 
            this.TaoCanh.Location = new System.Drawing.Point(94, 2);
            this.TaoCanh.Name = "TaoCanh";
            this.TaoCanh.Size = new System.Drawing.Size(86, 59);
            this.TaoCanh.TabIndex = 2;
            this.TaoCanh.Text = "Tạo cạnh";
            this.TaoCanh.UseVisualStyleBackColor = true;
            this.TaoCanh.Click += new System.EventHandler(this.TaoCanh_Click);
            // 
            // XoaDinh
            // 
            this.XoaDinh.Location = new System.Drawing.Point(2, 67);
            this.XoaDinh.Name = "XoaDinh";
            this.XoaDinh.Size = new System.Drawing.Size(86, 56);
            this.XoaDinh.TabIndex = 3;
            this.XoaDinh.Text = "Xoá đỉnh";
            this.XoaDinh.UseVisualStyleBackColor = true;
            this.XoaDinh.Click += new System.EventHandler(this.XoaDinh_Click);
            // 
            // Giai
            // 
            this.Giai.Location = new System.Drawing.Point(7, 375);
            this.Giai.Name = "Giai";
            this.Giai.Size = new System.Drawing.Size(173, 48);
            this.Giai.TabIndex = 5;
            this.Giai.Text = "Tìm đường đi ngắn nhất!";
            this.Giai.UseVisualStyleBackColor = true;
            this.Giai.Click += new System.EventHandler(this.Giai_Click);
            // 
            // hientrongso
            // 
            this.hientrongso.FormattingEnabled = true;
            this.hientrongso.ItemHeight = 16;
            this.hientrongso.Location = new System.Drawing.Point(7, 129);
            this.hientrongso.Name = "hientrongso";
            this.hientrongso.Size = new System.Drawing.Size(173, 148);
            this.hientrongso.TabIndex = 6;
            // 
            // goc
            // 
            this.goc.FormattingEnabled = true;
            this.goc.Location = new System.Drawing.Point(7, 299);
            this.goc.Name = "goc";
            this.goc.Size = new System.Drawing.Size(167, 24);
            this.goc.TabIndex = 7;
            // 
            // dich
            // 
            this.dich.FormattingEnabled = true;
            this.dich.Location = new System.Drawing.Point(7, 345);
            this.dich.Name = "dich";
            this.dich.Size = new System.Drawing.Size(167, 24);
            this.dich.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Điểm gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Điểm đích";
            // 
            // XđthBtn
            // 
            this.XđthBtn.Location = new System.Drawing.Point(94, 67);
            this.XđthBtn.Name = "XđthBtn";
            this.XđthBtn.Size = new System.Drawing.Size(86, 56);
            this.XđthBtn.TabIndex = 11;
            this.XđthBtn.Text = "Xoá đồ thị";
            this.XđthBtn.UseVisualStyleBackColor = true;
            this.XđthBtn.Click += new System.EventHandler(this.XđthBtn_Click);
            // 
            // hienketqua
            // 
            this.hienketqua.FormattingEnabled = true;
            this.hienketqua.ItemHeight = 16;
            this.hienketqua.Location = new System.Drawing.Point(9, 429);
            this.hienketqua.Name = "hienketqua";
            this.hienketqua.Size = new System.Drawing.Size(171, 148);
            this.hienketqua.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 646);
            this.Controls.Add(this.hienketqua);
            this.Controls.Add(this.XđthBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dich);
            this.Controls.Add(this.goc);
            this.Controls.Add(this.hientrongso);
            this.Controls.Add(this.Giai);
            this.Controls.Add(this.XoaDinh);
            this.Controls.Add(this.TaoCanh);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.TaoDinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TaoDinh;
        private System.Windows.Forms.PictureBox bang;
        private System.Windows.Forms.Button TaoCanh;
        private System.Windows.Forms.Button XoaDinh;
        private System.Windows.Forms.Button Giai;
        private System.Windows.Forms.ListBox hientrongso;
        private System.Windows.Forms.ComboBox goc;
        private System.Windows.Forms.ComboBox dich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button XđthBtn;
        private System.Windows.Forms.ListBox hienketqua;
    }
}

