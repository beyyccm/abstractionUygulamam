# 👨‍💼 Abstraction ile Çalışanlar Programı

Bu proje, C# dilinde nesne yönelimli programlamanın temel kavramlarından **Abstraction (Soyutlama)** prensibini kullanarak bir şirketin çalışanlarını temsil etmek için hazırlanmıştır.

---

## 📝 Proje Özeti

- `Calisan` adında soyut (abstract) bir temel sınıf oluşturulmuştur.
- `Calisan` sınıfında ortak özellikler (`Ad`, `Soyad`, `Departman`) tanımlanmıştır.
- `Calisan` sınıfında soyut (`abstract`) bir metot olan `Gorev()` tanımlanmıştır.
- `YazilimGelistirici`, `ProjeYonetici`, ve `SatisTemsilcisi` sınıfları `Calisan` sınıfından türetilmiş ve `Gorev()` metodunu kendilerine özgü şekilde override etmiştir.
- Her çalışan nesnesi kendi görev tanımını konsola yazdırmaktadır.

---

## ⚙️ Kullanılan Teknolojiler

- Programlama Dili: **C#**
- Platform: **.NET Console Application**
- IDE: Visual Studio, Visual Studio Code veya benzeri C# destekleyen editörler

---

## 🚀 Nasıl Çalıştırılır?

1. Proje dosyasını bir C# Console uygulaması olarak açın.
2. `Program.cs` dosyasına kodları yapıştırın veya projeye dahil edin.
3. Uygulamayı çalıştırın (`Ctrl + F5` veya `dotnet run`).
4. Konsolda her çalışanın görev tanımları görüntülenecektir.

---

## 💡 Temel Kavramlar

- **Abstract Class (Soyut Sınıf):** Nesne oluşturulamayan, alt sınıflara ortak özellik ve metotlar sağlayan sınıf.
- **Abstract Method (Soyut Metot):** Alt sınıflarda zorunlu olarak override edilmesi gereken metot.
- **Override:** Soyut metotların alt sınıflarda kendine özgü şekilde uygulanması.
- **Polymorphism:** Aynı isimdeki metodun farklı alt sınıflarda farklı davranması.

---

## 📖 Örnek Çıktı

