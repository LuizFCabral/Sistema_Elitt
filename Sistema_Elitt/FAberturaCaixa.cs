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
    public partial class FAberturaCaixa : Form
    {
        public bool selection=false;
        FundoCaixaDAO dao;
        public FAberturaCaixa()
        {
            InitializeComponent();
            dao = new FundoCaixaDAO();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.selection = true;
            this.Close();
        }

        private void FAberturaCaixa_Load(object sender, EventArgs e)
        {
            if(dao.buscarHoje().Equals(null))
            {
                MessageBox.Show("Você já deu uma abertura hoje!");
                this.Close();
            }
        }
    }
}
