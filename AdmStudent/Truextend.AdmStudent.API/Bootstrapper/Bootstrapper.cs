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

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            Nancy.Json.JsonSettings.PrimitiveConverters.Add(new JsonConvertEnum());
            Nancy.Json.JsonSettings.MaxJsonLength = int.MaxValue;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<StudentSetupModule>().AsSingleton();
        }

    }
}
