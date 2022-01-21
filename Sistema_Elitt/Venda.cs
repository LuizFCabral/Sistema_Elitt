using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class Venda
    {
        /*create table venda(
	cod serial primary key,
	total float,
	datav timestamp
);*/

        public int cod { get; private set; }
        public string tipo { get; private set; }
        public double total { get; private set; }
        public DateTime dataV { get; private set; }

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
        public void setTipo(string t)
        {
            this.tipo = t;
        }
        public void setTotal(double t)
        {
            this.total = t;
        }
        public void setTotal(string t)
        {
            try
            {
                this.total = Convert.ToDouble(t);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setTotal: " + ex.Message);
            }
        }
        public void setDataV(DateTime dv)
        {
            this.dataV = dv;
        }
        public void setDataV(string dv)
        {
            try
            {
                this.dataV = Convert.ToDateTime(dv);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setDataV: " + ex.Message);
            }
        }
    }
}
