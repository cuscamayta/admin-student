//-----------------------------------------------------------------------
// <copyright file="TypeStudent.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Domain.Enums
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contain the options for type student
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeStudent
    {
        Kinder,
        Elementary,
        High,
        University
    }
}
