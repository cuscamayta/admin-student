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
        public static String ToTimestamp(this string value)
        {
            var baseDate = new DateTime(1970, 01, 01);
            var toDate = value.ConvertStringToDate();
            var numberOfSeconds = toDate.Subtract(baseDate).TotalSeconds;
            return numberOfSeconds.ToString();
        }

        public static string ToTimestamp(this DateTime value)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp.ToString();
        }

        public static DateTime TimeStampToDateTime(this string unixTimeStamp)
        {            
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(double.Parse(unixTimeStamp));
            return date;
        }
        public static DateTime UnixTimestampToDateTime(this string timestamp)
        {            
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(double.Parse(timestamp));
            return date;
        }

        private static DateTime ConvertStringToDate(this string dateString)
        {
            DateTime currentDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss,fff",
                                           System.Globalization.CultureInfo.InvariantCulture);
            return currentDate;
        }
    }
}
