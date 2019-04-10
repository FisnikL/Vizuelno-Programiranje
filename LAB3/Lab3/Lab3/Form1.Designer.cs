namespace Lab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGolemaCena = new System.Windows.Forms.TextBox();
            this.tbSrednaCena = new System.Windows.Forms.TextBox();
            this.tbMalaCena = new System.Windows.Forms.TextBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbKecapCena = new System.Windows.Forms.TextBox();
            this.tbEkstraSirenjeCena = new System.Windows.Forms.TextBox();
            this.tbFeferonkiCena = new System.Windows.Forms.TextBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.cbEkstraSirenje = new System.Windows.Forms.CheckBox();
            this.cbFeferonki = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPivoVkupno = new System.Windows.Forms.TextBox();
            this.tbPivoCena = new System.Windows.Forms.TextBox();
            this.tbPivoKolicina = new System.Windows.Forms.TextBox();
            this.tbSokVkupno = new System.Windows.Forms.TextBox();
            this.tbSokCena = new System.Windows.Forms.TextBox();
            this.tbSokKolicina = new System.Windows.Forms.TextBox();
            this.tbColaVkupno = new System.Windows.Forms.TextBox();
            this.tbColaCena = new System.Windows.Forms.TextBox();
            this.tbColaKolicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.tbCenaDesert = new System.Windows.Forms.TextBox();
            this.tbImeDesert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbZaVrakjanje = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.tbVkupnoPlakjanje = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGolemaCena);
            this.groupBox1.Controls.Add(this.tbSrednaCena);
            this.groupBox1.Controls.Add(this.tbMalaCena);
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // tbGolemaCena
            // 
            this.tbGolemaCena.Location = new System.Drawing.Point(94, 66);
            this.tbGolemaCena.Name = "tbGolemaCena";
            this.tbGolemaCena.Size = new System.Drawing.Size(100, 20);
            this.tbGolemaCena.TabIndex = 5;
            this.tbGolemaCena.Text = "500";
            this.tbGolemaCena.TextChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbSrednaCena
            // 
            this.tbSrednaCena.Location = new System.Drawing.Point(94, 42);
            this.tbSrednaCena.Name = "tbSrednaCena";
            this.tbSrednaCena.Size = new System.Drawing.Size(100, 20);
            this.tbSrednaCena.TabIndex = 4;
            this.tbSrednaCena.Text = "300";
            this.tbSrednaCena.TextChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbMalaCena
            // 
            this.tbMalaCena.Location = new System.Drawing.Point(94, 19);
            this.tbMalaCena.Name = "tbMalaCena";
            this.tbMalaCena.Size = new System.Drawing.Size(100, 20);
            this.tbMalaCena.TabIndex = 3;
            this.tbMalaCena.Text = "200";
            this.tbMalaCena.TextChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(7, 66);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(63, 17);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.TabStop = true;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(7, 43);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(62, 17);
            this.rbSredna.TabIndex = 1;
            this.rbSredna.TabStop = true;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Checked = true;
            this.rbMala.Location = new System.Drawing.Point(7, 20);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(52, 17);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbKecapCena);
            this.groupBox2.Controls.Add(this.tbEkstraSirenjeCena);
            this.groupBox2.Controls.Add(this.tbFeferonkiCena);
            this.groupBox2.Controls.Add(this.cbKecap);
            this.groupBox2.Controls.Add(this.cbEkstraSirenje);
            this.groupBox2.Controls.Add(this.cbFeferonki);
            this.groupBox2.Location = new System.Drawing.Point(234, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // tbKecapCena
            // 
            this.tbKecapCena.Location = new System.Drawing.Point(134, 66);
            this.tbKecapCena.Name = "tbKecapCena";
            this.tbKecapCena.Size = new System.Drawing.Size(100, 20);
            this.tbKecapCena.TabIndex = 8;
            this.tbKecapCena.Text = "20";
            this.tbKecapCena.TextChanged += new System.EventHandler(this.cbDodatoci_CheckedChanged);
            // 
            // tbEkstraSirenjeCena
            // 
            this.tbEkstraSirenjeCena.Location = new System.Drawing.Point(134, 42);
            this.tbEkstraSirenjeCena.Name = "tbEkstraSirenjeCena";
            this.tbEkstraSirenjeCena.Size = new System.Drawing.Size(100, 20);
            this.tbEkstraSirenjeCena.TabIndex = 7;
            this.tbEkstraSirenjeCena.Text = "30";
            this.tbEkstraSirenjeCena.TextChanged += new System.EventHandler(this.cbDodatoci_CheckedChanged);
            // 
            // tbFeferonkiCena
            // 
            this.tbFeferonkiCena.Location = new System.Drawing.Point(135, 18);
            this.tbFeferonkiCena.Name = "tbFeferonkiCena";
            this.tbFeferonkiCena.Size = new System.Drawing.Size(100, 20);
            this.tbFeferonkiCena.TabIndex = 6;
            this.tbFeferonkiCena.Text = "40";
            this.tbFeferonkiCena.TextChanged += new System.EventHandler(this.cbDodatoci_CheckedChanged);
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(6, 67);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(56, 17);
            this.cbKecap.TabIndex = 2;
            this.cbKecap.Text = "Кечап";
            this.cbKecap.UseVisualStyleBackColor = true;
            this.cbKecap.CheckedChanged += new System.EventHandler(this.cbDodatoci_CheckedChanged);
            // 
            // cbEkstraSirenje
            // 
            this.cbEkstraSirenje.AutoSize = true;
            this.cbEkstraSirenje.Location = new System.Drawing.Point(6, 44);
            this.cbEkstraSirenje.Name = "cbEkstraSirenje";
            this.cbEkstraSirenje.Size = new System.Drawing.Size(106, 17);
            this.cbEkstraSirenje.TabIndex = 1;
            this.cbEkstraSirenje.Text = "Екстра Сирење";
            this.cbEkstraSirenje.UseVisualStyleBackColor = true;
            this.cbEkstraSirenje.CheckedChanged += new System.EventHandler(this.cbDodatoci_CheckedChanged);
            // 
            // cbFeferonki
            // 
            this.cbFeferonki.AutoSize = true;
            this.cbFeferonki.Location = new System.Drawing.Point(7, 20);
            this.cbFeferonki.Name = "cbFeferonki";
            this.cbFeferonki.Size = new System.Drawing.Size(87, 17);
            this.cbFeferonki.TabIndex = 0;
            this.cbFeferonki.Text = "Феферонки";
            this.cbFeferonki.UseVisualStyleBackColor = true;
            this.cbFeferonki.CheckedChanged += new System.EventHandler(this.cbDodatoci_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPivoVkupno);
            this.groupBox3.Controls.Add(this.tbPivoCena);
            this.groupBox3.Controls.Add(this.tbPivoKolicina);
            this.groupBox3.Controls.Add(this.tbSokVkupno);
            this.groupBox3.Controls.Add(this.tbSokCena);
            this.groupBox3.Controls.Add(this.tbSokKolicina);
            this.groupBox3.Controls.Add(this.tbColaVkupno);
            this.groupBox3.Controls.Add(this.tbColaCena);
            this.groupBox3.Controls.Add(this.tbColaKolicina);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // tbPivoVkupno
            // 
            this.tbPivoVkupno.Location = new System.Drawing.Point(377, 83);
            this.tbPivoVkupno.Name = "tbPivoVkupno";
            this.tbPivoVkupno.ReadOnly = true;
            this.tbPivoVkupno.Size = new System.Drawing.Size(69, 20);
            this.tbPivoVkupno.TabIndex = 14;
            // 
            // tbPivoCena
            // 
            this.tbPivoCena.Location = new System.Drawing.Point(285, 83);
            this.tbPivoCena.Name = "tbPivoCena";
            this.tbPivoCena.Size = new System.Drawing.Size(69, 20);
            this.tbPivoCena.TabIndex = 13;
            this.tbPivoCena.Text = "80";
            this.tbPivoCena.TextChanged += new System.EventHandler(this.tbPivo_TextChanged);
            // 
            // tbPivoKolicina
            // 
            this.tbPivoKolicina.Location = new System.Drawing.Point(189, 83);
            this.tbPivoKolicina.Name = "tbPivoKolicina";
            this.tbPivoKolicina.Size = new System.Drawing.Size(69, 20);
            this.tbPivoKolicina.TabIndex = 12;
            this.tbPivoKolicina.Text = "0";
            this.tbPivoKolicina.TextChanged += new System.EventHandler(this.tbPivo_TextChanged);
            // 
            // tbSokVkupno
            // 
            this.tbSokVkupno.Location = new System.Drawing.Point(377, 60);
            this.tbSokVkupno.Name = "tbSokVkupno";
            this.tbSokVkupno.ReadOnly = true;
            this.tbSokVkupno.Size = new System.Drawing.Size(69, 20);
            this.tbSokVkupno.TabIndex = 11;
            // 
            // tbSokCena
            // 
            this.tbSokCena.Location = new System.Drawing.Point(285, 60);
            this.tbSokCena.Name = "tbSokCena";
            this.tbSokCena.Size = new System.Drawing.Size(69, 20);
            this.tbSokCena.TabIndex = 10;
            this.tbSokCena.Text = "70";
            this.tbSokCena.TextChanged += new System.EventHandler(this.tbSok_TextChanged);
            // 
            // tbSokKolicina
            // 
            this.tbSokKolicina.Location = new System.Drawing.Point(189, 60);
            this.tbSokKolicina.Name = "tbSokKolicina";
            this.tbSokKolicina.Size = new System.Drawing.Size(69, 20);
            this.tbSokKolicina.TabIndex = 9;
            this.tbSokKolicina.Text = "0";
            this.tbSokKolicina.TextChanged += new System.EventHandler(this.tbSok_TextChanged);
            // 
            // tbColaVkupno
            // 
            this.tbColaVkupno.Location = new System.Drawing.Point(377, 34);
            this.tbColaVkupno.Name = "tbColaVkupno";
            this.tbColaVkupno.ReadOnly = true;
            this.tbColaVkupno.Size = new System.Drawing.Size(69, 20);
            this.tbColaVkupno.TabIndex = 8;
            // 
            // tbColaCena
            // 
            this.tbColaCena.Location = new System.Drawing.Point(285, 34);
            this.tbColaCena.Name = "tbColaCena";
            this.tbColaCena.Size = new System.Drawing.Size(69, 20);
            this.tbColaCena.TabIndex = 7;
            this.tbColaCena.Text = "60";
            this.tbColaCena.TextChanged += new System.EventHandler(this.tbCola_TextChanged);
            // 
            // tbColaKolicina
            // 
            this.tbColaKolicina.Location = new System.Drawing.Point(189, 34);
            this.tbColaKolicina.Name = "tbColaKolicina";
            this.tbColaKolicina.Size = new System.Drawing.Size(69, 20);
            this.tbColaKolicina.TabIndex = 6;
            this.tbColaKolicina.Text = "0";
            this.tbColaKolicina.TextChanged += new System.EventHandler(this.tbCola_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOtkazhi);
            this.groupBox4.Controls.Add(this.btnNaracaj);
            this.groupBox4.Controls.Add(this.tbCenaDesert);
            this.groupBox4.Controls.Add(this.tbImeDesert);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 123);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.Location = new System.Drawing.Point(109, 90);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazhi.TabIndex = 10;
            this.btnOtkazhi.Text = "Откажи";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(9, 90);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(75, 23);
            this.btnNaracaj.TabIndex = 9;
            this.btnNaracaj.Text = "Нарачај";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            this.btnNaracaj.Click += new System.EventHandler(this.btnNaracaj_Click);
            // 
            // tbCenaDesert
            // 
            this.tbCenaDesert.Location = new System.Drawing.Point(74, 48);
            this.tbCenaDesert.Name = "tbCenaDesert";
            this.tbCenaDesert.Size = new System.Drawing.Size(100, 20);
            this.tbCenaDesert.TabIndex = 8;
            this.tbCenaDesert.TextChanged += new System.EventHandler(this.tbDesert_TextChanged);
            // 
            // tbImeDesert
            // 
            this.tbImeDesert.Location = new System.Drawing.Point(74, 22);
            this.tbImeDesert.Name = "tbImeDesert";
            this.tbImeDesert.Size = new System.Drawing.Size(100, 20);
            this.tbImeDesert.TabIndex = 7;
            this.tbImeDesert.TextChanged += new System.EventHandler(this.tbDesert_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Име";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbZaVrakjanje);
            this.groupBox5.Controls.Add(this.tbNaplateno);
            this.groupBox5.Controls.Add(this.tbVkupnoPlakjanje);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(234, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 123);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // tbZaVrakjanje
            // 
            this.tbZaVrakjanje.Location = new System.Drawing.Point(124, 72);
            this.tbZaVrakjanje.Name = "tbZaVrakjanje";
            this.tbZaVrakjanje.Size = new System.Drawing.Size(100, 20);
            this.tbZaVrakjanje.TabIndex = 13;
            this.tbZaVrakjanje.Text = "0";
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Location = new System.Drawing.Point(124, 48);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(100, 20);
            this.tbNaplateno.TabIndex = 12;
            this.tbNaplateno.Text = "0";
            this.tbNaplateno.TextChanged += new System.EventHandler(this.tbNaplateno_TextChanged);
            // 
            // tbVkupnoPlakjanje
            // 
            this.tbVkupnoPlakjanje.Location = new System.Drawing.Point(124, 26);
            this.tbVkupnoPlakjanje.Name = "tbVkupnoPlakjanje";
            this.tbVkupnoPlakjanje.ReadOnly = true;
            this.tbVkupnoPlakjanje.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoPlakjanje.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "За враќање:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Наплатено:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Вкупно за плаќање:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNaracaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 399);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGolemaCena;
        private System.Windows.Forms.TextBox tbSrednaCena;
        private System.Windows.Forms.TextBox tbMalaCena;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbKecapCena;
        private System.Windows.Forms.TextBox tbEkstraSirenjeCena;
        private System.Windows.Forms.TextBox tbFeferonkiCena;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.CheckBox cbEkstraSirenje;
        private System.Windows.Forms.CheckBox cbFeferonki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPivoVkupno;
        private System.Windows.Forms.TextBox tbPivoCena;
        private System.Windows.Forms.TextBox tbPivoKolicina;
        private System.Windows.Forms.TextBox tbSokVkupno;
        private System.Windows.Forms.TextBox tbSokCena;
        private System.Windows.Forms.TextBox tbSokKolicina;
        private System.Windows.Forms.TextBox tbColaVkupno;
        private System.Windows.Forms.TextBox tbColaCena;
        private System.Windows.Forms.TextBox tbColaKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.TextBox tbCenaDesert;
        private System.Windows.Forms.TextBox tbImeDesert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbZaVrakjanje;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.TextBox tbVkupnoPlakjanje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

