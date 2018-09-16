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
        /// returnerer prisen
        /// </summary>
        /// <returns>240</returns>
        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 240 * 0.95;
            }
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
