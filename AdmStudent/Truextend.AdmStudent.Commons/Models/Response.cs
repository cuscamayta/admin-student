using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.Commons.Models
{
    public class ResponseDTO
    {
        public ResponseDTO(string message, object data, bool success = false, int status = 500)
        {
            this.Success = success;
            this.Status = status;
            this.Data = data;
            this.Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public object Data { get; set; }
    }
}
