using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Helpers
{
    public enum NamedIcon
    {
        None,
        Bike,
        Cloud,
        CloudSun,
        Diary,
        Edit,
        Gear,
        Improvement,
        Info,
        Link,
        Menu,
        MenuClose,
        MultiSport,
        Percent,
        PersonalBest,
        Rain,
        Result,
        Run,
        Speed,
        Stopwatch,
        Sun,
        Swim,
        Wind
    }

    public enum IconOption
    {
        DuoTone,
        Light,
        Regular,
        Solid
    }

    public static class IconHelper
    {
        public static string GetIconClass(NamedIcon icon, IconOption option = IconOption.DuoTone)
        {
            string faClass;

            switch (option)
            {
                case IconOption.DuoTone:
                    faClass = "fad";
                    break;

                case IconOption.Light:
                    faClass = "fal";
                    break;

                case IconOption.Regular:
                    faClass = "far";
                    break;

                default:
                    faClass = "fas";
                    break;
            }

            switch (icon)
            {
                case NamedIcon.None: return string.Empty;
                case NamedIcon.Bike: return $"{faClass} fa-biking";
                case NamedIcon.Cloud: return $"{faClass} fa-cloud";
                case NamedIcon.CloudSun: return $"{faClass} fa-cloud-sun";
                case NamedIcon.Diary: return $"{faClass} fa-calendar-alt";
                case NamedIcon.Edit: return $"{faClass} fa-calendar-alt";
                case NamedIcon.Gear: return $"{faClass} fa-cog";
                case NamedIcon.Improvement: return $"{faClass} fa-chart-line";
                case NamedIcon.Info: return $"{faClass} fa-info-circle";
                case NamedIcon.Link: return $"{faClass} fa-link";
                case NamedIcon.Menu: return $"{faClass} fa-bars";
                case NamedIcon.MenuClose: return $"{faClass} fa-times-circle";
                case NamedIcon.MultiSport: return $"{faClass} fa-random";
                case NamedIcon.Percent: return $"{faClass} fa-percent";
                case NamedIcon.PersonalBest: return $"{faClass} fa-medal";
                case NamedIcon.Rain: return $"{faClass} fa-cloud-rain";
                case NamedIcon.Result: return $"{faClass} fa-clipboard-list";
                case NamedIcon.Run: return $"{faClass} fa-running";
                case NamedIcon.Speed: return $"{faClass} fa-tachometer-alt";
                case NamedIcon.Stopwatch: return $"{faClass} fa-stopwatch";
                case NamedIcon.Sun: return $"{faClass} fa-sun";
                case NamedIcon.Swim: return $"{faClass} fa-swimmer";
                case NamedIcon.Wind: return $"{faClass} fa-wind";
            }

            return string.Empty;
        }
    }
}
