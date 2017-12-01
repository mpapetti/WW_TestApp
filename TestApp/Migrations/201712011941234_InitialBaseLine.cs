namespace TestApp.Migrations {
    using System.Data.Entity.Migrations;

    public partial class InitialBaseLine : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Test",
                c => new {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(),
                })
                .PrimaryKey(t => t.id);

        }

        public override void Down() {
            DropTable("dbo.Test");
        }
    }
}
