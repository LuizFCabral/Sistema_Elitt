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
                whisper.comando.CommandText = "Insert into Venda(tipo, total, datav) values(@tipo, @t, @dv)";
                whisper.comando.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = obj.tipo;
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
                whisper.comando.CommandText = "Insert into Venda(tipo, total, datav) values(@tipo, @t, @dv) returning cod";
                whisper.comando.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = obj.tipo;
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
        public DataTable listarVendaTipo(string direcao, string tipo)
        {
            Banco whisper = null;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, tipo, total, datav from venda where tipo=@tipo order by datav " + direcao;
                whisper.comando.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = tipo;
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                whisper.tabela.Columns[0].ColumnName = "Código";
                whisper.tabela.Columns[1].ColumnName = "Tipo";
                whisper.tabela.Columns[2].ColumnName = "Total";
                whisper.tabela.Columns[3].ColumnName = "Data da venda";
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar venda: " + ex.Message);
            }
        }
        public DataTable listarVendaHojeMes(string direcao, string tipo, string filtro)
        {
            Banco whisper = null;

            try
            {


                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, tipo, total, datav from venda where tipo=@tipo and extract("+filtro+" from datav) = extract("+filtro+" from current_date) order by datav " + direcao;
                whisper.comando.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = tipo;
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                whisper.tabela.Columns[0].ColumnName = "Código";
                whisper.tabela.Columns[1].ColumnName = "Tipo";
                whisper.tabela.Columns[2].ColumnName = "Total";
                whisper.tabela.Columns[3].ColumnName = "Data da venda";
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar venda: " + ex.Message);
            }
        }


        public DataTable listarVendaTipoData(string direcao, string tipo, DateTime dataI, DateTime dataF)
        {
            Banco whisper = null;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, tipo, total, datav from venda where tipo=@tipo and datav >= @dti and datav <= @dtf order by datav " + direcao;
                whisper.comando.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = tipo; 
                whisper.comando.Parameters.Add("@dti", NpgsqlDbType.Date).Value = dataI;
                whisper.comando.Parameters.Add("@dtf", NpgsqlDbType.Date).Value = dataF;
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                whisper.tabela.Columns[0].ColumnName = "Código";
                whisper.tabela.Columns[1].ColumnName = "Tipo";
                whisper.tabela.Columns[2].ColumnName = "Total";
                whisper.tabela.Columns[3].ColumnName = "Data da venda";
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
                whisper.comando.CommandText = "Update venda set tipo=@tipo, total=@t, datav=@dv where cod=@cod";
                whisper.comando.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = obj.tipo;
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
