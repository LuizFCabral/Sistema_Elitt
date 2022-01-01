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
    public partial class FConsultarProdutos : Form
    {
        public bool selection;
        ProdutoDAO dao;
        public FConsultarProdutos()
        {
            InitializeComponent();
            dao = new ProdutoDAO();
            dgvListaProdutos.DataSource = dao.listar();

            selection = false;
        }

        private void dgvListaProdutos_DoubleClick(object sender, EventArgs e)
        {
            this.selection = true;
            this.Close();
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            dao = new ProdutoDAO();
            try
            {
                if (txtPesquisa.Text.Length > 0)
                {
                    dgvListaProdutos.DataSource = dao.buscarParteDescr(txtPesquisa.Text);
                    selection = false;
                }
                else
                {
                    dgvListaProdutos.DataSource = dao.listar();
                    selection = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
