namespace EstacionamientoEF.Entity
{
    #region Directivas
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    #endregion

    #region Tabla
    [Table("Empleado")]
    [DataContract]
    public class Empleado
    {
        [Key]
        [DataMember]
        [Required]
        [MaxLength(15)]
        public int EmpleadoId { get; set; }

        [DataMember]
        [Required]
        [MaxLength(10)]
        public int Legajo { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string UserEmpleado { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Apellido { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string NroCelular { get; set; }
    }
    #endregion
}
