//-----------------------------------------------------------------------
// <copyright file="APIBootstrapper.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.TinyIoc;
    using Nancy.Validation.FluentValidation;
    using System.Linq;
    using Truextend.AdmStudent.Commons;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        /// <summary>
        /// Initialize the nancy app configuration
        /// </summary>
        /// <param name="container">current container</param>
        /// <param name="pipelines">current nancy pipeline</param>
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            Nancy.Json.JsonSettings.PrimitiveConverters.Add(new JsonConvertEnum());
            Nancy.Json.JsonSettings.RetainCasing = true;
            Nancy.Json.JsonSettings.MaxJsonLength = int.MaxValue;
            EnableCORS(pipelines);
            pipelines.BeforeRequest.AddItemToStartOfPipeline(context =>
            {
                if (context != null)
                {
                    //EnabledCORS(context);
                    var requestData = ConvertToString(context.Request.Body);
                    Logger.Debug(string.Format("Request: {0}", context.Request.Url));
                    Logger.Debug(string.Format("Request Data : {0}", requestData));
                }
                return null;
            });
        }

        private void EnableCORS(IPipelines pipelines)
        {
            pipelines.AfterRequest.AddItemToEndOfPipeline(ctx =>
            {
                if (ctx.Request.Headers.Keys.Contains("Origin"))
                {
                    var origins = "" + string.Join(" ", ctx.Request.Headers["Origin"]);
                    ctx.Response.Headers["Access-Control-Allow-Origin"] = origins;

                    if (ctx.Request.Method == "OPTIONS")
                    {                        
                        ctx.Response.Headers["Access-Control-Allow-Methods"] =
                            "GET, POST, PUT, DELETE, OPTIONS";

                        if (ctx.Request.Headers.Keys.Contains("Access-Control-Request-Headers"))
                        {
                            var allowedHeaders = "" + string.Join(
                                ", ", ctx.Request.Headers["Access-Control-Request-Headers"]);
                            ctx.Response.Headers["Access-Control-Allow-Headers"] = allowedHeaders;
                        }
                    }
                }
            });
        }


        /// <summary>
        /// Convert a request stream  to string
        /// </summary>
        /// <param name="requestBody">The current request stream</param>
        /// <returns>the request serialized</returns>
        private string ConvertToString(Nancy.IO.RequestStream requestBody)
        {
            var body = requestBody;
            int length = (int)requestBody.Length;
            byte[] data = new byte[length];
            body.Read(data, 0, length);
            return System.Text.Encoding.Default.GetString(data);
        }

        /// <summary>
        /// nancy application configuration
        /// </summary>
        /// <param name="container">current container</param>
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register(typeof(IFluentAdapterFactory), typeof(DefaultFluentAdapterFactory));
            container.Register<StudentSetupModule>().AsSingleton();
        }
    }
}
