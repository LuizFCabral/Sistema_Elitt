﻿using NpgsqlTypes;
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
        public DataTable listar()
        {
            Banco whisper = null;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, descr, preco, qtde from produto";
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
        public DataTable buscarParteDescr(string parte)
        {
            Banco whisper = null;

            try
            {
                whisper = new Banco();
                whisper.comando.CommandText = "Select cod, descr, preco, qtde from Produto where descr ilike @dica"; //like: casesensitive ilike: non casesensitive
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
                return (obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher:" + ex.Message);
            }
        }
    }
}