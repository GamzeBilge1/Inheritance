# Inheritance Pratik - Abstract Sınıf Kullanımı

Bu proje, C# dilinde **kalıtım (inheritance)** konusunu anlamak için geliştirilmiştir. Projede bir soyut (`abstract`) temel sınıf ve bu sınıftan türetilen alt sınıflar bulunmaktadır.

## Proje Özeti

1. **Base Sınıf (Kisi):**
   - `Kisi` soyut (`abstract`) bir sınıf olarak tanımlanmıştır.
   - Özellikler:
     - `Ad` (string)
     - `Soyad` (string)
   - Metot:
     - `Bilgi()`: Ad ve soyad bilgilerini konsola yazdırır.

2. **Türetilen Sınıflar:**
   - **Ogrenci:**
     - `Kisi` sınıfından türetilmiştir.
     - Ek Özellik:
       - `OgrenciNo` (int)
     - Ek Metot:
       - `OgrenciBilgi()`: Ad, soyad ve öğrenci numarasını konsola yazdırır.
   - **Ogretmen:**
     - `Kisi` sınıfından türetilmiştir.
     - Ek Özellik:
       - `Maas` (decimal)
     - Ek Metot:
       - `OgretmenBilgi()`: Ad, soyad ve maaş bilgisini konsola yazdırır.

3. **Program:**
   - `Main` metodunda `Ogrenci` ve `Ogretmen` nesneleri oluşturulmuş ve bu nesnelere değer atanmıştır.
   - Atanan değerler konsola yazdırılmıştır.

## Kullanım

1. Projeyi çalıştırın.
2. Konsol çıktısı:
   - Öğrencinin adı, soyadı ve öğrenci numarası.
   - Öğretmenin adı, soyadı ve maaş bilgisi.

## Notlar

- `Kisi` sınıfı soyut bir sınıf olduğu için doğrudan bir nesne olarak oluşturulamaz.
- Kalıtım yoluyla ortak özellikler ve metotlar türetilen sınıflarda yeniden kullanılabilir.
