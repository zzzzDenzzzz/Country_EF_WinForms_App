namespace Country_EF_WinForms_App.Services
{
    public static class MessageBoxService
    {
        public static void Show(string text, object sender)
        {
            if (sender is not Button button)
            {
                return;
            }
            MessageBox.Show(text, button.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
