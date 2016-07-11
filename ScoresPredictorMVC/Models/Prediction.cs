using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresPredictorMVC.Models
{
    public class Prediction
    {
        public int predictionId { get; set; }
        public User user { get; set; }
        public Fixture fixture { get; set; }
        public int homeTeamScore { get; set; }
        public int awayTeamScore { get; set; }
    }
}