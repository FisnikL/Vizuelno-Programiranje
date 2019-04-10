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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Product p = new Product();
            p.Ime = "Месо";
            p.Kategorija = "Храна";
            p.Cena = 300;
            lbProdukti.Items.Add(p);

            p = new Product();
            p.Ime = "Млеко";
            p.Kategorija = "Пијалок";
            p.Cena = 54;
            lbProdukti.Items.Add(p);

            p = new Product();
            p.Ime = "Вино";
            p.Kategorija = "Пијалок";
            p.Cena = 1300;
            lbProdukti.Items.Add(p);

            p = new Product();
            p.Ime = "Пиво";
            p.Kategorija = "Пијалок";
            p.Cena = 80;
            lbProdukti.Items.Add(p);

            p = new Product();
            p.Ime = "Шампон";
            p.Kategorija = "Хигиена";
            p.Cena = 220;
            lbProdukti.Items.Add(p);

            p = new Product();
            p.Ime = "Паста за заби";
            p.Kategorija = "Хигиена";
            p.Cena = 190;
            lbProdukti.Items.Add(p);
        }

        private void btnDodadiProdukt_Click(object sender, EventArgs e)
        {
            NovProdukt np = new NovProdukt();
            if(np.ShowDialog() == DialogResult.OK)
            {
                lbProdukti.Items.Add(np.product);
            }
        }

        private void lbProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDodadiKoshnicka.Enabled = lbProdukti.SelectedIndex != -1;
            nudKolicina.Enabled = btnDodadiKoshnicka.Enabled;
            btnIzbrishiProdukt.Enabled = lbProdukti.SelectedIndex != -1;
            refreshDetaliZaProduktot();
        }

        private void btnIsprazniProdukti_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?", 
                "Испразни ја листата", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbProdukti.Items.Clear();
                refreshDetaliZaProduktot();
            }
        }

        private void refreshDetaliZaProduktot()
        {
            tbIme.Text = "";
            tbKategorija.Text = "";
            tbCena.Text = "";
            if (lbProdukti.SelectedIndex != -1)
            {
                Product p = lbProdukti.SelectedItem as Product;
                tbIme.Text = p.Ime;
                tbKategorija.Text = p.Kategorija;
                tbCena.Text = string.Format("{0:0.00}", p.Cena);
            }
        }

        private void btnDodadiKoshnicka_Click(object sender, EventArgs e)
        {
            if(lbProdukti.SelectedIndex != -1)
            {
                ProductItem pi = new ProductItem();
                pi.Product = lbProdukti.SelectedItem as Product;
                pi.Kolicina = nudKolicina.Value;
                lbKoshnicka.Items.Add(pi);
                refreshVkupno();
                nudKolicina.Value = 1;
                lbProdukti.SelectedIndex = -1;
            }
        }

        private void refreshVkupno()
        {
            tbVkupno.Text = "";
            if (lbKoshnicka.Items.Count > 0)
            {
                decimal total = 0;
                foreach (ProductItem p in lbKoshnicka.Items)
                {
                    total += p.Kolicina * p.Product.Cena;
                }
                tbVkupno.Text = string.Format("{0:0.00}", total);
            }
        }

        private void lbKoshnicka_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrishiKoshnicka.Enabled = lbKoshnicka.SelectedIndex != -1;
        }

        private void btnIzbrishiKoshnicka_Click(object sender, EventArgs e)
        {
            if(lbKoshnicka.SelectedIndex != -1)
            {
                lbKoshnicka.Items.RemoveAt(lbKoshnicka.SelectedIndex);
                refreshVkupno();
            }
        }

        private void btnIzbrishiProdukt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете продуктот?",
                "Избриши продукт?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbProdukti.Items.RemoveAt(lbProdukti.SelectedIndex);
                refreshDetaliZaProduktot();
            }
        }

        private void btnIsprazniKoshnicka_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?",
                "Испразни ја кошничката?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbKoshnicka.Items.Clear();
                refreshVkupno();
            }
        }

        private void nudKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (nudKolicina.Value <= 0)
            {
                errorProvider1.SetError(nudKolicina, "Количина треба да биде > 0");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudKolicina, null);
                e.Cancel = false;
            }
        }

        private void nudKolicina_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
