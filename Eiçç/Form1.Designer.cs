namespace Eiçç
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmIşlemci = new System.Windows.Forms.Timer(this.components);
            this.tmPros1 = new System.Windows.Forms.Timer(this.components);
            this.tmPros2 = new System.Windows.Forms.Timer(this.components);
            this.tmPros3 = new System.Windows.Forms.Timer(this.components);
            this.tmEkle = new System.Windows.Forms.Timer(this.components);
            this.trbProses3 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstbP3 = new System.Windows.Forms.ListBox();
            this.lstbP2 = new System.Windows.Forms.ListBox();
            this.lstbP1 = new System.Windows.Forms.ListBox();
            this.btnGöster = new System.Windows.Forms.Button();
            this.chbPros3 = new System.Windows.Forms.CheckBox();
            this.chbPros2 = new System.Windows.Forms.CheckBox();
            this.chbPros1 = new System.Windows.Forms.CheckBox();
            this.trbProses2 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbİşlemci = new System.Windows.Forms.TrackBar();
            this.btnBaşlat = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trbProses1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPros2 = new System.Windows.Forms.TextBox();
            this.txbPros3 = new System.Windows.Forms.TextBox();
            this.txbKuyruk = new System.Windows.Forms.TextBox();
            this.txbPros1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbProses3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbProses2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbİşlemci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProses1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmIşlemci
            // 
            this.tmIşlemci.Interval = 1000;
            this.tmIşlemci.Tick += new System.EventHandler(this.tmIşlemci_Tick);
            // 
            // tmPros1
            // 
            this.tmPros1.Enabled = true;
            this.tmPros1.Interval = 1000;
            this.tmPros1.Tick += new System.EventHandler(this.tmPros1_Tick_1);
            // 
            // tmPros2
            // 
            this.tmPros2.Enabled = true;
            this.tmPros2.Interval = 1000;
            this.tmPros2.Tick += new System.EventHandler(this.tmPros2_Tick);
            // 
            // tmPros3
            // 
            this.tmPros3.Enabled = true;
            this.tmPros3.Interval = 1000;
            this.tmPros3.Tick += new System.EventHandler(this.tmPros3_Tick);
            // 
            // tmEkle
            // 
            this.tmEkle.Interval = 500;
            this.tmEkle.Tick += new System.EventHandler(this.tmEkle_Tick);
            // 
            // trbProses3
            // 
            this.trbProses3.Location = new System.Drawing.Point(55, 559);
            this.trbProses3.Name = "trbProses3";
            this.trbProses3.Size = new System.Drawing.Size(200, 56);
            this.trbProses3.TabIndex = 37;
            this.trbProses3.Value = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstbP3);
            this.panel1.Controls.Add(this.lstbP2);
            this.panel1.Controls.Add(this.lstbP1);
            this.panel1.Controls.Add(this.btnGöster);
            this.panel1.Controls.Add(this.chbPros3);
            this.panel1.Controls.Add(this.chbPros2);
            this.panel1.Controls.Add(this.chbPros1);
            this.panel1.Location = new System.Drawing.Point(394, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 318);
            this.panel1.TabIndex = 34;
            // 
            // lstbP3
            // 
            this.lstbP3.FormattingEnabled = true;
            this.lstbP3.ItemHeight = 16;
            this.lstbP3.Location = new System.Drawing.Point(253, 73);
            this.lstbP3.Name = "lstbP3";
            this.lstbP3.Size = new System.Drawing.Size(120, 244);
            this.lstbP3.TabIndex = 22;
            // 
            // lstbP2
            // 
            this.lstbP2.FormattingEnabled = true;
            this.lstbP2.ItemHeight = 16;
            this.lstbP2.Location = new System.Drawing.Point(127, 73);
            this.lstbP2.Name = "lstbP2";
            this.lstbP2.Size = new System.Drawing.Size(120, 244);
            this.lstbP2.TabIndex = 21;
            // 
            // lstbP1
            // 
            this.lstbP1.FormattingEnabled = true;
            this.lstbP1.ItemHeight = 16;
            this.lstbP1.Location = new System.Drawing.Point(3, 73);
            this.lstbP1.Name = "lstbP1";
            this.lstbP1.Size = new System.Drawing.Size(120, 244);
            this.lstbP1.TabIndex = 20;
            // 
            // btnGöster
            // 
            this.btnGöster.Location = new System.Drawing.Point(5, 38);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(370, 27);
            this.btnGöster.TabIndex = 19;
            this.btnGöster.Text = "Bitirilen Prosesleri Göster";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // chbPros3
            // 
            this.chbPros3.AutoSize = true;
            this.chbPros3.Location = new System.Drawing.Point(273, 11);
            this.chbPros3.Name = "chbPros3";
            this.chbPros3.Size = new System.Drawing.Size(82, 20);
            this.chbPros3.TabIndex = 18;
            this.chbPros3.Text = "Proses 3";
            this.chbPros3.UseVisualStyleBackColor = true;
            // 
            // chbPros2
            // 
            this.chbPros2.AutoSize = true;
            this.chbPros2.Location = new System.Drawing.Point(150, 11);
            this.chbPros2.Name = "chbPros2";
            this.chbPros2.Size = new System.Drawing.Size(82, 20);
            this.chbPros2.TabIndex = 17;
            this.chbPros2.Text = "Proses 2";
            this.chbPros2.UseVisualStyleBackColor = true;
            // 
            // chbPros1
            // 
            this.chbPros1.AutoSize = true;
            this.chbPros1.Location = new System.Drawing.Point(23, 11);
            this.chbPros1.Name = "chbPros1";
            this.chbPros1.Size = new System.Drawing.Size(82, 20);
            this.chbPros1.TabIndex = 16;
            this.chbPros1.Text = "Proses 1";
            this.chbPros1.UseVisualStyleBackColor = true;
            // 
            // trbProses2
            // 
            this.trbProses2.Location = new System.Drawing.Point(55, 497);
            this.trbProses2.Name = "trbProses2";
            this.trbProses2.Size = new System.Drawing.Size(200, 56);
            this.trbProses2.TabIndex = 36;
            this.trbProses2.Value = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Proses 3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trbİşlemci);
            this.groupBox1.Controls.Add(this.btnBaşlat);
            this.groupBox1.Controls.Add(this.btnBitir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trbProses1);
            this.groupBox1.Location = new System.Drawing.Point(55, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 122);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hız ayarları (1 sn de yapılan işlem sayısı)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "İşlemci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Proses 1";
            // 
            // trbİşlemci
            // 
            this.trbİşlemci.Location = new System.Drawing.Point(375, 61);
            this.trbİşlemci.Name = "trbİşlemci";
            this.trbİşlemci.Size = new System.Drawing.Size(200, 56);
            this.trbİşlemci.TabIndex = 0;
            this.trbİşlemci.Value = 1;
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.Location = new System.Drawing.Point(590, 30);
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.Size = new System.Drawing.Size(131, 39);
            this.btnBaşlat.TabIndex = 12;
            this.btnBaşlat.Text = "İşlemci Başlat";
            this.btnBaşlat.UseVisualStyleBackColor = true;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(590, 75);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(131, 42);
            this.btnBitir.TabIndex = 13;
            this.btnBitir.Text = "İşlemci Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Proses 2";
            // 
            // trbProses1
            // 
            this.trbProses1.Location = new System.Drawing.Point(6, 49);
            this.trbProses1.Name = "trbProses1";
            this.trbProses1.Size = new System.Drawing.Size(200, 56);
            this.trbProses1.TabIndex = 9;
            this.trbProses1.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Proses 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Proses 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Proses 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Proses kuyruğu";
            // 
            // txbPros2
            // 
            this.txbPros2.Location = new System.Drawing.Point(171, 145);
            this.txbPros2.Multiline = true;
            this.txbPros2.Name = "txbPros2";
            this.txbPros2.Size = new System.Drawing.Size(60, 158);
            this.txbPros2.TabIndex = 28;
            // 
            // txbPros3
            // 
            this.txbPros3.Location = new System.Drawing.Point(267, 143);
            this.txbPros3.Multiline = true;
            this.txbPros3.Name = "txbPros3";
            this.txbPros3.Size = new System.Drawing.Size(60, 158);
            this.txbPros3.TabIndex = 27;
            // 
            // txbKuyruk
            // 
            this.txbKuyruk.Location = new System.Drawing.Point(76, 85);
            this.txbKuyruk.Multiline = true;
            this.txbKuyruk.Name = "txbKuyruk";
            this.txbKuyruk.Size = new System.Drawing.Size(294, 36);
            this.txbKuyruk.TabIndex = 26;
            // 
            // txbPros1
            // 
            this.txbPros1.Location = new System.Drawing.Point(76, 145);
            this.txbPros1.Multiline = true;
            this.txbPros1.Name = "txbPros1";
            this.txbPros1.Size = new System.Drawing.Size(60, 158);
            this.txbPros1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 660);
            this.Controls.Add(this.trbProses3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trbProses2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPros2);
            this.Controls.Add(this.txbPros3);
            this.Controls.Add(this.txbKuyruk);
            this.Controls.Add(this.txbPros1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbProses3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbProses2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbİşlemci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProses1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmIşlemci;
        private System.Windows.Forms.Timer tmPros1;
        private System.Windows.Forms.Timer tmPros2;
        private System.Windows.Forms.Timer tmPros3;
        private System.Windows.Forms.Timer tmEkle;
        private System.Windows.Forms.TrackBar trbProses3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstbP3;
        private System.Windows.Forms.ListBox lstbP2;
        private System.Windows.Forms.ListBox lstbP1;
        private System.Windows.Forms.Button btnGöster;
        private System.Windows.Forms.CheckBox chbPros3;
        private System.Windows.Forms.CheckBox chbPros2;
        private System.Windows.Forms.CheckBox chbPros1;
        private System.Windows.Forms.TrackBar trbProses2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trbİşlemci;
        private System.Windows.Forms.Button btnBaşlat;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trbProses1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPros2;
        private System.Windows.Forms.TextBox txbPros3;
        private System.Windows.Forms.TextBox txbKuyruk;
        private System.Windows.Forms.TextBox txbPros1;
    }
}

