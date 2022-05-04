using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrondEnd.Shared.DTOs
{
#nullable disable
    public class DetailsDTO
    {
         [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("value")]
        public List<DetailData> Value { get; set; }
    }

    public class DetailData
    {
        public string label { get; set; }
        public string Content { get; set; }
        public string IdFile { get; set; }
    }
}
