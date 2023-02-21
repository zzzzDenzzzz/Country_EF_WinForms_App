using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Forms.CountryForms;
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

        async void LoadCountriesAsync()
        {
            TableCreatorService.ShowTable(
                gridCountries,
                TableCreatorService.CreateCountryTable(await _countryService.GetCountriesAsync()));
        }

        async void BtnCreateCountry_Click(object sender, EventArgs e)
        {
            var form = new AddCountryForm();
            if (form.ShowDialog() == DialogResult.OK )
            {
                await _countryService.AddCountryAsync(form.CountryName, form.Area, form.PopulationCountry, form.PartOfTheWorld);
                LoadCountriesAsync();
            }
        }

        async void BtnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (gridCountries.SelectedRows.Count > 0)
            {
                var countryId = int.Parse(gridCountries.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _countryService.DeleteCountryAsync(countryId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadCountriesAsync();
                }
            }
            else
            {
                MessageBox.Show(DefaultDB.OBJECT_TO_DELETE_NOT_FOUND);
            }
        }

        async void LoadCitiesAsync()
        {
            TableCreatorService.ShowTable(
                gridCities,
                TableCreatorService.CreateCityTable(await _cityService.GetCitiesAsync()));
        }
    }
}