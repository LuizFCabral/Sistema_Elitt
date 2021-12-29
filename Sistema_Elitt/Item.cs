using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class Item
    {
        /*create table item (
	cod serial primary key,
	qtde int,
	valor float,
	codprod int not null,
	codv int not null,
	constraint ri01 foreign key(codprod) references prod(cod) on update cascade,
	constraint ri02 foreign key(codv) references V(cod) on update cascade
); */

        public int cod { get; private set; }
        public int qtde { get; private set; }
        public double valor { get; private set; }
        public int codProd { get; private set; }
        public int codV { get; private set; }

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
        public void setValor(double v)
        {
            this.valor = v;
        }
        public void setValor(string v)
        {
            try
            {
                this.valor = Convert.ToDouble(v);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setValor: " + ex.Message);
            }
        }
        public void setCodProd(int cp)
        {
            this.codProd = cp;
        }
        public void setCodProd(string cp)
        {
            try
            {
                this.codProd = Convert.ToInt32(cp);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setCodProd: " + ex.Message);
            }
        }
        public void setCodV(int cv)
        {
            this.codV = cv;
        }
        public void setCodV(string cv)
        {
            try
            {
                this.codV = Convert.ToInt32(cv);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setCodV: " + ex.Message);
            }
        }
    }
}
