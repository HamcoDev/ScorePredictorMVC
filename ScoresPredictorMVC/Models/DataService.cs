using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ScoresPredictorMVC.Models
{
    public sealed class DataService
    {
        private static DataService instance = null;
        private static readonly object padlock = new object();

        private DataService()
        {
        }

        public static DataService Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataService();
                    }
                    return instance;
                }
            }
        }

        public List<Fixture> GetFixtures()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            //var fileReader = File.ReadAllText("C:\\Source\\Github\\ScorePredictorMVC\\ScoresPredictorMVC\\TestData\\JSONexample - fixtures.txt");
            //var f = JsonConvert.DeserializeObject<FixtureList>(fileReader);

            var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            return f.stock;
        }

        public List<Prediction> GetEditPredictions(int userId)
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBPredictions.php");

            //var fileReader = File.ReadAllText("C:\\Source\\Github\\ScorePredictorMVC\\ScoresPredictorMVC\\TestData\\JSONExample - predictions.txt");
            //var f = JsonConvert.DeserializeObject<PredictionList>(fileReader);

            var f = JsonConvert.DeserializeObject<PredictionList>(reply);

            return f.stock.Where(p => p.UserID == userId).ToList();
        }

        public List<UserScore> getWeekStats()
        {
            try
            {
                var client = new WebClient();
                //var reply = client.DownloadString("http://www.cgtipster.com/api2/PYBWeeklyStats.php");
                //var f = JsonConvert.DeserializeObject<UserScoreList>(reply,
                //    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                var fileReader = File.ReadAllText("C:\\Source\\Github\\ScorePredictorMVC\\ScoresPredictorMVC\\TestData\\JSONexample - weekstats.txt");
                var f = JsonConvert.DeserializeObject<UserScoreList>(fileReader);

                return f.stock.ToList();
            }
            catch (Exception)
            {
                return new List<UserScore>();
            }
        }

        public List<UserScore> getTotalStats()
        {
            try
            {
                var client = new WebClient();
                //var reply = client.DownloadString("http://www.cgtipster.com/api2/PYBTotalStats.php");
                //var f = JsonConvert.DeserializeObject<UserScoreList>(reply,
                //    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                var fileReader = File.ReadAllText("C:\\Source\\Github\\ScorePredictorMVC\\ScoresPredictorMVC\\TestData\\JSONexample - stats.txt");
                var f = JsonConvert.DeserializeObject<UserScoreList>(fileReader);

                return f.stock.ToList();

            }
            catch (Exception)
            {
                return new List<UserScore>();
            }
        }
    }
}