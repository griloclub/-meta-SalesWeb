using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch()
        {
            return View();
        }
        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
