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
        public Logger()
        {
        }

        public static void Error(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public static void Error(Exception exception, string message)
        {
            Console.WriteLine(message);
        }

        public static void Debug( string message)
        {
            Console.WriteLine(message);
        }

        public static void Fatal(string innerMessage, Exception exception)
        {
            Console.WriteLine(innerMessage);
        }
        public static void Info(string information)
        {
            Console.WriteLine(information);
        }
    }
}
