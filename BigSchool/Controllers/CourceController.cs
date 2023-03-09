using BigSchool.Models;
using BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CourceController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CourceController()
        {
            _dbContext = new ApplicationDbContext();
        }

        

        // GET: Cources
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}