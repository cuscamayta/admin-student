//-----------------------------------------------------------------------
// <copyright file="StudentSetupModule.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Nancy;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;
    using Truextend.AdmStudent.Commons.Helpers;
    using Truextend.AdmStudent.Commons;
    using Nancy.ModelBinding;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class StudentSetupModule : NancyModule
    {
        public StudentSetupModule()
            : base("/api/v1")
        {
            this.Post["/student"] = this.CreateStudent;
            this.Get["/students"] = this.GetAllStudents;
            this.Delete["/students/{studentGuid}"] = this.DeleteStudent;
            this.Get["/students/types/{type}"] = this.SearchStudentByType;
            this.Get["/students/{name}"] = this.SearchStudentByName;
            this.Get["/students/types/{type}/genders/{gender}"] = this.SearchStudentByTypeAndGender;       
        }

        private Response GetAllStudents(dynamic parameters)
        {
            var response = ServiceFacade.Instance.StudentService.GetAllStudents();

            return Response.AsJson<IEnumerable<Student>>(response);
        }

        private Response CreateStudent(dynamic parameters)
        {
            var student = this.Bind<Student>();
            var response = ServiceFacade.Instance.StudentService.CreateNewStudent(student);

            return Response.AsJson<bool>(response);
        }

        private Response DeleteStudent(dynamic parameters)
        {
            var studentId = (string)parameters.studentGuid;
            var response = ServiceFacade.Instance.StudentService.DeleteStudent(new Guid(studentId));
            return Response.AsJson<bool>(response);
        }

        private Response SearchStudentByName(dynamic parameters)
        {
            var name = (string)parameters.name;
            var response = ServiceFacade.Instance.StudentService.FindStudentByName(name);
            return Response.AsJson<IEnumerable<Student>>(response);
        }
        private Response SearchStudentByType(dynamic parameters)
        {
            var type = (string)parameters.type;
            var response = ServiceFacade.Instance.StudentService.FindStudentByType(type.ToEnum<TypeStudent>());
            return Response.AsJson<IEnumerable<Student>>(response);
        }
        private Response SearchStudentByTypeAndGender(dynamic parameters)
        {
            var type = (string)parameters.type;
            var gender = (string)parameters.gender;
            var response = ServiceFacade.Instance.StudentService.FindStudentByTypeAndGender(type.ToEnum<TypeStudent>(), gender.ToEnum<Gender>());
            return Response.AsJson<IEnumerable<Student>>(response);
        }
    }
}
