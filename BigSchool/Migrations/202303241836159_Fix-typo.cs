namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixtypo : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Attendances", name: "Course_ID", newName: "CourseId");
            RenameIndex(table: "dbo.Attendances", name: "IX_Course_ID", newName: "IX_CourseId");
            DropPrimaryKey("dbo.Attendances");
            AddPrimaryKey("dbo.Attendances", new[] { "CourseId", "AttendeeId" });
            DropColumn("dbo.Attendances", "CoureId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendances", "CoureId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Attendances");
            AddPrimaryKey("dbo.Attendances", new[] { "CoureId", "AttendeeId" });
            RenameIndex(table: "dbo.Attendances", name: "IX_CourseId", newName: "IX_Course_ID");
            RenameColumn(table: "dbo.Attendances", name: "CourseId", newName: "Course_ID");
        }
    }
}
