using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class ProdutoDAO
    {
        public int gravar(Produto obj)
        {
            Banco whisper = null;
            int qtde = 0;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into Produto(descr, preco, qtde) values(@d, @p, @q)";
                whisper.comando.Parameters.Add("@d", NpgsqlDbType.Varchar).Value = obj.descr;
                whisper.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.preco;
                whisper.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
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
        public void gravarGetCodigo(Produto obj)  //retorna o código atribuído para o registro gravado
        {
            Banco whisper = null; //obj de comunicação com o banco (vem da classe Banco que constrói a conexão e a comunicação com o banco de dados)
            int cod = 0; // codigo do registro gravado
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Insert into Produto(descr, preco, qtde) values(@d, @p, @q) returning cod";
                whisper.comando.Parameters.Add("@d", NpgsqlDbType.Varchar).Value = obj.descr;
                whisper.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.preco;
                whisper.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
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
        public DataTable listar(bool qtdeVazia)
        {
            Banco whisper = null;
            string busca = "";
               
            try
            {
                if (!qtdeVazia)
                    busca = " where qtde > 0";

                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, descr, preco, qtde from produto" + busca;
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader);
                Banco.conexao.Close();
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar produto: " + ex.Message);
            }
        }

        public int alterar(Produto obj)
        {
            Banco whisper = null;
            int qtde = 0;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Update produto set descr=@d, preco=@p, qtde=@q where cod=@cod";
                whisper.comando.Parameters.Add("@d", NpgsqlDbType.Varchar).Value = obj.descr;
                whisper.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.preco;
                whisper.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
                whisper.comando.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = obj.cod;
                whisper.comando.Prepare();
                qtde = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar produto: " + ex.Message);
            }
        }

        public int alterarQtde(Produto obj)
        {
            Banco whisper = null;
            int qtde = 0;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Update produto set qtde=@q where cod=@cod";
                whisper.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
                whisper.comando.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = obj.cod;
                whisper.comando.Prepare();
                qtde = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar quantidade do produto: " + ex.Message);
            }
        }

        public int remover(int cod)
        {
            Banco whisper;
            int qtde = 0;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Delete from produto where cod=@c";
                whisper.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = cod;
                whisper.comando.Prepare();
                qtde = whisper.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover produto:" + ex.Message);
            }
        }
        public DataTable buscarParteDescr(string parte, bool qtdeVazia)
        {
            Banco whisper = null;
            string busca = "";

            try
            {
                if (!qtdeVazia)
                    busca = " and qtde > 0";

                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, descr, preco, qtde from Produto where descr ilike @dica" + busca; //like: casesensitive ilike: non casesensitive
                whisper.comando.Parameters.Add("@dica", NpgsqlDbType.Varchar).Value = "%" + parte + "%";
                whisper.dreader = whisper.comando.ExecuteReader();
                whisper.tabela = new DataTable();
                whisper.tabela.Load(whisper.dreader); //converte a tabela do postgres para a formatação do csharp
                Banco.conexao.Close();
                return (whisper.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar por parte da descrição: " + ex.Message);
            }
        }

        public int buscarQtde(int cod)
        {
            Banco whisper = null;
            int qtde;
            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select qtde from Produto where cod=@cod"; 
                whisper.comando.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = cod;
                whisper.comando.Prepare();
                qtde = (int)whisper.comando.ExecuteScalar();
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar a quantidade do produto: " + ex.Message);
            }
        }

        public Produto preencher(int cod)
        {
            Banco whisper;
            Produto obj = null;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, descr, preco, qtde from Produto where cod=@c";
                whisper.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = cod;
                whisper.comando.Prepare();
                whisper.dreader = whisper.comando.ExecuteReader();

                if (whisper.dreader.Read())
                {
                    obj = new Produto();
                    obj.setCod((int)whisper.dreader[0]);
                    obj.setDescr((string)whisper.dreader[1]);
                    obj.setPreco((double)whisper.dreader[2]);
                    obj.setQtde((int)whisper.dreader[3]);
                }
                Banco.conexao.Close();
                if (obj == null)
                    throw new Exception("Código inexistente.");
                return (obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar dados pelo código: " + ex.Message);
            }
        }
    }
}
