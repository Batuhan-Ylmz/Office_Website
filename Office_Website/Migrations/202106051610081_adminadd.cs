namespace Office_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Authority", c => c.String());
        }
    }
}
