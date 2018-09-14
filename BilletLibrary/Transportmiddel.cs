using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract base klasse (Transportmiddel) der skal overskrives
    /// </summary>
    public abstract class Transportmiddel
    {   
        /// <summary>
        /// Nummerplade property der bruger string
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// Dato property der bruger DateTime
        /// </summary>
        public DateTime Dato { get; set; }
        /// <summary>
        /// hvis du har brobizz får du 5% rabat
        /// </summary>
        public bool Brobizz { get; set; } = false;

        protected Transportmiddel(string nummerplade, DateTime dato,bool brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }
        /// <summary>
        /// Retur metode der skal overskrives double(Pris)
        /// </summary>
        /// <returns>Pris på Transportmiddel</returns>
        public abstract double Pris();
        /// <summary>
        /// Retur metode der skal overskrives string(Køretøj)
        /// </summary>
        /// <returns> Type af Transportmiddel</returns>
        public abstract string Køretøj();

        
    }
}
