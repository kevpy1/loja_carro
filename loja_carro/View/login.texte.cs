using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_carro.View
{
    public partial class Brokan : Form
    {
        public Brokan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbNumer = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbBrokerCode = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCodeArea = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(687, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txbNumer
            // 
            this.txbNumer.Location = new System.Drawing.Point(108, 89);
            this.txbNumer.Name = "txbNumer";
            this.txbNumer.Size = new System.Drawing.Size(100, 20);
            this.txbNumer.TabIndex = 1;
            this.txbNumer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(108, 376);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 2;
            // 
            // txbTelephone
            // 
            this.txbTelephone.Location = new System.Drawing.Point(108, 273);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(100, 20);
            this.txbTelephone.TabIndex = 3;
            // 
            // txbBrokerCode
            // 
            this.txbBrokerCode.Location = new System.Drawing.Point(108, 141);
            this.txbBrokerCode.Name = "txbBrokerCode";
            this.txbBrokerCode.Size = new System.Drawing.Size(100, 20);
            this.txbBrokerCode.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Senha,
            this.Usuario,
            this.codigo,
            this.p});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 344);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(911, 224);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.DisplayIndex = 0;
            this.codigo.Text = "Codigo";
            // 
            // Senha
            // 
            this.Senha.DisplayIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.DisplayIndex = 2;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(108, 236);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(100, 21);
            this.cmbState.TabIndex = 7;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(108, 315);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 9;
            // 
            // txbCodeArea
            // 
            this.txbCodeArea.Location = new System.Drawing.Point(108, 189);
            this.txbCodeArea.Name = "txbCodeArea";
            this.txbCodeArea.Size = new System.Drawing.Size(100, 20);
            this.txbCodeArea.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(687, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Inserir";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(687, 236);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 13;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // FrmBrokanas
            // 
            this.ClientSize = new System.Drawing.Size(896, 575);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbCodeArea);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbBrokerCode);
            this.Controls.Add(this.txbTelephone);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbNumer);
            this.Controls.Add(this.btnDelete);
            this.Name = "FrmBrokanas";
            this.Load += new System.EventHandler(this.FrmBrokanas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBrokanas_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
