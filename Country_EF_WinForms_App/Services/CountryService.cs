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
    }
}
