using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCTravel.Models
{
    public class searchViewModel
    {
        public List<tblCategory> Categories;
        public tblCategory ChosenCategory;
        public List<tblActivity> ActvitiesInCategory;
        public int NumberOfActivities;
    }
}