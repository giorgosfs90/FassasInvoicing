using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FassasInvoicingLibrary
{
    public class Eteria
    {
       
        public string Eponimia { get; set; }
        public string Afm { get; set; }
        public string Doy{ get; set; }
        public string Drastiriotita { get; set; }
        public string Diefthinsi { get; set; }
        public string Poli { get; set; }
        public string Tk { get; set; }
        public string Xora { get; set; }
        public string Tilefono { get; set; }
        public string Email { get; set; }

        public Eteria(string eponimia, string afm, string doy,string drastiriotita, string diefthinsi, string poli, string tk, string xora, string tilefono, string email )
        {
            email = Email;
            tilefono = Tilefono;
            xora = Xora;
            tk = Tk;
            poli = Poli;
            diefthinsi = Diefthinsi;
            drastiriotita = Drastiriotita;
            doy = Doy;
            afm = Afm;
            eponimia = Eponimia;
        }

        public Eteria() { }

        public string DisplayEponimia
        {
            get
            {
                return $"{Eponimia}";
            }
        }

        public string DisplayAFM
        {
            get
            {
                return $"{Afm}";
            }
        }
        public string DisplayDrastiriotita
        {
            get
            {
                return $"{Drastiriotita}";
            }
        }

        public string DisplayDoy
        {
            get
            {
                return $"{Doy}";
            }
        }
        public string DisplayDiefthinsi
        {
            get
            {
                return $"{Diefthinsi}"+", "+$"{Tk}"+" "+$"{Poli}"+" "+$"{Xora}";
            }
        }

    }
}
