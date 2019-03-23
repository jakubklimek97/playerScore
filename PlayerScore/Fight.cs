using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlayerScore
{
    [DataContract]
    class Fight
    {
        [DataMember]
        public string start_time { get; set; }
        [DataMember]
        public string end_time { get; set; }
        [DataMember]
        public string boss { get; set; }
        [DataMember]
        public string kill { get; set; }
        [DataMember]
        public string bossPercentage { get; set; }
    }
}
