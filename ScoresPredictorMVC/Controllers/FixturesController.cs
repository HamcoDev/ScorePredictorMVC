using System.Linq;
using ScoresPredictorMVC.Models;
using System.Net;
using System.Web.Mvc;

namespace ScoresPredictorMVC.Controllers
{
    public class FixturesController : Controller
    {

        // GET: /Fixtures/
        public ActionResult View()
        {
            var ds = DataService.Instance;
            var fixtures = ds.GetFixtures();

          return View(fixtures);
        }

        // Get: /Fixtures/Edit
        public ActionResult Edit()
        {
            var data = DataService.Instance;
            var predictions = data.GetEditPredictions(1);

            return View(predictions);
        }

      // Get: /Fixtures/Enter
      public ActionResult EnterAll()
      {
        var ds = DataService.Instance;
        var fixtures = ds.GetFixtures();

        var currentFixture = fixtures.First();

        return View(currentFixture);
      }

      // Get: /Fixtures/Enter/5
        public ActionResult Enter(int id)
        {
            var ds = DataService.Instance;
            var fixtures = ds.GetFixtures();

          var currentFixture = fixtures.First(fixture => fixture.ID == id);

          return View(currentFixture);
        }

        // Get: Fixtures/NextFixture
        [ChildActionOnly]
        public ActionResult NextFixture()
        {
            //var fixture =
            //    from f in fixtureList
            //    orderby f.Date
            //    select f;

            //return PartialView("_Fixture", fixture.First());
            return View();
        }

    }
}
