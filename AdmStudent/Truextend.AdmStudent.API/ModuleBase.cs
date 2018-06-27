using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Commons.Models;

namespace Truextend.AdmStudent.API
{
    public abstract class ModuleBase : NancyModule
    {
        public ModuleBase(string uri)
            : base(uri)
        {
        }

        public Response HandlerErrorAndExecute<T>(Func<T> funcToExecute) where T : class
        {
            try
            {
                var responseData = funcToExecute();
                var responseResult = new ResponseDTO(string.Empty, responseData, true, (int)HttpStatusCode.OK);

                return Response.AsJson(responseResult);
            }
            catch (ArgumentException exception)
            {
                var responseResult = new ResponseDTO(exception.InnerException.Message, string.Empty, false, (int)HttpStatusCode.InternalServerError);
                return Response.AsJson(responseResult);
            }
            catch (RequestExecutionException exception)
            {
                var responseResult = new ResponseDTO(exception.InnerException.Message, string.Empty, false, (int)HttpStatusCode.InternalServerError);
                return Response.AsJson(responseResult);
            }
            catch (Exception exception)
            {
                var responseResult = new ResponseDTO(exception.InnerException.Message, string.Empty, false, (int)HttpStatusCode.InternalServerError);
                return Response.AsJson(responseResult);
            }
        }

    }
}
