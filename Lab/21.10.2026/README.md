# Lab - 21.10.2026 (CENG 215 Lab Week 1) 🧪

Bu klasör, **21.10.2026** tarihli CENG 215 laboratuvar dersinde verilen 5 C# konsol uygulamasını içermektedir. Her soru ayrı bir .NET konsol projesi olarak hazırlanmış ve tek bir solution (`Lab_21_10_2026.slnx`) altında toplanmıştır.

---

## 📂 Projeler

| Soru | Proje | Açıklama |
| :---: | :--- | :--- |
| Q1 | [Q1_CircleArea](./Q1_CircleArea/Program.cs) | Yarıçapı alıp dairenin alanını ve çevresini hesaplar (`const double PI = 3.14159`). |
| Q2 | [Q2_GradeCalculator](./Q2_GradeCalculator/Program.cs) | İki vize (%20 + %20) ve final (%60) notundan ortalama hesaplar, `?:` ile "Passed"/"Failed" yazdırır (eşik: 70). |
| Q3 | [Q3_TemperatureConverter](./Q3_TemperatureConverter/Program.cs) | Celsius değerini `F = C × 9.0 / 5 + 32` formülüyle Fahrenheit'a çevirir. |
| Q4 | [Q4_TimeConverter](./Q4_TimeConverter/Program.cs) | Toplam saniyeyi `/` ve `%` kullanarak saat, dakika ve saniyeye ayırır (örn. 3675 → 1 saat, 1 dakika, 15 saniye). |
| Q5 | [Q5_SwapValues](./Q5_SwapValues/Program.cs) | İki tam sayıyı üçüncü bir değişken (`temp`) kullanarak yer değiştirir. |

---

## 📁 Dizin Yapısı

```text
21.10.2026/
├── Q1_CircleArea/
├── Q2_GradeCalculator/
├── Q3_TemperatureConverter/
├── Q4_TimeConverter/
├── Q5_SwapValues/
├── Lab_21_10_2026.slnx
└── README.md
```

---

## 🚀 Çalıştırma

### Visual Studio
`Lab_21_10_2026.slnx` dosyasını açın, çalıştırmak istediğiniz projeye sağ tıklayıp **Set as Startup Project** seçin ve **F5** ile çalıştırın.

### .NET CLI
```bash
cd Lab/21.10.2026
dotnet run --project Q1_CircleArea
```

> **Not:** Türkçe bölge ayarlarında ondalık ayırıcı virgüldür. Ondalıklı sayı girerken `2.5` yerine `2,5` yazın.
