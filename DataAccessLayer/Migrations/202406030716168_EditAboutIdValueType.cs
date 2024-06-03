namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditAboutIdValueType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Abouts");
            AlterColumn("dbo.Abouts", "AboutId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Abouts", "AboutId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Abouts");
            AlterColumn("dbo.Abouts", "AboutId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Abouts", "AboutId");
        }
    }
}
