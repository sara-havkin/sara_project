namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class success : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ChapterOfPrayers");
            DropPrimaryKey("dbo.Importances");
            DropPrimaryKey("dbo.NusachOfChapters");
            AddColumn("dbo.ChapterOfPrayers", "ChapterOfPrayerId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Importances", "ImpotanceId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Importances", "IdNusach", c => c.Int(nullable: false));
            AddColumn("dbo.NusachOfChapters", "NusachOfChapterId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.NusachOfChapters", "IdChapter", c => c.Int(nullable: false));
            AddColumn("dbo.Prayers", "IdChapterOfPrayer", c => c.Int(nullable: false));
            AddColumn("dbo.Prayers", "IdChapter", c => c.Int(nullable: false));
            AddColumn("dbo.Prayers", "IdImportanceLevel", c => c.Int(nullable: false));
            AddColumn("dbo.Zmanins", "IdPrayer", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ChapterOfPrayers", "ChapterOfPrayerId");
            AddPrimaryKey("dbo.Importances", "ImpotanceId");
            AddPrimaryKey("dbo.NusachOfChapters", "NusachOfChapterId");
            DropColumn("dbo.ChapterOfPrayers", "Id");
            DropColumn("dbo.Importances", "ImpotanceLevel");
            DropColumn("dbo.Importances", "NusachId");
            DropColumn("dbo.NusachOfChapters", "NusachId");
            DropColumn("dbo.NusachOfChapters", "ChapterId");
            DropColumn("dbo.Prayers", "ChapterId");
            DropColumn("dbo.Prayers", "ImportanceLevelId");
            DropColumn("dbo.Zmanins", "PrayerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zmanins", "PrayerId", c => c.Int(nullable: false));
            AddColumn("dbo.Prayers", "ImportanceLevelId", c => c.Int(nullable: false));
            AddColumn("dbo.Prayers", "ChapterId", c => c.Int(nullable: false));
            AddColumn("dbo.NusachOfChapters", "ChapterId", c => c.Int(nullable: false));
            AddColumn("dbo.NusachOfChapters", "NusachId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Importances", "NusachId", c => c.Int(nullable: false));
            AddColumn("dbo.Importances", "ImpotanceLevel", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.ChapterOfPrayers", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.NusachOfChapters");
            DropPrimaryKey("dbo.Importances");
            DropPrimaryKey("dbo.ChapterOfPrayers");
            DropColumn("dbo.Zmanins", "IdPrayer");
            DropColumn("dbo.Prayers", "IdImportanceLevel");
            DropColumn("dbo.Prayers", "IdChapter");
            DropColumn("dbo.Prayers", "IdChapterOfPrayer");
            DropColumn("dbo.NusachOfChapters", "IdChapter");
            DropColumn("dbo.NusachOfChapters", "NusachOfChapterId");
            DropColumn("dbo.Importances", "IdNusach");
            DropColumn("dbo.Importances", "ImpotanceId");
            DropColumn("dbo.ChapterOfPrayers", "ChapterOfPrayerId");
            AddPrimaryKey("dbo.NusachOfChapters", "NusachId");
            AddPrimaryKey("dbo.Importances", "ImpotanceLevel");
            AddPrimaryKey("dbo.ChapterOfPrayers", "Id");
        }
    }
}
