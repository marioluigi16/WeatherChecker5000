namespace WeatherChecker5000.WinForms
{
    partial class frmForecastBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDataTemp = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblWeatherDescription = new System.Windows.Forms.Label();
            this.lblRainfall = new System.Windows.Forms.Label();
            this.lblRainAmt = new System.Windows.Forms.Label();
            this.lblSnowfall = new System.Windows.Forms.Label();
            this.lblSnowAmt = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(12, 34);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(73, 13);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperature: ";
            // 
            // lblDataTemp
            // 
            this.lblDataTemp.AutoSize = true;
            this.lblDataTemp.Location = new System.Drawing.Point(91, 34);
            this.lblDataTemp.Name = "lblDataTemp";
            this.lblDataTemp.Size = new System.Drawing.Size(35, 13);
            this.lblDataTemp.TabIndex = 1;
            this.lblDataTemp.Text = "label1";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(12, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(24, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "day";
            // 
            // lblWeatherDescription
            // 
            this.lblWeatherDescription.AutoSize = true;
            this.lblWeatherDescription.Location = new System.Drawing.Point(12, 56);
            this.lblWeatherDescription.Name = "lblWeatherDescription";
            this.lblWeatherDescription.Size = new System.Drawing.Size(98, 13);
            this.lblWeatherDescription.TabIndex = 3;
            this.lblWeatherDescription.Text = "weatherDescription";
            // 
            // lblRainfall
            // 
            this.lblRainfall.AutoSize = true;
            this.lblRainfall.Location = new System.Drawing.Point(12, 96);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(45, 13);
            this.lblRainfall.TabIndex = 4;
            this.lblRainfall.Text = "Rainfall:";
            // 
            // lblRainAmt
            // 
            this.lblRainAmt.AutoSize = true;
            this.lblRainAmt.Location = new System.Drawing.Point(63, 96);
            this.lblRainAmt.Name = "lblRainAmt";
            this.lblRainAmt.Size = new System.Drawing.Size(13, 13);
            this.lblRainAmt.TabIndex = 5;
            this.lblRainAmt.Text = "0";
            // 
            // lblSnowfall
            // 
            this.lblSnowfall.AutoSize = true;
            this.lblSnowfall.Location = new System.Drawing.Point(146, 96);
            this.lblSnowfall.Name = "lblSnowfall";
            this.lblSnowfall.Size = new System.Drawing.Size(50, 13);
            this.lblSnowfall.TabIndex = 6;
            this.lblSnowfall.Text = "Snowfall:";
            // 
            // lblSnowAmt
            // 
            this.lblSnowAmt.AutoSize = true;
            this.lblSnowAmt.Location = new System.Drawing.Point(202, 96);
            this.lblSnowAmt.Name = "lblSnowAmt";
            this.lblSnowAmt.Size = new System.Drawing.Size(13, 13);
            this.lblSnowAmt.TabIndex = 7;
            this.lblSnowAmt.Text = "0";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(12, 76);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(35, 13);
            this.lblWind.TabIndex = 8;
            this.lblWind.Text = "Wind:";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(53, 76);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblWindSpeed.TabIndex = 9;
            this.lblWindSpeed.Text = "0";
            // 
            // frmForecastBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 118);
            this.ControlBox = false;
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblSnowAmt);
            this.Controls.Add(this.lblSnowfall);
            this.Controls.Add(this.lblRainAmt);
            this.Controls.Add(this.lblRainfall);
            this.Controls.Add(this.lblWeatherDescription);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDataTemp);
            this.Controls.Add(this.lblTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForecastBox";
            this.Text = "frmForecastBox";
            this.Load += new System.EventHandler(this.FrmForecastBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDataTemp;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblWeatherDescription;
        private System.Windows.Forms.Label lblRainfall;
        private System.Windows.Forms.Label lblRainAmt;
        private System.Windows.Forms.Label lblSnowfall;
        private System.Windows.Forms.Label lblSnowAmt;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblWindSpeed;
    }
}