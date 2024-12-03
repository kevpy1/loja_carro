using loja_carro.Model;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace loja_carro.View
{
    public partial class Brokan : Form
    {
        private int Id = -1;
        public Brokan()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txbNumer.Clear();
            txbBrokerCode.Clear();
            cmbState.SelectedIndex = 0;
            txbCodeArea.Clear();
            txbTelephone.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private bool ValidateFields()
        {
            if (txbBrokerCode.Text.Length == 0 || txbPassword.Text.Length == 0)
            {
                MessageBox.Show("Os campos CRECI e Senha são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UpdateListView()
        {
            ltvBroker.Items.Clear();

            BrokerDAO brokerDAO = new BrokerDAO();
            List<Broker> brokers = brokerDAO.ListAllBrokers();

            foreach (Broker broker in brokers)
            {
                ListViewItem item = new ListViewItem(broker.Id.ToString());
                item.SubItems.Add(broker.BrokerName);
                item.SubItems.Add(broker.BrokerCode);
                item.SubItems.Add(broker.State);
                item.SubItems.Add(broker.CodeArea.ToString());
                item.SubItems.Add(broker.Telephone);
                item.SubItems.Add(broker.Email);
                ltvBroker.Items.Add(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    if (new BrokerDAO().Insert(new Broker(
                        txbNumer.Text, txbBrokerCode.Text, cmbState.Text, int.Parse(txbCodeArea.Text),
                        txbTelephone.Text, txbEmail.Text, txbPassword.Text)))
                        MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void FrmBroker_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ltvBroker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvBroker.FocusedItem.Index;
                Id = int.Parse(ltvBroker.Items[index].SubItems[0].Text);
                txbNumer.Text = ltvBroker.Items[index].SubItems[1].Text;
                txbBrokerCode.Text = ltvBroker.Items[index].SubItems[2].Text;
                cmbState.Text = ltvBroker.Items[index].SubItems[3].Text;
                txbCodeArea.Text = ltvBroker.Items[index].SubItems[4].Text;
                txbTelephone.Text = ltvBroker.Items[index].SubItems[5].Text;
                txbEmail.Text = ltvBroker.Items[index].SubItems[6].Text;

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BrokerDAO brokerDao = new BrokerDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    brokerDao.Delete(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    new BrokerDAO().Update(new Broker(
                        Id, txbNumer.Text, txbBrokerCode.Text, cmbState.Text, int.Parse(txbCodeArea.Text),
                        txbTelephone.Text, txbEmail.Text, txbPassword.Text));
                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private Button btnDelete;
        private TextBox txbNumer;
        private TextBox txbPassword;
        private TextBox txbTelephone;
        private TextBox txbBrokerCode;
        private ListView ltvBroker;
        private ColumnHeader codigo;
        private ComboBox cmbState;
        private TextBox txbEmail;
        private TextBox txbCodeArea;
        private Button btnUpdate;
        private ColumnHeader Senha;
        private ColumnHeader Usuario;
        private ColumnHeader p;
    }
}
