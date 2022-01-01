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
        public int linha;
        public Form1()
        {
            InitializeComponent();
            dgvVenda.Columns.Add("codigo", "Código");
            dgvVenda.Columns.Add("descr", "Descrição");
            dgvVenda.Columns.Add("preco", "Preço unitário");
            dgvVenda.Columns.Add("qtde", "Quantidade");
            dgvVenda.Columns.Add("total", "Valor");

            dgvVenda.Rows.Add();
            linha = dgvVenda.Rows.Count - 1;
            dgvVenda.Rows[linha].Cells[0].Value = 1;
            dgvVenda.Rows[linha].Cells[1].Value = "banana";
            dgvVenda.Rows[linha].Cells[2].Value = "10";
            dgvVenda.Rows[linha].Cells[3].Value = "4";
            dgvVenda.Rows[linha].Cells[4].Value = "40";

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
                            achou = true;
                            quant = Convert.ToInt32(dgvVenda.Rows[i].Cells[3].Value);
                            valor = quant * Convert.ToDouble(dgvVenda.Rows[i].Cells[2].Value);
                            dgvVenda.Rows[i].Cells[3].Value = quant.ToString();
                            dgvVenda.Rows[i].Cells[4].Value = valor.ToString();
                            break;
                        }
                    }
                    if (!achou)
                    {
                        dgvVenda.Rows.Add();
                        linha = dgvVenda.Rows.Count - 1;
                        dgvVenda.Rows[linha].Cells[0].Value = txtCodProduto.Text;
                        dgvVenda.Rows[linha].Cells[1].Value = txtDescr.Text;
                        dgvVenda.Rows[linha].Cells[2].Value = txtValorU.Text;
                        dgvVenda.Rows[linha].Cells[3].Value = txtQuant.Text;
                        int quantItem = Convert.ToInt32(txtQuant.Text);
                        double valorU = Convert.ToDouble(txtValorU.Text);
                        dgvVenda.Rows[linha].Cells[4].Value = quantItem * valorU;
                    }
                    GimmeTotal();
                }
                LimparCampos();
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
            int i;
            try
            {
                objV = new Venda();
                objV.setDataV(DateTime.Now);
                objV.setTotal(txtTotal.Text);
                daoV = new VendaDAO();

                daoV.gravarGetCodigo(objV);

                daoI = new ItemDAO();

                for (i = 0; i < dgvVenda.Rows.Count; i++)
                {
                    objI = new Item();
                    objI.setCodV(objV.cod);
                    objI.setCodProd(dgvVenda.Rows[i].Cells[0].Value.ToString());
                    objI.setValor(dgvVenda.Rows[i].Cells[2].Value.ToString());
                    objI.setQtde(dgvVenda.Rows[i].Cells[3].Value.ToString());
                    daoI.gravar(objI);
                }

                this.dgvVenda.Rows.Clear();
                LimparCampos();
                txtTotal.Clear();
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
        }
    }
}
