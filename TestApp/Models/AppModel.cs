namespace TestApp.Models {
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class AppModel : DbContext {
        public AppModel() : base("name=AppModel") {
        }

        public DbSet<TestTableModel> TestTableModel { get; set; }
        public DbSet<NewTableModel> NewTableModel { get; set; }

        public DbSet<CompanyModel> Company { get; set; }
        public DbSet<StudentsModel> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            // Prevents multiple cascade DELETES or UPDATES
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Rather than identityUser generic class , use the name of the renamed ApplicationUser being User
            modelBuilder.Entity<TestTableModel>().ToTable("Test");
            modelBuilder.Entity<NewTableModel>().ToTable("New");
            modelBuilder.Entity<CompanyModel>().ToTable("Company");
            modelBuilder.Entity<StudentsModel>().ToTable("Student");
        }
    }
}
