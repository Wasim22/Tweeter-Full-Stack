namespace WTwitter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Follows", "FollowId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Follows", "FollowId");
        }
    }
}
