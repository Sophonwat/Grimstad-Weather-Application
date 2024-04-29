namespace Grimstad_Weather_Application
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labSunrise1 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset1 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labPressure1 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labWindSpeed1 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(153, 62);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(238, 31);
            this.TBCity.TabIndex = 1;
            this.TBCity.Text = "Grimstad";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(397, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(92, 183);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(103, 26);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(92, 232);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(75, 26);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details";
            // 
            // labSunrise1
            // 
            this.labSunrise1.AutoSize = true;
            this.labSunrise1.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise1.ForeColor = System.Drawing.Color.White;
            this.labSunrise1.Location = new System.Drawing.Point(92, 283);
            this.labSunrise1.Name = "labSunrise1";
            this.labSunrise1.Size = new System.Drawing.Size(85, 26);
            this.labSunrise1.TabIndex = 5;
            this.labSunrise1.Text = "Sunrise:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(183, 283);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(49, 26);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset1
            // 
            this.labSunset1.AutoSize = true;
            this.labSunset1.BackColor = System.Drawing.Color.Transparent;
            this.labSunset1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset1.ForeColor = System.Drawing.Color.White;
            this.labSunset1.Location = new System.Drawing.Point(92, 325);
            this.labSunset1.Name = "labSunset1";
            this.labSunset1.Size = new System.Drawing.Size(78, 26);
            this.labSunset1.TabIndex = 7;
            this.labSunset1.Text = "Sunset:";
            this.labSunset1.Click += new System.EventHandler(this.label5_Click);
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(176, 325);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(49, 26);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(472, 225);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(49, 26);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // labPressure1
            // 
            this.labPressure1.AutoSize = true;
            this.labPressure1.BackColor = System.Drawing.Color.Transparent;
            this.labPressure1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure1.ForeColor = System.Drawing.Color.White;
            this.labPressure1.Location = new System.Drawing.Point(353, 225);
            this.labPressure1.Name = "labPressure1";
            this.labPressure1.Size = new System.Drawing.Size(93, 26);
            this.labPressure1.TabIndex = 11;
            this.labPressure1.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(491, 183);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(49, 26);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // labWindSpeed1
            // 
            this.labWindSpeed1.AutoSize = true;
            this.labWindSpeed1.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed1.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed1.Location = new System.Drawing.Point(353, 183);
            this.labWindSpeed1.Name = "labWindSpeed1";
            this.labWindSpeed1.Size = new System.Drawing.Size(132, 26);
            this.labWindSpeed1.TabIndex = 9;
            this.labWindSpeed1.Text = "Wind Speed: ";
            this.labWindSpeed1.Click += new System.EventHandler(this.label9_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(97, 114);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(118, 56);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 369);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 100);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grimstad_Weather_Application.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 481);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labPressure1);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.labWindSpeed1);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunset1);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labSunrise1);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labSunrise1;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset1;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labPressure1;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labWindSpeed1;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

