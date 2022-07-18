﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new InformacionContacto(1)); //Descomentar para probar la funcionalidad de Informacion de Contacto
            Application.Run(new MenuPrincipal());

            aplicacion = new MenuPrincipal();
            Application.Run(aplicacion);
 
        }
        static public MenuPrincipal aplicacion;
    }
}
