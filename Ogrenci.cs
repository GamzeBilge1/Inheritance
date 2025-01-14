using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Pratik
{
    public class Ogrenci : Kisi  // Kisi sınıfından miras alan Ogrenci sınıfı
    {
        public int OgrenciNo { get; set; }

        public void OgrenciBilgi()
        {
            Bilgi(); // Base sınıftaki Bilgi() metodunu çağırıyoruz
            Console.WriteLine("ogrenci no : "+OgrenciNo);
        }
    }
}
