using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScoresPredictorMVC.Models
{
    public class ScoresPredictorDb : DbContext
    {
        public ScoresPredictorDb() : base("name=DefaultConnection"){}

        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Prediction> Predictions { get; set; }
    }
}