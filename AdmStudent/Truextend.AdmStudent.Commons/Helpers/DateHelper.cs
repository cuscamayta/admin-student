//-----------------------------------------------------------------------
// <copyright file="DateHelper.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Commons.Helpers
{
	using System;

    public static class DateHelper
    {
        public static String ToTimestamp(this DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
