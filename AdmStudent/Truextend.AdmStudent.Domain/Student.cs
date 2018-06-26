﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Domain.Enums;

namespace Truextend.AdmStudent.Domain
{
    public class Student
    {

        public Student(string name, TypeStudent type, Gender gender, string lastUpdate)
        {
            this.Name = name;
            this.Type = type;
            this.Gender = gender;
            this.LastUpdate = lastUpdate;
            this.Id = Guid.NewGuid();
        }

        public Student()
        {
            Id = Guid.NewGuid();
            Type = TypeStudent.Kinder;
            Gender = Gender.Female;
        }
        public Guid Id { get; set; }
        public TypeStudent Type { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string LastUpdate { get; set; }

    }
}
