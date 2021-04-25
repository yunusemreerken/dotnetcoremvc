namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columndeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "eklendi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "eklendi", c => c.String());
        }
    }
}
