using System.Threading.Tasks;
using ComicStore.Catalog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComicStore.WebApp.MVC.Controllers
{
    [Route("catalog")]
    public class CatalogController : Controller
    {
        private readonly CatalogDbContext _catalogContext;

        public CatalogController(CatalogDbContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Index()
        {
            return View(await _catalogContext.Items.AsNoTracking().ToListAsync());
        }
    }
}