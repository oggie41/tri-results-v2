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
        Duathlon,
        Edit,
        Garmin,
        Gear,
        Improvement,
        Info,
        IntervalsIcu,
        Link,
        Menu,
        MenuClose,
        Percent,
        PersonalBest,
        Power,
        Rain,
        Result,
        Run,
        Speed,
        Stopwatch,
        Sun,
        Swim,
        Transition,
        Triathlon,
        Wind
    }

    public enum IconOption
    {
        DuoTone,
        Light,
        Regular,
        Solid,
        Thin
    }

    public static class IconHelper
    {
        public static string GetIconClass(NamedIcon icon, IconOption option = IconOption.Regular)
        {
            string faClass = "fa-regular";

            switch (option)
            {
                case IconOption.DuoTone:
                    faClass = "fa-duotone";
                    break;

                case IconOption.Light:
                    faClass = "fa-light";
                    break;

                case IconOption.Regular:
                    faClass = "fa-regular";
                    break;

                case IconOption.Solid:
                    faClass = "fa-solid";
                    break;

                case IconOption.Thin:
                    faClass = "fa-thin";
                    break;
            }

            switch (icon)
            {
                case NamedIcon.None: return string.Empty;
                case NamedIcon.Bike: return $"{faClass} fa-biking";
                case NamedIcon.Cloud: return $"{faClass} fa-cloud";
                case NamedIcon.CloudSun: return $"{faClass} fa-cloud-sun";
                case NamedIcon.Diary: return $"{faClass} fa-calendar-alt";
                case NamedIcon.Duathlon: return $"{faClass} fa-diagram-nested";
                case NamedIcon.Edit: return $"{faClass} fa-edit";
                case NamedIcon.Garmin: return $"{faClass} fa-triangle";
                case NamedIcon.Gear: return $"{faClass} fa-cog";
                case NamedIcon.Improvement: return $"{faClass} fa-chart-line";
                case NamedIcon.Info: return $"{faClass} fa-info-circle";
                case NamedIcon.IntervalsIcu: return $"{faClass} fa-wave-pulse";
                case NamedIcon.Link: return $"{faClass} fa-link";
                case NamedIcon.Menu: return $"{faClass} fa-bars";
                case NamedIcon.MenuClose: return $"{faClass} fa-times-circle";
                case NamedIcon.Percent: return $"{faClass} fa-percent";
                case NamedIcon.PersonalBest: return $"{faClass} fa-medal";
                case NamedIcon.Power: return $"{faClass} fa-bolt";
                case NamedIcon.Rain: return $"{faClass} fa-cloud-rain";
                case NamedIcon.Result: return $"{faClass} fa-clipboard-list";
                case NamedIcon.Run: return $"{faClass} fa-running";
                case NamedIcon.Speed: return $"{faClass} fa-tachometer-alt";
                case NamedIcon.Stopwatch: return $"{faClass} fa-stopwatch";
                case NamedIcon.Sun: return $"{faClass} fa-sun";
                case NamedIcon.Swim: return $"{faClass} fa-swimmer";
                case NamedIcon.Transition: return $"{faClass} fa-chevron-double-right";
                case NamedIcon.Triathlon: return $"{faClass} fa-project-diagram";
                case NamedIcon.Wind: return $"{faClass} fa-wind";
            }

            return string.Empty;
        }
    }
}
