using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_paw
{
    public partial class Form1 : Form
    {
        List<Imobil> listaImob=new List<Imobil>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btImob_Click(object sender, EventArgs e)
        {
            try
            {
                int idImobil=Convert.ToInt32(tbIDIm.Text);
                string tipImobil=cbTipIm.Text;
                string adresa=tbAdresaIm.Text;
                float suprafataUtila=Convert.ToInt32(tbSuprafata.Text);
                int nrCamere=Convert.ToInt32(numericNrCamIm.Value);
                float pret=Convert.ToInt32(tbPretIm.Text);
                string descriere=tbDescriereIm.Text;
                Imobil i = new Imobil(idImobil, tipImobil, adresa, suprafataUtila, nrCamere, pret, descriere);
                listaImob.Add(i);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbIDIm.Text = "10";
                cbTipIm.Text = "Necunoscut";
                tbAdresaIm.Text = "Necunoscuta";
                tbSuprafata.Text = "1";
                tbPretIm.Text = "200";
                tbDescriereIm.Text = "Necunoscuta";
                numericNrCamIm.Value = 1;
            }
        }

        private void btVizIm_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaImob);
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbIDIm.Text="10";
            cbTipIm.Text = "Necunoscut";
            tbAdresaIm.Text="Necunoscuta";
            tbSuprafata.Text="1";
            tbPretIm.Text="200";
            tbDescriereIm.Text="Necunoscuta";
            numericNrCamIm.Value = 1;
        }

        public bool idValid(int id)
        {
            return id > 1 && id < 100;
        }

        public bool adresaValid(string adresa)
        {
            return adresa.Length > 3;
        }

        public bool suprafataValid(int supr)
        {
            return supr > 0;
        }

        public bool nrValid(int nr)
        {
            return nr >= 1;
        }

        public bool pretValid(int pret)
        {
            return pret > 150;
        }

        public bool descrValid(string desc)
        {
            return desc.Length > 3;
        }
        private void tbIDIm_Validating(object sender, CancelEventArgs e)
        {
            if(!idValid(Convert.ToInt32(tbIDIm.Text)))
            {
                errorProvider1.SetError(tbIDIm, "Id invalid!");
                e.Cancel = true;
            }
        }

        private void tbIDIm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbIDIm, String.Empty);
        }

        private void tbAdresaIm_Validating(object sender, CancelEventArgs e)
        {
            if(!adresaValid(tbAdresaIm.Text))
            {
                errorProvider1.SetError(tbAdresaIm, "Adresa invalida!");
                e.Cancel = true;
            }
        }

        private void tbAdresaIm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbAdresaIm, String.Empty);
        }

        private void tbSuprafata_Validating(object sender, CancelEventArgs e)
        {
            if(!suprafataValid(Convert.ToInt32(tbSuprafata.Text)))
            {
                errorProvider1.SetError(tbSuprafata, "Suprafata invalida!");
                e.Cancel = true;
            }
        }

        private void tbSuprafata_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbSuprafata, String.Empty);
        }

        private void numericNrCamIm_Validating(object sender, CancelEventArgs e)
        {
            if(!nrValid(Convert.ToInt32(numericNrCamIm.Text)))
            {
                errorProvider1.SetError(numericNrCamIm, "Nr camere invalid!");
                e.Cancel = true;
            }
        }

        private void numericNrCamIm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(numericNrCamIm, String.Empty);
        }

        private void tbPretIm_Validating(object sender, CancelEventArgs e)
        {
            if(!pretValid(Convert.ToInt32(tbPretIm.Text)))
            {
                errorProvider1.SetError(tbPretIm, "Pret invalid!");
                e.Cancel = true;
            }
        }

        private void tbPretIm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPretIm, String.Empty);
        }

        private void tbDescriereIm_Validating(object sender, CancelEventArgs e)
        {
            if(!descrValid(tbDescriereIm.Text))
            {
                errorProvider1.SetError(tbDescriereIm, "Descriere invalida!");
                e.Cancel = true;
            }
        }

        private void tbDescriereIm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDescriereIm, String.Empty);
        }
    }
}
