using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class NovProdukt : Form
    {
        public Product product;
        public NovProdukt()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (tbIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внесете име!");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
            }
        }

        private void tbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (tbKategorija.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbKategorija, "Внесете категорија!");
            }
            else
            {
                errorProvider1.SetError(tbKategorija, null);
            }
        }

        private void tbCena_Validating(object sender, CancelEventArgs e)
        {
            decimal cena;
            if (tbCena.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCena, "Внесете цена!");
            }else if (!decimal.TryParse(tbCena.Text, out cena))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCena, "Внесете бројка");
            }
            else
            {
                errorProvider1.SetError(tbCena, null);
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            product = new Product();
            product.Ime = tbIme.Text;
            product.Kategorija = tbKategorija.Text;
            product.Cena = decimal.Parse(tbCena.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
