using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sporsalonu
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeyonetimi uyeForm = new uyeyonetimi();
            uyeForm.ShowDialog(); // uyeyonetimi formunu aç

            // Mevcut formu gizle
           // this.Hide();
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odemeYonetimi odemeForm= new odemeYonetimi();
            odemeForm.ShowDialog();// odemeYonetimi formunu aç
            //this.Hide();// Mevcut formu gizle
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
