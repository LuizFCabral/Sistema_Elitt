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
    public partial class FQtde : Form
    {
        public bool feito;
        public Produto obj;
        public int q;
        public FQtde()
        {
            InitializeComponent();
            feito = false;
            q = 0;
            try
            {
                obj = FProduto.pAtual;
                this.Text = "Adicionar unidades de " + obj.descr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a tela: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao;
            try
            {
                q = (int)nudNumUnidades.Value;
                dao = new ProdutoDAO();
                obj.setQtde(q + obj.qtde);
                dao.alterar(obj);
                feito = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a alteração na quantidade de unidades de " + obj.descr + ": " + ex.Message);
            }
        }
    }
}
