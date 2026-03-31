namespace Basic_Registration_for_Patients_and_Pets.Models;

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