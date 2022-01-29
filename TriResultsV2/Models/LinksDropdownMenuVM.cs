namespace TriResultsV2.Models
{
    public class LinksDropdownMenuVM
    {
        public EventResult EventResult { get; set; }

        public int PaddingX { get; set; } = 0;

        public int PaddingY { get; set; } = 0;

        public bool ShowExtendedText { get; set; } = true;
        
        public bool HideTextForMobile { get; set; } = false;
    }
}
