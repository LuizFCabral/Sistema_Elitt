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
                cmbCredDeb.SelectedIndex = 0;
                dgvVendas.DataSource = dao.listarVendaTipo("DESC", "cartao/credito");
                dgvVendasD.DataSource = dao.listarVendaTipo("DESC", "dinheiro");
                somatoriaVendas();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inicializar a tela: " + ex.Message);
            }
        }

        //Somatoria de vendas
        private void somatoriaVendas()
        {
            double totalC = 0, totalD = 0, totalVendas;

            try
            {
                if (dgvVendas != null)
                {
                    for(int i = 0; i < dgvVendas.Rows.Count; i++)
                    {
                        totalC += Convert.ToDouble(dgvVendas.Rows[i].Cells[2].Value);
                    }
                }
                if(dgvVendasD != null)
                {
                    for(int i = 0; i < dgvVendasD.Rows.Count; i++)
                    {
                        totalD += Convert.ToDouble(dgvVendasD.Rows[i].Cells[2].Value);
                    }
                }
            
                totalVendas = totalC + totalD;
                lblTotalVendaC.Text = "R$" + String.Format("{0:0.00}",totalC);
                lblTotalVendaD.Text = "R$" + String.Format("{0:0.00}", totalD);
                lblTotalDasVendas.Text = "R$" + String.Format("{0:0.00}", totalVendas);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Somatoria de vendas


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

        private void cmbCredDeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbCredDeb.Text;
            VendaDAO dao = new VendaDAO();
            DateTime dti, dtf;

            try
            {
                dti = dtpDataI.Value;
                dtf = dtpDataF.Value;

                if (tipo == "Crédito")
                    tipo = "cartao/credito";
                else
                    tipo = "cartao/debito";

                dgvVendas.DataSource = dao.listarVendaTipoData("DESC", tipo, dti, dtf);
                somatoriaVendas();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnBuscarPData_Click(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            DateTime dti, dtf;
            string tipo = cmbCredDeb.Text;

            try
            {

                dti = dtpDataI.Value;
                dtf = dtpDataF.Value;

                if(tipo == "Crédito")
                    tipo = "cartao/credito";
                else
                    tipo = "cartao/debito";

                dgvVendas.DataSource = dao.listarVendaTipoData("DESC", tipo, dti, dtf);
                dgvVendasD.DataSource = dao.listarVendaTipoData("DESC", "dinheiro", dti, dtf);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDasVendas_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalVendaD_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalVendaC_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void gpbVendasD_Enter(object sender, EventArgs e)
        {

        }

        private void gpbItensVenda_Enter(object sender, EventArgs e)
        {

        }

        private void gpbVendas_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltroTodos_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataF_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataI_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
