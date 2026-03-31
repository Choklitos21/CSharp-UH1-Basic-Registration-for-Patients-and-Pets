# CSharp-UH1-Basic-Registration-for-Patients-and-Pets

## 📋 Project Overview

This project is a basic **console application in C#** designed to manage patients in a clinical system. It covers core C# concepts including object-oriented programming, collection management, control structures, and error handling.

---

## 🛠️ 1. Development Environment Setup

Before starting, make sure the following tools are installed:

- **[.NET SDK](https://dotnet.microsoft.com/download)** – Required to build and run C# applications.
- **Editor** – Choose one of the following:
  - [Visual Studio](https://visualstudio.microsoft.com/) (full IDE, recommended for beginners)
  - [Visual Studio Code](https://code.visualstudio.com/) with the **C# extension**

### Verify Installation

After installing the .NET SDK, open a terminal and run:

```bash
dotnet --version
```

Create and run a simple test program to confirm everything works:

```bash
dotnet new console -n HelloWorld
cd HelloWorld
dotnet run
```

---

## 📁 2. Project Structure

The project is organized to support scalability and separation of concerns:

```
ClinicalApp/
├── Models/
│   └── Paciente.cs          # Patient data model
├── Services/
│   └── PacienteService.cs   # Business logic for patient management
└── Program.cs               # Application entry point and menu
```

- **`Program.cs`** – Entry point of the application; contains the interactive menu.
- **`Models/`** – Folder containing data model classes.
- **`Services/`** – Folder containing service classes with business logic.

---

## 👤 3. The `Paciente` Class

The `Paciente` class is defined in `Models/Paciente.cs` and represents a patient with the following properties:

```csharp
public class Paciente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Sintoma { get; set; }
}
```

| Property  | Type     | Description              |
|-----------|----------|--------------------------|
| `Id`      | `int`    | Unique patient identifier |
| `Nombre`  | `string` | Patient's full name       |
| `Edad`    | `int`    | Patient's age             |
| `Sintoma` | `string` | Patient's symptom         |

### Example – Creating a Patient Object

```csharp
Paciente paciente = new Paciente
{
    Id = 1,
    Nombre = "Juan Pérez",
    Edad = 35,
    Sintoma = "Fiebre"
};
```

---

## 🖥️ 4. Interactive Console Menu

The application presents a menu loop using a `while` loop and a `switch-case` to handle user selections:

```csharp
bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n--- Menú de Pacientes ---");
    Console.WriteLine("1. Registrar paciente");
    Console.WriteLine("2. Listar pacientes");
    Console.WriteLine("3. Buscar paciente");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            servicio.RegistrarPaciente(pacientes);
            break;
        case "2":
            servicio.ListarPacientes(pacientes);
            break;
        case "3":
            servicio.BuscarPaciente(pacientes);
            break;
        case "4":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
```

---

## ⚙️ 5. The `PacienteService` Class

All core operations are encapsulated in `Services/PacienteService.cs` to promote **separation of concerns**:

```csharp
public class PacienteService
{
    public void RegistrarPaciente(List<Paciente> pacientes)
    {
        // Prompts user input and adds a new patient to the list
    }

    public void ListarPacientes(List<Paciente> pacientes)
    {
        // Displays all registered patients
    }

    public void BuscarPaciente(List<Paciente> pacientes)
    {
        // Searches for a patient by name
    }
}
```

| Method               | Description                              |
|----------------------|------------------------------------------|
| `RegistrarPaciente`  | Registers a new patient into the list    |
| `ListarPacientes`    | Lists all currently registered patients  |
| `BuscarPaciente`     | Searches for a patient by their name     |

---

## 📦 6. Data Storage with `List<Paciente>`

Patient data is stored in memory using a `List<Paciente>`, which is passed between methods to maintain consistency throughout the session:

```csharp
List<Paciente> pacientes = new List<Paciente>();
PacienteService servicio = new PacienteService();
```

The list is created in `Program.cs` and passed as a parameter to each service method, ensuring all operations work on the same shared data.

---

## 🔒 7. Error Handling with `try-catch`

Basic input validation is implemented using `try-catch` blocks to ensure the application handles invalid data gracefully:

```csharp
try
{
    Console.Write("Ingrese la edad del paciente: ");
    int edad = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Error: La edad debe ser un número entero válido.");
}
```

This prevents the application from crashing when users enter unexpected or invalid input.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Choklitos21/CSharp-UH1-Basic-Registration-for-Patients-and-Pets.git
   cd CSharp-UH1-Basic-Registration-for-Patients-and-Pets
   ```

2. Build and run the application:
   ```bash
   dotnet run
   ```

---

## 📚 Key C# Concepts Covered

- Console I/O (`Console.ReadLine`, `Console.WriteLine`)
- Classes and Properties
- `List<T>` collections
- `while` loops and `switch-case` control structures
- Methods and encapsulation
- `try-catch` error handling
- Separation of concerns with service classes
