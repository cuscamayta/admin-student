using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.API
{
    public class StudentSetupModule : NancyModule
    {
        public StudentSetupModule()
            : base("/api/v1/admstudent")
        {
            this.Post["/student"] = this.CreateStudent;
            this.Get["/students"] = this.GetAllStudents;
            this.Delete["/students/{studentGuid}"] = this.DeleteStudent;
            this.Get["/students/types/{type}"] = this.SearchStudentByType;
            this.Get["/students/name/{name}"] = this.SearchStudentByName;
            this.Get["/students/types/{type}/gender/{gender}"] = this.SearchStudentByTypeAndGender;

        }

        private Response GetAllStudents(dynamic parameters)
        {
            return Response.AsJson<string>("this is a test for services");
        }

        private Response CreateStudent(dynamic parameters)
        {
            return Response.AsJson<string>("this is a test for services");
        }

        private Response DeleteStudent(dynamic parameters)
        {
            return Response.AsJson<string>("this is a test for services");
        }

        private Response SearchStudentByName(dynamic parameters)
        {
            return Response.AsJson<string>("this is a test for services");
        }
        private Response SearchStudentByType(dynamic parameters)
        {
            return Response.AsJson<string>("this is a test for services");
        }
        private Response SearchStudentByTypeAndGender(dynamic parameters)
        {
            return Response.AsJson<string>("this is a test for services");
        }


    }
}
