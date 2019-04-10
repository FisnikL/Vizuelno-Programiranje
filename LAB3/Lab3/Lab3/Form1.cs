using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private string naracka;
        public Form1()
        {
            InitializeComponent();
            naracka = "";
            calculatePrice();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbMala.Checked)
            {
                float price = 0;
                bool parsed = float.TryParse(tbMalaCena.Text, out price);
                if (parsed)
                {
                    
                    calculatePrice();
                }
                else
                {
                    MessageBox.Show("Enter a valid price for Mala pizza");
                }
            }
            else if (rbSredna.Checked)
            {
                float price = 0;
                bool parsed = float.TryParse(tbSrednaCena.Text, out price);
                if (parsed)
                {
                    
                    calculatePrice();
                }
                else
                {
                    MessageBox.Show("Enter a valid price for Sredna pizza");
                }
            }
            else if (rbGolema.Checked)
            {
                float price = 0;
                bool parsed = float.TryParse(tbGolemaCena.Text, out price);
                if (parsed)
                {
                    
                    calculatePrice();
                }
                else
                {
                    MessageBox.Show("Enter a valid price for Golema pizza");
                }
            }
        }




        private void calculatePrice()
        {
            double total = 0;
            naracka = "";
            if (rbMala.Checked)
            {
                total += float.Parse(tbMalaCena.Text);
                naracka += "Мала пица\n";
            }
            else if (rbSredna.Checked)
            {
                total += float.Parse(tbSrednaCena.Text);
                naracka += "Средна пица\n";
            }
            else  if(rbGolema.Checked)
            {
                total += float.Parse(tbGolemaCena.Text);
                naracka += "Голема пица\n";
            }
            if(cbFeferonki.Checked || cbEkstraSirenje.Checked || cbKecap.Checked)
            {
                naracka += "Додатоци:\n";
            }

            if (cbFeferonki.Checked)
            {
                total += float.Parse(tbFeferonkiCena.Text);
                naracka += "Феферонки\n";
            }
            if (cbEkstraSirenje.Checked)
            {
                total += float.Parse(tbEkstraSirenjeCena.Text);
                naracka += "Екстра сирење\n";
            }
            if (cbKecap.Checked)
            {
                total += float.Parse(tbKecapCena.Text);
                naracka += "Кечап\n";
            }

            if(tbColaVkupno.Text!="" || tbSokVkupno.Text !="" || tbPivoVkupno.Text != "")
            {
                naracka += "Пијалок:\n";
            }

            if (tbColaVkupno.Text != "")
            {
                total += float.Parse(tbColaVkupno.Text);
                naracka += tbColaKolicina.Text + " " + label1.Text + "\n";
            }
            if (tbSokVkupno.Text != "")
            {
                total += float.Parse(tbSokVkupno.Text);
                naracka += tbSokKolicina.Text + " " + label2.Text + "\n";
            }
            if (tbPivoVkupno.Text != "")
            {
                total += float.Parse(tbPivoVkupno.Text);
                naracka += tbPivoKolicina.Text + " " + label3.Text + "\n";
            }
            if (tbImeDesert.Text != "")
            {
                total += float.Parse(tbCenaDesert.Text);
                naracka += "Десерт:\n";
                naracka += tbImeDesert.Text;
            }
            tbVkupnoPlakjanje.Text = Convert.ToString(total);
        }

        private void tbCola_TextChanged(object sender, EventArgs e)
        {
            float kolicina = 0, price = 0;
            bool parsedKolicina = float.TryParse(tbColaKolicina.Text, out kolicina);
            bool parsedPrice = float.TryParse(tbColaCena.Text, out price);
            if (!parsedKolicina)
            {
                MessageBox.Show("Enter a valid Kolicina for Cola/Fanta/Sprajt");
            }else if (!parsedPrice)
            {
                MessageBox.Show("Enter a valid Cena for Cola/Fanta/Sprajt");
            }
            {
                tbColaVkupno.Text = Convert.ToString(kolicina * price);
                calculatePrice();
            }
        }

        private void tbSok_TextChanged(object sender, EventArgs e)
        {
            float kolicina = 0, price = 0;
            bool parsedKolicina = float.TryParse(tbSokKolicina.Text, out kolicina);
            bool parsedPrice = float.TryParse(tbSokCena.Text, out price);
            if (!parsedKolicina)
            {
                MessageBox.Show("Enter a valid Kolicina for Sok od jabolko/Portokal");
            }
            else if (!parsedPrice)
            {
                MessageBox.Show("Enter a valid Cena for Sok od jabolko/Portokal");
            }
            {
                tbSokVkupno.Text = Convert.ToString(kolicina * price);
                calculatePrice();
            }
        }

        private void tbPivo_TextChanged(object sender, EventArgs e)
        {
            float kolicina = 0, price = 0;
            bool parsedKolicina = float.TryParse(tbPivoKolicina.Text, out kolicina);
            bool parsedPrice = float.TryParse(tbPivoCena.Text, out price);
            if (!parsedKolicina)
            {
                MessageBox.Show("Enter a valid Kolicina for Pivo");
            }
            else if (!parsedPrice)
            {
                MessageBox.Show("Enter a valid Cena for Pivo");
            }
            {
                tbPivoVkupno.Text = Convert.ToString(kolicina * price);
                calculatePrice();
            }
        }

        private void tbDesert_TextChanged(object sender, EventArgs e)
        {
            if(tbImeDesert.Text != "")
            {
                float price = 0;
                bool parsedPrice = float.TryParse(tbCenaDesert.Text, out price);
                if (!parsedPrice)
                {
                    MessageBox.Show("Enter a valid Cena for Desert");
                }
                else{
                    calculatePrice();
                }
            }
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(naracka, "Вашата нарачка");
            
        }

        private void cbDodatoci_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void tbNaplateno_TextChanged(object sender, EventArgs e)
        {
            float naplateno = 0;
            bool parsedPrice = float.TryParse(tbNaplateno.Text, out naplateno);
            if (!parsedPrice)
            {
                MessageBox.Show("Enter a valid value for Naplateno ");
            }
            else
            {
                float vkupno = float.Parse(tbVkupnoPlakjanje.Text);
                if (naplateno > vkupno)
                    tbZaVrakjanje.Text = Convert.ToString(naplateno - vkupno);
            }
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи нарачка?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
