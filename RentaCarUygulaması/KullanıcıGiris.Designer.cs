namespace RentaCarUygulaması
{
    partial class KullanıcıGiris
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
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Girisyap = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.BackColor = System.Drawing.Color.SteelBlue;
            this.kullaniciadi.ForeColor = System.Drawing.Color.Red;
            this.kullaniciadi.Location = new System.Drawing.Point(337, 139);
            this.kullaniciadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(137, 22);
            this.kullaniciadi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.SteelBlue;
            this.sifre.ForeColor = System.Drawing.Color.Red;
            this.sifre.Location = new System.Drawing.Point(337, 219);
            this.sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(137, 22);
            this.sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(316, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(363, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifre";
            // 
            // Girisyap
            // 
            this.Girisyap.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.giriş_yap_butonupng;
            this.Girisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Girisyap.Location = new System.Drawing.Point(337, 257);
            this.Girisyap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girisyap.Name = "Girisyap";
            this.Girisyap.Size = new System.Drawing.Size(139, 42);
            this.Girisyap.TabIndex = 5;
            this.Girisyap.UseVisualStyleBackColor = true;
            this.Girisyap.Click += new System.EventHandler(this.Girisyap_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(481, 215);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KullanıcıGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.admingirisekranı;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 398);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Girisyap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KullanıcıGiris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KullanıcıGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Girisyap;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

