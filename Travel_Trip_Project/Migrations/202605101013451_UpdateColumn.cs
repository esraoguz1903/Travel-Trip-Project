namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Title");
        }
    }
}
