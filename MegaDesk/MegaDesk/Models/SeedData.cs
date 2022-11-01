using MegaDesk.Data;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskContext(serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskContext>>()))
            {
                if (context == null || context.DeskQuote == null)
                {
                    throw new InvalidOperationException("Null DeskQuoteContext");
                }

                // Look for any desk quotes
                if (context.DeskQuote.Any())
                {
                    return;
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        QuoteDate = DateTime.Now,
                        CustomerName = "Jane Doe",
                        Width = 24,
                        Depth = 12,
                        NumOfDrawers = 1,
                        SurfaceMaterial = "Laminate",
                        ProductionTime = 3,
                        Area = 288,
                        QuoteTotal = 410
                    }
                    );
            }
        }
    }
}
