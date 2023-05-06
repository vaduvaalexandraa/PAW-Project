using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw
{
    [Serializable]
    public class Imobil
    {
        private int idImobil;
        private string tipImobil;
        private string adresa;
        private float suprafataUtila;
        private int nrCamere;
        private float pret;
        private string descriere;

        public int IdImobil { get=>idImobil; set => idImobil = value; }
        public string TipImobil { get { return tipImobil; } set { tipImobil = value; } }
        public string Adresa { get => adresa; set => adresa = value; }
        public float SuprafataUtila { get => suprafataUtila; set => suprafataUtila = value; }
        public int NrCamere { get => nrCamere; set => nrCamere = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Descriere { get => descriere; set => descriere = value; }

        public Imobil()
        {
            idImobil = 0;
            tipImobil = "Necunoscut";
            adresa = "Necunoscuta";
            suprafataUtila = 0;
            nrCamere = 0;
            pret = 0;
            descriere = "Necunoscuta";
        }

        public Imobil(int i,string tip,string a,float s,int nr,float p, string d)
        {
            this.idImobil=i;
            this.tipImobil = tip;
            this.adresa = a;
            this.suprafataUtila = s;
            this.nrCamere = nr;
            this.pret = p;
            this.descriere = d;
        }

        public override string ToString()
        {
            return "Imobilul cu id-ul: " +idImobil+", este de tip: " + tipImobil + ", are adresa: " + adresa + ".\nDetine o suprafata utila de: " + suprafataUtila +
                " metrii patrati,avand numarul de camere: " + nrCamere + ", fiind listat la pretul de: " + pret + " si avand descrierea: " + descriere+".";
        }
    }
}
