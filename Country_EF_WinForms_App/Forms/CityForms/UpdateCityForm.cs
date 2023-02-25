using Country_EF_WinForms_App.Constants;
using System.ComponentModel;

namespace Country_EF_WinForms_App.Forms.CityForms
{
    public partial class UpdateCityForm : Form
    {
        public string CityName => txtName.Text.Trim();

        public decimal CityPopulation => numericPopulation.Value;

        public int CountryId => (int)comboBoxCountry.SelectedValue!;

        public bool IsCapital
        {
            get
            {
                if (radioBtnNo.Checked)
                {
                    return false;
                }
                return true;
            }
            set
            {
                if (value == true)
                {
                    radioBtnYes.Checked = true;
                }
                else
                {
                    radioBtnNo.Checked = true;
                }
            }
        }

        public UpdateCityForm(List<KeyValuePair<string, int>> countries, string name, decimal population, bool isCapital, int countryId)
        {
            InitializeComponent();
            txtName.Text = name;
            numericPopulation.Value = population;
            IsCapital = isCapital;
            PopulateComboBox(countries, countryId);
        }

        void PopulateComboBox(List<KeyValuePair<string, int>> countries, int countryId = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };
            pairs.AddRange(countries);

            comboBoxCountry.DisplayMember = "Key";
            comboBoxCountry.ValueMember = "Value";
            comboBoxCountry.DataSource = pairs;
            comboBoxCountry.SelectedItem = pairs.First(x => x.Value == countryId);
        }

        void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length > DefaultDB.STRING_VALUE_MAX_LENGTH)
            {
                errorName.SetError(txtName, DefaultDB.NAME_TOO_LONG);
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorName.SetError(txtName, DefaultDB.NAME_CANNOT_BE_EMPTY);
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtName, string.Empty);
                e.Cancel = false;
            }
        }

        void NumericPopulation_Validating(object sender, CancelEventArgs e)
        {
            if (numericPopulation.Value <= 0)
            {
                errorPopulation.SetError(numericPopulation, DefaultDB.VALUE_IS_NULL);
                e.Cancel = true;
            }
            else
            {
                errorPopulation.SetError(numericPopulation, string.Empty);
                e.Cancel = false;
            }
        }

        void ComboBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxCountry.SelectedValue! == 0)
            {
                errorCountry.SetError(comboBoxCountry, DefaultDB.VALUE_IS_NULL);
                e.Cancel = true;
            }
            else
            {
                errorCountry.SetError(comboBoxCountry, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
