using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Forms;
using Country_EF_WinForms_App.Forms.CityForms;
using Country_EF_WinForms_App.Forms.CountryForms;
using Country_EF_WinForms_App.Services;

namespace Country_EF_WinForms_App
{
    public partial class MainForm : Form
    {
        CountryService _countryService = null!;

        CityService _cityService = null!;

        readonly Dictionary<int, Action> LoadTabsMethod;

        public MainForm()
        {
            InitializeComponent();
            
            LoadTabsMethod = new()
            {
                {0, LoadTabPageCountriesAsync },
                {1, LoadTabPageCitiesAsync },
                {2, LoadTabPageQueries },
            };
        }

        #region [MainForm_Load]

        void MainForm_Load(object sender, EventArgs e)
        {
            _countryService = new();
            _cityService = new();
            LoadTabsMethod[tabControlMain.SelectedIndex]();
        }

        #endregion

        #region [CRUD Countries]

        async void LoadTabPageCountriesAsync()
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
                LoadTabPageCountriesAsync();
            }
        }

        async void BtnUpdateCountry_Click(object sender, EventArgs e)
        {
            if (gridCountries.SelectedRows.Count > 0)
            {
                var countryId = int.Parse(gridCountries.SelectedRows[0].Cells[0].Value.ToString()!);
                var country = await _countryService.GetCountryByIdAsync(countryId);

                if (country == null)
                {
                    MessageBox.Show(DefaultDB.OBJECT_NOT_FOUND);
                    LoadTabPageCountriesAsync();
                    return;
                }

                try
                {
                    var form = new UpdateCountryForm(country.Name, country.Area, country.Population, country.PartOfTheWorld);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        await _countryService.UpdateCountryAsync(country, form.CountryName, form.Area, form.PopulationCountry, form.PartOfTheWorld);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadTabPageCountriesAsync();
                }
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
                    LoadTabPageCountriesAsync();
                }
            }
            else
            {
                MessageBox.Show(DefaultDB.OBJECT_NOT_FOUND);
            }
        }

        #endregion

        #region [CRUD Cities]

        async void LoadTabPageCitiesAsync()
        {
            TableCreatorService.ShowTable(
                gridCities,
                TableCreatorService.CreateCityTable(await _cityService.GetCitiesAsync()));
        }

        async void BtnCreateCity_Click(object sender, EventArgs e)
        {
            var pairs = await _cityService.GetCountryPairsAsync();
            var form = new AddCityForm(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _cityService.AddCityAsync(form.CityName, form.CityPopulation, form.CountryId, form.IsCapital);
                LoadTabPageCitiesAsync();
            }
        }

        async void BtnUpdateCity_Click(object sender, EventArgs e)
        {
            if (gridCities.SelectedRows.Count > 0)
            {
                var cityId = int.Parse(gridCities.SelectedRows[0].Cells[0].Value.ToString()!);
                var city = await _cityService.GetCityByIdAsync(cityId);
                if (city == null)
                {
                    MessageBox.Show(DefaultDB.OBJECT_NOT_FOUND);
                    LoadTabPageCitiesAsync();
                    return;
                }

                try
                {
                    var pairs = await _cityService.GetCountryPairsAsync();
                    var form = new UpdateCityForm(pairs, city.Name, city.Population, city.IsCapital, city.CountryId);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        await _cityService.UpdateCityAsync(city, form.CityName, form.CityPopulation, form.CountryId, form.IsCapital);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadTabPageCitiesAsync();
                }
            }
        }

        async void BtnDeleteCity_Click(object sender, EventArgs e)
        {
            if (gridCities.SelectedRows.Count > 0)
            {
                var cityId = int.Parse(gridCities.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _cityService.DeleteCityAsync(cityId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadTabPageCitiesAsync();
                }
            }
            else
            {
                MessageBox.Show(DefaultDB.OBJECT_NOT_FOUND);
            }
        }

        #endregion

        #region [Queries]

        void LoadTabPageQueries()
        {

        }

        void BtnGetCapital_Click(object sender, EventArgs e)
        {
            int key = 0;
            var form = new QueryForm(key);
            var s = sender as Button;
            form.Text = s.Text;
            form.ShowDialog();
        }

        #endregion
    }
}