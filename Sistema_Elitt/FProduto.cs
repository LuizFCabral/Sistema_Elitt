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
    public partial class FProduto : Form
    {
        public FProduto()
        {
            InitializeComponent();

            //listagem inicial
            try
            {
                atualizarLista("");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na inicialização da tela: " + ex.Message);
            }
        }
        private void atualizarLista(string pesquisa)
        {
            DataTable r;
            ProdutoDAO dao;
            try
            {
                dao = new ProdutoDAO();
                if(pesquisa.Length == 0)
                {
                    r = dao.listar();
                }
                else
                {
                    r = dao.buscarParteDescr(pesquisa);
                }
                dgvProdutos.DataSource = r;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao fazer a consulta de produtos: " + ex.Message);
            }
        }
        private void mostrarSelecao(Produto select)
        {
            try
            {
                txtCod.Text = select.cod.ToString();
                gpbSelect.Text = "Dados do produto - " + select.descr;
                txtDescrSelect.Text = select.descr;
                txtPrecoSelect.Text = select.preco.ToString();
                nudQtdeSelect.Value = select.qtde;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao colocar dados na tela: " + ex.Message);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string descr, p, q;
            try
            {
                descr = txtDescr.Text.Trim();
                p = txtPreco.Text.Trim();
                q = nudQtde.Value.ToString();
                if(descr.Length == 0 || p.Length == 0 || q.Length == 0)
                {
                    MessageBox.Show("Preencha todos os dados antes de cadastrar o produto");
                }
                else
                {
                    Produto obj = new Produto();
                    ProdutoDAO dao = new ProdutoDAO();
                    obj.setDescr(descr);
                    obj.setPreco(p);
                    obj.setQtde(q);
                    dao.gravarGetCodigo(obj);
                    MessageBox.Show("Produto " + obj.descr + " foi cadastrado com sucesso. Código: " + obj.cod);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            string pesquisa;
            ProdutoDAO dao;
            try
            {
                pesquisa = txtPesquisa.Text.Trim();
                atualizarLista(pesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string cod;
            try
            {
                cod = txtCod.Text;
                if(cod.Length > 0)
                {
                    ProdutoDAO dao = new ProdutoDAO();
                    Produto obj = dao.preencher(Convert.ToInt32(cod));
                    mostrarSelecao(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na procura pelo código: " + ex.Message);
            }
        }
    }
}
