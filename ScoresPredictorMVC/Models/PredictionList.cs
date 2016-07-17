using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresPredictorMVC.Models
{
    public class PredictionList
    {
        public List<Prediction> stock { get; set; }

        public int success { get; set; }
    }
}
