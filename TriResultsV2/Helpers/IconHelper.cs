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
        Diary,
        Gear,
        Info,
        Menu,
        MenuClose,
        MultiSport,
        PersonalBest,
        Result,
        Run,
        Swim,
        Stopwatch,
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
        public static string GetIconClass(NamedIcon icon, IconOption option = IconOption.Solid)
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
                case NamedIcon.Diary: return $"{faClass} fa-calendar-alt";
                case NamedIcon.Gear: return $"{faClass} fa-cog";
                case NamedIcon.Info: return $"{faClass} fa-info-circle";
                case NamedIcon.Menu: return $"{faClass} fa-bars";
                case NamedIcon.MenuClose: return $"{faClass} fa-times-circle";
                case NamedIcon.MultiSport: return $"{faClass} fa-random";
                case NamedIcon.PersonalBest: return $"{faClass} fa-medal";
                case NamedIcon.Result: return $"{faClass} fa-clipboard-list";
                case NamedIcon.Run: return $"{faClass} fa-running";
                case NamedIcon.Stopwatch: return $"{faClass} fa-stopwatch";
                case NamedIcon.Swim: return $"{faClass} fa-swimmer";
                case NamedIcon.Wind: return $"{faClass} fa-wind";
            }

            return string.Empty;
        }
    }
}
