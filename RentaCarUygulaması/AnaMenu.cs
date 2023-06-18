using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCarUygulaması
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arabalar arabalarFormu = new Arabalar();
            arabalarFormu.Show();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müsteriler müsterilerFormu = new Müsteriler();
            müsterilerFormu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personeller personelFormu = new Personeller();
            personelFormu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kiralamalar kiralamaFormu = new Kiralamalar();
            kiralamaFormu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kullanıcıİşlemleri KullanıcıİşlemleriFormu = new Kullanıcıİşlemleri();
            KullanıcıİşlemleriFormu.Show();
        }
    }
}
