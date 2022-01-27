using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class FundoCaixaDAO
    {

        public int gravar(FundoCaixa obj)
        {
            Banco whisper = null;
            int qtde = 0;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into FundoCaixa(abertura, totalDia, dataFundo) values(@d, @p, @dv)";
                whisper.comando.Parameters.Add("@d", NpgsqlDbType.Double).Value = obj.abertura;
                whisper.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.totalDia;
                whisper.comando.Parameters.Add("@dv", NpgsqlDbType.Timestamp).Value = obj.dataFundo;
                whisper.comando.Prepare();
                qtde = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar produto: " + ex.Message);
            }
        }

        public void gravarGetCodigo(FundoCaixa obj)  //retorna o código atribuído para o registro gravado
        {
            Banco whisper = null; //obj de comunicação com o banco (vem da classe Banco que constrói a conexão e a comunicação com o banco de dados)
            int cod = 0; // codigo do registro gravado
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into FundoCaixa(abertura, totalDia, dataFundo) values(@d, @p, @dv) returning cod";
                whisper.comando.Parameters.Add("@d", NpgsqlDbType.Double).Value = obj.abertura;
                whisper.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.totalDia;
                whisper.comando.Parameters.Add("@dv", NpgsqlDbType.Timestamp).Value = obj.dataFundo;
                whisper.comando.Prepare();
                cod = (int)whisper.comando.ExecuteScalar(); //retorna algum valor (pode ser real, inteiro, etc - por isso o tipo object) gerado pelo banco de dados. Neste caso, esse valor é o código atribuído ao registro gerado pelo banco. 
                Banco.conexao.Close();
                obj.setCod(cod);
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
                whisper.comando.CommandText = "Select abertura, totalDia, dataFundo from fundoCaixa";
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar fundoCaixa: " + ex.Message);
            }
        }public DataTable buscarHoje()
        {
            Banco whisper = null;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select  dataFundo from fundoCaixa where" +
                    " extract(day from dataFundo) = extract(day from current_date) and" +
                    " extract(month from dataFundo) = extract(month from current_date) and" +
                    " extract(year from dataFundo) = extract(year from current_date)";
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar fundoCaixa: " + ex.Message);
            }
        }

    }
}
