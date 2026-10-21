# CENG 215 Course Codes & Assignments 🎓💻

Bu depo, **CENG 215** dersi kapsamında hazırlanan laboratuvar çalışmaları, ödevler ve dönem projelerinin kaynak kodlarını içermektedir.

---

## 📁 Projeler ve İçerik

### 📝 Homework (Ödevler)
| Klasör / Proje | Açıklama | Teknoloji / Dil | Durum |
| :--- | :--- | :---: | :---: |
| [hw1 (GradeCalculator)](./Homework/hw1/) | Ders notları ve ağırlık yüzdelerine göre ağırlıklı ortalama ve harf notu hesaplayan Windows Forms uygulaması. | C# / .NET 10.0 (WinForms) | Tamamlandı ✅ |
| [hw2 (Basic C# Programs)](./Homework/hw2/) | Temel C# konsol uygulamaları: Yaş hesaplayıcı (`age_calculator.cs`), sayı işlemleri (`number_operations.cs`) ve dikdörtgen hesaplayıcı (`rectangle_calculator.cs`). | C# / .NET | Tamamlandı ✅ |

### 🔬 Lab (Laboratuvar Çalışmaları)
| Klasör / Proje | Açıklama | Teknoloji / Dil | Durum |
| :--- | :--- | :---: | :---: |
| [21.10.2026 (Lab Week 1)](./Lab/21.10.2026/) | 5 konsol uygulaması: Daire alanı (Q1), not ortalaması (Q2), sıcaklık dönüştürücü (Q3), zaman dönüştürücü (Q4), değer takası (Q5). | C# / .NET 10.0 (Console) | Tamamlandı ✅ |

---

## 📂 Dizin Yapısı

```text
CENG_215_Codes/
│
├── Homework/                        # Ödev projeleri
│   ├── hw1/                         # Ödev 1: GradeCalculator (WinForms)
│   │   ├── GradeCalculator/         # WinForms Kaynak Kodları (Form1.cs, Program.cs, vb.)
│   │   ├── GradeCalculator.slnx     # Solution Dosyası
│   │   └── README.md                # Projeye özel dokümantasyon
│   └── hw2/                         # Ödev 2: Temel C# Konsol Uygulamaları
│       ├── age_calculator.cs        # Yaş hesaplama
│       ├── number_operations.cs     # Sayısal işlemler
│       ├── rectangle_calculator.cs  # Dikdörtgen alan ve çevre hesabı
│       └── README.md                # Ödev 2 dokümantasyonu
│
├── Lab/                             # Laboratuvar çalışmaları
│   ├── .gitkeep
│   └── 21.10.2026/                  # Lab Week 1: 5 konsol projesi (Q1-Q5)
│       ├── Q1_CircleArea/           # Daire alanı ve çevresi
│       ├── Q2_GradeCalculator/      # Vize/final ortalaması ve geçti/kaldı
│       ├── Q3_TemperatureConverter/ # Celsius -> Fahrenheit
│       ├── Q4_TimeConverter/        # Saniye -> saat/dakika/saniye
│       ├── Q5_SwapValues/           # Üçüncü değişkenle takas
│       ├── Lab_21_10_2026.slnx      # Solution Dosyası
│       └── README.md                # Lab dokümantasyonu
│
├── .gitignore                       # Derleme ve geçici dosyaları hariç tutma
└── README.md                        # Ana repo tanıtım ve içerik belgesi
```

---

## 🚀 Projeleri Çalıştırma

Her projenin kendi dizininde ayrıntılı çalışma ve derleme adımlarını içeren bir `README.md` dosyası bulunmaktadır.

Örneğin, `GradeCalculator` projesini çalıştırmak için:
```bash
git clone https://github.com/yigitardakidiman/CENG215_codes.git
cd CENG215_codes/Homework/hw1/GradeCalculator
dotnet run
```

---

## 👤 Geliştirici

- **Geliştirici:** Yiğit Arda Kıdıman
- **GitHub:** [@yigitardakidiman](https://github.com/yigitardakidiman)
- **Repo:** [CENG215_codes](https://github.com/yigitardakidiman/CENG215_codes)
