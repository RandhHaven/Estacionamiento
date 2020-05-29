namespace EstacionamientoEF
{
    using EstacionamientoEF.Entity;
    using Microsoft.EntityFrameworkCore;

    public partial class EstacionamientoModel : DbContext
    {
        #region Tables
        public virtual DbSet<Car> Autos { get; set; }
        public virtual DbSet<Employee> Empleados { get; set; }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
              .Property(e => e.CarId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;Database=postefcore;Uid=root;Pwd=root;");
            }
        }

        #endregion
    }
}
