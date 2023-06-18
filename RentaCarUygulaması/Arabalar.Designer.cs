namespace RentaCarUygulaması
{
    partial class Arabalar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.yıltxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.renkcmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yakıtcmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fiyattxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.ComboBox();
            this.guncelleme = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 442);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 535);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modeltxt
            // 
            this.modeltxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modeltxt.Location = new System.Drawing.Point(361, 85);
            this.modeltxt.Margin = new System.Windows.Forms.Padding(4);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(183, 35);
            this.modeltxt.TabIndex = 2;
            // 
            // yıltxt
            // 
            this.yıltxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yıltxt.Location = new System.Drawing.Point(243, 207);
            this.yıltxt.Margin = new System.Windows.Forms.Padding(4);
            this.yıltxt.Name = "yıltxt";
            this.yıltxt.Size = new System.Drawing.Size(149, 35);
            this.yıltxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(386, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(297, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(731, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(876, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Renk";
            // 
            // plakatxt
            // 
            this.plakatxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakatxt.Location = new System.Drawing.Point(676, 90);
            this.plakatxt.Margin = new System.Windows.Forms.Padding(4);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(190, 35);
            this.plakatxt.TabIndex = 9;
            // 
            // renkcmb
            // 
            this.renkcmb.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renkcmb.FormattingEnabled = true;
            this.renkcmb.Items.AddRange(new object[] {
            "",
            "Siyah",
            "Beyaz",
            "Gri",
            "Kırmızı",
            "Mavi",
            "Yeşil",
            "Sarı",
            "Turuncu",
            "Mor",
            "Pembe",
            "Kahverengi",
            "Turkuaz",
            "Lacivert",
            "Bordo",
            "Lila",
            "Bej",
            "Açık mavi",
            "Açık yeşil",
            "Açık gri",
            "Açık sarı",
            "Açık pembe",
            "Açık mor",
            "Açık turuncu",
            "Açık kahverengi",
            "Açık turkuaz",
            "Açık lacivert",
            "Açık bordo",
            "Açık lila",
            "Açık bej",
            "Koyu mavi",
            "Koyu yeşil",
            "Koyu gri",
            "Koyu sarı",
            "Koyu pembe",
            "Koyu mor",
            "Koyu turuncu",
            "Koyu kahverengi",
            "Koyu turkuaz",
            "Koyu lacivert",
            "Koyu bordo",
            "Koyu lila",
            "Koyu bej"});
            this.renkcmb.Location = new System.Drawing.Point(834, 211);
            this.renkcmb.Margin = new System.Windows.Forms.Padding(4);
            this.renkcmb.Name = "renkcmb";
            this.renkcmb.Size = new System.Drawing.Size(160, 33);
            this.renkcmb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(542, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yakıt Türü";
            // 
            // yakıtcmb
            // 
            this.yakıtcmb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakıtcmb.FormattingEnabled = true;
            this.yakıtcmb.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Elektrikli",
            "Benzin & LPG"});
            this.yakıtcmb.Location = new System.Drawing.Point(535, 211);
            this.yakıtcmb.Margin = new System.Windows.Forms.Padding(4);
            this.yakıtcmb.Name = "yakıtcmb";
            this.yakıtcmb.Size = new System.Drawing.Size(177, 37);
            this.yakıtcmb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(1024, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fiyat";
            // 
            // fiyattxt
            // 
            this.fiyattxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyattxt.Location = new System.Drawing.Point(964, 90);
            this.fiyattxt.Margin = new System.Windows.Forms.Padding(4);
            this.fiyattxt.Name = "fiyattxt";
            this.fiyattxt.Size = new System.Drawing.Size(199, 35);
            this.fiyattxt.TabIndex = 14;
            // 
            // markatxt
            // 
            this.markatxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markatxt.FormattingEnabled = true;
            this.markatxt.Items.AddRange(new object[] {
            "",
            "Audi",
            "BMW",
            "Mercedes-Benz",
            "Volkswagen",
            "Renault",
            "Ford",
            "Fiat",
            "Toyota",
            "Honda",
            "Hyundai",
            "Kia",
            "Volvo",
            "Nissan",
            "Mazda",
            "Chevrolet",
            "Peugeot",
            "Opel",
            "Citroen",
            "Skoda",
            "Subaru",
            "Mitsubishi",
            "Jaguar",
            "Land Rover",
            "Lexus",
            "Mini",
            "Porsche",
            "Tesla",
            "Alfa Romeo",
            "Aston Martin",
            "Bentley",
            "Bugatti",
            "Ferrari",
            "Lamborghini",
            "Maserati",
            "Rolls-Royce",
            "McLaren",
            "Lotus",
            "Infiniti",
            "GMC",
            "Peugeot",
            "Renault",
            "Skoda",
            "Tesla"});
            this.markatxt.Location = new System.Drawing.Point(16, 85);
            this.markatxt.Margin = new System.Windows.Forms.Padding(4);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(214, 40);
            this.markatxt.TabIndex = 16;
            // 
            // guncelleme
            // 
            this.guncelleme.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.Kullanıcı_güncelle__2__;
            this.guncelleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guncelleme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guncelleme.Location = new System.Drawing.Point(740, 301);
            this.guncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.guncelleme.Name = "guncelleme";
            this.guncelleme.Size = new System.Drawing.Size(138, 122);
            this.guncelleme.TabIndex = 18;
            this.guncelleme.Text = "Güncelleme";
            this.guncelleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelleme.UseVisualStyleBackColor = true;
            this.guncelleme.Click += new System.EventHandler(this.guncelleme_Click);
            // 
            // sil
            // 
            this.sil.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.kullanıcı_sil;
            this.sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sil.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(1060, 301);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(153, 122);
            this.sil.TabIndex = 19;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.kullanıcı_bul;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(361, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 122);
            this.button2.TabIndex = 17;
            this.button2.Text = "Bul";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.kullanıcıkaydet_logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(16, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 123);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arabalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.arabalararkaplanyeni;
            this.ClientSize = new System.Drawing.Size(1226, 992);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelleme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiyattxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yakıtcmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.renkcmb);
            this.Controls.Add(this.plakatxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yıltxt);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Arabalar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Arabalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.TextBox yıltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.ComboBox renkcmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox yakıtcmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fiyattxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox markatxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button guncelleme;
        private System.Windows.Forms.Button sil;
    }
}