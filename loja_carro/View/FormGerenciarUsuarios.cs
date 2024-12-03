using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loja_carro.View
{
    public partial class FormGerenciarUsuarios : Form
    {
        public FormGerenciarUsuarios()
        {
            InitializeComponent();
            string[] linha = { "Campo1", "Campo2", "Campo3" };
            var listViewItem = new ListViewItem(linha);
            listView1.Items.Add(listViewItem);
        }

        private void FormGerenciarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
