namespace TestApp.Migrations {
    using System.Data.Entity.Migrations;

    public partial class AddingCompany : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Company",
                c => new {
                    employeeId = c.Int(nullable: false, identity: true),
                    employeeName = c.String(maxLength: 200),
                })
                .PrimaryKey(t => t.employeeId);

            CreateTable(
                "dbo.New",
                c => new {
                    id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 100),
                })
                .PrimaryKey(t => t.id);

        }

        public override void Down() {
            DropTable("dbo.New");
            DropTable("dbo.Company");
        }
    }
}
