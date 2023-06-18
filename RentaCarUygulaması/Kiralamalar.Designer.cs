namespace RentaCarUygulaması
{
    partial class Kiralamalar
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
            this.kiralanmatarihi = new System.Windows.Forms.DateTimePicker();
            this.teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.araclarcmb = new System.Windows.Forms.ComboBox();
            this.kirala = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.musterilercmb = new System.Windows.Forms.ComboBox();
            this.personellercmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kiralanmatarihi
            // 
            this.kiralanmatarihi.CalendarFont = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralanmatarihi.Location = new System.Drawing.Point(46, 143);
            this.kiralanmatarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kiralanmatarihi.Name = "kiralanmatarihi";
            this.kiralanmatarihi.Size = new System.Drawing.Size(216, 22);
            this.kiralanmatarihi.TabIndex = 0;
            // 
            // teslimtarihi
            // 
            this.teslimtarihi.Location = new System.Drawing.Point(46, 236);
            this.teslimtarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teslimtarihi.Name = "teslimtarihi";
            this.teslimtarihi.Size = new System.Drawing.Size(216, 22);
            this.teslimtarihi.TabIndex = 1;
            this.teslimtarihi.ValueChanged += new System.EventHandler(this.teslimtarihi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiralama Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teslim Tarihi";
            // 
            // araclarcmb
            // 
            this.araclarcmb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araclarcmb.FormattingEnabled = true;
            this.araclarcmb.Location = new System.Drawing.Point(395, 131);
            this.araclarcmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.araclarcmb.Name = "araclarcmb";
            this.araclarcmb.Size = new System.Drawing.Size(221, 37);
            this.araclarcmb.TabIndex = 4;
            this.araclarcmb.SelectedIndexChanged += new System.EventHandler(this.araclarcmb_SelectedIndexChanged);
            // 
            // kirala
            // 
            this.kirala.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kirala.Location = new System.Drawing.Point(8, 370);
            this.kirala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kirala.Name = "kirala";
            this.kirala.Size = new System.Drawing.Size(124, 71);
            this.kirala.TabIndex = 5;
            this.kirala.Text = "Kirala";
            this.kirala.UseVisualStyleBackColor = true;
            this.kirala.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(251, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "Teslim Alındı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 454);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 338);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(453, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arabalar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(767, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Müşteriler";
            // 
            // musterilercmb
            // 
            this.musterilercmb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musterilercmb.FormattingEnabled = true;
            this.musterilercmb.Location = new System.Drawing.Point(720, 128);
            this.musterilercmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musterilercmb.Name = "musterilercmb";
            this.musterilercmb.Size = new System.Drawing.Size(221, 37);
            this.musterilercmb.TabIndex = 11;
            // 
            // personellercmb
            // 
            this.personellercmb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personellercmb.FormattingEnabled = true;
            this.personellercmb.Location = new System.Drawing.Point(583, 236);
            this.personellercmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personellercmb.Name = "personellercmb";
            this.personellercmb.Size = new System.Drawing.Size(213, 37);
            this.personellercmb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(620, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personeller";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(835, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 71);
            this.button1.TabIndex = 15;
            this.button1.Text = "Geçmiş Kiralamaları Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(540, 372);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 71);
            this.button3.TabIndex = 16;
            this.button3.Text = "Güncel Kiralamaları Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Kiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentaCarUygulaması.Properties.Resources.arackiralama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 803);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.personellercmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.musterilercmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kirala);
            this.Controls.Add(this.araclarcmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teslimtarihi);
            this.Controls.Add(this.kiralanmatarihi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kiralamalar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Kiralamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker kiralanmatarihi;
        private System.Windows.Forms.DateTimePicker teslimtarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox araclarcmb;
        private System.Windows.Forms.Button kirala;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox musterilercmb;
        private System.Windows.Forms.ComboBox personellercmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}