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
                cmbFiltro.SelectedIndex = 0;
                dgvVendas.DataSource = dao.listarVendaTipoData("DESC", "cartao", "day");
                dgvVendasD.DataSource = dao.listarVendaTipoData("DESC", "dinheiro", "day");
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

        private void rdbs(string tipo, string arg)
        {
            try
            {
                VendaDAO dao = new VendaDAO();
                string filtro = cmbFiltro.Text;
                if (filtro == "Dia")
                    filtro = "day";
                else
                {
                    if (filtro == "Mês")
                        filtro = "month";
                    else
                    {
                        if (filtro == "Ano")
                            filtro = "year";
                    }
                }

                if (tipo == "cartao")
                {
                    if(tipo == "recente")
                        dgvVendas.DataSource = dao.listarVendaTipoData("DESC", "cartao", filtro);
                    else
                        dgvVendas.DataSource = dao.listarVendaTipoData("ASC", "cartao", filtro);
                }
                else
                {
                    if (tipo == "recente")
                        dgvVendasD.DataSource = dao.listarVendaTipoData("DESC", "dinheiro", filtro);
                    else
                        dgvVendasD.DataSource = dao.listarVendaTipoData("ASC", "dinheiro", filtro);
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

        private void FConsultas_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            string filtro = cmbFiltro.Text;
            bool todas = false;
            try
            {
                if (filtro == "Dia")
                    filtro = "day";
                else {
                    if (filtro == "Mês")
                        filtro = "month";
                    else
                    {
                        if(filtro=="Ano")
                            filtro = "year";
                        else
                        {
                            if(filtro =="Todas as vendas")
                                todas = true;
                        }
                    }
                }

                if (todas)
                {
                    dgvVendas.DataSource = dao.listarVendaTipo("DESC", "cartao");
                    dgvVendasD.DataSource = dao.listarVendaTipo("DESC", "dinheiro");
                }
                else
                {
                    dgvVendas.DataSource = dao.listarVendaTipoData("DESC", "cartao", filtro);
                    dgvVendasD.DataSource = dao.listarVendaTipoData("DESC", "dinheiro", filtro);    
                }

                somatoriaVendas();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
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
    }
}
