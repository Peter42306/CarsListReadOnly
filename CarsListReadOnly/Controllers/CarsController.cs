using CarsListReadOnly.Data;
using CarsListReadOnly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsListReadOnly.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarsContext _context;

        public CarsController(CarsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Car> cars = await _context.Cars.ToListAsync();
            return View(cars);
        }
    }
}
