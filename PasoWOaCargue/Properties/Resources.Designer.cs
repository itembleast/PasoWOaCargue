﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasoWOaCargue.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PasoWOaCargue.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Busca una cadena traducida similar a select distinct j0.Tipo_Documento, j0.Numero_Documento, j0.tercero,j0.Forma_de_Pago,j0.CódigoInventario, j0.Descripción,  j0.Conversion_Cantidad, j0.Conversion_Valor_Unitario,j0.Subtotal, j0.Iva, j0.Descuento_Porcentaje, Inventarios_Personalizado_1, Inventarios_Personalizado_2, Identificacion_tercero, Nombre_Ciudad, Fecha from Vista_Auxiliar_Movimientos_Inventario j0 /*inner join Vista_Tabla_Inventarios i on j0.CódigoInventario = i.Codigo_Producto*/ where j0.Tipo_Documento in (&apos;FV&apos;) and j0.Numero_Documento&gt; [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string ConsultaFactWO {
            get {
                return ResourceManager.GetString("ConsultaFactWO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a select Numero_Documento from Cargue
        ///order by Numero_Documento DESC
        ///LIMIT 1.
        /// </summary>
        internal static string UltimaFactsqlite {
            get {
                return ResourceManager.GetString("UltimaFactsqlite", resourceCulture);
            }
        }
    }
}
