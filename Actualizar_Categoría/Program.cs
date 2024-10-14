using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actualizar_Categoría
{
    // Clase estática que contiene el punto de entrada principal para la aplicación
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread] // Indica que la aplicación utiliza un modelo de subprocesos de un solo hilo (necesario para aplicaciones de Windows Forms)
        static void Main()
        {
            // Habilita los estilos visuales para la aplicación
            Application.EnableVisualStyles();
            // Establece el modo de renderizado de texto compatible con versiones anteriores
            Application.SetCompatibleTextRenderingDefault(false);
            // Inicia el formulario principal de la aplicación (Form1)
            Application.Run(new Form1());
        }
    }
}
