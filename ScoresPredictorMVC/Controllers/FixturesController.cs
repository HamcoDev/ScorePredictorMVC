using Newtonsoft.Json;
using ScoresPredictorMVC.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ScoresPredictorMVC.Controllers
{
    public class FixturesController : Controller
    {

        // GET: /Fixtures/
        public ActionResult View()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            //var fileReader = File.ReadAllText("JSONexample - fixtures.txt");
            //var f = JsonConvert.DeserializeObject<FixtureList>(fileReader);

            var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            return View(f.stock);

            //var model =
            //    from f in fixtureList
            //    orderby f.Date
            //    select f;

            //return View(model);
        }

        // Get: /Fixtures/Edit
        public ActionResult Edit()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            //var fileReader = File.ReadAllText("JSONexample - fixtures.txt");
            //var f = JsonConvert.DeserializeObject<FixtureList>(fileReader);

            var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            var index = 1;

            foreach (Fixture fixture in f.stock)
            {
                fixture.fixtureId = index;
                index++;
            }

            return View(f.stock);
        }

        // Get: /Fixtures/Enter/5
        public ActionResult Enter(int id)
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            //var fileReader = File.ReadAllText("JSONexample - fixtures.txt");
            //var f = JsonConvert.DeserializeObject<FixtureList>(fileReader);

            var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            var index = 1;
            foreach (Fixture fixture in f.stock)
            {
                fixture.fixtureId = index;
                index++;
            }

            var currentFixture = f.stock.First(fixture => fixture.fixtureId == id);

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

        //Post: /Fixtures/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            //var fixture = fixtureList.Single(f => f.ID == id);

            //if (TryUpdateModel(fixture))
            //{
            //    // todo: save to db
            //    return RedirectToAction("View");
            //}

            //return View(fixture);

            return View();
        }
    }
}
