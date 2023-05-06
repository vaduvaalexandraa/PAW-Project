using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw
{
    [Serializable]
    public class Oferta
    {
        
        private Imobil imobil;
        private DateTime dataListare;
        private bool disponibil;

        public Imobil Imobil { get => imobil; set => imobil = value; }
        public DateTime DataListare { get => dataListare; set => dataListare = value; }
        public bool Disponibil { get => disponibil; set => disponibil = value; }

        public Oferta()
        {
            this.imobil = new Imobil();
            this.dataListare = new DateTime(2000,1,1);
            this.disponibil = true;
        }

        public Oferta(Imobil i, int zi, int luna, int an,bool disp)
        {
            this.imobil = i;
            this.dataListare =new DateTime(an,luna, zi);
            this.disponibil= disp;
        }

        public override string ToString()
        {
            return "Oferta listata: \n"+imobil.ToString()+"\n"+"Acesta este listat la date de: "+dataListare.ToString("d/M/yyyy")+".\n"
                +"Si are disponibilitatea: "+disponibil;
        }
    }
}
