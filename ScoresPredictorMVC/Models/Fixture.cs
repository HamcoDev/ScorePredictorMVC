using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresPredictorMVC.Models
{
    public class Fixture
    {
        public int ID { get; set; }
        public int fixtureId { get; set; }
        public int gameWeek { get; set; }
        public DateTime Date { get; set; }
        public string Home_Team { get; set; }
        public string Away_Team { get; set; }
    }
}