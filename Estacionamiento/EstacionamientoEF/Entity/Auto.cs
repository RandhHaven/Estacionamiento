namespace EstacionamientoEF.Entity
{
    #region Directives
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    #endregion

    #region Table
    [Table("Auto")]
    [DataContract]
    public class Auto
    {
        [Key]
        [DataMember]
        public int AutoId { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Marca { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Modelo { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string DescripcionAuto { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Patente { get; set; }

        [DataMember]
        [Required]
        public int EmployeeId { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Color { get; set; }

    }
    #endregion
}
