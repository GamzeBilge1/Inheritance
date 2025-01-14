using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Pratik
{
    public class Ogretmen: Kisi  // Kisi sınıfından miras alan Ogretmen sınıfı
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgi()
        {
            Bilgi(); // Base sınıftaki Bilgi() metodunu çağırıyoruz
            Console.WriteLine("Maaş: "+Maas);
        }
    }
}
