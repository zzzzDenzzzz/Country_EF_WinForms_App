using System.ComponentModel;

namespace Country_EF_WinForms_App.Services
{
    public static class GetEnumDescriptionService
    {
        public static string GetEnumDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    return attributes[0].Description;
                }
            }
            
            return value.ToString();
        }
    }
}
