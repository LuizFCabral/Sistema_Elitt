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
                whisper.comando.CommandText = "Insert into Item(qtde, valor, codprod, codv) values(@q, @v, @cp, @cv)";
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
                whisper.comando.CommandText = "Select p.descr, i.qtde, i.valor, i.qtde*i.valor from Item i "
                    + "INNER JOIN Produto p on i.codprod = p.cod "
                    + "where i.codv = @cv";
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

    }
}
