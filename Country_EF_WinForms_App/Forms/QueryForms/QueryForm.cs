using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Services;

namespace Country_EF_WinForms_App.Forms
{
    public partial class QueryForm : Form
    {
        readonly QueryService _queryService;

        readonly Dictionary<Enum, Action> LoadMethod;

        public QueryForm(MethodKeys key)
        {
            InitializeComponent();
            _queryService = new();
            LoadMethod = new()
            {
                { MethodKeys.GetCapitals, GetCapitalsAsync },
                { MethodKeys.GetCapitalsSetPopulation, GetCapitalsSetPopulation },
                { MethodKeys.GetEuropianCountries, GetEuropianCountries },
                { MethodKeys.GetCapitalContainsLetter, GetCapitalContainsLetter },
                { MethodKeys.GetCapitalStartWithLetter, GetCapitalStartWithLetter },
                { MethodKeys.GetCountryTopArea, GetCountryTopArea },
                { MethodKeys.GetCapitalTopPopulation, GetCapitalTopPopulation },
                { MethodKeys.GetCountryLargestArea, GetCountryLargestArea },
                { MethodKeys.GetCapitalLargestPopulation, GetCapitalLargestPopulation },
                { MethodKeys.GetCountrySmallestAreaEuropa, GetCountrySmallestAreaEuropa },
            };
            LoadMethod[key]();
        }

        async void GetCapitalsAsync()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalsAsync()));
        }

        async void GetCapitalsSetPopulation()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalsSetPopulationAsync()));
        }

        async void GetEuropianCountries()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCountryTable(await _queryService.GetEuropianCountriesAsync()));
        }

        async void GetCapitalContainsLetter()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalContainsLetterAsync()));
        }

        async void GetCapitalStartWithLetter()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalStartWithLetterAsync()));
        }

        async void GetCountryTopArea()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCountryTable(await _queryService.GetCountryTopAreaAsync()));
        }

        async void GetCapitalTopPopulation()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalTopPopulationAsync()));
        }

        async void GetCountryLargestArea()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCountryTable(await _queryService.GetCountryLargestAreaAsync()));
        }

        async void GetCapitalLargestPopulation()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalLargestPopulationAsync()));
        }

        async void GetCountrySmallestAreaEuropa()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCountryTable(await _queryService.GetCountrySmallestAreaEuropaAsync()));
        }
    }
}
