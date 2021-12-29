using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class VendaDAO
    {
        public int finalizar(Venda obj)
        {
            Banco whisper = null;
            int quant = 0;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into Venda(total, datav) values(@t, @dv)";
                whisper.comando.Parameters.Add("@t", NpgsqlDbType.Double).Value = obj.total;
                whisper.comando.Parameters.Add("@dv", NpgsqlDbType.Timestamp).Value = obj.dataV;
                whisper.comando.Prepare();
                quant = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (quant);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao finalizar venda: " + ex.Message);
            }
        }
        public void gravarGetCodigo(Venda obj)  //retorna o código atribuído para o registro gravado
        {
            Banco whisper = null; //obj de comunicação com o banco (vem da classe Banco que constrói a conexão e a comunicação com o banco de dados)
            int codigo = 0; // codigo do registro gravado
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into Venda(total, datav) values(@t, @dv) returning cod";
                whisper.comando.Parameters.Add("@t", NpgsqlDbType.Double).Value = obj.total;
                whisper.comando.Parameters.Add("@dv", NpgsqlDbType.Timestamp).Value = obj.dataV;
                whisper.comando.Prepare();
                codigo = (int)whisper.comando.ExecuteScalar(); //retorna algum valor (pode ser real, inteiro, etc - por isso o tipo object) gerado pelo banco de dados. Neste caso, esse valor é o código atribuído ao registro gerado pelo banco. 
                Banco.conexao.Close();
                obj.setCod(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }

        }
        public DataTable listar()
        {
            Banco whisper = null;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, total, datav from venda";
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar venda: " + ex.Message);
            }
        }
        public int alterar(Venda obj)
        {
            Banco whisper = null;
            int quant = 0;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Update venda set total=@t, datav=@dv where cod=@cod";
                whisper.comando.Parameters.Add("@t", NpgsqlDbType.Varchar).Value = obj.total;
                whisper.comando.Parameters.Add("@dv", NpgsqlDbType.Double).Value = obj.dataV;
                whisper.comando.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = obj.cod;
                whisper.comando.Prepare();
                quant = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (quant);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar venda: " + ex.Message);
            }
        }

    }
}
