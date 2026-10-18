# Homework 2 - Basic C# Console Programs 📐🔢

Bu dizin, **CENG 215** dersi kapsamındaki 2. ödev çalışmalarını ve temel konsol uygulamalarını içermektedir.

---

## 📋 Ödev Konuları ve Gereksinimler

### 1. Age Calculator ([`age_calculator.cs`](./age_calculator.cs))
- **Açıklama:** Kullanıcıdan adını (`string`) ve yaşını (`string`) girmesini isteyen bir konsol uygulaması.
- **Gereksinimler:**
  - Kullanıcıdan alınan yaş bilgisi `string` türünden `int` türüne dönüştürülmelidir (`Convert.ToInt32` veya `int.Parse`).
  - Kullanıcının bir sonraki yılki yaşı hesaplanmalı (`age + 1`) ve ekrana yazdırılmalıdır.
- **Örnek Çalışma:**
  ```text
  Enter your name: Yiğit
  Enter your current age: 20
  Hello Yiğit!
  Next year, you will be 21 years old.
  ```

---

### 2. Rectangle Calculator ([`rectangle_calculator.cs`](./rectangle_calculator.cs))
- **Açıklama:** Kullanıcıdan bir dikdörtgenin genişlik (`width`) ve yükseklik (`height`) değerlerini alarak alanını ve çevresini hesaplayan konsol uygulaması.
- **Gereksinimler:**
  - `5.5` gibi ondalıklı (decimal/floating-point) değerlerin girilebilmesi için uygun veri tipi (`double`) kullanılmalıdır.
  - **Alan:** $\text{Area} = \text{width} \times \text{height}$
  - **Çevre:** $\text{Perimeter} = 2 \times (\text{width} + \text{height})$
- **Örnek Çalışma:**
  ```text
  Enter width: 5.5
  Enter height: 4
  Area: 22
  Perimeter: 19
  ```

---

### 3. Number Operations ([`number_operations.cs`](./number_operations.cs))
- **Açıklama:** Kullanıcıdan iki tamsayı (`int`) girmesini isteyen ve bu sayılar üzerinde temel aritmetik işlemleri gerçekleştiren konsol uygulaması.
- **Gereksinimler:**
  - İki adet tamsayı (`int`) alınmalıdır.
  - Şu 5 işlem hesaplanıp gösterilmelidir:
    1. **Toplam (Sum):** `num1 + num2`
    2. **Fark (Difference):** `num1 - num2`
    3. **Çarpım (Product):** `num1 * num2`
    4. **Bölüm (Division):** `(double)num1 / num2` *(Bölüm sonucunun ondalıklı çıkabilmesi için tip dönüşümü yapılmalıdır)*
    5. **Kalan / Mod (Remainder):** `num1 % num2`
- **Örnek Çalışma:**
  ```text
  Enter first number: 5
  Enter second number: 2
  Sum: 7
  Difference: 3
  Product: 10
  Division: 2.5
  Remainder: 1
  ```

---

## 🚀 Çalıştırma

Tek bir `.cs` dosyasını `dotnet-script` veya `csc` (C# Compiler) ile derleyip çalıştırabilirsiniz:

```powershell
csc age_calculator.cs
.\age_calculator.exe
```
