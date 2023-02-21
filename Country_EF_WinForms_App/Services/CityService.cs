using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Contexts;
using Country_EF_WinForms_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Country_EF_WinForms_App.Services
{
    public class CityService
    {
        readonly CountryContext _context;

        public CityService()
        {
            _context = new();
        }

        public async Task<List<City>> GetCitiesAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task AddCityAsync(string name, decimal population, int countryId)
        {
            var city = new City
            {
                Name = name,
                Population = population,
                CountryId = countryId
            };

            await _context.AddAsync(city);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCityAsync(City city, string newName, decimal newPopulation, int newCountryId)
        {
            city.Name = newName;
            city.Population = newPopulation;
            city.CountryId = newCountryId;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCityAsync(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city != null)
            {
                if (city.Country != null)
                {
                    throw new Exception(DefaultDB.DELETION_IS_NOT_POSSIBLE);
                }
                _context.Cities.Remove(city);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DefaultDB.OBJECT_TO_DELETE_NOT_FOUND);
            }
        }

        public async Task<List<KeyValuePair<string, int>>> GetCityPairsAsync()
        {
            return await _context.Cities
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }

        public async Task<City?> GetCityByIdAsync(int id)
        {
            return await _context.Cities.FindAsync(id);
        }
    }
}
