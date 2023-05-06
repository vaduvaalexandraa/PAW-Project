using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw
{
    [Serializable]
    public class Cerere
    {
        private string tipImobilCautat;
        private string zonaDorita;
        private float suprafataMinima;
        private int nrCamere;
        private float pretMaxim;

        public string TipImbolilCautat { get => tipImobilCautat; set => tipImobilCautat = value; }
        public string ZonaDorita { get => zonaDorita;set=>zonaDorita = value; }
        public float SuprafataMinima { get => suprafataMinima;set=> suprafataMinima = value; }
        public int NrCamere { get => nrCamere; set => nrCamere = value; }
        public float PretMaxim { get => pretMaxim; set => pretMaxim = value; }

        public Cerere()
        {
            this.tipImobilCautat = "necunoscut";
            this.zonaDorita = "necunoscuta";
            this.suprafataMinima = 0;
            this.nrCamere = 0;
            this.pretMaxim = 0;
        }

        public Cerere(string t,string z, float s, int n, float p)
        {
            this.tipImobilCautat = t;
            this.zonaDorita= z;
            this.suprafataMinima= s;
            this.nrCamere = n;
            this.pretMaxim= p;
        }

        public override string ToString()
        {
            return "Imobilul cautat este de tip: " +tipImobilCautat+", zona dorita este: "+zonaDorita+", suprafata minima: "+suprafataMinima+
                ", nr de camere: "+nrCamere+" si pretul maxim: "+pretMaxim;
        }

    }
}
