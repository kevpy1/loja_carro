﻿using System.Windows.Forms;

namespace loja_carro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbcatec = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxmodelo = new System.Windows.Forms.Label();
            this.txbpreço = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbprec3 = new System.Windows.Forms.CheckBox();
            this.txbprec2 = new System.Windows.Forms.CheckBox();
            this.txbprec1 = new System.Windows.Forms.CheckBox();
            this.txbPicape = new System.Windows.Forms.CheckBox();
            this.txbSUV = new System.Windows.Forms.CheckBox();
            this.txbSedã = new System.Windows.Forms.CheckBox();
            this.txbcat1 = new System.Windows.Forms.CheckBox();
            this.txbToyotaCross = new System.Windows.Forms.CheckBox();
            this.txbSubarufor = new System.Windows.Forms.CheckBox();
            this.txbFordMaverick = new System.Windows.Forms.CheckBox();
            this.txbNissanleaf = new System.Windows.Forms.CheckBox();
            this.txbtoyot = new System.Windows.Forms.CheckBox();
            this.btnlimpsrfil = new System.Windows.Forms.Button();
            this.txbkm1 = new System.Windows.Forms.TextBox();
            this.txbprec4 = new System.Windows.Forms.CheckBox();
            this.txbprec5 = new System.Windows.Forms.CheckBox();
            this.txbprec6 = new System.Windows.Forms.CheckBox();
            this.txbkm2 = new System.Windows.Forms.TextBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.cmbmarcaescolha = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.Label();
            this.txbObjetivo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txbcar4 = new System.Windows.Forms.PictureBox();
            this.txbar1 = new System.Windows.Forms.PictureBox();
            this.txbcar3 = new System.Windows.Forms.PictureBox();
            this.txbcar2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txbcar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbcar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbcar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbcatec
            // 
            this.txbcatec.AutoSize = true;
            this.txbcatec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcatec.Location = new System.Drawing.Point(1, 210);
            this.txbcatec.Name = "txbcatec";
            this.txbcatec.Size = new System.Drawing.Size(96, 24);
            this.txbcatec.TabIndex = 1;
            this.txbcatec.Text = "categoria";
            this.txbcatec.Click += new System.EventHandler(this.objetivo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 13;
            // 
            // cbxmodelo
            // 
            this.cbxmodelo.AutoSize = true;
            this.cbxmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmodelo.Location = new System.Drawing.Point(12, 375);
            this.cbxmodelo.Name = "cbxmodelo";
            this.cbxmodelo.Size = new System.Drawing.Size(67, 20);
            this.cbxmodelo.TabIndex = 17;
            this.cbxmodelo.Text = "modelo";
            this.cbxmodelo.Click += new System.EventHandler(this.cbxmodelo_Click);
            // 
            // txbpreço
            // 
            this.txbpreço.AutoSize = true;
            this.txbpreço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpreço.Location = new System.Drawing.Point(12, 532);
            this.txbpreço.Name = "txbpreço";
            this.txbpreço.Size = new System.Drawing.Size(54, 20);
            this.txbpreço.TabIndex = 19;
            this.txbpreço.Text = "preço";
            this.txbpreço.Click += new System.EventHandler(this.txbpreço_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "km";
            // 
            // txbprec3
            // 
            this.txbprec3.AutoSize = true;
            this.txbprec3.Location = new System.Drawing.Point(17, 618);
            this.txbprec3.Name = "txbprec3";
            this.txbprec3.Size = new System.Drawing.Size(150, 17);
            this.txbprec3.TabIndex = 32;
            this.txbprec3.Text = "R$ 180.000 a R$ 220.000";
            this.txbprec3.UseVisualStyleBackColor = true;
            // 
            // txbprec2
            // 
            this.txbprec2.AutoSize = true;
            this.txbprec2.Location = new System.Drawing.Point(17, 595);
            this.txbprec2.Name = "txbprec2";
            this.txbprec2.Size = new System.Drawing.Size(153, 17);
            this.txbprec2.TabIndex = 33;
            this.txbprec2.Text = " R$ 130.000 a R$ 170.000";
            this.txbprec2.UseVisualStyleBackColor = true;
            // 
            // txbprec1
            // 
            this.txbprec1.AutoSize = true;
            this.txbprec1.Location = new System.Drawing.Point(17, 571);
            this.txbprec1.Name = "txbprec1";
            this.txbprec1.Size = new System.Drawing.Size(153, 17);
            this.txbprec1.TabIndex = 34;
            this.txbprec1.Text = "R$ 120.000 a R$ 150.000,";
            this.txbprec1.UseVisualStyleBackColor = true;
            // 
            // txbPicape
            // 
            this.txbPicape.AutoSize = true;
            this.txbPicape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPicape.Location = new System.Drawing.Point(12, 340);
            this.txbPicape.Name = "txbPicape";
            this.txbPicape.Size = new System.Drawing.Size(59, 17);
            this.txbPicape.TabIndex = 35;
            this.txbPicape.Text = "Picape";
            this.txbPicape.UseVisualStyleBackColor = true;
            // 
            // txbSUV
            // 
            this.txbSUV.AutoSize = true;
            this.txbSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSUV.Location = new System.Drawing.Point(12, 317);
            this.txbSUV.Name = "txbSUV";
            this.txbSUV.Size = new System.Drawing.Size(48, 17);
            this.txbSUV.TabIndex = 36;
            this.txbSUV.Text = "SUV";
            this.txbSUV.UseVisualStyleBackColor = true;
            // 
            // txbSedã
            // 
            this.txbSedã.AutoSize = true;
            this.txbSedã.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSedã.Location = new System.Drawing.Point(12, 294);
            this.txbSedã.Name = "txbSedã";
            this.txbSedã.Size = new System.Drawing.Size(51, 17);
            this.txbSedã.TabIndex = 37;
            this.txbSedã.Text = "Sedã";
            this.txbSedã.UseVisualStyleBackColor = true;
            // 
            // txbcat1
            // 
            this.txbcat1.AutoSize = true;
            this.txbcat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcat1.Location = new System.Drawing.Point(12, 271);
            this.txbcat1.Name = "txbcat1";
            this.txbcat1.Size = new System.Drawing.Size(58, 17);
            this.txbcat1.TabIndex = 38;
            this.txbcat1.Text = "Hatch:";
            this.txbcat1.UseVisualStyleBackColor = true;
            // 
            // txbToyotaCross
            // 
            this.txbToyotaCross.AutoSize = true;
            this.txbToyotaCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbToyotaCross.Location = new System.Drawing.Point(15, 429);
            this.txbToyotaCross.Name = "txbToyotaCross";
            this.txbToyotaCross.Size = new System.Drawing.Size(123, 17);
            this.txbToyotaCross.TabIndex = 44;
            this.txbToyotaCross.Text = "Toyota Corolla Cross";
            this.txbToyotaCross.UseVisualStyleBackColor = true;
            // 
            // txbSubarufor
            // 
            this.txbSubarufor.AutoSize = true;
            this.txbSubarufor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubarufor.Location = new System.Drawing.Point(15, 452);
            this.txbSubarufor.Name = "txbSubarufor";
            this.txbSubarufor.Size = new System.Drawing.Size(101, 17);
            this.txbSubarufor.TabIndex = 43;
            this.txbSubarufor.Text = "Subaru Forester";
            this.txbSubarufor.UseVisualStyleBackColor = true;
            // 
            // txbFordMaverick
            // 
            this.txbFordMaverick.AutoSize = true;
            this.txbFordMaverick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFordMaverick.Location = new System.Drawing.Point(15, 475);
            this.txbFordMaverick.Name = "txbFordMaverick";
            this.txbFordMaverick.Size = new System.Drawing.Size(127, 17);
            this.txbFordMaverick.TabIndex = 42;
            this.txbFordMaverick.Text = "Ford Maverick Hybrid";
            this.txbFordMaverick.UseVisualStyleBackColor = true;
            // 
            // txbNissanleaf
            // 
            this.txbNissanleaf.AutoSize = true;
            this.txbNissanleaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNissanleaf.Location = new System.Drawing.Point(15, 498);
            this.txbNissanleaf.Name = "txbNissanleaf";
            this.txbNissanleaf.Size = new System.Drawing.Size(82, 17);
            this.txbNissanleaf.TabIndex = 41;
            this.txbNissanleaf.Text = "Nissan Leaf";
            this.txbNissanleaf.UseVisualStyleBackColor = true;
            // 
            // txbtoyot
            // 
            this.txbtoyot.AutoSize = true;
            this.txbtoyot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtoyot.Location = new System.Drawing.Point(15, 406);
            this.txbtoyot.Name = "txbtoyot";
            this.txbtoyot.Size = new System.Drawing.Size(127, 17);
            this.txbtoyot.TabIndex = 40;
            this.txbtoyot.Text = "Toyota Corolla Hybrid";
            this.txbtoyot.UseVisualStyleBackColor = true;
            // 
            // btnlimpsrfil
            // 
            this.btnlimpsrfil.Location = new System.Drawing.Point(547, 681);
            this.btnlimpsrfil.Name = "btnlimpsrfil";
            this.btnlimpsrfil.Size = new System.Drawing.Size(75, 23);
            this.btnlimpsrfil.TabIndex = 45;
            this.btnlimpsrfil.Text = "limpar filtro";
            this.btnlimpsrfil.UseVisualStyleBackColor = true;
            this.btnlimpsrfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbkm1
            // 
            this.txbkm1.Location = new System.Drawing.Point(190, 337);
            this.txbkm1.Name = "txbkm1";
            this.txbkm1.Size = new System.Drawing.Size(55, 20);
            this.txbkm1.TabIndex = 46;
            this.txbkm1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbprec4
            // 
            this.txbprec4.AutoSize = true;
            this.txbprec4.Location = new System.Drawing.Point(18, 641);
            this.txbprec4.Name = "txbprec4";
            this.txbprec4.Size = new System.Drawing.Size(150, 17);
            this.txbprec4.TabIndex = 49;
            this.txbprec4.Text = "R$ 200.000 a R$ 250.000";
            this.txbprec4.UseVisualStyleBackColor = true;
            // 
            // txbprec5
            // 
            this.txbprec5.AutoSize = true;
            this.txbprec5.Location = new System.Drawing.Point(18, 664);
            this.txbprec5.Name = "txbprec5";
            this.txbprec5.Size = new System.Drawing.Size(150, 17);
            this.txbprec5.TabIndex = 48;
            this.txbprec5.Text = "R$ 300.000 a R$ 350.000";
            this.txbprec5.UseVisualStyleBackColor = true;
            this.txbprec5.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // txbprec6
            // 
            this.txbprec6.AutoSize = true;
            this.txbprec6.Location = new System.Drawing.Point(18, 687);
            this.txbprec6.Name = "txbprec6";
            this.txbprec6.Size = new System.Drawing.Size(150, 17);
            this.txbprec6.TabIndex = 47;
            this.txbprec6.Text = "R$ 400.000 a R$ 450.000";
            this.txbprec6.UseVisualStyleBackColor = true;
            // 
            // txbkm2
            // 
            this.txbkm2.Location = new System.Drawing.Point(269, 337);
            this.txbkm2.Name = "txbkm2";
            this.txbkm2.Size = new System.Drawing.Size(55, 20);
            this.txbkm2.TabIndex = 50;
            this.txbkm2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(688, 681);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnfiltrar.TabIndex = 51;
            this.btnfiltrar.Text = "filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbmarcaescolha
            // 
            this.cmbmarcaescolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmarcaescolha.FormattingEnabled = true;
            this.cmbmarcaescolha.Items.AddRange(new object[] {
            "Toyota",
            "Ford",
            "Chevrolet",
            "Honda",
            "Volkswagen",
            "BMW",
            "Mercedes-Benz",
            "Audi",
            "Nissan",
            "Hyundai",
            "Kia",
            "Tesla",
            "Subaru",
            "Porsche",
            "Fiat",
            "Jaguar",
            "Land Rover",
            "Volvo",
            "Mazda",
            "Renault"});
            this.cmbmarcaescolha.Location = new System.Drawing.Point(395, 56);
            this.cmbmarcaescolha.Name = "cmbmarcaescolha";
            this.cmbmarcaescolha.Size = new System.Drawing.Size(102, 24);
            this.cmbmarcaescolha.TabIndex = 60;
            this.cmbmarcaescolha.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxMarca
            // 
            this.cbxMarca.AutoSize = true;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.Location = new System.Drawing.Point(407, 20);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(58, 20);
            this.cbxMarca.TabIndex = 59;
            this.cbxMarca.Text = "marca";
            this.cbxMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbObjetivo
            // 
            this.txbObjetivo.AutoSize = true;
            this.txbObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObjetivo.Location = new System.Drawing.Point(551, 20);
            this.txbObjetivo.Name = "txbObjetivo";
            this.txbObjetivo.Size = new System.Drawing.Size(71, 20);
            this.txbObjetivo.TabIndex = 62;
            this.txbObjetivo.Text = "objetivo";
            this.txbObjetivo.Click += new System.EventHandler(this.txbObjetivo_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.comboBox2.Location = new System.Drawing.Point(535, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 24);
            this.comboBox2.TabIndex = 63;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txbcar4
            // 
            this.txbcar4.Image = global::loja_carro.Properties.Resources.carro_4;
            this.txbcar4.Location = new System.Drawing.Point(688, 417);
            this.txbcar4.Name = "txbcar4";
            this.txbcar4.Size = new System.Drawing.Size(223, 185);
            this.txbcar4.TabIndex = 58;
            this.txbcar4.TabStop = false;
            // 
            // txbar1
            // 
            this.txbar1.Image = global::loja_carro.Properties.Resources.carro_2;
            this.txbar1.Location = new System.Drawing.Point(359, 417);
            this.txbar1.Name = "txbar1";
            this.txbar1.Size = new System.Drawing.Size(223, 185);
            this.txbar1.TabIndex = 57;
            this.txbar1.TabStop = false;
            // 
            // txbcar3
            // 
            this.txbcar3.Image = global::loja_carro.Properties.Resources.carro_3;
            this.txbcar3.Location = new System.Drawing.Point(688, 210);
            this.txbcar3.Name = "txbcar3";
            this.txbcar3.Size = new System.Drawing.Size(223, 185);
            this.txbcar3.TabIndex = 56;
            this.txbcar3.TabStop = false;
            // 
            // txbcar2
            // 
            this.txbcar2.Image = global::loja_carro.Properties.Resources.carro_1__2_;
            this.txbcar2.Location = new System.Drawing.Point(359, 210);
            this.txbcar2.Name = "txbcar2";
            this.txbcar2.Size = new System.Drawing.Size(223, 185);
            this.txbcar2.TabIndex = 55;
            this.txbcar2.TabStop = false;
            this.txbcar2.Click += new System.EventHandler(this.txbcar2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loja_carro.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(-19, -88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 298);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-19, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1363, 218);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 735);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txbObjetivo);
            this.Controls.Add(this.cmbmarcaescolha);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txbcar4);
            this.Controls.Add(this.txbar1);
            this.Controls.Add(this.txbcar3);
            this.Controls.Add(this.txbcar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.txbkm2);
            this.Controls.Add(this.txbprec4);
            this.Controls.Add(this.txbprec5);
            this.Controls.Add(this.txbprec6);
            this.Controls.Add(this.txbkm1);
            this.Controls.Add(this.btnlimpsrfil);
            this.Controls.Add(this.txbToyotaCross);
            this.Controls.Add(this.txbSubarufor);
            this.Controls.Add(this.txbFordMaverick);
            this.Controls.Add(this.txbNissanleaf);
            this.Controls.Add(this.txbtoyot);
            this.Controls.Add(this.txbcat1);
            this.Controls.Add(this.txbSedã);
            this.Controls.Add(this.txbSUV);
            this.Controls.Add(this.txbPicape);
            this.Controls.Add(this.txbprec1);
            this.Controls.Add(this.txbprec2);
            this.Controls.Add(this.txbprec3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbpreço);
            this.Controls.Add(this.cbxmodelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbcatec);
            this.Name = "Form1";
            this.Text = "loja ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbcar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbcar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbcar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Label txbcatec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cbxmodelo;
        private System.Windows.Forms.Label txbpreço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox txbprec3;
        private System.Windows.Forms.CheckBox txbprec2;
        private System.Windows.Forms.CheckBox txbprec1;
        private System.Windows.Forms.CheckBox txbPicape;
        private System.Windows.Forms.CheckBox txbSUV;
        private System.Windows.Forms.CheckBox txbSedã;
        private System.Windows.Forms.CheckBox txbcat1;
        private System.Windows.Forms.CheckBox txbToyotaCross;
        private System.Windows.Forms.CheckBox txbSubarufor;
        private System.Windows.Forms.CheckBox txbFordMaverick;
        private System.Windows.Forms.CheckBox txbNissanleaf;
        private System.Windows.Forms.CheckBox txbtoyot;
        private System.Windows.Forms.Button btnlimpsrfil;
        private System.Windows.Forms.TextBox txbkm1;
        private System.Windows.Forms.CheckBox txbprec4;
        private System.Windows.Forms.CheckBox txbprec5;
        private System.Windows.Forms.CheckBox txbprec6;
        private System.Windows.Forms.TextBox txbkm2;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox txbcar2;
        private System.Windows.Forms.PictureBox txbcar3;
        private System.Windows.Forms.PictureBox txbar1;
        private System.Windows.Forms.PictureBox txbcar4;
        private System.Windows.Forms.ComboBox cmbmarcaescolha;
        private System.Windows.Forms.Label cbxMarca;
        private System.Windows.Forms.Label txbObjetivo;
        private System.Windows.Forms.ComboBox comboBox2;

        public Form1(ComboBox comboBox2)
        {
            this.comboBox2 = comboBox2;
        }
    }
}

