//-----------------------------------------------------------------------
// <copyright file="RequestUri.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.UI.Console.Model
{
    using System.Collections.Generic;
    public class RequestUri
    {
        public RequestUri(TypeRequest type, Dictionary<string, string> parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }
        public TypeRequest Type { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
    }
}
