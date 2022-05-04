using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrondEnd.Shared.DTOs
{
#nullable disable
    public class OdataResponse
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("value")]
        public List<Value> value { get; set; }


    }
    public class Value
    {
        public string RowID { get; set; }
        public string codIntervento { get; set; }
        public string dataIntervento { get; set; }
        public string statoFattura { get; set; }
        public string firmatario { get; set; }
        public string luogoIntervento { get; set; }
    }
}
