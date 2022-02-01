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
                cmbFiltro.SelectedIndex = 0;
                cmbCredDeb.SelectedIndex = 0;
                dgvVendas.DataSource = dao.listarVendaTipoData("DESC", "cartao/credito", "day");
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
            string tipo = cmbCredDeb.Text;
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
                    dgvVendas.DataSource = dao.listarVendaTipo("DESC", tipo);
                    dgvVendasD.DataSource = dao.listarVendaTipo("DESC", "dinheiro");
                }
                else
                {
                    dgvVendas.DataSource = dao.listarVendaTipoData("DESC", tipo, filtro);
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

        private void cmbCredDeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text;
            string tipo = cmbCredDeb.Text;
            VendaDAO dao = new VendaDAO();
            try
            {
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

                if (tipo == "Crédito")
                    tipo = "cartao/credito";
                else
                    tipo = "cartao/debito";

                dgvVendas.DataSource = dao.listarVendaTipoData("DESC", tipo, filtro);
                somatoriaVendas();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnConsultarFC_Click(object sender, EventArgs e)
        {
            FConsultarFC f = new FConsultarFC();
            f.Show();
        }
    }
}
