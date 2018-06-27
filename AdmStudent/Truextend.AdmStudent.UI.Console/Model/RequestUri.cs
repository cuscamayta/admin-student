using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.UI.Console.Model
{
    public class RequestUri
    {
        public RequestUri(TypeRequest type, Dictionary<string, string> parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }
        public TypeRequest Type { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
    }
}
