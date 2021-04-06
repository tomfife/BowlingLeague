using System;
using System.Linq;
using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeague.Components
{
    public class TeamTitleViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamTitleViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        // This is to grab the Team names from the context
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];   // Pulls from the url and says this is our selected category

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x.TeamName));
        }
    }
}
