using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT
{
    internal class GPTResponseModel
    {
        public string classFileName { get; set; } = string.Empty;
        public string classCode { get; set; } = string.Empty;
        public string xamlFileName { get; set; } = string.Empty;
        public string xamlCode { get; set;} = string.Empty;
    }
}
