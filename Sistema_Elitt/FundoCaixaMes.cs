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
    public partial class FundoCaixaMes : Form
    {
        public FundoCaixaMes()
        {
            InitializeComponent();
            FundoCaixaDAO dao = new FundoCaixaDAO();
            double total = 0;

            try
            {
                dgvFundoCaixaMes.DataSource = dao.listarFundoCaixaMes();

                for (int i = 0; i < dgvFundoCaixaMes.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgvFundoCaixaMes.Rows[i].Cells[1].Value);
                }
                lblTotalVendas.Text = "R$" + String.Format("{0:0.00}", total);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tela da consulta do total do mês" + ex.Message);
            }

            
        }

        private void FundoCaixaMes_Load(object sender, EventArgs e)
        {

        }
    }
}
