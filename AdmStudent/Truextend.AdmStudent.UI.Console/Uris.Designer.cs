﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Truextend.AdmStudent.UI.Console {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Uris {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Uris() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Truextend.AdmStudent.UI.Console.Uris", typeof(Uris).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:3002/api/v1/student.
        /// </summary>
        internal static string CREATE_STUDENT {
            get {
                return ResourceManager.GetString("CREATE_STUDENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:3002/api/v1/students/{0}.
        /// </summary>
        internal static string DELETE_STUDENT {
            get {
                return ResourceManager.GetString("DELETE_STUDENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:3002/api/v1/students.
        /// </summary>
        internal static string GET_ALL_STUDENTS {
            get {
                return ResourceManager.GetString("GET_ALL_STUDENTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:3002/api/v1/students/{0}.
        /// </summary>
        internal static string SEARCH_BY_NAME {
            get {
                return ResourceManager.GetString("SEARCH_BY_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:3002/api/v1/students/types/{0}.
        /// </summary>
        internal static string SEARCH_BY_TYPE {
            get {
                return ResourceManager.GetString("SEARCH_BY_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:3002/api/v1/students/types/{0}/gender/{1}.
        /// </summary>
        internal static string SEARCH_BY_TYPE_GENDER {
            get {
                return ResourceManager.GetString("SEARCH_BY_TYPE_GENDER", resourceCulture);
            }
        }
    }
}