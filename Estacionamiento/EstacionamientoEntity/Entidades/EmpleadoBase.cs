namespace EstacionamientoEntity.Entidades
{
    using System;

    [Serializable]
    public class EmpleadoBase
    {
        #region Properties

        public int IdEmpleado { get; set; }

        public int Legajo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public byte Edad { get; set; }

        public string NroCelular { get; set; }
        #endregion
    }
}
