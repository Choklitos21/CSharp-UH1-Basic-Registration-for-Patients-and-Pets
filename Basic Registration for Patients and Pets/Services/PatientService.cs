using Basic_Registration_for_Patients_and_Pets.Models;

namespace Basic_Registration_for_Patients_and_Pets.Services;

public class PatientService
{
    private List<Patient> _patients = new List<Patient>();
    private int _currentId = 0;
    
    public void RegisterPatient()
    {
        Console.Write("\nWhat's the patient name?: ");
        string name = Console.ReadLine() ?? "";
        while (name == "")
        {
            Console.Write("Name must not be empty: ");
            name = Console.ReadLine() ?? "";
        }

        int age;
        Console.Write("\nWhat's the patient age?: ");
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 100)
        {
            Console.Write("Age must be a number, higher than 0 and less than 100: ");
        }
        
        Console.Write("\nWhat are the symptoms?: ");
        string symptoms = Console.ReadLine() ?? "";
        while (symptoms == "")
        {
            Console.Write("Name must not be empty: ");
            symptoms = Console.ReadLine() ?? "";
        }
        
        _patients.Add(new Patient(_currentId++, name, age, symptoms));
        Console.WriteLine("\n ========== Patient successfully registered ==========");
    }

    public void ListPatients()
    {
        if (_patients.Count == 0)
        {
            Console.WriteLine("There are no registered patients");
            return;
        }
        
        Console.WriteLine("============ All Patients ============");
        foreach (var patient in _patients)
        {
            Console.WriteLine(@$"
            Name: {patient.Name}
            Age: {patient.Age}
            Symptoms: {patient.Symptom}");
        }
    }

    public void SearchPatient()
    {
        if (_patients.Count == 0)
        {
            Console.WriteLine("There are no registered patients");
            return;
        }
        
        Console.Write("\nWhat's the name of the patient you're looking for?: ");
        string patientName = Console.ReadLine() ?? "";
        while (patientName == "")
        {
            Console.Write("Name must not be empty: ");
            patientName = Console.ReadLine() ?? "";
        }

        foreach (var patient in _patients)
        {
            if (patient.Name.ToLower() == patientName.ToLower())
            {
                Console.WriteLine("============ Patient Found ============");
                Console.WriteLine(@$"
                Name: {patient.Name}
                Age: {patient.Age}
                Symptoms: {patient.Symptom}");
                return;
            }
        }
        
        Console.WriteLine("============ Patient not Found ============");
    }
}