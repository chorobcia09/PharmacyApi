public class Medication
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ActiveSubstance { get; set; } = string.Empty;

    public decimal DoseMg { get; set; }

    public bool PrescriptionRequired { get; set; }

    public string Manufacturer { get; set; } = string.Empty;
}
