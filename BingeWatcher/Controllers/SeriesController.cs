using BingeWatcher.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.Controllers
{
    public class SeriesController : Controller
    {
        private readonly AppDbContext _context;

        public SeriesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allSeries = await _context.Series.ToListAsync();
            return View(allSeries);
        }
    }
}
