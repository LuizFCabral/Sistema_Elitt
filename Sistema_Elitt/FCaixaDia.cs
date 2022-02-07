using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Elitt.Global;

namespace Sistema_Elitt
{   
    
    public partial class FCaixaDia : Form
    {
        FundoCaixa obj;
        FundoCaixaDAO dao;
        VendaDAO daoV;

        public FCaixaDia()
        {
            InitializeComponent();
            daoV = new VendaDAO(); 
            txtFundoCaixa.Text = Global.abertura;
            carregarTabs();
        }
        //Carregar tabelas
        private void carregarTabs()
        {

            double totalCC=0, totalCD=0, totalD=0;
            try
            {
                dgvCartCred.DataSource = daoV.listarVendaHojeMes("DESC", "cartao/credito", "day");
                dgvCartDeb.DataSource = daoV.listarVendaHojeMes("DESC", "cartao/debito", "day");
                dgvDinheiro.DataSource = daoV.listarVendaHojeMes("DESC", "dinheiro", "day");

                for(int i=0; i < dgvCartCred.Rows.Count; i++)
                {
                    totalCC += Convert.ToDouble(dgvCartCred.Rows[i].Cells[2].Value);
                }
                for (int i = 0; i < dgvCartDeb.Rows.Count; i++)
                {
                    totalCD += Convert.ToDouble(dgvCartDeb.Rows[i].Cells[2].Value);
                }
                for (int i = 0; i < dgvDinheiro.Rows.Count; i++)
                {
                    totalD += Convert.ToDouble(dgvDinheiro.Rows[i].Cells[2].Value);
                }
                lblTotalDia.Text = String.Format("{0:0.00}", (totalCC + totalCD + totalD));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar o Caixa do dia" + ex.Message);
            }
        }
        //Carregar tabelas

        //Limpar campos
        private void encerrarExpediente()
        {
            Global.abertura = "";
            this.Close();
        }

        //Limpar campos

        private void btnFinalizarCaixa_Click(object sender, EventArgs e)
        {
            obj = new FundoCaixa();
            dao = new FundoCaixaDAO();

            try
            {
                obj.setAbertura(txtFundoCaixa.Text);
                obj.setTotalDia(lblTotalDia.Text);
                obj.setDataFundo(DateTime.Now);
                dao.gravar(obj);
                MessageBox.Show("Caixa fechado com sucesso");
                encerrarExpediente();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao finalizar o caixa" + ex.Message);
            }
        }

        private void dgvCartCred_DoubleClick(object sender, EventArgs e)
        {
            ItemDAO dao;
            int cod;
            DateTime dT;
            try
            {
                cod = (int)dgvCartCred.SelectedCells[0].Value;
                lblTotalVenda.Text = "Valor total: R$" + String.Format("{0:0.00}", dgvCartCred.SelectedCells[2].Value);
                dT = (DateTime)dgvCartCred.SelectedCells[3].Value;
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

        private void dgvCartDeb_DoubleClick(object sender, EventArgs e)
        {
            ItemDAO dao;
            int cod;
            DateTime dT;
            try
            {
                cod = (int)dgvCartDeb.SelectedCells[0].Value;
                lblTotalVenda.Text = "Valor total: R$" + String.Format("{0:0.00}", dgvCartDeb.SelectedCells[2].Value);
                dT = (DateTime)dgvCartDeb.SelectedCells[3].Value;
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

        private void dgvDinheiro_DoubleClick(object sender, EventArgs e)
        {
            ItemDAO dao;
            int cod;
            DateTime dT;
            try
            {
                cod = (int)dgvDinheiro.SelectedCells[0].Value;
                lblTotalVenda.Text = "Valor total: R$" + String.Format("{0:0.00}", dgvDinheiro.SelectedCells[2].Value);
                dT = (DateTime)dgvDinheiro.SelectedCells[3].Value;
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

        private void FCaixaDia_MouseEnter(object sender, EventArgs e)
        {
            carregarTabs();
        }
    }
}
