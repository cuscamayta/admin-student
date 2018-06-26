//-----------------------------------------------------------------------
// <copyright file="GUIDHelper.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Commons.Helpers
{
	using System;

    public static class GUIDHelper
    {
        public static long ToLong(this Guid guid)
        {
            byte[] gb = guid.ToByteArray();
            int i = BitConverter.ToInt32(gb, 0);

            long longGuid = BitConverter.ToInt64(gb, 0);
            return longGuid;
        }

        public static bool IsNullOrEmpty(this Guid? guid)
        {
            return (!guid.HasValue || guid.Value == Guid.Empty);
        }
    }
}
