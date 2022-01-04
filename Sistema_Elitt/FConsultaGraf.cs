using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistema_Elitt
{
    public partial class FConsultaGraf : Form
    {
        public FConsultaGraf()
        {
            InitializeComponent();
            Produto obj;

            try
            {
                obj = FProduto.pAtual; //captura o produto do formulário anterior

                //configs do gráfico
                chtProdAno.Series.Clear(); //limpa as séries
                chtProdAno.Titles.Add("Quantidade vendida de " + obj.descr + " em " + System.DateTime.Now.Year); //titulo do gráfico
                chtProdAno.ChartAreas[0].AxisX.Title = "Mês";//titulo do eixo x
                chtProdAno.ChartAreas[0].AxisY.Title = "Quantidade vendida";//titulo do eixo Y

                chtProdAno.Series.Add(new Series());

                chtProdAno.Series[0].Name = "Unidades"; // nome da série
                chtProdAno.Series[0].ChartType = SeriesChartType.Column; //como são mostrados os dados

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na inicialização da tela: " + ex.Message);
            }
        }
    }
}
