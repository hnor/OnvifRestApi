using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects
{
    public class OnvifSystemDateAndTimeResponse
    {
        public string DateTimeType { get; set; }
        public bool DaylightSavings { get; set; }
        public string TimeZone { get; set; }
        public DateTime UTCDateTime { get; set; }
        public DateTime LocalDateTime { get; set; }
    }
}