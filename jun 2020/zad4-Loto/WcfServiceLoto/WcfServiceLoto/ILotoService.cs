using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLoto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILotoService" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = ILotoCallback]
    public interface ILotoService
    {

        [OperationContract]
        bool PrijaviSe(Prijava novaPrijava);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    [Serializable]
    public class Prijava
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public int[] brojevi { get; set; }

        [DataMember]
        public string Nadimak { get; set; }
    }
}
