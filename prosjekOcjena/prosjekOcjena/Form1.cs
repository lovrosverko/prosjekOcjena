using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjekOcjena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ocjena;
        double zbrojOcjena = 0;
        double prosjek = 0;
        double brojOcjena = 0;

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                ocjena = Convert.ToInt32(txtUnosOcjene.Text);
                if (ocjena < 1 || ocjena > 5)
                {
                    MessageBox.Show("Upišite ispravnu ocjenu", "Pogreška");
                    txtUnosOcjene.Clear();
                }
                else
                {
                    brojOcjena++;
                    zbrojOcjena += ocjena;
                    txtIspis.AppendText(ocjena + "\r\n");
                    DialogResult odgovor =
                    MessageBox.Show("Želite li unijeti još jednu ocjenu?",
                    "Izbor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (odgovor == DialogResult.Yes)
                    {
                        txtUnosOcjene.Clear();
                    }
                    else
                    {
                        prosjek = zbrojOcjena / brojOcjena;
                        txtIspis.Text = "Prosjek je: " + prosjek;
                    }
                }
                
            }
            catch (Exception greska)
            {
                MessageBox.Show("Upišite ispravnu ocjenu", "Pogreška");
                txtUnosOcjene.Clear();
            }
        }
    }
}
