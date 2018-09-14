using System;

namespace BilletLibrary
{
    /// <summary>
    /// Dette er en public klasse bil
    /// </summary>
    public class Bil: Transportmiddel
    {
        public Bil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            if (nummerplade.Length >= 8)
            {
                throw new SystemException("DET ER IKKE EN NUMMERPLADE KNOLD!!!");
            }
            else
            {
                Nummerplade = nummerplade;
            }

            Dato = dato;
            Brobizz = brobizz;
        }
        /// <summary>
        /// Brobizz rabat på 5%
        /// </summary>
        /// <returns></returns>
        public double BrobizzRabat()
        {
            if (Brobizz == true)
            {
                return Pris() * 0.95;
            }
            return Pris();
        }
        /// <summary>
        /// returnerer prisen
        /// </summary>
        /// <returns>240</returns>
        public override double Pris()
        {
          return 240;
        }
        /// <summary>
        /// returnerer hvilket køretøj
        /// </summary>
        /// <returns>Bil</returns>
        public override string Køretøj()
        {
            return "Bil";
        }

        
    }
}
