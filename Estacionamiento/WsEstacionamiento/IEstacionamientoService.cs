using System.Runtime.Serialization;
using System.ServiceModel;

namespace WsEstacionamiento
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsEstacionamiento" in both code and config file together.
    [ServiceContract]
    public interface IEstacionamientoService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string GetListadoAutos();

        [OperationContract]
        string GetListadoEmpleados();
        [OperationContract]
        string CrearAuto();

        [OperationContract]
        string EliminarAuto(int idAuto);

        [OperationContract]
        string EditarAuto(int idAuto);

        [OperationContract]
        string CrearEmpleado();

        [OperationContract]
        string EliminarEmpleado(int idEmpleado);

        [OperationContract]
        string EditarEmpleado(int idEmpleado);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
