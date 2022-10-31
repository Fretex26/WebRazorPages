using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MegaDesk.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Entry Date")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        public string CustomerName { get; set; }

        [Display(Name = "Surface Material")]
        [Required]
        public string SurfaceMaterial { get; set; }

        [Display(Name = "Number of Drawers")]
        [Required]
        public int NumOfDrawers { get; set; }

        [Display(Name = "Desk Width")]
        [Required]
        public int Width { get; set; }

        [Display(Name = "Desk Depth")]
        [Required]
        public int Depth { get; set; }

        [Display(Name = "Rush Order Needed")]
        [Required]
        public int RushDays { get; set; }
    }
}
