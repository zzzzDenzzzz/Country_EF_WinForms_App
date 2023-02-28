using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Forms;

namespace Country_EF_WinForms_App.Services
{
    public static class FormHelperService
    {
        public static void CreateForm(MethodKeys key, object sender)
        {
            var form = new QueryForm(key);
            var button = sender as Button;
            form.Text = button?.Text;
            form.ShowDialog();
        }
    }
}
