using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; // add this reference!!

namespace GeoLib.Contracts
{
    [DataContract] // specifies this is a data contract
    public class ZipCodeData // contract classes names end with Data.
    {
        [DataMember] // won't serialize members of DataContract uless they declared DataMembers of this Contract.
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

    }
}
