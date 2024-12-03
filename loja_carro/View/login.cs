using loja_carro.Model;
using loja_carro.Resources.Model;
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
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void texsenha1_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        private void textSenh_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginpass_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //teste apagar
            string kevpy = txbusuario.Text;
            string kevpy1 = txbsenha.Text;

            
            if (kevpy == "kevpy" &&  kevpy1 == "123")
            {
                Form1 form1 = new Form1();
                this.Visible = false;
                form1.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha está incorreto");
            }
        }

        private void txtcriarlog_Click(object sender, EventArgs e)
        { 
            string usuariocad = txbusuario.Text;
            string senha = txbsenha.Text;



            Usuario usuario = new Usuario(usuariocad, senha);

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            usuarioDAO.Insert(usuario);
            
            txbusuario.Clear();
            txbsenha.Clear();

            MessageBox.Show("Usuario cadastrado ");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var formLoja = new FormGerenciarUsuarios();
            formLoja.ShowDialog();
        }
    }
}
