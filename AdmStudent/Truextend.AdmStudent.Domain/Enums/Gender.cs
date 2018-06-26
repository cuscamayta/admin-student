//-----------------------------------------------------------------------
// <copyright file="Gender.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------


namespace Truextend.AdmStudent.Domain.Enums
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contain the options for gender
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female
    }
}
