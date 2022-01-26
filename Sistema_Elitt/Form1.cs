using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Elitt.Functions;

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
        {   FProduto f = new FProduto();
            if (Application.OpenForms.OfType<FProduto>().Count() > 0 )
            {
                f.BringToFront();
                this.SendToBack();
            }
            else
                f.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FConsultas f = new FConsultas();
            if (Application.OpenForms.OfType<FProduto>().Count() > 0)
            {
                f.BringToFront();
                this.SendToBack();
            }
            else
                f.Show();
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
                        txtValorU.Text = String.Format("{0:0.00}", obj.preco.ToString());
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
                txtValorU.Text = String.Format("{0:0.00}", dgvVenda.Rows[linha].Cells[2].Value);
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
                            dgvVenda.Rows[i].Cells[4].Value = String.Format("{0:0.00}", valor);
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
                        dgvVenda.Rows[linha].Cells[2].Value =  txtValorU.Text;
                        if (txtQuant.Text.Length <= 0)
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
                        double total = quantItem * valorU;
                        dgvVenda.Rows[linha].Cells[4].Value = String.Format("{0:0.00}", total);
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
                if (dgvVenda.Rows.Count <= 0)
                {
                    MessageBox.Show("Nenhum produto no carrinho!");
                }
                else
                {
                    objV = new Venda();
                    string tipo;
                    if (rdbCartao.Checked)
                        tipo = "cartao";
                    else
                        tipo = "dinheiro";
                    objV.setTipo(tipo);
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
                    txtTroco.Text = "00,00";
                    txtRecebido.Text = "";
                    GimmeTotal();
                    MessageBox.Show("Venda finalizada com sucesso!");
                }

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

        private void calculaTroco()
        {
            double total, recebido;
            if(txtRecebido.Text.Length <= 0)
            {
                recebido = 0;
            }
            else
            {
                recebido = Convert.ToDouble(txtRecebido.Text);
            }
            total = Convert.ToDouble(String.Format("{0:0.00}", txtTotal.Text));
            if (total < recebido)
                txtTroco.Text = String.Format("{0:0.00}", (recebido - total));
            else
                txtTroco.Text = "0,00";
        }

        private void txtRecebido_KeyUp(object sender, KeyEventArgs e)
        {
            calculaTroco();
        }
        private void txtRecebido_Leave(object sender, EventArgs e)
        {
            calculaTroco();
        }

        private void txtRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions functions = new Functions();
            functions.OnlyNumbers(e);
        }

        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions functions = new Functions();
            functions.OnlyNumbers(e);
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions functions = new Functions();
            functions.OnlyNumbers(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

    }
}
