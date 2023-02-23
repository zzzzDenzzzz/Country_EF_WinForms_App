using Country_EF_WinForms_App.Entities;
using System.Data;

namespace Country_EF_WinForms_App.Services
{
    public class TableCreatorService
    {
        public static DataTable CreateCountryTable(List<Country> countries)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название");
            table.Columns.Add("Площадь");
            table.Columns.Add("Население");
            table.Columns.Add("Часть света");

            foreach (var country in countries)
            {
                DataRow row = table.NewRow();
                row[0] = country.Id;
                row[1] = country.Name;
                row[2] = country.Area;
                row[3] = country.Population;
                row[4] = country.PartOfTheWorld.GetEnumDescription();
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable CreateCityTable(List<City> cities)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название");
            table.Columns.Add("Население");
            table.Columns.Add("Страна");

            foreach (var city in cities)
            {
                DataRow row = table.NewRow();
                row[0] = city.Id;
                row[1] = city.Name;
                row[2] = city.Population;
                row[3] = city.Country.Name.ToString();
                table.Rows.Add(row);
            }
            return table;
        }

        public static void ShowTable(DataGridView grid, DataTable table)
        {
            grid.DataSource = null;
            grid.DataSource = table;
            grid.Columns[0].Visible = false;
        }
    }
}
