using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapUyeTakipSistemi
{
    public class BorcKitap
    {
        public string UyeTC { get; set; }
        public string KitapAdi { get; set; }

        public BorcKitap(string uyeTC, string kitapAdi)
        {
            UyeTC = uyeTC;
            KitapAdi = kitapAdi;
        }

        public override string ToString()
        {
            return $"TC: {UyeTC} -> {KitapAdi}";
        }
    }
}