using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Domain.Enums;

namespace Truextend.AdmStudent.Domain
{
    public class Student
    {
        public TypeStudent Type { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public TimeSpan LastUpdate { get; set; }
    }
}
