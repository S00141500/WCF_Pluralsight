using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace GeoLib.Contracts
{
    [ServiceContract]
    public interface IGeoService
    {
        [OperationContract]
        ZipCodeData GetZipCodeInfo(string zip);

        [OperationContract]
        IEnumerable<string> GetStates(bool primaryOnly);

        /*  As method overloading is a feature of .Net and since WCF can use SOAP which should be interpolable
         *  with non .Net systems you can still use method overloading but must specify a unique name for 
         *  the overloaded Operartion Contracts i.e [OperationContract(Name="GetZipsFromState")]
         *  SOAP will always serialize the operation contracts using this name.
         */

        [OperationContract(Name="GetZipsFromState")]
        IEnumerable<ZipCodeData> GetZips(string state);

        [OperationContract(Name="GetZipsForRange"]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);
    }
}
