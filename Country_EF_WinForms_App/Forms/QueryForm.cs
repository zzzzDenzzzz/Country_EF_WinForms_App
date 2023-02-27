using Country_EF_WinForms_App.Services;

namespace Country_EF_WinForms_App.Forms
{
    public partial class QueryForm : Form
    {
        readonly QueryService _queryService;

        public QueryForm(int key)
        {
            InitializeComponent();
            _queryService = new();
            m(key);
        }

        async void Method_1()
        {
            TableCreatorService.ShowTable(
                gridQuery,
                TableCreatorService.CreateCityTable(await _queryService.GetCapitalAsync()));
        }

        void m(int key)
        {
            switch (key)
            {
                case 0:
                    Method_1();
                    break;
                default:
                    break;
            }
        }
    }
}
