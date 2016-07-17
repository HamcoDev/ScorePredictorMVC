using System.Web.Mvc;
using ScoresPredictorMVC.Models;


namespace ScoresPredictorMVC.Controllers
{
    public class LeagueController : Controller
    {
        // Get: /League/weekTable
        public ActionResult weekTable()
        {
            var data = DataService.Instance;

            return View(data.getWeekStats());
        }

        // Get: /League/totalTable
        public ActionResult totalTable()
        {
            var data = DataService.Instance;

            return View(data.getTotalStats());
        }
           
      public ActionResult Stats()
      {
        return View();
      }

    }
}