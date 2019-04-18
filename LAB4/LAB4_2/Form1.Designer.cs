namespace LAB4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbProdukti = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKoshnicka = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodadiKoshnicka = new System.Windows.Forms.Button();
            this.btnIzbrishiKoshnicka = new System.Windows.Forms.Button();
            this.btnDodadiProdukt = new System.Windows.Forms.Button();
            this.btnIzbrishiProdukt = new System.Windows.Forms.Button();
            this.btnIsprazniProdukti = new System.Windows.Forms.Button();
            this.btnIsprazniKoshnicka = new System.Windows.Forms.Button();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти:";
            // 
            // lbProdukti
            // 
            this.lbProdukti.FormattingEnabled = true;
            this.lbProdukti.Location = new System.Drawing.Point(13, 30);
            this.lbProdukti.Name = "lbProdukti";
            this.lbProdukti.Size = new System.Drawing.Size(260, 368);
            this.lbProdukti.TabIndex = 1;
            this.lbProdukti.SelectedIndexChanged += new System.EventHandler(this.lbProdukti_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(34, 13);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кошничка:";
            // 
            // lbKoshnicka
            // 
            this.lbKoshnicka.FormattingEnabled = true;
            this.lbKoshnicka.Location = new System.Drawing.Point(517, 30);
            this.lbKoshnicka.Name = "lbKoshnicka";
            this.lbKoshnicka.Size = new System.Drawing.Size(249, 316);
            this.lbKoshnicka.TabIndex = 4;
            this.lbKoshnicka.SelectedIndexChanged += new System.EventHandler(this.lbKoshnicka_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.tbKategorija);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(291, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(10, 127);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(74, 20);
            this.tbCena.TabIndex = 5;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbKategorija
            // 
            this.tbKategorija.Location = new System.Drawing.Point(10, 82);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.ReadOnly = true;
            this.tbKategorija.Size = new System.Drawing.Size(184, 20);
            this.tbKategorija.TabIndex = 4;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(10, 37);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(184, 20);
            this.tbIme.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Категорија:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Име:";
            // 
            // btnDodadiKoshnicka
            // 
            this.btnDodadiKoshnicka.Enabled = false;
            this.btnDodadiKoshnicka.Location = new System.Drawing.Point(291, 219);
            this.btnDodadiKoshnicka.Name = "btnDodadiKoshnicka";
            this.btnDodadiKoshnicka.Size = new System.Drawing.Size(138, 23);
            this.btnDodadiKoshnicka.TabIndex = 6;
            this.btnDodadiKoshnicka.Text = "Додади во кошничка >>";
            this.btnDodadiKoshnicka.UseVisualStyleBackColor = true;
            this.btnDodadiKoshnicka.Click += new System.EventHandler(this.btnDodadiKoshnicka_Click);
            // 
            // btnIzbrishiKoshnicka
            // 
            this.btnIzbrishiKoshnicka.Enabled = false;
            this.btnIzbrishiKoshnicka.Location = new System.Drawing.Point(291, 263);
            this.btnIzbrishiKoshnicka.Name = "btnIzbrishiKoshnicka";
            this.btnIzbrishiKoshnicka.Size = new System.Drawing.Size(200, 23);
            this.btnIzbrishiKoshnicka.TabIndex = 7;
            this.btnIzbrishiKoshnicka.Text = "Избриши од кошничка";
            this.btnIzbrishiKoshnicka.UseVisualStyleBackColor = true;
            this.btnIzbrishiKoshnicka.Click += new System.EventHandler(this.btnIzbrishiKoshnicka_Click);
            // 
            // btnDodadiProdukt
            // 
            this.btnDodadiProdukt.Location = new System.Drawing.Point(291, 310);
            this.btnDodadiProdukt.Name = "btnDodadiProdukt";
            this.btnDodadiProdukt.Size = new System.Drawing.Size(200, 23);
            this.btnDodadiProdukt.TabIndex = 8;
            this.btnDodadiProdukt.Text = "Додади нов продукт";
            this.btnDodadiProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiProdukt.Click += new System.EventHandler(this.btnDodadiProdukt_Click);
            // 
            // btnIzbrishiProdukt
            // 
            this.btnIzbrishiProdukt.CausesValidation = false;
            this.btnIzbrishiProdukt.Enabled = false;
            this.btnIzbrishiProdukt.Location = new System.Drawing.Point(291, 358);
            this.btnIzbrishiProdukt.Name = "btnIzbrishiProdukt";
            this.btnIzbrishiProdukt.Size = new System.Drawing.Size(200, 23);
            this.btnIzbrishiProdukt.TabIndex = 9;
            this.btnIzbrishiProdukt.Text = "Избриши продукт";
            this.btnIzbrishiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrishiProdukt.Click += new System.EventHandler(this.btnIzbrishiProdukt_Click);
            // 
            // btnIsprazniProdukti
            // 
            this.btnIsprazniProdukti.Location = new System.Drawing.Point(12, 409);
            this.btnIsprazniProdukti.Name = "btnIsprazniProdukti";
            this.btnIsprazniProdukti.Size = new System.Drawing.Size(261, 23);
            this.btnIsprazniProdukti.TabIndex = 10;
            this.btnIsprazniProdukti.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniProdukti.UseVisualStyleBackColor = true;
            this.btnIsprazniProdukti.Click += new System.EventHandler(this.btnIsprazniProdukti_Click);
            // 
            // btnIsprazniKoshnicka
            // 
            this.btnIsprazniKoshnicka.Location = new System.Drawing.Point(506, 409);
            this.btnIsprazniKoshnicka.Name = "btnIsprazniKoshnicka";
            this.btnIsprazniKoshnicka.Size = new System.Drawing.Size(261, 23);
            this.btnIsprazniKoshnicka.TabIndex = 11;
            this.btnIsprazniKoshnicka.Text = "Испразни ја кошничката?";
            this.btnIsprazniKoshnicka.UseVisualStyleBackColor = true;
            this.btnIsprazniKoshnicka.Click += new System.EventHandler(this.btnIsprazniKoshnicka_Click);
            // 
            // tbVkupno
            // 
            this.tbVkupno.Location = new System.Drawing.Point(566, 358);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.ReadOnly = true;
            this.tbVkupno.Size = new System.Drawing.Size(201, 20);
            this.tbVkupno.TabIndex = 12;
            this.tbVkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вкупно:";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Enabled = false;
            this.nudKolicina.Location = new System.Drawing.Point(436, 221);
            this.nudKolicina.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(55, 20);
            this.nudKolicina.TabIndex = 14;
            this.nudKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKolicina.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Leave += new System.EventHandler(this.nudKolicina_Leave);
            this.nudKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.nudKolicina_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 443);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVkupno);
            this.Controls.Add(this.btnIsprazniKoshnicka);
            this.Controls.Add(this.btnIsprazniProdukti);
            this.Controls.Add(this.btnIzbrishiProdukt);
            this.Controls.Add(this.btnDodadiProdukt);
            this.Controls.Add(this.btnIzbrishiKoshnicka);
            this.Controls.Add(this.btnDodadiKoshnicka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKoshnicka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbProdukti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProdukti;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbKoshnicka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodadiKoshnicka;
        private System.Windows.Forms.Button btnIzbrishiKoshnicka;
        private System.Windows.Forms.Button btnDodadiProdukt;
        private System.Windows.Forms.Button btnIzbrishiProdukt;
        private System.Windows.Forms.Button btnIsprazniProdukti;
        private System.Windows.Forms.Button btnIsprazniKoshnicka;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

