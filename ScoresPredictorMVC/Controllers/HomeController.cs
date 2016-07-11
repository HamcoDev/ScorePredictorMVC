using ScoresPredictorMVC.Models;
using System.Web.Mvc;

namespace ScoresPredictorMVC.Controllers
{
    public class HomeController : Controller
    {
        ScoresPredictorDb db = new ScoresPredictorDb();

        public ActionResult Index(int week = 0)
        {
            //var model =
            //    db.Fixtures
            //    .Where(f => week == 0 || f.gameWeek.Equals(week))
            //    .OrderBy(f => f.Date)
            //    .Select(f => f);

            //return View(model);

            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();

            model.appName = "Scores Predictor";
            model.appDeveloper = "Hamco Dev";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (db != null)
            {
                db.Dispose();
            }
            
            base.Dispose(disposing);
        }
    }
}
