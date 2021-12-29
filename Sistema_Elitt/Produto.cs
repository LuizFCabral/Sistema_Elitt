using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class Produto
    {
        /*create table produto (
	cod serial primary key,
	descr varchar(50),
	preco float,
	qtde int
);*/

        public int cod { get; private set; }
        public string descr { get; private set; }
        public double preco { get; private set; }
        public int qtde { get; private set; }

        public void setCod(int c)
        {
            this.cod = c;
        }
        public void setCod(string c)
        {
            try
            {
                this.cod = Convert.ToInt32(c);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setCod: " + ex.Message);
            }
        }
        public void setDescr(string d)
        {
            this.descr = d;
        }
        public void setPreco(double p)
        {
            this.preco = p;
        }
        public void setPreco(string p)
        {
            try
            {
                this.preco = Convert.ToDouble(p);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setPreco: " + ex.Message);
            }
        }
        public void setQtde(int q)
        {
            this.qtde = q;
        }
        public void setQtde(string q)
        {
            try
            {
                this.qtde = Convert.ToInt32(q);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setQtde: " + ex.Message);
            }
        }
    }
}
