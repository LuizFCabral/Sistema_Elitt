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
    public partial class FConsultarFC : Form
    {
        public FConsultarFC()
        {
            InitializeComponent();
            FundoCaixaDAO dao = new FundoCaixaDAO();
            dgvFundoCaixa.DataSource = dao.listar();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            FundoCaixaDAO dao = new FundoCaixaDAO();
            DateTime dti, dtf;

            try
            {
                dti = dtpDataI.Value;
                dtf = dtpDataF.Value;

                dgvFundoCaixa.DataSource = dao.listarFiltrado(dti, dtf);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FundoCaixaDAO dao = new FundoCaixaDAO();
            dgvFundoCaixa.DataSource = dao.listar();
        }
    }
}
