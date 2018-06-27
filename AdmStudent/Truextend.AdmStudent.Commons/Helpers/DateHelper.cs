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

        public static String ToTimestamp(this DateTime value)
        {
            var baseDate = new DateTime(1970, 01, 01);
            var numberOfSeconds = value.Subtract(baseDate).TotalSeconds;
            return numberOfSeconds.ToString();
        }

        public static string TimeStampToDateTime(this string unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(double.Parse(unixTimeStamp)).ToLocalTime();
            return dtDateTime.ToString("yyyy-MM-dd HH:mm:ss,fff");
        }

        private static DateTime ConvertStringToDate(this string dateString)
        {
            DateTime currentDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss,fff",
                                           System.Globalization.CultureInfo.InvariantCulture);
            return currentDate;
        }
    }
}
