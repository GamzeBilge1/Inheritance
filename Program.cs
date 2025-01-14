

using Inheritance_Pratik;

Ogrenci ogrenci = new Ogrenci();  // Öğrenci nesnesi oluşturuluyor

ogrenci.Ad = "Gamze";
ogrenci.Soyad = "Bilge";
ogrenci.OgrenciNo = 123;
ogrenci.OgrenciBilgi();  // Öğrenci bilgilerini konsola yazdır

Console.WriteLine("-----------------------");

Ogretmen ogretmen = new Ogretmen();   // Öğretmen nesnesi oluşturuluyor
ogretmen.Ad = "Merve";
ogretmen.Soyad = "Can";
ogretmen.Maas = 12345;
ogretmen.OgretmenBilgi(); // Öğretmen bilgilerini konsola yazdır