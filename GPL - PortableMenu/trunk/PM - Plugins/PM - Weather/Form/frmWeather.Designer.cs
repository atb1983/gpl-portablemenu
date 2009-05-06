namespace PM_Plugins.PM_SystemInfo
{
    partial class frmWeather
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listResult = new System.Windows.Forms.ListView();
            this.columnZipCode = new System.Windows.Forms.ColumnHeader();
            this.columnLocation = new System.Windows.Forms.ColumnHeader();
            this.txtCity = new ATB_Framework.Controls.TextBoxEx();
            this.lblCity = new ATB_Framework.Controls.LabelEx();
            this.btnSearch = new ATB_Framework.Controls.ButtonEx();
            this.btnCancel = new ATB_Framework.Controls.ButtonEx();
            this.btnOk = new ATB_Framework.Controls.ButtonEx();
            this.lblZipcode = new ATB_Framework.Controls.LabelEx();
            this.txtZipCode = new ATB_Framework.Controls.TextBoxEx();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackgroundImage = null;
            this.pnlIcon.SkinEnabled = true;
            this.pnlIcon.SkinImg = "Weather";
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(307, 2);
            // 
            // listResult
            // 
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnZipCode,
            this.columnLocation});
            this.listResult.ForeColor = System.Drawing.Color.SteelBlue;
            this.listResult.FullRowSelect = true;
            this.listResult.GridLines = true;
            this.listResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listResult.Location = new System.Drawing.Point(14, 101);
            this.listResult.MultiSelect = false;
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(299, 126);
            this.listResult.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listResult.TabIndex = 0;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            this.listResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listResult_MouseDoubleClick);
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // columnZipCode
            // 
            this.columnZipCode.Text = "ZipCode";
            this.columnZipCode.Width = 70;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLocation.Width = 200;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(14, 75);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(218, 20);
            this.txtCity.SkinEnabled = true;
            this.txtCity.SkinImg = "";
            this.txtCity.TabIndex = 1;
            this.txtCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyUp);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCity.Location = new System.Drawing.Point(14, 59);
            this.lblCity.Name = "lblCity";
            this.lblCity.ReallyTransparent = false;
            this.lblCity.Size = new System.Drawing.Size(105, 13);
            this.lblCity.SkinEnabled = true;
            this.lblCity.SkinImg = "";
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City (State / Country)";
            this.lblCity.TextLanguageDefault = "City (State / Country)";
            this.lblCity.TextLanguageEnabled = true;
            this.lblCity.TextLanguageKey = "lblCity";
            this.lblCity.TextLanguageRegion = "frmWeather";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.HoverColorA = System.Drawing.Color.Orange;
            this.btnSearch.HoverColorB = System.Drawing.Color.Khaki;
            this.btnSearch.Location = new System.Drawing.Point(238, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.NormalColorA = System.Drawing.Color.White;
            this.btnSearch.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.SkinEnabled = true;
            this.btnSearch.SkinImg = "";
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextLanguageDefault = "Search";
            this.btnSearch.TextLanguageEnabled = true;
            this.btnSearch.TextLanguageKey = "btnSearch";
            this.btnSearch.TextLanguageRegion = "Common";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.HoverColorA = System.Drawing.Color.Orange;
            this.btnCancel.HoverColorB = System.Drawing.Color.Khaki;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(238, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.NormalColorA = System.Drawing.Color.White;
            this.btnCancel.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.SkinEnabled = true;
            this.btnCancel.SkinImg = "btnCancel";
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextLanguageDefault = "Cancel";
            this.btnCancel.TextLanguageEnabled = true;
            this.btnCancel.TextLanguageKey = "btnCancel";
            this.btnCancel.TextLanguageRegion = "Common";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOk.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.btnOk.HoverColorA = System.Drawing.Color.Orange;
            this.btnOk.HoverColorB = System.Drawing.Color.Khaki;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(157, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.btnOk.NormalColorA = System.Drawing.Color.White;
            this.btnOk.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.btnOk.Size = new System.Drawing.Size(75, 26);
            this.btnOk.SkinEnabled = true;
            this.btnOk.SkinImg = "btnOk";
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextLanguageDefault = "Ok";
            this.btnOk.TextLanguageEnabled = true;
            this.btnOk.TextLanguageKey = "btnOk";
            this.btnOk.TextLanguageRegion = "Common";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblZipcode.Location = new System.Drawing.Point(14, 19);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.ReallyTransparent = false;
            this.lblZipcode.Size = new System.Drawing.Size(50, 13);
            this.lblZipcode.SkinEnabled = true;
            this.lblZipcode.SkinImg = "";
            this.lblZipcode.TabIndex = 12;
            this.lblZipcode.Text = "Zip Code";
            this.lblZipcode.TextLanguageDefault = "Zip Code";
            this.lblZipcode.TextLanguageEnabled = true;
            this.lblZipcode.TextLanguageKey = "lblZipcode";
            this.lblZipcode.TextLanguageRegion = "frmWeather";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(14, 35);
            this.txtZipCode.MaxLength = 8;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(105, 20);
            this.txtZipCode.SkinEnabled = true;
            this.txtZipCode.SkinImg = "";
            this.txtZipCode.TabIndex = 11;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 269);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Name = "frmWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmWeather_Load);
            this.Controls.SetChildIndex(this.txtCity, 0);
            this.Controls.SetChildIndex(this.lblCity, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.listResult, 0);
            this.Controls.SetChildIndex(this.txtZipCode, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblZipcode, 0);
            this.Controls.SetChildIndex(this.pnlExit, 0);
            this.Controls.SetChildIndex(this.pnlIcon, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader columnZipCode;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private ATB_Framework.Controls.TextBoxEx txtCity;
        private ATB_Framework.Controls.LabelEx lblCity;
        private ATB_Framework.Controls.ButtonEx btnSearch;
        private ATB_Framework.Controls.ButtonEx btnCancel;
        private ATB_Framework.Controls.ButtonEx btnOk;
        private ATB_Framework.Controls.LabelEx lblZipcode;
        private ATB_Framework.Controls.TextBoxEx txtZipCode;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
