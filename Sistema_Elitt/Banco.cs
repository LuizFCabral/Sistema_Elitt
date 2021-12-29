using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class Banco
    {
        public static NpgsqlConnection conexao;
        public NpgsqlCommand comando;
        public NpgsqlDataReader dreader;
        public DataTable tabela;

        public Banco()
        {
            try
            {
                if ((conexao == null) || (conexao.State != ConnectionState.Open))
                {
                    conexao = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=pedro5012;Database=LPA;");
                    conexao.Open();
                }
                comando = new NpgsqlCommand();
                comando.Connection = conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de conexão: " + ex.Message);
            }
        }
    }
}
