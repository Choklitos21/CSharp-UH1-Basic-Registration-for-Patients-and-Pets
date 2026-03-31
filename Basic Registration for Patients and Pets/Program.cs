using Basic_Registration_for_Patients_and_Pets.Services;

PatientService service = new PatientService();

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