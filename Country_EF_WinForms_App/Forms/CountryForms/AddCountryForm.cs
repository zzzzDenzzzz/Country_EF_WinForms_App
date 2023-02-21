using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Services;
using System.ComponentModel;

namespace Country_EF_WinForms_App.Forms.CountryForms
{
    public partial class AddCountryForm : Form
    {
        public string CountryName => txtCountryName.Text.Trim();

        public decimal Area => numericArea.Value;

        public decimal PopulationCountry => numericPopulationCountry.Value;

        public PartsOfTheWorld PartOfTheWorld => (PartsOfTheWorld)comboBoxPartOfTheWorld.SelectedValue!;

        public AddCountryForm()
        {
            InitializeComponent();
            GetDescriptionPartOfTheWorld();
        }

        void GetDescriptionPartOfTheWorld()
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };

            var partOfTheWorld = Enum.GetValues<PartsOfTheWorld>();
            pairs.AddRange(partOfTheWorld.Select(e => new KeyValuePair<string, int>(e.GetEnumDescription(), (int)e)));

            comboBoxPartOfTheWorld.DisplayMember = "Key";
            comboBoxPartOfTheWorld.ValueMember = "Value";
            comboBoxPartOfTheWorld.DataSource = pairs;
        }

        void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        void TxtCountryName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCountryName.Text.Trim().Length > DefaultDB.STRING_VALUE_MAX_LENGTH)
            {
                errorName.SetError(txtCountryName, DefaultDB.NAME_TOO_LONG);
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(txtCountryName.Text.Trim()))
            {
                errorName.SetError(txtCountryName, DefaultDB.NAME_CANNOT_BE_EMPTY);
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtCountryName, string.Empty);
                e.Cancel = false;
            }
        }

        void NumericArea_Validating(object sender, CancelEventArgs e)
        {
            if (numericArea.Value <= 0)
            {
                errorArea.SetError(numericArea, DefaultDB.VALUE_IS_NULL);
                e.Cancel = true;
            }
            else
            {
                errorArea.SetError(numericArea, string.Empty);
                e.Cancel = false;
            }
        }

        void NumericPopulationCountry_Validating(object sender, CancelEventArgs e)
        {
            if (numericPopulationCountry.Value <= 0)
            {
                errorArea.SetError(numericPopulationCountry, DefaultDB.VALUE_IS_NULL);
                e.Cancel = true;
            }
            else
            {
                errorArea.SetError(numericPopulationCountry, string.Empty);
                e.Cancel = false;
            }
        }

        void ComboBoxPartOfTheWorld_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxPartOfTheWorld.SelectedValue! == 0)
            {
                errorPartOfTheWorld.SetError(comboBoxPartOfTheWorld, DefaultDB.VALUE_IS_NULL);
                e.Cancel = true;
            }
            else
            {
                errorPartOfTheWorld.SetError(comboBoxPartOfTheWorld, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
