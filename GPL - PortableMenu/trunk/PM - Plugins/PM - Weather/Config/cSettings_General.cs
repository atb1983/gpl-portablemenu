/*
    This file is part of GPL_PortableMenu.

    GPL_PortableMenu is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    GPL_PortableMenu is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with GPL_PortableMenu.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.IO;

namespace PM_Plugins.PM_Weather.Config
{
    [Serializable()]
    public class General
    {

        #region "Singleton"

        private static General _settingsGeneral = null;

        public static General getInstance()
        {
            if (_settingsGeneral == null)
                _settingsGeneral = new General();
            return _settingsGeneral;
        }

        public static void setInstance(General obj)
        {
            _settingsGeneral = obj;
        }

        #endregion

        #region "Enums"

        public enum eTypeTemperature
        {
            Celsius,
            Fahrenheit
        }

        #endregion

        #region "Properties"

        private String _zipCode = "SPXX0050"; // Madrid
        [CategoryAttribute("General"), Browsable(false), ReadOnly(false), BindableAttribute(false), DesignOnly(false), DescriptionAttribute("Change ZipCode")]
        public String ZipCode
        {
            get { return _zipCode; }
            set {
                if (value.Length == 8)
                    _zipCode = value;
            }
        }

        private bool _enableReload = true;
        [CategoryAttribute("General"), Browsable(true), ReadOnly(false), BindableAttribute(false), DesignOnly(false), DescriptionAttribute("Enable or Disable the Automatic Reload")]        
        public bool EnableReload
        {
            get { return _enableReload; }
            set { _enableReload = value; }
        }

        private int _reload = 15;
        [CategoryAttribute("General"), Browsable(true), ReadOnly(false), BindableAttribute(false), DesignOnly(false), DescriptionAttribute("Recargamos cada cierto tiempo")] 
        public int ReloadMinutes
        {
            get { return _reload; }
            set { _reload = value; }
        }

        private eTypeTemperature _typeTemperature = eTypeTemperature.Celsius;
        [CategoryAttribute("General"), Browsable(true), ReadOnly(false), BindableAttribute(false), DesignOnly(false), DescriptionAttribute("type of temperature, in Celcius or Fahrenheit ")]
        public eTypeTemperature TypeTemperature
        {
            get { return _typeTemperature; }
            set { _typeTemperature = value; }
        }

        private String _tempFolder = Path.GetTempPath() + "PM_Weather\\";
        [CategoryAttribute("Internal"), Browsable(false), ReadOnly(false), BindableAttribute(false), DesignOnly(false), DescriptionAttribute("")]        
        public String TempFolder
        {
            get { return _tempFolder; }
            set { _tempFolder = value; }
        }

        private String _tempFolderImages = Path.GetTempPath() + "PM_Weather\\images\\weather\\";
        [CategoryAttribute("Internal"), Browsable(false), ReadOnly(false), BindableAttribute(false), DesignOnly(false), DescriptionAttribute("")]
        public String TempFolderImages
        {
            get { return _tempFolderImages; }
            set { _tempFolderImages = value; }
        }        
        #endregion

    }
}
