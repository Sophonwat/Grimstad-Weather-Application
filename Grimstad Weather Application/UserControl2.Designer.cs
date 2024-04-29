namespace Grimstad_Weather_Application
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTemp = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labDT = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.Location = new System.Drawing.Point(155, 135);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(126, 28);
            this.labTemp.TabIndex = 9;
            this.labTemp.Text = "Temprature";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDescription.Location = new System.Drawing.Point(154, 96);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(120, 28);
            this.labWeatherDescription.TabIndex = 8;
            this.labWeatherDescription.Text = "Description";
            // 
            // labMainWeather
            // 
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainWeather.Location = new System.Drawing.Point(155, 54);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(59, 28);
            this.labMainWeather.TabIndex = 7;
            this.labMainWeather.Text = "Clear";
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.Location = new System.Drawing.Point(155, 15);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(81, 28);
            this.labDT.TabIndex = 6;
            this.labDT.Text = "Sunday";
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(2, 1);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(146, 178);
            this.picWeatherIcon.TabIndex = 5;
            this.picWeatherIcon.TabStop = false;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(779, 182);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labTemp;
        public System.Windows.Forms.Label labWeatherDescription;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.PictureBox picWeatherIcon;
    }
}
