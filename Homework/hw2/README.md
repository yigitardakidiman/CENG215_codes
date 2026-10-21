# Homework 2 - Basic C# Console Programs 📐🔢

This directory contains the second homework assignment for the **CENG 215** course, consisting of basic console applications.

---

## 📋 Assignment Topics & Requirements

### 1. Age Calculator ([`age_calculator.cs`](./age_calculator.cs))
- **Description:** A console application that asks the user to enter their name (`string`) and age (`string`).
- **Requirements:**
  - The age entered by the user must be converted from `string` to `int` (`Convert.ToInt32` or `int.Parse`).
  - The user's age next year must be calculated (`age + 1`) and printed to the screen.
- **Sample Run:**
  ```text
  Enter your name: Yiğit
  Enter your current age: 20
  Hello Yiğit!
  Next year, you will be 21 years old.
  ```

---

### 2. Rectangle Calculator ([`rectangle_calculator.cs`](./rectangle_calculator.cs))
- **Description:** A console application that reads the width (`width`) and height (`height`) of a rectangle from the user and calculates its area and perimeter.
- **Requirements:**
  - An appropriate data type (`double`) must be used so that decimal (floating-point) values such as `5.5` can be entered.
  - **Area:** $\text{Area} = \text{width} \times \text{height}$
  - **Perimeter:** $\text{Perimeter} = 2 \times (\text{width} + \text{height})$
- **Sample Run:**
  ```text
  Enter width: 5.5
  Enter height: 4
  Area: 22
  Perimeter: 19
  ```

---

### 3. Number Operations ([`number_operations.cs`](./number_operations.cs))
- **Description:** A console application that asks the user to enter two integers (`int`) and performs basic arithmetic operations on them.
- **Requirements:**
  - Two integers (`int`) must be read.
  - The following 5 operations must be calculated and displayed:
    1. **Sum:** `num1 + num2`
    2. **Difference:** `num1 - num2`
    3. **Product:** `num1 * num2`
    4. **Division:** `(double)num1 / num2` *(a type cast is required so the result can have a decimal part)*
    5. **Remainder (Mod):** `num1 % num2`
- **Sample Run:**
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

## 🚀 Running

You can compile and run a single `.cs` file with `dotnet-script` or `csc` (C# Compiler):

```powershell
csc age_calculator.cs
.\age_calculator.exe
```
