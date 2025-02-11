using Coffer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffer.Controllers
{
    public class CofferController : Controller
    {
        private readonly CofferDBContext _context;

        public CofferController(CofferDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Group data by sector and count occurrences
            var sectorData = _context.Coffers
                .Where(c => !string.IsNullOrEmpty(c.sector)) // Avoid null values
                .GroupBy(c => c.sector)
                .Select(g => new
                {
                    Label = g.Key,   // Sector name
                    Value = g.Count() // Count of records
                })
                .OrderByDescending(d => d.Value) // Sort by highest count
                .ToList();

            // Pass data to View using ViewBag
            ViewBag.SectorLabels = sectorData.Select(d => d.Label).ToArray();
            ViewBag.SectorValues = sectorData.Select(d => d.Value).ToArray();

            // Also pass full table data to the view
            ViewBag.TableData = _context.Coffers.ToList();

            return View();
        }
    }
}
