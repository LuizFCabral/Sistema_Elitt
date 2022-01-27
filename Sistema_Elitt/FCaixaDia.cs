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

        public FCaixaDia()
        {
            InitializeComponent();
            txtFundoCaixa.Text = Global.abertura;
        }
        private void btnFinalizarCaixa_Click(object sender, EventArgs e)
        {

        }
    }
}
