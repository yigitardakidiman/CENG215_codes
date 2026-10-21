# Lab - 21.10.2026 (CENG 215 Lab Week 1) 🧪

This folder contains the 5 C# console applications assigned in the CENG 215 lab session on **21.10.2026**. Each question is implemented as a separate .NET console project, and all projects are grouped under a single solution (`Lab_21_10_2026.slnx`).

---

## 📂 Projects

| Question | Project | Description |
| :---: | :--- | :--- |
| Q1 | [Q1_CircleArea](./Q1_CircleArea/Program.cs) | Reads the radius and calculates the area and circumference of a circle (`const double PI = 3.14159`). |
| Q2 | [Q2_GradeCalculator](./Q2_GradeCalculator/Program.cs) | Calculates the average of two midterms (20% + 20%) and a final (60%), then prints "Passed"/"Failed" using `?:` (threshold: 70). |
| Q3 | [Q3_TemperatureConverter](./Q3_TemperatureConverter/Program.cs) | Converts Celsius to Fahrenheit using `F = C × 9.0 / 5 + 32`. |
| Q4 | [Q4_TimeConverter](./Q4_TimeConverter/Program.cs) | Splits a total number of seconds into hours, minutes and seconds using `/` and `%` (e.g. 3675 → 1 hour, 1 minute, 15 seconds). |
| Q5 | [Q5_SwapValues](./Q5_SwapValues/Program.cs) | Swaps two integers using a third (`temp`) variable. |

---

## 📁 Directory Structure

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

## 🚀 Running

### Visual Studio
Open `Lab_21_10_2026.slnx`, right-click the project you want to run, select **Set as Startup Project** and press **F5**.

### .NET CLI
```bash
cd Lab/21.10.2026
dotnet run --project Q1_CircleArea
```

> **Note:** On systems with Turkish regional settings, the decimal separator is a comma. Enter decimal values as `2,5` instead of `2.5`.
