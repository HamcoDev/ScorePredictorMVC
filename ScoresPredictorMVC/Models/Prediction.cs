using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresPredictorMVC.Models
{
    public class Prediction
    {
        public int predictionId { get; set; }
        public int UserID { get; set; }
        public int FixtureID { get; set; }
        public string homeTeam { get; set; }
        public string awayTeam { get; set; }
        public int homeTeamScore { get; set; }
        public int awayTeamScore { get; set; }
    }
}