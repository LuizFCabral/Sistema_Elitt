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
        public Form1()
        {
            InitializeComponent();
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





        private void dgvVenda_DoubleClick(object sender, EventArgs e)
        {

        }


    }
}
