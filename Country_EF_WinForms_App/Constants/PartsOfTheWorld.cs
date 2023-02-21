using System.ComponentModel;

namespace Country_EF_WinForms_App.Constants
{
    public enum PartsOfTheWorld
    {
        [Description("Азия")]
        ASIA = 1,
        [Description("Африка")]
        AFRICA,
        [Description("Европа")]
        EUROPA,
        [Description("Северная Америка")]
        NORTH_AMERICA,
        [Description("Южная Америка")]
        SOUTH_AMERICA,
        [Description("Австралия")]
        AUSTRALIA,
    }
}
