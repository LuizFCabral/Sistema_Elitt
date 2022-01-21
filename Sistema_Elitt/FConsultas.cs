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
                dgvVendas.DataSource = dao.listarVendaTipo("DESC", "cartao");
                dgvVendasD.DataSource = dao.listarVendaTipo("DESC", "dinheiro");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inicializar a tela: " + ex.Message);
            }
        }

        private void rdbs(string tipo, string arg)
        {
            try
            {
                VendaDAO dao = new VendaDAO();
                if(tipo == "cartao")
                {
                    if(tipo == "recente")
                        dgvVendas.DataSource = dao.listarVendaTipo("DESC", "cartao");
                    else
                        dgvVendas.DataSource = dao.listarVendaTipo("ASC", "cartao");
                }
                else
                {
                    if (tipo == "recente")
                        dgvVendasD.DataSource = dao.listarVendaTipo("DESC", "dinheiro");
                    else
                        dgvVendasD.DataSource = dao.listarVendaTipo("ASC", "dinheiro");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar parâmetro de ordenação para 'mais recentes primeiro': " + ex.Message);
            }
        }

        private void rdbDesc_Click(object sender, EventArgs e)
        {
            rdbs("cartao", "recente");
        }

        private void rdbAsc_Click(object sender, EventArgs e)
        {
            rdbs("cartao", "antigo");
        }

        private void rdbMrd_CheckedChanged(object sender, EventArgs e)
        {
            rdbs("cartao", "recente");
        }

        private void rdbMad_CheckedChanged(object sender, EventArgs e)
        {
            rdbs("cartao", "antigo");
        }
        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            ItemDAO dao;
            int cod;
            DateTime dT;
            try
            {
                cod = (int)dgvVendas.SelectedCells[0].Value;
                lblTotalVenda.Text = "Valor total: R$" + String.Format("{0:0.00}", dgvVendas.SelectedCells[2].Value);
                dT = (DateTime)dgvVendas.SelectedCells[3].Value;
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

        private void dgvVendasD_DoubleClick(object sender, EventArgs e)
        {
            ItemDAO dao;
            int cod;
            DateTime dT;
            try
            {
                cod = (int)dgvVendasD.SelectedCells[0].Value;
                lblTotalVenda.Text = "Valor total: R$" + String.Format("{0:0.00}", dgvVendasD.SelectedCells[2].Value);
                dT = (DateTime)dgvVendasD.SelectedCells[3].Value;
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
