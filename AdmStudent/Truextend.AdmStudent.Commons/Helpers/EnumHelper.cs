//-----------------------------------------------------------------------
// <copyright file="EnumHelper.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------


namespace Truextend.AdmStudent.Commons.Helpers
{
	using System;

    public static class EnumHelper
    {
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
