using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Elitt
{
    public partial class FConsultas : Form
    {
        public FConsultas()
        {
            InitializeComponent();

            try
            {
                VendaDAO dao = new VendaDAO();
                gpbItensVenda.Hide();
                rdbDesc.Checked = true;
                dgvVendas.DataSource = dao.listarOrderTemporal("DESC");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inicializar a tela: " + ex.Message);
            }
        }

        private void rdbDesc_Click(object sender, EventArgs e)
        {
            try
            {
                VendaDAO dao = new VendaDAO();
                dgvVendas.DataSource = dao.listarOrderTemporal("DESC");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar parâmetro de ordenação para 'mais recentes primeiro': " + ex.Message);
            }
        }

        private void rdbAsc_Click(object sender, EventArgs e)
        {
            try
            {
                VendaDAO dao = new VendaDAO();
                dgvVendas.DataSource = dao.listarOrderTemporal("ASC");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar parâmetro de ordenação para 'mais antigas primeiro': " + ex.Message);
            }
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            ItemDAO dao;
            int cod;
            DateTime dT;
            try
            {
                cod = (int)dgvVendas.SelectedCells[0].Value;
                lblTotalVenda.Text = "Valor total: R$" + String.Format("{0:0.00}", dgvVendas.SelectedCells[1].Value);
                dT = (DateTime)dgvVendas.SelectedCells[2].Value;
                dao = new ItemDAO();
                gpbItensVenda.Text = "Itens da venda " + " de código " + cod + " realizada em: " + dT.ToString();
                dgvProdutosVenda.DataSource = dao.listarCodVenda(cod);
                gpbItensVenda.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar uma venda para mostrar seus itens: " + ex.Message);
            }
        }
    }
}
