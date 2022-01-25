using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TriResultsV2.Helpers
{
    public static class CommonHelper
    {
        public static string ToEnumDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                ?.GetName();
        }

        public static string ToYesNoString(this bool value)
        {
            return value ? "Yes" : "No";
        }

        public static string ToColouredYesNoHtml(this bool value)
        {
            return value ? "<span class=\"text-success\">Yes</span>" : "<span class=\"text-danger\">No</span>";
        }
    }
}
