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
        public int codAtual;
        public static Produto pAtual;
        private string pesquisaAtual;
        public FProduto()
        {
            InitializeComponent();

            try
            {
                pAtual = new Produto();
                codAtual = 0;
                pesquisaAtual = "";
                gpbSelect.Hide();
                atualizarLista("");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na inicialização da tela: " + ex.Message);
            }
        }
        //Limpar campos
        public void LimparCampos()
        {
            txtDescr.Clear();
            txtPreco.Clear();
            nudQtde.ResetText();
        }

        //Limpar campos

        private void atualizarLista(string pesquisa)
        {
            DataTable r;
            ProdutoDAO dao;
            try
            {
                dao = new ProdutoDAO();
                if(pesquisa.Length == 0)
                {
                    r = dao.listar(true);
                }
                else
                {
                    r = dao.buscarParteDescr(pesquisa, true);
                }
                r.Columns[0].ColumnName = "Código";
                r.Columns[1].ColumnName = "Descrição";
                r.Columns[2].ColumnName = "Preço";
                r.Columns[3].ColumnName = "Quantidade";
                dgvProdutos.DataSource = r;
                LimparCampos();
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
                pAtual = select;
                codAtual = select.cod;
                txtCod.Text = select.cod.ToString();
                gpbSelect.Text = "Dados do produto - " + select.descr + ", Código: " + select.cod;
                txtDescrSelect.Text = select.descr;
                txtPrecoSelect.Text = String.Format("{0:0.00}", select.preco);
                nudQtdeSelect.Value = select.qtde;
                gpbSelect.Show();
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
                p = String.Format("{0:0.00}", txtPreco.Text.Replace(",", ".").Trim());
                q = nudQtde.Value.ToString();
                if(descr.Length == 0 || p.Length == 0 || q.Length == 0)
                {
                    throw new Exception("Preencha todos os dados antes de cadastrar o produto");
                }
                else
                {
                    bool achou = false, prosseguir = true;
                    for(int i = 0; i < dgvProdutos.Rows.Count; i++)
                    {
                        if(dgvProdutos.Rows[i].Cells[1].Value.ToString().Equals(descr))
                        {
                            achou = true;
                            prosseguir = false;
                            break;
                        }
                    }
                    if(achou)
                    {
                        DialogResult r = MessageBox.Show("Já existe um produto cadastrado com a descrição '" + descr + "'. Deseja utilizar essa descrição novamente?",
                            "Descrição já em uso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (r.Equals(DialogResult.Yes))
                        {
                            prosseguir = true;
                        }
                        else
                        {
                            MessageBox.Show("Operação cancelada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if(prosseguir)
                    {
                        Produto obj = new Produto();
                        ProdutoDAO dao = new ProdutoDAO();
                        obj.setDescr(descr);
                        obj.setPreco(p);
                        obj.setQtde(q);
                        dao.gravarGetCodigo(obj);
                        atualizarLista(pesquisaAtual);
                        MessageBox.Show("Produto " + obj.descr + " foi cadastrado com sucesso. Código: " + obj.cod);

                        LimparCampos();
                        txtDescr.Focus();
                    }
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
            try
            {
                pesquisa = txtPesquisa.Text.Trim();
                if (pesquisa.Length > 0 )
                {
                    atualizarLista(pesquisa);
                    pesquisaAtual = pesquisa;
                }
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
                txtCod.Text = codAtual.ToString();
            }
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            Produto obj;
            try
            {
                obj = new Produto();
                obj.setCod((int)dgvProdutos.SelectedCells[0].Value);
                obj.setDescr(dgvProdutos.SelectedCells[1].Value.ToString());
                obj.setPreco((double)dgvProdutos.SelectedCells[2].Value);
                obj.setQtde((int)dgvProdutos.SelectedCells[3].Value);
                mostrarSelecao(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar produto da lista: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string descr, p, q;
            try
            {
                descr = txtDescrSelect.Text.Trim();
                p = String.Format("{0:0.00}", txtPrecoSelect.Text.Replace(",",".").Trim());
                q = nudQtdeSelect.Value.ToString();
                if (descr.Length == 0 || p.Length == 0 || q.Length == 0)
                {
                    throw new Exception("Preencha todos os dados antes de atualizar o produto");
                }
                else
                {
                    bool prosseguir = true;
                    if (!descr.Trim().Equals(pAtual.descr.Trim()))
                    {
                        bool achou = false;
                        for (int i = 0; i < dgvProdutos.Rows.Count; i++)
                        {
                            if (dgvProdutos.Rows[i].Cells[1].Value.ToString().Equals(descr))
                            {
                                achou = true;
                                prosseguir = false;
                                break;
                            }
                        }
                        if (achou)
                        {
                            DialogResult r = MessageBox.Show("Já existe um produto cadastrado com a descrição '" + descr + "'. Deseja utilizar essa descrição novamente?",
                                "Descrição já em uso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (r.Equals(DialogResult.Yes))
                            {
                                prosseguir = true;
                            }
                            else
                            {
                                MessageBox.Show("Operação cancelada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    if (prosseguir)
                    {
                        Produto obj = new Produto();
                        ProdutoDAO dao = new ProdutoDAO();
                        obj.setCod(codAtual);
                        obj.setDescr(descr);
                        obj.setPreco(p);
                        obj.setQtde(q);
                        dao.alterar(obj);
                        atualizarLista(pesquisaAtual);
                        mostrarSelecao(obj);
                        MessageBox.Show("Produto de código " + obj.cod + " foi atualizado com sucesso.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao;
            try
            {
                dao = new ProdutoDAO();
                dao.remover(codAtual);
                gpbSelect.Hide();
                atualizarLista(pesquisaAtual);
                txtCod.Clear();
                MessageBox.Show("Produto de código " + codAtual + " foi removido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover produto: " + ex.Message);
            }
        }
        private string validarNumInt(string t, int i)
        {
            return null;
        }
        private string validarNumRac(string t, int i)
        {
            return null;
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            FQtde f;
            try
            {
                f = new FQtde();
                f.ShowDialog();
                if (f.feito)
                {
                    atualizarLista(pesquisaAtual);
                    mostrarSelecao(f.obj);
                    if (f.q > 0)
                        MessageBox.Show(f.q + " unidades de " + f.obj.descr + " adicionadas com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar unidades ao produto: " + ex.Message);
            }
        }

        private void txtPreco_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FConsultaGraf f;
            try
            {
                f = new FConsultaGraf();
                f.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao acessar relatórios do produto " + pAtual.descr + " : " + ex.Message);
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions functions = new Functions();
            functions.OnlyNumbers(e);
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions functions = new Functions();
            functions.OnlyNumbers(e);
        }

        private void txtPrecoSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions functions = new Functions();
            functions.OnlyNumbers(e);
        }
    }
}
