using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleApp.Data;
using PeopleApp.Models;
using PeopleApp.ViewModels;
using System.Diagnostics;

namespace PeopleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index([FromQuery] string selectedCity)
        {
            return View(new PeopleListViewModel
            {
                People = _context.People.Include(p => p.Department).Include(p => p.Location),
                Cities = _context.Locations.Select(l => l.City).Distinct(),
                SelectedCity = selectedCity
            });
        }

        public IActionResult BlazorPeopleList()
        {
            return View();
        }
    }
}