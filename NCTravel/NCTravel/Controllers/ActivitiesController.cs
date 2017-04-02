using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NCTravel.Models;

namespace NCTravel.Controllers
{
    public class ActivitiesController : Controller
    {
        List<tblActivity> activities = new List<tblActivity>();

        NCTravelDataEntities1 db = new NCTravelDataEntities1();

        public ActionResult Sports()
        {
            var activities = db.tblActivities
                .Where(m => m.CategoryID == 4)
                .OrderBy(m => m.actName)
                .ToList();

            activitiesViewModel viewModel = new activitiesViewModel();

            viewModel.activities = activities;
            
            return View(viewModel);
        }
        public ActionResult Outdoors()
        {
            var activities = db.tblActivities
                .Where(m => m.CategoryID == 1)
                .OrderBy(m => m.actName)
                .ToList();

            activitiesViewModel viewModel = new activitiesViewModel();

            viewModel.activities = activities;

            return View(viewModel);
        }
        public ActionResult History()
        {
            var activities = db.tblActivities
               .Where(m => m.CategoryID == 2)
               .OrderBy(m => m.actName)
               .ToList();

            activitiesViewModel viewModel = new activitiesViewModel();

            viewModel.activities = activities;

            return View(viewModel);
        }
        public ActionResult Museums()
        {
            var activities = db.tblActivities
                .Where(m => m.CategoryID == 3)
                .OrderBy(m => m.actName)
                .ToList();

            activitiesViewModel viewModel = new activitiesViewModel();

            viewModel.activities = activities;

            return View(viewModel);
        }
    }
}