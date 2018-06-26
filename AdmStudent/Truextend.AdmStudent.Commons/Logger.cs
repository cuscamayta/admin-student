//-----------------------------------------------------------------------
// <copyright file="Logger.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Commons
{
	using System;

    public class Logger
    {
        public static void Error(Exception exception)
        {
            throw new NotImplementedException();
        }

        public static void Error(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public static void Fatal(string innerMessage, Exception exception)
        {
            throw new NotImplementedException();
        }
        public static void Info(string information)
        {
            Console.WriteLine(information);
        }
    }
}
