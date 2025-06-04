using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapUyeTakipSistemi
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitap(string kitapAdi, string yazarAdi, int sayfaSayisi)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            SayfaSayisi = sayfaSayisi;
        }

        public override string ToString()
        {
            return $"{KitapAdi} - {YazarAdi} ({SayfaSayisi} syf)";
        }

    }
}
