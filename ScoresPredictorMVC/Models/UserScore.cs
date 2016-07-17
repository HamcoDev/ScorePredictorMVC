using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresPredictorMVC.Models
{
    public class UserScore
    {
        public string name { get; set; }
        public int totalScore { get; set; }
        public int weekScore { get; set; }
    }
}
