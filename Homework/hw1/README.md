# Grade Calculator 📊

This project, developed for the **CENG 215** course, is a modern **Windows Forms (.NET 10.0)** desktop application that calculates a student's weighted course average and letter grade from their in-term and end-of-term assessment grades and the weight percentages of those grades.

---

## 🚀 Features

- **Flexible Grade & Weight Input:**
  - Homework grade and weight (%)
  - Lab grade and weight (%)
  - Midterm grade and weight (%)
  - Final grade and weight (%)
- **Input Validation & Empty Value Handling:**
  - Grade or weight fields left empty are automatically treated as `0`.
  - The total of the entered weights is checked against **100%**; if the total is not 100, the user is notified with a warning message.
- **Weighted Average Calculation:**
  - Grades are multiplied by their weight coefficients and calculated with two decimal places (`0.00`) of precision.
- **Letter Grade Assignment:**
  - A standard university letter grade scale is applied to the calculated average.
- **Form Reset (Clear):**
  - All input fields and result displays are reset to their initial state with a single click.
- **Modern User Interface:**
  - A clean card- and panel-based design with a modern color palette.

---

## 📐 Letter Grade Scale

| Weighted Average | Letter Grade |
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

## 🛠️ Technologies Used

- **Programming Language:** C#
- **Platform / Framework:** .NET 10.0 (Windows Desktop SDK)
- **UI:** Windows Forms (WinForms)
- **Development Environment:** Visual Studio / Visual Studio Code

---

## 💻 Setup & Running

### Requirements
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) (or the corresponding .NET version)
- Windows operating system (required for Windows Forms)

### Option 1: Run with Visual Studio
1. Open the `GradeCalculator.slnx` solution file in Visual Studio.
2. Press **Start** (F5) in the top menu to build and run the project.

### Option 2: Run with the .NET CLI
From the repository root, run the following commands in a terminal or PowerShell:

```bash
cd Homework/hw1/GradeCalculator
dotnet run
```
