namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "eklendi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "eklendi");
        }
    }
}
