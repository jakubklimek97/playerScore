using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlayerScore
{
    [DataContract]
    class Report
    {
       
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string start { get; set; }
        [DataMember]
        public string end { get; set; }
        [DataMember]
        public short zone { get; set; }
        [DataMember]
        public string owner { get; set; }
        [DataMember]
        public string id { get; set; }
    }
}
