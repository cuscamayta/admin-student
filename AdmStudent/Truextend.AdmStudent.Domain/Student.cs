//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Domain
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using Truextend.AdmStudent.Domain.Enums;

    /// <summary>
    /// The domain definition for student
    /// </summary>
    public class Student
    {
        public Student(string name, TypeStudent type, Gender gender, DateTime lastUpdate)
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
            LastUpdate = DateTime.Now;
        }
        public Guid Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TypeStudent Type { get; set; }

        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }
        //public string LastUpdate { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
