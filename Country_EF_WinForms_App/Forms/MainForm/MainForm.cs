using Country_EF_WinForms_App.Services;

namespace Country_EF_WinForms_App
{
    public partial class MainForm : Form
    {
        readonly CountryService _countryService;

        readonly CityService _cityService;

        readonly Dictionary<int, Action> LoadTabsMethod;

        public MainForm()
        {
            InitializeComponent();
            _countryService = new();
            _cityService = new();
            LoadTabsMethod = new()
            {
                {0, LoadCountriesAsync },
                {1, LoadCitiesAsync },
            };
        }

        #region [MainForm_Load, TabControlMain_SelectedIndexChanged]

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabsMethod[0]();
        }

        void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabsMethod[tabControlMain.SelectedIndex]();
        }

        #endregion

        void BtnCreateCountry_Click(object sender, EventArgs e)
        {

        }

        async void LoadCountriesAsync()
        {
            TableCreatorService.ShowTable(
                gridCountries,
                TableCreatorService.CreateCountryTable(await _countryService.GetCountriesAsync()));
        }

        async void LoadCitiesAsync()
        {
            TableCreatorService.ShowTable(
                gridCities,
                TableCreatorService.CreateCityTable(await _cityService.GetCitiesAsync()));
        }
    }
}