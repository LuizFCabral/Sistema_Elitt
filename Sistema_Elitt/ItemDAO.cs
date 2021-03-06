using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class ItemDAO
    {
        public int gravar(Item obj)
        {
            Banco whisper = null;
            int quant = 0;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into Item(descr, qtde, valor, codprod, codv) values(@d, @q, @v, @cp, @cv)";
                whisper.comando.Parameters.Add("@d", NpgsqlDbType.Varchar).Value = obj.descr;
                whisper.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
                whisper.comando.Parameters.Add("@v", NpgsqlDbType.Double).Value = obj.valor;
                whisper.comando.Parameters.Add("@cp", NpgsqlDbType.Integer).Value = obj.codProd;
                whisper.comando.Parameters.Add("@cv", NpgsqlDbType.Integer).Value = obj.codV;
                whisper.comando.Prepare();
                quant = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (quant);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar item: " + ex.Message);
            }
        }
        public DataTable listarCodVenda(int codV)
        {
            Banco whisper = null;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select descr, qtde, valor, qtde*valor from Item "
                    + "where codv = @cv";
                whisper.comando.Parameters.Add("@cv", NpgsqlDbType.Integer).Value = codV;
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                whisper.tabela.Columns[0].ColumnName = "Descrição";
                whisper.tabela.Columns[1].ColumnName = "N. de unidades";
                whisper.tabela.Columns[2].ColumnName = "Valor un.";
                whisper.tabela.Columns[3].ColumnName = "Subtotal do item";
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar itens da venda de código " + codV + ": " + ex.Message);
            }
        }
        public DataTable quantidadeVendidaMes(int codP, DateTime inicio, DateTime fim)
        {
            Banco whisper = null;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "SELECT SUM(i.qtde) FROM Item i "
                    + "INNER JOIN Venda v on i.codv = v.cod "
                    + "where i.codprod = @cp AND v.datav BETWEEN @in AND @f "
                    + "GROUP BY MONTH(v.dataV)";
                whisper.comando.Parameters.Add("@cp", NpgsqlDbType.Integer).Value = codP;
                whisper.comando.Parameters.Add("@in", NpgsqlDbType.Timestamp).Value = inicio;
                whisper.comando.Parameters.Add("@f", NpgsqlDbType.Timestamp).Value = fim;
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar quantidades vendidas por mês do produto de código " + codP + ": " + ex.Message);
            }
        }

    }
}
