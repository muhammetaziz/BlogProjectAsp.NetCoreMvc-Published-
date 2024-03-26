namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorPhone", c => c.String(maxLength: 15));
            AddColumn("dbo.Authors", "AuthorTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "AuthorShotAbout", c => c.String(maxLength: 150));
            AddColumn("dbo.Authors", "AuthorPassword", c => c.String(maxLength: 25));
            AddColumn("dbo.Authors", "AuthorMail", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorMail");
            DropColumn("dbo.Authors", "AuthorPassword");
            DropColumn("dbo.Authors", "AuthorShotAbout");
            DropColumn("dbo.Authors", "AuthorTitle");
            DropColumn("dbo.Authors", "AuthorPhone");
        }
    }
}
