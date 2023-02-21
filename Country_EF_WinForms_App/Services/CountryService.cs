using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Contexts;
using Country_EF_WinForms_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Country_EF_WinForms_App.Services
{
    public class CountryService
    {
        readonly CountryContext _context;

        public CountryService()
        {
            _context = new();
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task AddCountryAsync(string name, decimal area, decimal population, PartsOfTheWorld partOfTheWorld)
        {
            var country = new Country
            {
                Name = name,
                Area = area,
                Population = population,
                PartOfTheWorld = partOfTheWorld
            };

            await _context.AddAsync(country);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCountryAsync(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country != null)
            {
                if (country.Cities != null && country.Cities.Any())
                {
                    throw new Exception(DefaultDB.DELETION_IS_NOT_POSSIBLE);
                }

                _context.Remove(country);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DefaultDB.OBJECT_TO_DELETE_NOT_FOUND);
            }
        }
    }
}
