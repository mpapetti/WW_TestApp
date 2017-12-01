namespace TestApp.Models {
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class AppModel : DbContext {
        public AppModel()
            : base("name=AppModel") {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            // Prevents multiple cascade DELETES or UPDATES
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Rather than identityUser generic class , use the name of the renamed ApplicationUser being User
            modelBuilder.Entity<TestTableModel>().ToTable("Test");
            modelBuilder.Entity<NewTableModel>().ToTable("New");
        }
    }
}
