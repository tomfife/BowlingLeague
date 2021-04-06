using System;
namespace BowlingLeague.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalNumItems { get; set; }

        // Calculate the number of pages

        public int NumPages => (int)(Math.Ceiling((decimal)TotalNumItems / NumItemsPerPage));
    }
}
