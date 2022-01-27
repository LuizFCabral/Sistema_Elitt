using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Elitt
{
    public class FundoCaixa
    {
        public int cod { get; private set; }
        public double abertura { get; private set; }
        public double totalDia { get; private set; }
        public DateTime dataFundo { get; private set; }

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
        public void setAbertura(double d)
        {
            this.abertura = d;
        }
        public void setAbertura(string c)
        {
            try
            {
                this.abertura = Convert.ToDouble(c);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setAbertura: " + ex.Message);
            }
        }
        public void setTotalDia(double c)
        {
            this.totalDia = c;
        }
        public void setTotalDia(string c)
        {
            try
            {
                this.totalDia = Convert.ToDouble(c);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setTotalDia: " + ex.Message);
            }
        }
        public void setDataFundo(DateTime dv)
        {
            this.dataFundo = dv;
        }
        public void setDataFundo(string dv)
        {
            try
            {
                this.dataFundo = Convert.ToDateTime(dv);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no setDataFundo: " + ex.Message);
            }
        }

    }
}
