using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmOgr_Click(object sender, EventArgs e)
        {
            frmOgrKayit ogrenciKayitForm = new frmOgrKayit();

           
            ogrenciKayitForm.FormClosed += (s, args) => this.Show();

            this.Hide(); 
            ogrenciKayitForm.Show();
        }

        private void frmOgrt_Click(object sender, EventArgs e)
        {
            frmOgrtKayit ogretmenKayitForm = new frmOgrtKayit();

            ogretmenKayitForm.FormClosed += (s, args) => this.Show();

            this.Hide(); // Giriş formunu gizle
            ogretmenKayitForm.Show();
        }
    }
}
