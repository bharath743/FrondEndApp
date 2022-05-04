using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrondEnd.Shared.DTOs
{
#nullable disable
    public class DownloadFileResponse
    {
        public Info info { get; set; }
        public object returnData { get; set; }
        public object pfService { get; set; }
        public ReturnFileBinary returnFileBinary { get; set; }
    }
    public class Info
    {
        public object link { get; set; }
        public string message { get; set; }
        public object error { get; set; }
        public object messageID { get; set; }
        public string status { get; set; }
        public int count { get; set; }
    }

    public class ReturnFileBinary
    {
        public string fileName { get; set; }
        public string fileType { get; set; }
        public string base64Binary { get; set; }
    }
}
