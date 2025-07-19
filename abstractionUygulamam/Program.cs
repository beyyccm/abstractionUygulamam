using System;

// Abstract base class
abstract class Calisan
{
    // Ortak özellikler
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // Soyut metot: Her çalışan farklı görev yapar
    public abstract void Gorev();
}

// Yazılım geliştirici sınıfı
class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
    }
}

// Proje yöneticisi sınıfı
class ProjeYonetici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} proje yöneticisi olarak çalışıyorum.");
    }
}

// Satış temsilcisi sınıfı
class SatisTemsilcisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
    }
}

class Program
{
    static void Main()
    {
        // Yazılım geliştirici nesnesi
        YazilimGelistirici yazilimci = new YazilimGelistirici()
        {
            Ad = "Ali",
            Soyad = "Demir",
            Departman = "Yazılım"
        };

        // Proje yöneticisi nesnesi
        ProjeYonetici projeYoneticisi = new ProjeYonetici()
        {
            Ad = "Hasan",
            Soyad = "Çıldırmış",
            Departman = "Proje Yönetimi"
        };

        // Satış temsilcisi nesnesi
        SatisTemsilcisi satisci = new SatisTemsilcisi()
        {
            Ad = "Ayşe",
            Soyad = "Kara",
            Departman = "Satış"
        };

        // Görevlerini ekrana yazdır
        yazilimci.Gorev();
        projeYoneticisi.Gorev();
        satisci.Gorev();
    }
}
