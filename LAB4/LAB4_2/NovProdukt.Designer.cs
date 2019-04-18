namespace LAB4
{
    partial class NovProdukt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категорија:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(16, 30);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(230, 20);
            this.tbIme.TabIndex = 0;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // tbKategorija
            // 
            this.tbKategorija.Location = new System.Drawing.Point(16, 79);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.Size = new System.Drawing.Size(230, 20);
            this.tbKategorija.TabIndex = 1;
            this.tbKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.tbKategorija_Validating);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(16, 124);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(100, 20);
            this.tbCena.TabIndex = 2;
            this.tbCena.Validating += new System.ComponentModel.CancelEventHandler(this.tbCena_Validating);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(177, 219);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 4;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.CausesValidation = false;
            this.btnOtkazhi.Location = new System.Drawing.Point(96, 219);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazhi.TabIndex = 5;
            this.btnOtkazhi.Text = "Откажи";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Достапност:";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(16, 177);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(100, 20);
            this.tbKolicina.TabIndex = 3;
            this.tbKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating_1);
            // 
            // NovProdukt
            // 
            this.AcceptButton = this.btnDodadi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 254);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbKategorija);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovProdukt";
            this.Text = "Нов продукт";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label4;
    }
}