namespace WTwitter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowUpdate4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tweets", "Tweet_Id", c => c.Int());
            CreateIndex("dbo.Tweets", "Tweet_Id");
            AddForeignKey("dbo.Tweets", "Tweet_Id", "dbo.Tweets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tweets", "Tweet_Id", "dbo.Tweets");
            DropIndex("dbo.Tweets", new[] { "Tweet_Id" });
            DropColumn("dbo.Tweets", "Tweet_Id");
        }
    }
}
