using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NCTravel.Models;

namespace NCTravel.Controllers
{
    public class searchController : Controller
    {
        List<tblActivity> activities = new List<tblActivity>();

        List<tblCategory> categories = new List<tblCategory>();

        public searchController()
        {
            NCTravelDataEntities1 db = new NCTravelDataEntities1();

            categories = db.tblCategories
                .OrderBy(m => m.CategoryName)
                .ToList();
        }

        // GET: search
        public ActionResult Index()
        {
            searchViewModel viewModel = new searchViewModel();

            viewModel.Categories = categories;
              
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(int categorySelect)
        {
            NCTravelDataEntities1 db = new NCTravelDataEntities1();

            var activitiesInCategory = db.tblActivities
                .Where(m => m.CategoryID == categorySelect)
                .OrderBy(m => m.actName)
                .ToList();

            searchViewModel viewModel = new searchViewModel();

            viewModel.Categories = categories;
            viewModel.ChosenCategory = categories.Find(c => c.CategoryID == categorySelect);
            viewModel.ActvitiesInCategory = activitiesInCategory;
            viewModel.NumberOfActivities = activitiesInCategory.Count();

            return View("SelectedActivities", viewModel);
        }
    }
}