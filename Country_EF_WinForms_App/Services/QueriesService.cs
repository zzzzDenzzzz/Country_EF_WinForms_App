using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Country_EF_WinForms_App.Services
{
    public class QueriesService
    {
        readonly CountryContext _context;

        public QueriesService()
        {
            _context = new();
        }

        // отобразить названия столиц
        public async Task<List<string>> GetCapital()
        {
            return await _context.Cities
                .Where(c => c.IsCapital == true)
                .Select(c => c.Name)
                .ToListAsync();
        }

        // отобразить названия крупных городов конкрктной страны
        public async Task<List<string>> GetCitySetCountry(int countryId)
        {
            return await _context.Countries
                .Where(c => c.Id == countryId)
                .Select(c => c.Name)
                .ToListAsync();
        }

        // отобразить название столиц с количеством жителей больше 5 млн.
        public async Task<List<string>> GetCapitalSetPopulation(decimal population = 5000000)
        {
            return await _context.Cities
                .Where(c => c.IsCapital == true && c.Population > population)
                .Select(c => c.Name)
                .ToListAsync();
        }

        // отобразить названия всех европейских стран
        public async Task<List<string>> GetEuropianCountries()
        {
            return await _context.Countries
                .Where(c => c.PartOfTheWorld == PartsOfTheWorld.EUROPA)
                .Select(c => c.Name)
                .ToListAsync();
        }

        // отобразить названия стран c площадью большей конкретного числа
        public async Task<List<string>> GetCountriesSetArea(decimal area)
        {
            return await _context.Countries
                .Where(c => c.Area > area)
                .Select(c => c.Name)
                .ToListAsync();
        }
    }
}
