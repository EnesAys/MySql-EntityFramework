namespace MySqlEntityF_COdeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ChangeType = c.String(unicode: false),
                        ObjectType = c.String(unicode: false),
                        FromJson = c.String(unicode: false),
                        ToJson = c.String(unicode: false),
                        DateCreated = c.DateTime(nullable: false, precision: 0),
                        TableName = c.String(unicode: false),
                        IdentityJson = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Audits");
        }
    }
}
