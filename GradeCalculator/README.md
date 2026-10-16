# Grade Calculator (Ders Notu Hesaplama) 📊

Bu proje, **CENG 215** dersi kapsamında geliştirilmiş, öğrencilerin dönem içi ve dönem sonu değerlendirme notları ile bu notların ağırlık yüzdelerini girerek ağırlıklı ders ortalamasını ve harf notunu hesaplayan modern bir **Windows Forms (.NET 10.0)** masaüstü uygulamasıdır.

---

## 🚀 Özellikler

- **Esnek Not & Yüzde Girişi:**
  - Ödev (Homework) notu ve ağırlığı (%)
  - Laboratuvar (Lab) notu ve ağırlığı (%)
  - Vize (Midterm) notu ve ağırlığı (%)
  - Final notu ve ağırlığı (%)
- **Giriş Doğrulama & Boş Değer Yönetimi:**
  - Boş bırakılan not veya ağırlık alanları otomatik olarak `0` olarak kabul edilir.
  - Girilen ağırlıkların toplamının **%100** olup olmadığı kontrol edilir; toplam 100 değilse kullanıcı uyarı mesajı ile bilgilendirilir.
- **Ağırlıklı Ortalama Hesabı:**
  - Notlar belirlenen ağırlık katsayılarına göre çarpılarak iki ondalık basamak (`0.00`) hassasiyetle hesaplanır.
- **Harf Notu Belirleme:**
  - Hesaplanan ortalamaya göre standart üniversite harf notu baremi uygulanır.
- **Formu Sıfırlama (Temizle):**
  - Tek tıklamayla tüm girdi alanları ve sonuç göstergeleri başlangıç durumuna döndürülür.
- **Modern Kullanıcı Arayüzü:**
  - Kart ve panel tabanlı, modern renk paletine sahip şık tasarım.

---

## 📐 Harf Notu Baremi

| Ağırlıklı Ortalama | Harf Notu |
| :---: | :---: |
| 90 – 100 | **AA** |
| 80 – 89.99 | **BA** |
| 75 – 79.99 | **BB** |
| 70 – 74.99 | **CB** |
| 60 – 69.99 | **CC** |
| 55 – 59.99 | **DC** |
| 50 – 54.99 | **DD** |
| 40 – 49.99 | **FD** |
| 0 – 39.99 | **FF** |

---

## 🛠️ Kullanılan Teknolojiler

- **Programlama Dili:** C#
- **Platform / Framework:** .NET 10.0 (Windows Desktop SDK)
- **Arayüz:** Windows Forms (WinForms)
- **Geliştirme Ortamı:** Visual Studio / Visual Studio Code

---

## 💻 Kurulum ve Çalıştırma

### Gereksinimler
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) (veya ilgili .NET sürümü)
- Windows İşletim Sistemi (Windows Forms desteği için)

### Yöntem 1: Visual Studio ile Çalıştırma
1. `GradeCalculator.slnx` çözüm dosyasını Visual Studio ile açın.
2. Üst menüden **Start / Başlat** (F5) butonuna basarak projeyi derleyip çalıştırın.

### Yöntem 2: .NET CLI ile Çalıştırma
Terminal veya PowerShell üzerinden proje dizinine geçerek aşağıdaki komutu çalıştırabilirsiniz:

```bash
cd GradeCalculator/GradeCalculator
dotnet run
```
