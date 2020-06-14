//-----------------------------------------------------------------------
// <copyright file="JsonConvertEnum.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Nancy.Json;
    using System;
    using System.Collections.Generic;

    public class JsonConvertEnum : JavaScriptPrimitiveConverter
    {
        public override IEnumerable<Type> SupportedTypes
        {
            get
            {
                yield return typeof(Enum);
            }
        }
        
        public override object Deserialize(
            object primitiveValue, Type type, JavaScriptSerializer serializer)
        {
            if (!type.IsEnum)
            {
                return null;
            }

            return Enum.Parse(type, (string)primitiveValue);
        }

        public override object Serialize(
            object obj, JavaScriptSerializer serializer)
        {
            if (!obj.GetType().IsEnum)
            {
                return null;
            }

            return obj.ToString();
        }

    }
}
