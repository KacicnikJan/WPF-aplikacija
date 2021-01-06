using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Aplikacija
{
    public class Podatki
    {
        private string imeStranke1;
        private string imeStranke2;
        private string PriimekStranke1;
        private string PriimekStranke2;
        private string datumRojstva1;
        private string datumRojstva2;
        private string kraj;

        private bool zaposlen1;
        private bool zaposlen2;

        private bool pooblastilo = false;

        private bool prosnja_stranke = false;
        private bool odgovor_ministrstva = false;
        private bool stranka_zavrnila = false;

        public Podatki()
        {
            this.ImeStranke1 = null;
            this.ImeStranke2 = null;
            this.PriimekStranke1 = null;
            this.PriimekStranke2 = null;
            this.DatumRojstva1 = null;
            this.DatumRojstva2 = null;
            this.Zaposlen1 = false;
            this.Zaposlen2 = false;
            this.Pooblastilo = false;
            this.Kraj = null;
        }

        public bool Zaposlen1 { get => zaposlen1; set => zaposlen1 = value; }
        public bool Zaposlen2 { get => zaposlen2; set => zaposlen2 = value; }
        public string ImeStranke1 { get => imeStranke1; set => imeStranke1 = value; }
        public string ImeStranke2 { get => imeStranke2; set => imeStranke2 = value; }
        public string DatumRojstva1 { get => datumRojstva1; set => datumRojstva1 = value; }
        public string DatumRojstva2 { get => datumRojstva2; set => datumRojstva2 = value; }
        public bool Prosnja_stranke { get => prosnja_stranke; set => prosnja_stranke = value; }
        public bool Odgovor_ministrstva { get => odgovor_ministrstva; set => odgovor_ministrstva = value; }
        public bool Stranka_zavrnila { get => stranka_zavrnila; set => stranka_zavrnila = value; }
        public string PriimekStranke11 { get => PriimekStranke1; set => PriimekStranke1 = value; }
        public string PriimekStranke21 { get => PriimekStranke2; set => PriimekStranke2 = value; }
        public bool Pooblastilo { get => pooblastilo; set => pooblastilo = value; }
        public string Kraj { get => kraj; set => kraj = value; }
    }
}
