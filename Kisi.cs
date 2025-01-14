using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Pratik
{
    public abstract class Kisi // abstract ile base sınıf oluşturuldu . doğrudan bir nesne olarak oluşturulamaz.
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void Bilgi()
        {
            Console.WriteLine("Merhaba. Ben "+Ad+ " "+Soyad);
        }
    }
}
