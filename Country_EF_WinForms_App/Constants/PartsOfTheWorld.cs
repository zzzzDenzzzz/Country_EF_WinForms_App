using System.ComponentModel;

namespace Country_EF_WinForms_App.Constants
{
    public enum PartsOfTheWorld
    {
        [Description("Азия")]
        Asia = 1,
        [Description("Африка")]
        Africa,
        [Description("Европа")]
        Europa,
        [Description("Северная Америка")]
        North_America,
        [Description("Южная Америка")]
        South_America,
        [Description("Австралия")]
        Australia,
    }
}
