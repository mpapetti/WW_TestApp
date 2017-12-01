namespace TestApp.Migrations {
    using System.Data.Entity.Migrations;

    public partial class AddingNewModel : DbMigration {
        public override void Up() {
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
        }
    }
}
