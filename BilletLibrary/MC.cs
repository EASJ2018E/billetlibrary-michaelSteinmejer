using System;

namespace BilletLibrary
{
    /// <summary>
    /// Dette er en public klasse MC:transport
    /// </summary>
    public class MC:Transportmiddel
    {
        
        /// <summary>
        /// Motorcykel konstruktør der arver fra base class
        /// </summary>
        /// <param name="nummerplade"></param>
        /// <param name="dato"></param>
        /// <param name="brobizz"></param>
        public MC(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
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
        /// <returns>125</returns>
        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 125 * 0.95;
            }
            return 125;
        }
        /// <summary>
        /// returnerer hvilket køretøj
        /// </summary>
        /// <returns>MC</returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
