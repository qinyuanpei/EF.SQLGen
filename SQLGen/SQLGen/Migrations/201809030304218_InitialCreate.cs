namespace SQLGen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.String(nullable: false, maxLength: 128),
                        BuName = c.String(),
                        BuFullName = c.String(),
                        BuCode = c.String(),
                        HierarchyCode = c.String(),
                        ParentGuid = c.String(),
                        WebSite = c.String(),
                        Fax = c.String(),
                        CompanyAddr = c.String(),
                        Charter = c.String(),
                        CorporationDeputy = c.String(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        Comments = c.String(),
                        ModifiedBy = c.String(),
                        IsEndCompany = c.Boolean(),
                        IsCompany = c.Boolean(),
                        BuLevel = c.Double(),
                        BuType = c.Double(),
                        OrderCode = c.String(),
                        OrderHierarchyCode = c.String(),
                        AreaCode = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
        }
    }
}
