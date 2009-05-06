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
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using ATB_Framework.Functions;
using ATB_Framework.Controls;
using System.IO;

namespace PM_Plugins.PM_SystemInfo
{
    internal partial class frmWeather : ATB_Framework.Forms.frmDialogEx
    {
        #region "Singleton"

        private static frmWeather _frmWeather = null;

        internal static frmWeather getInstance()
        {
            if (_frmWeather == null)
                _frmWeather = new frmWeather();
            return _frmWeather;
        }

        #endregion

        #region "Constructor"

        internal frmWeather()
        {
            InitializeComponent();
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IDictionary<String, String> _Locations = new Dictionary<String, String>();

            int i = 0;
            
            listResult.Items.Clear();            
            _Locations.Clear();
            
            _Locations = SearchForLocationIds(txtCity.Text.Trim());
            
            if (_Locations != null)            
                foreach (System.Collections.Generic.KeyValuePair<String, String> loc in _Locations)
                {
                    listResult.Items.Add(loc.Key);
                    listResult.Items[i].SubItems.Add(loc.Value);

                    i += 1;
                }
        }


        public IDictionary<String, String> SearchForLocationIds(String location)
        {

            XmlReader xmldoc = null;
            String msg = "";
            IDictionary<String, String> valuePairs = new Dictionary<String, String>();
            String id = "";
            String type = "";
            String loc = "";

            try
            {
                // Trap blank locations.
                if (!String.IsNullOrEmpty(location))
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.CloseInput = true;

                    FileInfo file = ctrlSetupEx.Download("http://xoap.weather.com/search/search?where=" + location);

                    if (file != null)
                    {
                        xmldoc = XmlReader.Create(file.FullName);
                        xmldoc.ReadStartElement();
                        xmldoc.ReadToDescendant("loc");

                        if (xmldoc.AttributeCount == 0 && xmldoc.IsStartElement() == false)
                            valuePairs = null;
                        else
                        {
                            while (!(xmldoc.IsStartElement() == false))
                            {
                                xmldoc.MoveToElement();
                                id = xmldoc.GetAttribute("id");
                                type = xmldoc.GetAttribute("type");
                                loc = xmldoc.ReadElementString("loc");

                                valuePairs.Add(id, loc);
                            }
                        }
                    }
                }
                else
                {
                    valuePairs = null;

                }
            }
            catch (WebException ex)
            {
                msg = ex.Message;
                valuePairs = null;
            }
            catch (XmlException ex)
            {
                msg = ex.Message;
                valuePairs = null;
            }
            finally
            {                
                if (xmldoc != null)                
                    xmldoc.Close();                
                
                if (!String.IsNullOrEmpty(msg))
                    MessageBoxEx.getInstance().ShowMessage(ctrlSetupEx.GetLanguageString("frmWeather","msgErrorLocationID","Unable to obtain Location ID"),
                        ctrlSetupEx.GetLanguageString("Common","msgInfo","info"),MessageBoxButtons.OK,MessageBoxIcon.Information);                    
            }            

            return valuePairs;
        }

        private void txtCity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, new EventArgs());
        }

        private void frmWeather_Load(object sender, EventArgs e)
        {
            this.txtZipCode.Text = PM_Plugins.PM_Weather.Config.General.getInstance().ZipCode;
        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                if (listResult.SelectedItems.Count > 0)
                {
                    this.txtZipCode.Text = listResult.SelectedItems[0].SubItems[0].Text;
                    this.txtCity.Text = listResult.SelectedItems[0].SubItems[1].Text;
                }
            }
            catch (Exception ex)
            {
                cInOut.LogEntry(ex, false);
            }
        }

        private void listResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listResult_SelectedIndexChanged(sender,new EventArgs());
            btnOk_Click(sender,new EventArgs());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (this.txtZipCode.Text.Length == 8)
            {
                PM_Weather.Config.General.getInstance().ZipCode = this.txtZipCode.Text;
                this.Close();                
            }
            else
            {
                errorProvider.SetError(this.txtZipCode, ctrlSetupEx.GetLanguageString("frmWeather", "msgZipCode", "The Zipcode must be 8 characters"));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (this.txtZipCode.Text.Length != 8)
                errorProvider.SetError(this.txtZipCode, ctrlSetupEx.GetLanguageString("frmWeather", "msgZipCode", "The Zipcode must be 8 characters"));        
        }

    }
}
