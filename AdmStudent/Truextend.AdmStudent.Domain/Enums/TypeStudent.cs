//-----------------------------------------------------------------------
// <copyright file="TypeStudent.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Truextend.AdmStudent.Domain.Enums
{
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
