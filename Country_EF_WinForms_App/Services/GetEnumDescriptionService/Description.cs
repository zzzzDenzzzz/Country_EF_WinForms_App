using System.ComponentModel;

namespace Country_EF_WinForms_App.Services.GetEnumDescriptionService
{
    public static class Description
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (field != null)
            {
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    return attribute.Description;
                }
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }
    }
}
