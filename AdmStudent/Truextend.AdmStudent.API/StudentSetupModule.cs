//-----------------------------------------------------------------------
// <copyright file="StudentSetupModule.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Nancy;
    using System;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;
    using Truextend.AdmStudent.Commons.Helpers;
    using Nancy.ModelBinding;
    using Nancy.Validation;
    using Truextend.AdmStudent.API.Validators;

    public class StudentSetupModule : ModuleBase
    {
        public StudentSetupModule()
            : base("/api/v1")
        {
            this.Post["/student"] = this.CreateStudent;
            this.Get["/students"] = this.GetAllStudents;
            this.Delete["/students/{studentGuid}"] = this.DeleteStudent;
            this.Get["/students/types/{type}"] = this.SearchStudentByType;
            this.Get["/students/{name}"] = this.SearchStudentByName;
            this.Get["/students/types/{type}/gender/{gender}"] = this.SearchStudentByTypeAndGender;
        }

        private Response GetAllStudents(dynamic parameters)
        {
            return HandlerErrorAndExecute(() =>
            {
                var response = ServiceFacade.Instance.StudentService.GetAllStudents();
                return response;
            });
        }

        private Response CreateStudent(dynamic parameters)
        {
            return ValidateHandlerErrorAndExecute<object>(this.Validate(this.Bind<Student>()), () =>
             {
                 var student = this.Bind<Student>();
                 var response = ServiceFacade.Instance.StudentService.CreateNewStudent(student);
                 return HttpStatusCode.OK.ToString();
             });
        }

        private Response DeleteStudent(dynamic parameters)
        {
            return ValidateHandlerErrorAndExecute<object>(StringValidator.ValidateGuid("StudentId", (string)parameters.studentGuid), () =>
            {
                var studentId = (string)parameters.studentGuid;
                var response = ServiceFacade.Instance.StudentService.DeleteStudent(new Guid(studentId));
                return response;
            });
        }

        private Response SearchStudentByName(dynamic parameters)
        {
            return ValidateHandlerErrorAndExecute(StringValidator.ValidateString("name", (string)parameters.name), () =>
               {
                   var name = (string)parameters.name;
                   var response = ServiceFacade.Instance.StudentService.FindStudentByName(name);
                   return response;
               });
        }

        private Response SearchStudentByType(dynamic parameters)
        {
            return ValidateHandlerErrorAndExecute(StringValidator.ValidateString("type", (string)parameters.type), () =>
             {
                 var type = (string)parameters.type;
                 var response = ServiceFacade.Instance.StudentService.FindStudentByType(type.ToEnum<TypeStudent>());
                 return response;
             });
        }
        private Response SearchStudentByTypeAndGender(dynamic parameters)
        {
            return HandlerErrorAndExecute(() =>
            {
                var type = (string)parameters.type;
                var gender = (string)parameters.gender;
                var response = ServiceFacade.Instance.StudentService.FindStudentByTypeAndGender(type.ToEnum<TypeStudent>(), gender.ToEnum<Gender>());
                return response;
            });
        }
    }
}
