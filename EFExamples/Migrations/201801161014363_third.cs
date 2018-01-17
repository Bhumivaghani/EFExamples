namespace EFExamples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Standards", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Standards", "Description", c => c.String());
        }
    }
}
