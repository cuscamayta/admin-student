//-----------------------------------------------------------------------
// <copyright file="Enums.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Commons.Extensions
{
    using System;

    public static class Enums
    {
        public static bool IsDefinedInEnum(this Enum value, Type enumType)
        {
            if (value.GetType() != enumType)
                return false;

            return Enum.IsDefined(enumType, value);
        }
    }
}
