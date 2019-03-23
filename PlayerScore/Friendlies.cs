using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlayerScore
{
    [DataContract]
    class Friendlies
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string id { get; set; }
    }
}
