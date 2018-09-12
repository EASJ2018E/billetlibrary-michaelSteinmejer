using System;

namespace BilletLibrary
{
    /// <summary>
    /// Dette er en public klasse bil
    /// </summary>
    public class Bil
    {
    /// <value>Dette er Nummerplade</value>
        public string Nummerplade { get; set; }
    /// <value>Dette er dato</value>
        public DateTime Dato { get; set; }

        /// <summary>
        /// returnerer prisen
        /// </summary>
        /// <returns>240</returns>
        public int Pris()
        {
            return 240;
        }
        /// <summary>
        /// returnerer hvilket køretøj
        /// </summary>
        /// <returns>Bil</returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
