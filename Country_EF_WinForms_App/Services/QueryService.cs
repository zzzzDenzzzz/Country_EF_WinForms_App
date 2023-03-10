using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Contexts;
using Country_EF_WinForms_App.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Country_EF_WinForms_App.Services
{
    public class QueryService
    {
        readonly CountryContext _context;

        public QueryService()
        {
            _context = new();
        }

        // отобразить названия столиц
        public async Task<List<City>> GetCapitalsAsync()
        {
            return await _context.Cities
                .Where(c => c.IsCapital == true)
                .ToListAsync();
        }

        // отобразить название столиц с количеством жителей больше 5 млн.
        public async Task<List<City>> GetCapitalsSetPopulationAsync(decimal population = 5000000)
        {
            return await _context.Cities
                .Where(c => c.IsCapital == true && c.Population > population)
                .ToListAsync();
        }

        // отобразить названия всех европейских стран
        public async Task<List<Country>> GetEuropianCountriesAsync()
        {
            return await _context.Countries
                .Where(c => c.PartOfTheWorld == PartsOfTheWorld.EUROPA)
                .ToListAsync();
        }

        // отобразить все столицы, у которых в названии есть буквы а, р
        public async Task<List<City>> GetCapitalContainsLetterAsync(char a = 'а', char r = 'р')
        {
            var city = await _context.Cities
                .Where(c => c.IsCapital == true)
                .ToListAsync();

            var cityIsLetter = city
                .Where(c => c.Name.ToLower().Contains(a) && c.Name.ToLower().Contains(r))
                .ToList();

            return cityIsLetter;
        }

        // отобразить все столицы, у которых название начинается с буквы к
        public async Task<List<City>> GetCapitalStartWithLetterAsync(char k = 'к')
        {
            var city = await _context.Cities
                .Where(c => c.IsCapital == true)
                .ToListAsync();

            var cityIsLetter = city
                .Where(c => c.Name.ToLower().StartsWith(k))
                .ToList();

            return cityIsLetter;
        }

        // отобразить название стран, у которых площадь находится в указанном диапазоне
        public async Task<List<Country>> GetCountriesSetAreaAsync(decimal areaMin, decimal areaMax)
        {
            decimal min, max = 0;

            max = (areaMax > areaMin) ? areaMax : areaMin;
            min = (areaMin < areaMax) ? areaMin : areaMax;

            return await _context.Countries
                .Where(c => c.Area >= min && c.Area <= max)
                .ToListAsync();
        }

        // отобразить название стран, у которых количество жителей больше указанного числа
        public async Task<List<Country>> GetCountrySetPopulationAsync(decimal population)
        {
            return await _context.Countries
                .Where(c => c.Population > population)
                .ToListAsync();
        }

        // показать топ-5 стран по площади
        public async Task<List<Country>> GetCountryTopAreaAsync(int top = 5)
        {
            return await _context.Countries
                .OrderByDescending(c => c.Area)
                .Take(top)
                .ToListAsync();
        }

        // показать топ-5 столиц по количеству жителей
        public async Task<List<City>> GetCapitalTopPopulationAsync(int top = 5)
        {
            return await _context.Cities
                .Where(c => c.IsCapital == true)
                .OrderByDescending(c => c.Population)
                .Take(top)
                .ToListAsync();
        }

        // показать страну с самой большой площадью
        public async Task<Country> GetCountryLargestAreaAsync()
        {
            return await _context.Countries
                .OrderByDescending(c => c.Area)
                .FirstAsync();
        }

        // показать столицу с самым большим количеством жителей
        public async Task<City> GetCapitalLargestPopulationAsync()
        {
            return await _context.Cities
                .Where(c => c.IsCapital == true)
                .OrderByDescending(c => c.Population)
                .FirstAsync();
        }

        // показать страну с самой маленькой площадью в Европе
        public async Task<Country> GetCountrySmallestAreaEuropaAsync()
        {
            return await _context.Countries
                .Where(c => c.PartOfTheWorld == PartsOfTheWorld.EUROPA)
                .OrderBy(c => c.Area)
                .FirstAsync();
        }

        // показать среднюю площадь стран в Европе
        public async Task<decimal> GetAvgAreaEuropaAsync()
        {
            return await _context.Countries
                .Where(c => c.PartOfTheWorld == PartsOfTheWorld.EUROPA)
                .AverageAsync(c => c.Area);
        }

        // показать общее количество стран
        public async Task<int> GetCountCountriesAsync()
        {
            return await _context.Countries
                .CountAsync();
        }

        // показать часть света с максимальным количеством стран
        public async Task<PartsOfTheWorld> GetPartOfTheWorldWithMaxCountriesAsync()
        {
            return await _context.Countries
                .GroupBy(c => c.PartOfTheWorld)
                .Select(p => new { Name = p.Key, Count = p.Count() })
                .OrderByDescending(c => c.Count)
                .Select(c => c.Name)
                .FirstAsync();
        }

        // показаьть количество стран в каждой части света
        public async Task<List<(PartsOfTheWorld, int)>> GetCountCountriesInPartOfTheWorldAsync()
        {
            var list = await _context.Countries
                .GroupBy(c => c.PartOfTheWorld)
                .Select(p => new { Name = p.Key, Count = p.Count() })
                .ToListAsync();

            return list.Select(r => (r.Name, r.Count)).ToList();
        }
    }
}
