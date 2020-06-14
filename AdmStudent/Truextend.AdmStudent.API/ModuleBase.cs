//-----------------------------------------------------------------------
// <copyright file="ModuleBase.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Nancy;
    using Nancy.Validation;
    using System;
    using Truextend.AdmStudent.Commons.Models;

    public abstract class ModuleBase : NancyModule
    {
        public ModuleBase(string uri)
            : base(uri)
        {
        }

        public Response ValidateHandlerErrorAndExecute<T>(ModelValidationResult validateModel, Func<T> funcToExecute) where T : class
        {
            if (!validateModel.IsValid)
            {
                return Response.AsJson(new ResponseDTO("Invalid parameters", validateModel.Errors, false, (int)HttpStatusCode.BadRequest));
            }

            return HandlerErrorAndExecute(funcToExecute);
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
