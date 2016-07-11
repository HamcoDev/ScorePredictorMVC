namespace ScoresPredictorMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fixtures",
                c => new
                    {
                        fixtureId = c.Int(nullable: false, identity: true),
                        gameWeek = c.Int(nullable: false),
                        fixtureDate = c.DateTime(nullable: false),
                        homeTeamName = c.String(),
                        awayTeamName = c.String(),
                    })
                .PrimaryKey(t => t.fixtureId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        username = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
            CreateTable(
                "dbo.Predictions",
                c => new
                    {
                        predictionId = c.Int(nullable: false, identity: true),
                        homeTeamScore = c.Int(nullable: false),
                        awayTeamScore = c.Int(nullable: false),
                        user_userId = c.Int(),
                        fixture_fixtureId = c.Int(),
                    })
                .PrimaryKey(t => t.predictionId)
                .ForeignKey("dbo.Users", t => t.user_userId)
                .ForeignKey("dbo.Fixtures", t => t.fixture_fixtureId)
                .Index(t => t.user_userId)
                .Index(t => t.fixture_fixtureId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Predictions", new[] { "fixture_fixtureId" });
            DropIndex("dbo.Predictions", new[] { "user_userId" });
            DropForeignKey("dbo.Predictions", "fixture_fixtureId", "dbo.Fixtures");
            DropForeignKey("dbo.Predictions", "user_userId", "dbo.Users");
            DropTable("dbo.Predictions");
            DropTable("dbo.Users");
            DropTable("dbo.Fixtures");
        }
    }
}
