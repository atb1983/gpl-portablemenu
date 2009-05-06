/*
    This file is part of GPL-PortableMenu.

    GPL-PortableMenu is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    GPL-PortableMenu is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with GPL-PortableMenu.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;
using ATB_Framework.Controls;
using GPL_Portable_Menu.Classes;
using GPL_Portable_Menu.Forms;

namespace GPL_Portable_Menu
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(frmSplash.getInstance());
            if (frmSplash.getInstance().DialogResult == DialogResult.OK)
                Application.Run(frmPortableMenu.getInstance());

            cPortableMenu.SaveWindow(frmPortableMenu.getInstance());
            ctrlSetupEx.SaveSettings();
            ctrlSetupEx.ClosePlugins();            
        }
    }
}