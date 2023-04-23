using PetAsService.Forms;
using PetAsService.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsService
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Principal());
        }

        public static string nomeUsuario;
        public static string selectedApi = "";

        public static Icon getIcon()
        {
            Icon icon = null;
            switch (Program.selectedApi)
            {
                case "Dog":
                    icon = global::PetAsService.Properties.Resources.dogo_argentino1;
                    break;
                case "Gato":
                    icon = global::PetAsService.Properties.Resources.feliz1;
                    break;
            }
            return icon;
        }
    }
}
