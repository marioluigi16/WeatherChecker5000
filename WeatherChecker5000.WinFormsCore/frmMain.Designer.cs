namespace WeatherChecker5000.WinFormsCore
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCurrentWeatherDescription = new System.Windows.Forms.Label();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.pbWeatherIcon = new System.Windows.Forms.PictureBox();
            this.rdoUnitImp = new System.Windows.Forms.RadioButton();
            this.rdoUnitMet = new System.Windows.Forms.RadioButton();
            this.grpUnitSelection = new System.Windows.Forms.GroupBox();
            this.rdoUnitKel = new System.Windows.Forms.RadioButton();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnDailyForecast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).BeginInit();
            this.grpUnitSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCity
            // 
            this.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(74, 40);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(389, 21);
            this.cboCity.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "ESC - Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(683, 408);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "F12 - Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(15, 40);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(53, 21);
            this.cboCountry.TabIndex = 0;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.CboCountry_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentWeatherDescription);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentTemp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbWeatherIcon);
            this.splitContainer1.Size = new System.Drawing.Size(776, 335);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblCurrentWeatherDescription
            // 
            this.lblCurrentWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeatherDescription.Location = new System.Drawing.Point(3, 160);
            this.lblCurrentWeatherDescription.Name = "lblCurrentWeatherDescription";
            this.lblCurrentWeatherDescription.Size = new System.Drawing.Size(416, 32);
            this.lblCurrentWeatherDescription.TabIndex = 1;
            this.lblCurrentWeatherDescription.Text = "--";
            this.lblCurrentWeatherDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTemp.Location = new System.Drawing.Point(3, 21);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(416, 139);
            this.lblCurrentTemp.TabIndex = 0;
            this.lblCurrentTemp.Text = "--°";
            this.lblCurrentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbWeatherIcon
            // 
            this.pbWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.pbWeatherIcon.Name = "pbWeatherIcon";
            this.pbWeatherIcon.Size = new System.Drawing.Size(344, 209);
            this.pbWeatherIcon.TabIndex = 0;
            this.pbWeatherIcon.TabStop = false;
            // 
            // rdoUnitImp
            // 
            this.rdoUnitImp.AutoSize = true;
            this.rdoUnitImp.Location = new System.Drawing.Point(27, 19);
            this.rdoUnitImp.Name = "rdoUnitImp";
            this.rdoUnitImp.Size = new System.Drawing.Size(75, 17);
            this.rdoUnitImp.TabIndex = 4;
            this.rdoUnitImp.TabStop = true;
            this.rdoUnitImp.Tag = "F";
            this.rdoUnitImp.Text = "Fahrenheit";
            this.rdoUnitImp.UseVisualStyleBackColor = true;
            this.rdoUnitImp.CheckedChanged += new System.EventHandler(this.RdoUnit_CheckedChanged);
            // 
            // rdoUnitMet
            // 
            this.rdoUnitMet.AutoSize = true;
            this.rdoUnitMet.Location = new System.Drawing.Point(132, 19);
            this.rdoUnitMet.Name = "rdoUnitMet";
            this.rdoUnitMet.Size = new System.Drawing.Size(58, 17);
            this.rdoUnitMet.TabIndex = 5;
            this.rdoUnitMet.TabStop = true;
            this.rdoUnitMet.Tag = "C";
            this.rdoUnitMet.Text = "Celsius";
            this.rdoUnitMet.UseVisualStyleBackColor = true;
            this.rdoUnitMet.CheckedChanged += new System.EventHandler(this.RdoUnit_CheckedChanged);
            // 
            // grpUnitSelection
            // 
            this.grpUnitSelection.Controls.Add(this.rdoUnitKel);
            this.grpUnitSelection.Controls.Add(this.rdoUnitMet);
            this.grpUnitSelection.Controls.Add(this.rdoUnitImp);
            this.grpUnitSelection.Location = new System.Drawing.Point(469, 12);
            this.grpUnitSelection.Name = "grpUnitSelection";
            this.grpUnitSelection.Size = new System.Drawing.Size(319, 49);
            this.grpUnitSelection.TabIndex = 6;
            this.grpUnitSelection.TabStop = false;
            this.grpUnitSelection.Text = "Select Temperature Unit";
            // 
            // rdoUnitKel
            // 
            this.rdoUnitKel.AutoSize = true;
            this.rdoUnitKel.Location = new System.Drawing.Point(234, 19);
            this.rdoUnitKel.Name = "rdoUnitKel";
            this.rdoUnitKel.Size = new System.Drawing.Size(54, 17);
            this.rdoUnitKel.TabIndex = 6;
            this.rdoUnitKel.TabStop = true;
            this.rdoUnitKel.Tag = "K";
            this.rdoUnitKel.Text = "Kelvin";
            this.rdoUnitKel.UseVisualStyleBackColor = true;
            this.rdoUnitKel.CheckedChanged += new System.EventHandler(this.RdoUnit_CheckedChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 24);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(82, 24);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // btnDailyForecast
            // 
            this.btnDailyForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyForecast.Location = new System.Drawing.Point(341, 408);
            this.btnDailyForecast.Name = "btnDailyForecast";
            this.btnDailyForecast.Size = new System.Drawing.Size(135, 30);
            this.btnDailyForecast.TabIndex = 9;
            this.btnDailyForecast.Text = "5 Day Forecast";
            this.btnDailyForecast.UseVisualStyleBackColor = true;
            this.btnDailyForecast.Click += new System.EventHandler(this.BtnDailyForecast_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDailyForecast);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.grpUnitSelection);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Checker 5000";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).EndInit();
            this.grpUnitSelection.ResumeLayout(false);
            this.grpUnitSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCurrentTemp;
        private System.Windows.Forms.Label lblCurrentWeatherDescription;
        private System.Windows.Forms.RadioButton rdoUnitImp;
        private System.Windows.Forms.RadioButton rdoUnitMet;
        private System.Windows.Forms.GroupBox grpUnitSelection;
        private System.Windows.Forms.RadioButton rdoUnitKel;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnDailyForecast;
        private System.Windows.Forms.PictureBox pbWeatherIcon;
    }
}

