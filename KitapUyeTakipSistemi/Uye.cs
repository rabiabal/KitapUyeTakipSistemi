using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapUyeTakipSistemi
{
    public class Uye
    {
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string UyeTC { get; set; }

        public Uye(string uyeAdi, string uyeSoyadi, string uyeTC)
        {
            UyeAdi = uyeAdi;
            UyeSoyadi = uyeSoyadi;
            UyeTC = uyeTC;
        }

        public override string ToString()
        {
            return $"{UyeAdi} {UyeSoyadi} - TC: {UyeTC}";
        }
    }
    }

