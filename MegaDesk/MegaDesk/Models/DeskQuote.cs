using MegaDesk.Pages.DeskQuotes;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using MegaDesk.Pages.DeskQuotes;

namespace MegaDesk.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        public string CustomerName { get; set; }

        [Display(Name = "Desk Width")]
        [Range(24, 96)]
        [Required]
        public static int Width { get; set; }

        [Display(Name = "Desk Depth")]
        [Range(12, 48)]
        [Required]
        public static int Depth { get; set; }

        [Display(Name = "Number of Drawers")]
        [Range(0, 7)]
        [Required]
        public int NumOfDrawers { get; set; }

        [Display(Name = "Surface Material")]
        [Required]
        public string SurfaceMaterial { get; set; }

        [Display(Name = "Production Time")]
        [Required]
        public int ProductionTime { get; set; }

        public int Area { get; set; }

        [Display(Name = "Quote Total")]
        public decimal QuoteTotal { get; set; } = TotalOfQuote.OfQuote(Width, Depth);
    }
}
