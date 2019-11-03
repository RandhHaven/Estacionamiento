namespace EntityEstacionamiento.Helpers
{
    #region Directives
    #endregion

    public abstract class AServiceAccess
    {
        protected bool lresult;
        protected string result;

        public AServiceAccess()
        { }

        public string Serialize(object obj)
        {
            return (SerializationHelper.SerializeToBinaryString(obj));
        }

        public object Deserialize()
        {
            if (result == null)
                return (null);

            return (SerializationHelper.DeserializeFromBinaryString(result));
        }
    }
}
