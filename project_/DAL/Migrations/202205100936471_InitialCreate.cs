namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChapterOfPrayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrayerText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Importances",
                c => new
                    {
                        ImpotanceLevel = c.Int(nullable: false, identity: true),
                        NusachId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImpotanceLevel);
            
            CreateTable(
                "dbo.NusachOfChapters",
                c => new
                    {
                        NusachId = c.Int(nullable: false, identity: true),
                        ChapterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NusachId);
            
            CreateTable(
                "dbo.Nuschauts",
                c => new
                    {
                        NusachId = c.Int(nullable: false, identity: true),
                        NusachName = c.String(),
                    })
                .PrimaryKey(t => t.NusachId);
            
            CreateTable(
                "dbo.Prayers",
                c => new
                    {
                        PrayerId = c.Int(nullable: false, identity: true),
                        ChapterId = c.Int(nullable: false),
                        ImportanceLevelId = c.Int(nullable: false),
                        TimeChapter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrayerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        SpeedOfSpeak = c.Int(nullable: false),
                        Nusach = c.Int(nullable: false),
                        Min = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Zmanins",
                c => new
                    {
                        ZmanId = c.Int(nullable: false, identity: true),
                        ZmanName = c.String(),
                        PrayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZmanId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zmanins");
            DropTable("dbo.Users");
            DropTable("dbo.Prayers");
            DropTable("dbo.Nuschauts");
            DropTable("dbo.NusachOfChapters");
            DropTable("dbo.Importances");
            DropTable("dbo.ChapterOfPrayers");
        }
    }
}
