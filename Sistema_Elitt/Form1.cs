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
    public partial class Form1 : Form
    {
        private int linha;
        private int qtde;
        public Form1()
        {
            InitializeComponent();
            this.dgvVenda.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvVenda.Columns.Add("codigo", "Código");
            dgvVenda.Columns.Add("descr", "Descrição");
            dgvVenda.Columns.Add("preco", "Preço unitário");
            dgvVenda.Columns.Add("qtde", "Quantidade");
            dgvVenda.Columns.Add("total", "Valor");
        }


        //Menu
        private void btnProd_Click(object sender, EventArgs e)
        {
            FProduto f = new FProduto();
            f.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FConsultas f = new FConsultas();
            f.ShowDialog();
        }
        //Menu

        //Soma total
        public void GimmeTotal()
        {
            double soma = 0;

            try
            {
                for (int i = 0; i < dgvVenda.Rows.Count; i++)
                {
                    soma += Convert.ToDouble(dgvVenda.Rows[i].Cells[4].Value);
                }
                txtTotal.Text = String.Format("{0:0.00}", soma);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Soma total

        //Achar produto
        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            int cod;
            ProdutoDAO dao;
            Produto obj;
            try
            {
                if (txtCodProduto.Text.Trim().Length > 0)
                {
                    cod = Convert.ToInt32(txtCodProduto.Text);
                    dao = new ProdutoDAO();
                    obj = dao.preencher(cod);
                    if (obj != null)
                    {
                        txtDescr.Text = obj.descr;
                        txtValorU.Text = obj.preco.ToString();
                        qtde = dao.buscarQtde(cod);
                    }
                    else
                    {
                        MessageBox.Show("Produto desconhecido!");
                        txtCodProduto.Focus();
                        txtCodProduto.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no txtCodProdutoLeave: " + ex.Message);
                txtCodProduto.Focus();
            }
        }
        //Achar produto

        //Limpar campos
        public void LimparCampos()
        {
            txtCodProduto.Clear();
            txtQuant.Clear();
            txtDescr.Clear();
            txtValorU.Clear();
        }
        //Limpar campos



        private void dgvVenda_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                linha = dgvVenda.SelectedCells[0].RowIndex;
                txtCodProduto.Text = dgvVenda.Rows[linha].Cells[0].Value.ToString();
                txtDescr.Text = dgvVenda.Rows[linha].Cells[1].Value.ToString();
                txtValorU.Text = dgvVenda.Rows[linha].Cells[2].Value.ToString();
                txtQuant.Text = dgvVenda.Rows[linha].Cells[3].Value.ToString();
                btnRemover.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher campos: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FConsultarProdutos f = new FConsultarProdutos();

            try
            {
                f.ShowDialog();
                if (f.selection)
                {
                    linha = f.dgvListaProdutos.SelectedCells[0].RowIndex;
                    txtCodProduto.Text = f.dgvListaProdutos.Rows[linha].Cells[0].Value.ToString();
                    txtDescr.Text = f.dgvListaProdutos.Rows[linha].Cells[1].Value.ToString();
                    txtValorU.Text = f.dgvListaProdutos.Rows[linha].Cells[2].Value.ToString();
                    qtde = Convert.ToInt32(f.dgvListaProdutos.Rows[linha].Cells[3].Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int quant;
            double valor;
            bool achou = false;

            try
            {
                if (txtDescr.Text.Trim().Length > 0)
                {
                    for (int i = 0; i < dgvVenda.Rows.Count; i++)
                    {
                        if (txtDescr.Text.ToUpper().CompareTo(dgvVenda.Rows[i].Cells[1].Value.ToString().ToUpper()) == 0)

                        {
                            quant = Convert.ToInt32(txtQuant.Text);
                            achou = true;
                            valor = quant * Convert.ToDouble(dgvVenda.Rows[i].Cells[2].Value);
                            dgvVenda.Rows[i].Cells[3].Value = quant;
                            dgvVenda.Rows[i].Cells[4].Value = valor.ToString();
                            break;
                        }
                    }
                    if (!achou)
                    {
                        int quantItem;
                        dgvVenda.Rows.Add();
                        linha = dgvVenda.Rows.Count - 1;
                        dgvVenda.Rows[linha].Cells[0].Value = txtCodProduto.Text;
                        dgvVenda.Rows[linha].Cells[1].Value = txtDescr.Text;
                        dgvVenda.Rows[linha].Cells[2].Value = txtValorU.Text;
                        if (txtQuant.Text.Length<=0)
                        {
                            dgvVenda.Rows[linha].Cells[3].Value = 1;
                            quantItem = 1;
                        }
                        else
                        {
                            dgvVenda.Rows[linha].Cells[3].Value = txtQuant.Text;
                            quantItem = Convert.ToInt32(txtQuant.Text);
                        }
                        double valorU = Convert.ToDouble(txtValorU.Text);
                        dgvVenda.Rows[linha].Cells[4].Value = quantItem * valorU;
                    }
                    GimmeTotal();
                }
                LimparCampos();
                txtCodProduto.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Venda objV;
            VendaDAO daoV;
            Item objI;
            ItemDAO daoI;
            Produto objP;
            ProdutoDAO daoP;
            int i, qtdeAntigo;
            try
            {
                objV = new Venda();
                objV.setDataV(DateTime.Now);
                objV.setTotal(txtTotal.Text);
                daoV = new VendaDAO();
                daoV.gravarGetCodigo(objV);

                daoI = new ItemDAO();
                daoP = new ProdutoDAO();

                for (i = 0; i < dgvVenda.Rows.Count; i++)
                {
                    objI = new Item();
                    objP = new Produto();
                    objI.setCodV(objV.cod);
                    objI.setCodProd(dgvVenda.Rows[i].Cells[0].Value.ToString());
                    objI.setDescr(dgvVenda.Rows[i].Cells[1].Value.ToString());
                    objI.setValor(dgvVenda.Rows[i].Cells[2].Value.ToString());
                    objI.setQtde(dgvVenda.Rows[i].Cells[3].Value.ToString());
                    daoI.gravar(objI);

                    objP.setCod(objI.codProd);
                    qtdeAntigo = daoP.buscarQtde(objP.cod);
                    objP.setQtde(qtdeAntigo - objI.qtde);
                    
                    daoP.alterarQtde(objP);
                }
                this.dgvVenda.Rows.Clear();
                LimparCampos();
                GimmeTotal();
                MessageBox.Show("Venda finalizada com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvVenda.Rows.Remove(dgvVenda.SelectedRows[0]);
            btnRemover.Hide();
            LimparCampos();
            GimmeTotal();
        }

        private void txtQuant_Leave(object sender, EventArgs e)
        {
            if (txtQuant.Text.Length > 0)
            {
                int qtdeAgr = Convert.ToInt32(txtQuant.Text);
                if (qtdeAgr > qtde)
                {
                    MessageBox.Show("A quantidade colocada não condiz com o estoque e foi alterada");
                    txtQuant.Text = qtde.ToString();
                }
            }
        }
    }
}
