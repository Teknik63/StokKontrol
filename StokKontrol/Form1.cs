using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
         this.firmalarTableAdapter.Fill(this.firmalar._firmalar);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (firmalarTableAdapter.GetData().Count<=0)
            {
                MessageBox.Show("Silinecek Kayıt Yok.");
            }
            else
            {
                int i = Convert.ToInt32(firma_idTextBox.Text);
                firmalarTableAdapter.delete(i);
                firmalarTableAdapter.Fill(firmalar._firmalar);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            firmalarTableAdapter.insert(
            fAdi.Text,
            fTelefon.Text,
            fkisi.Text,
            fAdres.Text);

            firmalarTableAdapter.Fill(firmalar._firmalar);
            insertPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertPanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (firmalarTableAdapter.GetData().Count <= 0)
            {
                MessageBox.Show("Güncellenecek Kayıt Yok.");
            }
            else
            {
                int i = Convert.ToInt32(firma_idTextBox.Text);
                firmalarTableAdapter.firmalarUpdate(
                    firma_adiTextBox.Text,
                    firma_telefonTextBox.Text,
                    firma_kisiTextBox.Text,
                    firma_adresTextBox.Text,
                    i);
                firmalarTableAdapter.Fill(firmalar._firmalar);
            }


        }
    }
}
