using Community.Data;
using Community.Models;
using Community.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Community.Controllers
{
    [Authorize(Roles ="Admin,User")]
    public class HomeController : Controller
    {
        private readonly CommunityContext _context;

        public HomeController(CommunityContext context)
        {
            _context = context;       
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.News.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> ViewNews(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }
     
    }
}
