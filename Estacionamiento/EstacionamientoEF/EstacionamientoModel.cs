namespace EstacionamientoEF
{
    using EstacionamientoEF.Entity;
    using Microsoft.EntityFrameworkCore;

    public partial class EstacionamientoModel : DbContext
    {
        #region Tables
        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
              .Property(e => e.AutoId);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.EmpleadoId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        #endregion
    }
}
