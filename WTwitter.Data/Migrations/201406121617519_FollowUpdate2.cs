namespace WTwitter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowUpdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Follows", "UserId", "dbo.Users");
            AddColumn("dbo.Follows", "User_Id", c => c.Int());
            CreateIndex("dbo.Follows", "FollowId");
            CreateIndex("dbo.Follows", "User_Id");
            AddForeignKey("dbo.Follows", "FollowId", "dbo.Users", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Follows", "UserId", "dbo.Users", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Follows", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Follows", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Follows", "UserId", "dbo.Users");
            DropForeignKey("dbo.Follows", "FollowId", "dbo.Users");
            DropIndex("dbo.Follows", new[] { "User_Id" });
            DropIndex("dbo.Follows", new[] { "FollowId" });
            DropColumn("dbo.Follows", "User_Id");
            AddForeignKey("dbo.Follows", "UserId", "dbo.Users", "Id", cascadeDelete: false);
        }
    }
}
