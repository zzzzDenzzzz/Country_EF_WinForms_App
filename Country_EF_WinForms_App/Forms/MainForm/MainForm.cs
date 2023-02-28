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

        QueryService _queryService = null!;

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
            _queryService = new();
            numericMaxArea.Value = 0;
            numericMinArea.Value = 0;
            numericMinPopulation.Value = 0;
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

            var pairs = await _cityService.GetCountryPairsAsync();
            _cityService.PopulateComboBox(comboBoxContries, pairs);
        }

        async void LoadTabPageCitiesAsync(int countryId)
        {
            TableCreatorService.ShowTable(
                gridCities,
                TableCreatorService.CreateCityTable(await _cityService.GetCitiesAsync(countryId)));
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


        void ComboBoxContries_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabPageCitiesAsync((int)comboBoxContries.SelectedValue!);
        }

        async void BtnShowArea_Click(object sender, EventArgs e)
        {
            if (numericMinArea.Value == numericMaxArea.Value)
            {
                LoadTabPageCountriesAsync();
                return;
            }
            TableCreatorService.ShowTable(
                gridCountries,
                TableCreatorService.CreateCountryTable(await _queryService
                .GetCountriesSetAreaAsync(numericMinArea.Value, numericMaxArea.Value)));
        }

        async void BtnShowPopulation_Click(object sender, EventArgs e)
        {
            TableCreatorService.ShowTable(
                gridCountries,
                TableCreatorService.CreateCountryTable(await _queryService
                .GetCountrySetPopulationAsync(numericMinPopulation.Value)));
        }

        async void BtnGetAvgAreaEuropa_Click(object sender, EventArgs e)
        {
            var avgArea = await _queryService.GetAvgAreaEuropaAsync();
            MessageBoxService.Show(avgArea.ToString(), sender);
        }

        async void BtnGetCountCountries_Click(object sender, EventArgs e)
        {
            var count = await _queryService.GetCountCountriesAsync();
            MessageBoxService.Show(count.ToString(), sender);
        }

        async void BtnGetPartOfTheWorldWithMaxCountries_Click(object sender, EventArgs e)
        {
            var max = await _queryService.GetPartOfTheWorldWithMaxCountriesAsync();
            MessageBoxService.Show(max.GetEnumDescription(), sender);
        }

        async void BtnGetCountCountriesInPartOfTheWorld_Click(object sender, EventArgs e)
        {
            var count = await _queryService.GetCountCountriesInPartOfTheWorldAsync();
            if (count != null)
            {
                string text = string.Empty;
                foreach (var item in count)
                {
                    text += (item.Item1.GetEnumDescription() + " = " + item.Item2 + Environment.NewLine);
                }
                MessageBoxService.Show(text, sender);
            }
        }

        void BtnGetCapital_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCapitals, sender);
        }

        void BtnGetCapitalsSetPopulation_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCapitalsSetPopulation, sender);
        }

        void BtnGetEuropianCountries_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetEuropianCountries, sender);
        }

        void BtnGetCapitalContainsLetter_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCapitalContainsLetter, sender);
        }

        void BtnGetCapitalStartWithLetter_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCapitalStartWithLetter, sender);
        }

        void BtnGetCountryTopArea_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCountryTopArea, sender);
        }

        void BtnGetCapitalTopPopulation_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCapitalTopPopulation, sender);
        }

        void BtnGetCountryLargestArea_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCountryLargestArea, sender);
        }

        void BtnGetCapitalLargestPopulation_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCapitalLargestPopulation, sender);
        }

        void BtnGetCountrySmallestAreaEuropa_Click(object sender, EventArgs e)
        {
            FormHelperService.CreateForm(MethodKeys.GetCountrySmallestAreaEuropa, sender);
        }

        #endregion

    }
}