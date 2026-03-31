# CSharp-UH1-Basic-Registration-for-Patients-and-Pets

## 📋 Project Overview

This project is a **console application in C#** designed to manage patient registration in a clinical system. It demonstrates core C# concepts including object-oriented programming, collection management, control structures, and input validation. The application allows users to register, list, and search for patients through an interactive menu-driven interface.

---

## 📁 1. Project Structure

The project is organized to support scalability and separation of concerns:

```
Basic Registration for Patients and Pets/
├── Models/
│   └── Patient.cs                    # Patient data model
├── Services/
│   └── PatientService.cs             # Business logic for patient management
├── Program.cs                        # Application entry point and menu
├── Basic Registration for Patients and Pets.csproj  # Project configuration
└── README.md                         # This file
```

- **`Program.cs`** – Entry point of the application; contains the interactive menu loop and command routing.
- **`Models/`** – Folder containing data model classes.
  - `Patient.cs` – Defines the Patient class with properties and constructor.
- **`Services/`** – Folder containing service classes with business logic.
  - `PatientService.cs` – Encapsulates all patient-related operations.

---

## 👤 2. The `Patient` Class

The `Patient` class is defined in `Models/Patient.cs` and represents a patient with the following properties and constructor:

```csharp
public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Symptom { get; set; }

    public Patient(int newId, string newName, int newAge, string newSymptoms)
    {
        Id = newId;
        Name = newName;
        Age = newAge;
        Symptom = newSymptoms;
    }
}
```

| Property  | Type     | Description              |
|-----------|----------|--------------------------|
| `Id`      | `int`    | Unique patient identifier (auto-incremented) |
| `Name`    | `string` | Patient's full name      |
| `Age`     | `int`    | Patient's age            |
| `Symptom` | `string` | Patient's reported symptom |

### Example – Creating a Patient Object

```csharp
Patient patient = new Patient(
    newId: 1,
    newName: "John Smith",
    newAge: 35,
    newSymptoms: "Fever and cough"
);
```

---

## 🖥️ 3. Interactive Console Menu

The application presents a menu loop using a `while` loop and a `switch-case` statement to handle user selections:

```csharp
bool flag = true;
while (flag)
{
    Console.WriteLine("\n--- Patients Menu ---");
    Console.WriteLine("1. Register a patient");
    Console.WriteLine("2. List all patients");
    Console.WriteLine("3. Search a patient");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            service.RegisterPatient();
            break;
        case "2":
            service.ListPatients();
            break;
        case "3":
            service.SearchPatient();
            break;
        case "4":
            flag = false;
            Console.WriteLine("Bye bye");
            break;
        default:
            Console.WriteLine("Option no valid");
            break;
    }
}
```

The menu continuously prompts the user until they choose option 4 (Exit).

---

## ⚙️ 4. The `PatientService` Class

All core operations are encapsulated in `Services/PatientService.cs` to promote **separation of concerns**. The service maintains its own internal list of patients and manages a unique ID counter:

```csharp
public class PatientService
{
    private List<Patient> _patients = new List<Patient>();
    private int _currentId = 0;
    
    public void RegisterPatient() { /* ... */ }
    public void ListPatients() { /* ... */ }
    public void SearchPatient() { /* ... */ }
}
```

| Method           | Description                              |
|------------------|------------------------------------------|
| `RegisterPatient`| Prompts user for patient details and adds a new patient to the list with validation |
| `ListPatients`   | Displays all registered patients in a formatted way |
| `SearchPatient`  | Searches for a patient by name (case-insensitive) |

### 4.1 RegisterPatient() Method

This method guides the user through patient registration with input validation:

- **Name**: Required field (non-empty string)
- **Age**: Must be a valid integer between 0 and 100
- **Symptoms**: Required field (non-empty string)

Upon successful registration, the patient is added to the list with an auto-incremented ID, and a confirmation message is displayed.

### 4.2 ListPatients() Method

Displays all registered patients in a formatted list. If no patients exist, it displays a message indicating the list is empty.

### 4.3 SearchPatient() Method

Allows users to search for a patient by name. The search is case-insensitive. If found, the patient's details are displayed. If not found, a "Patient not Found" message appears.

---

## 📦 5. Data Storage

Patient data is stored in memory using a `List<Patient>`, which is managed by the `PatientService` class. The list is maintained throughout the application's lifetime (while the program is running). The `_currentId` field automatically increments each time a new patient is registered, ensuring unique IDs.

**Note**: Data is not persisted to disk, so all patient records are lost when the application closes.

---

## 🔒 6. Input Validation

The application implements robust input validation to ensure data integrity:

- **Name and Symptoms**: Non-empty string validation using while loops
- **Age**: Numeric validation using `int.TryParse()` with range checking (0-100)

Example from RegisterPatient:

```csharp
int age;
Console.Write("\nWhat's the patient age?: ");
while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 100)
{
    Console.Write("Age must be a number, higher than 0 and less than 100: ");
}
```

This prevents the application from crashing when users enter invalid input.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Choklitos21/CSharp-UH1-Basic-Registration-for-Patients-and-Pets.git
   cd CSharp-UH1-Basic-Registration-for-Patients-and-Pets
   ```

2. Navigate to the project directory:
   ```bash
   cd "Basic Registration for Patients and Pets"
   ```

3. Build and run the application:
   ```bash
   dotnet run
   ```

4. Follow the on-screen menu to register, list, or search for patients.

---

## 📚 Key C# Concepts Covered

- **Console I/O**: `Console.ReadLine()`, `Console.WriteLine()`
- **Classes and Properties**: Using auto-properties and constructors
- **Collections**: `List<T>` for storing and managing data
- **Control Structures**: `while` loops and `switch-case` statements
- **Methods and Encapsulation**: Service class pattern for business logic separation
- **Input Validation**: `int.TryParse()` and manual string validation
- **String Operations**: Case-insensitive comparison with `.ToLower()`
- **Nullable Reference Types**: Using `string?` and the null-coalescing operator `??`
