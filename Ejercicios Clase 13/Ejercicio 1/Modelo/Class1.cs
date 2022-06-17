using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Modelo
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            decimal total = (BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) + (BilletesDe100 * 100) + (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000);
            return total;
        }
        public Billetera Combinar(Billetera billetera2)
        {
            Billetera billetera3 = new Billetera()
            {
                BilletesDe10 = BilletesDe10 + billetera2.BilletesDe10,
                BilletesDe20 = BilletesDe20 + billetera2.BilletesDe20,
                BilletesDe50 = BilletesDe50 + billetera2.BilletesDe50,
                BilletesDe100 = BilletesDe100 + billetera2.BilletesDe100,
                BilletesDe200 = BilletesDe200 + billetera2.BilletesDe200,
                BilletesDe500 = BilletesDe500 + billetera2.BilletesDe500,
                BilletesDe1000 = BilletesDe1000 + billetera2.BilletesDe1000
            };

            BilletesDe10 = BilletesDe20 = BilletesDe50 = BilletesDe100 = BilletesDe200 = BilletesDe500 = BilletesDe1000 = 0;
            
            billetera2.BilletesDe10 = billetera2.BilletesDe20 = billetera2.BilletesDe50 = billetera2.BilletesDe100 = billetera2.BilletesDe200 = billetera2.BilletesDe500 = billetera2.BilletesDe1000 = 0;
            return billetera3;
        }
    }
}
