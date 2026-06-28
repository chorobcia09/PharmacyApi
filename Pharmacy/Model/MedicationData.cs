public static class MedicationData
{
    public static List<Medication> Medications =
    [
        new()
        {
            Id = 1,
            Name = "Apap",
            ActiveSubstance = "Paracetamol",
            DoseMg = 500,
            PrescriptionRequired = false,
            Manufacturer = "US Pharmacia"
        },

        new()
        {
            Id = 2,
            Name = "Ibuprom",
            ActiveSubstance = "Ibuprofen",
            DoseMg = 200,
            PrescriptionRequired = false,
            Manufacturer = "US Pharmacia"
        },

        new()
        {
            Id = 3,
            Name = "Ketonal Forte",
            ActiveSubstance = "Ketoprofen",
            DoseMg = 100,
            PrescriptionRequired = true,
            Manufacturer = "Sandoz"
        },

        new()
        {
            Id = 4,
            Name = "Amotaks",
            ActiveSubstance = "Amoxicillin",
            DoseMg = 500,
            PrescriptionRequired = true,
            Manufacturer = "Polfa Tarchomin"
        },

        new()
        {
            Id = 5,
            Name = "No-Spa",
            ActiveSubstance = "Drotaverine",
            DoseMg = 40,
            PrescriptionRequired = false,
            Manufacturer = "Sanofi"
        }
    ];
}
