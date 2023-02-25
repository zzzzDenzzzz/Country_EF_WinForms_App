namespace Country_EF_WinForms_App.Entities
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Population { get; set; }

        public int CountryId { get; set; }

        public bool IsCapital { get; set; }

        public virtual Country Country { get; set; } = null!;
    }
}
