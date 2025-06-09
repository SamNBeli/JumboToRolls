# 📦 Jumbo Roll Set Calculator

Calculate how many finished rolls can be produced from a jumbo roll or snapoff remainder.

---

## 📌 Features

- 1) Calculate the most efficient sets of roll we can make from a jumbo


---

## 🧮 Calculation Formula

### Paper Radius
```
R_paper = (Roll Diameter - Core Diameter) / 2
```

### Area of Paper
```
A_roll = π × (R_total² - R_core²)
A_jumbo = π × (R_total² - R_shell²)
```

### Number of Rolls
```
N = A_jumbo / A_roll
```

---

## 📐 Parameters

- **Core Diameter**: `100 mm`
- **Jumbo Shell Diameter**: `1000 mm`

### Roll Size Options (including core)

| Size ID | Max Diameter | Min Diameter |
|--------|--------------|--------------|
| S1     | 1016 mm      | 966 mm       |
| S2     | 1067 mm      | 1017 mm      |
| S3     | 1143 mm      | 1093 mm      |
| S4     | 1250 mm      | 1200 mm      |
| S5     | 1270 mm      | 1220 mm      |

---

## 💻 Usage

### Function 1: Calculate Roll Count
```csharp
 public IActionResult CalculateFromJumbo([FromBody] JumboCalculationRequest request)
```

---

## 🧪 Sample Input/Output

**Example 1**  
Input:   
Output:

---

## 🚀 Roadmap

- [ ] Support variable core thickness


---

## 🛠 Tech Stack

| Component     | Tech             |
|---------------|------------------|
| Language      | C#               |
| Testing       | xUnit            |
| Documentation | Markdown, Notion |

---
