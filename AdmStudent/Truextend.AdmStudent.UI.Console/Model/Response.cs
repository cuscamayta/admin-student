using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.UI.Console.Model
{
    public class Response<T> where T : class
    {
        public Response(string message, T data, bool success = false, int status = 500)
        {
            this.Success = success;
            this.Status = status;
            this.Data = data;
            this.Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public T Data { get; set; }
    }
}
