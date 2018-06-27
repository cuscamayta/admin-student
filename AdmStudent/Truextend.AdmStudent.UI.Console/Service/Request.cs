using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Commons.Models;
using Truextend.AdmStudent.UI.Console.Model;
using Truextend.AdmStudent.Commons;

namespace Truextend.AdmStudent.UI.Console.Service
{
    public class Request
    {
        public void MakeRequestCreateStudent(Action<object, UploadStringCompletedEventArgs> afterExecuteRequest)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-Type"] = "application/json";
                client.UploadStringCompleted += new UploadStringCompletedEventHandler((sender, e) => { afterExecuteRequest(sender, e); });

                client.UploadStringAsync(new Uri(Uris.CREATE_STUDENT), "POST", string.Empty);
            }
        }

        public static void MakeRequest(string uri, Action<ResponseDTO> printerData)
        {
            try
            {
                WebRequest request = WebRequest.Create(uri);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                using (StreamReader reader = new StreamReader(dataStream))
                {
                    //var responseResult = new ResponseDTO(string.Empty, reader.ReadToEnd(), true, (int)response.StatusCode);
                    var result = JsonConvert.DeserializeObject<ResponseDTO>(reader.ReadToEnd());
                    printerData(result);
                };
                response.Close();
            }
            catch (SocketException socketException)
            {
                var response = new ResponseDTO(socketException.InnerException.Message, string.Empty, false, (int)HttpStatusCode.ServiceUnavailable);
                printerData(response);
            }
            catch (Exception exception)
            {
                var response = new ResponseDTO(exception.InnerException.Message, string.Empty, false, (int)HttpStatusCode.InternalServerError);
                printerData(response);
            }
        }

        public static RequestUri BuildUriAndParameters(string[] arguments)
        {
            try
            {
                var parameter = ReadParameters(arguments);
                var requestType = TypeRequest.FindAll;
                if (parameter.Count > 0)
                {
                    if (parameter.Count == 1 && parameter.ContainsKey("name"))
                    {
                        requestType = TypeRequest.FindByName;
                    }
                    else if (parameter.Count == 1 && parameter.ContainsKey("type"))
                    {
                        requestType = TypeRequest.FindByType;
                    }
                    else if (parameter.Count == 2 && parameter.ContainsKey("type") && parameter.ContainsKey("gender"))
                    {
                        requestType = TypeRequest.FindByTypeGender;
                    }
                }
                return new RequestUri(requestType, parameter);
            }
            catch (ArgumentException exception)
            {
                Logger.Error(exception);
                return new RequestUri(TypeRequest.BadRequest, new Dictionary<string, string>());
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
                return new RequestUri(TypeRequest.BadRequest, new Dictionary<string, string>());
            }
        }

        private static Dictionary<string, string> ReadParameters(string[] args)
        {
            Regex cmdRegEx = new Regex(@"(?<name>.+?)=(?<val>.+)");

            Dictionary<string, string> cmdArgs = new Dictionary<string, string>();
            foreach (string s in args)
            {
                Match m = cmdRegEx.Match(s);
                if (m.Success)
                {
                    cmdArgs.Add(m.Groups[1].Value.ToLower(), m.Groups[2].Value);
                }
            }

            return cmdArgs;
        }
    }
}
