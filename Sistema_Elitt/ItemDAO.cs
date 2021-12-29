using NpgsqlTypes;
using System;
using System.Collections.Generic;
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
                whisper.comando.CommandText = "Insert into Item(qtde, valor, codprod, codv) values(@q, @v, @cp, cv)";
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
    }
}
