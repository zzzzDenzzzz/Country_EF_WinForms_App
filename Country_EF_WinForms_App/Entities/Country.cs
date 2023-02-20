using Country_EF_WinForms_App.Constants;

namespace Country_EF_WinForms_App.Entities
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Area { get; set; }

        public decimal Population { get; set; }

        public int CapitalId { get; set; }

        public PartsOfTheWorld PartOfTheWorld { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
