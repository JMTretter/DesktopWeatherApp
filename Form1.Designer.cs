namespace DesktopWeatherApp
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
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnHourly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaily
            // 
            this.btnDaily.Location = new System.Drawing.Point(13, 4);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(330, 32);
            this.btnDaily.TabIndex = 0;
            this.btnDaily.Text = "Daily Forecast";
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnCurrentWeather_Click);
            // 
            // btnHourly
            // 
            this.btnHourly.Location = new System.Drawing.Point(516, 3);
            this.btnHourly.Name = "btnHourly";
            this.btnHourly.Size = new System.Drawing.Size(330, 33);
            this.btnHourly.TabIndex = 1;
            this.btnHourly.Text = "Hourly Forecast";
            this.btnHourly.UseVisualStyleBackColor = true;
            this.btnHourly.Click += new System.EventHandler(this.btnHourly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 562);
            this.Controls.Add(this.btnHourly);
            this.Controls.Add(this.btnDaily);
            this.Name = "Form1";
            this.Text = "Local Weather";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnHourly;
    }
}

