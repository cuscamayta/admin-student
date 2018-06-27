using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.UI.Console;
using ConsoleTables;
using Truextend.AdmStudent.UI.Console.Model;
using Truextend.AdmStudent.UI.Console.Service;
using Truextend.AdmStudent.Commons.Helpers;

namespace Examples.System.Net
{

    public class WebRequestGetExample
    {
        public static void Main(string[] args)
        {
            try
            {
                var requestUri = Request.BuildUriAndParameters(args);
                switch (requestUri.Type)
                {
                    case TypeRequest.FindAll:
                        Console.WriteLine("Parameters not entered or incorrect, Displaying all data.");
                        Request.MakeRequest(Uris.GET_ALL_STUDENTS, PrinterData);
                        break;
                    case TypeRequest.FindByName:
                        Request.MakeRequest(string.Format(Uris.SEARCH_BY_NAME, requestUri.Parameters["name"]), PrinterData);
                        break;
                    case TypeRequest.FindByType:
                        Request.MakeRequest(string.Format(Uris.SEARCH_BY_TYPE, requestUri.Parameters["type"]), PrinterData);
                        break;
                    case TypeRequest.FindByTypeGender:
                        Request.MakeRequest(string.Format(Uris.SEARCH_BY_TYPE_GENDER, requestUri.Parameters["type"], requestUri.Parameters["gender"]), PrinterData);
                        break;
                    default:
                        throw new InvalidOperationException("Error while retrieving the parameters");
                }
            }
            catch (InvalidOperationException exception)
            {
                WriteConsoleError(() =>
                {
                    Console.WriteLine(string.Format("Message Error:{0}", exception.InnerException.Message));
                });
            }
            catch (Exception exception)
            {
                WriteConsoleError(() =>
                {
                    Console.WriteLine(string.Format("Message Error:{0}", exception.InnerException.Message));
                });
            }
        }

        private static void PrinterData(Response<string> response)
        {
            if (response.Success)
            {
                var students = JsonConvert.DeserializeObject<List<Student>>(response.Data);
                var table = new ConsoleTable("Id", "Type", "Name", "Gender", "LastUpdate");

                students.ForEachWithIndex((student, index) =>
                {
                    table.AddRow(index, student.Type.ToString(), student.Name, student.Gender.ToString(), student.LastUpdate);
                });

                WriteConsoleSuccess(() =>
                {
                    table.Write();
                    Console.ReadLine();
                });

            }
            else
            {
                WriteConsoleError(() =>
                {
                    Console.WriteLine(string.Format("Status Code:{0}", response.Status));
                    Console.WriteLine(string.Format("Message Error:{0}", response.Message));
                });

            }
        }

        private static void WriteConsoleError(Action funcToWriteInConsole)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            funcToWriteInConsole();
            Console.ResetColor();
        }

        private static void WriteConsoleSuccess(Action funcToWriteInConsole)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            funcToWriteInConsole();
            Console.ResetColor();
        }
    }
}