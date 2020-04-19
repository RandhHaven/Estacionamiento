using EFEstacionamiento.Entity;
using System.Data.Entity;

namespace EFEstacionamiento
{
    public partial class ModeloEstacionamiento : DbContext
    {
        #region Tables
        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        #endregion

        #region Build
        public ModeloEstacionamiento()
           : base("name=" + "ModeloEstacionamiento")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

        }
        #endregion

        #region Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
               .Property(e => e.AutoId);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.EmpleadoId);
        }
        #endregion
    }
}
