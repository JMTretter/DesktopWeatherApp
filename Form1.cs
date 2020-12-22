using Microsoft.Build.BuildEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCurrentWeather_Click(object sender, EventArgs e)
        {
            List<string> location = GetIPAddress.IPAddress();
            List<List<string>> forecast = GetWeather.GetWeatherForcast(location);

            //set location for first ListView
            Point boxPoint = new Point(13,60);

            //Build one ListView for each day in the forcecast
            foreach (var a in forecast)
            {
                ListView view = new ListView();
                view.AutoSize = true;
                view.Margin = new Padding(5);
                view.Width = 340;
                view.Height = 170;

                //Add date and weather description for each day
                Label labelDate = new Label();
                labelDate.Text = a[0] + " - " + a[5];
                labelDate.Font = new Font("Ariel", 12);
                labelDate.Location = new Point(10, 5);
                labelDate.AutoSize = true;
                view.Controls.Add(labelDate);

                //add forecasted high for each day
                Label labelHigh = new Label();
                labelHigh.Text = "Forecasted High: " + a[4] + "°C";
                labelHigh.Font = new Font("Ariel", 12);
                labelHigh.Location = new Point(10, 45);
                labelHigh.AutoSize = true;
                view.Controls.Add(labelHigh);

                //add forecasted low for each day
                Label labelLow = new Label();
                labelLow.Text = "Forecasted Low: " + a[3] + "°C";
                labelLow.Font = new Font("Ariel", 12);
                labelLow.Location = new Point(10, 65);
                labelLow.AutoSize = true;
                view.Controls.Add(labelLow);

                //add "feels like" high temp for each day
                Label labelFeelsLikeHigh = new Label();
                labelFeelsLikeHigh.Text = "'Feels' Like High Temp:  " + a[1] + "°C";
                labelFeelsLikeHigh.Font = new Font("Ariel", 12);
                labelFeelsLikeHigh.Location = new Point(10, 100);
                labelFeelsLikeHigh.AutoSize = true;
                view.Controls.Add(labelFeelsLikeHigh);

                //add "feels like" low temp for each day
                Label labelFeelsLikeLow = new Label();
                labelFeelsLikeLow.Text = "'Feels' Like Low Temp:  " + a[2] + "°C";
                labelFeelsLikeLow.Font = new Font("Ariel", 12);
                labelFeelsLikeLow.Location = new Point(10, 120);
                labelFeelsLikeLow.AutoSize = true;
                view.Controls.Add(labelFeelsLikeLow);

                //set location for listview
                view.Location = boxPoint;
                boxPoint.Y += view.Height + 20;

                //adds listview to form
                this.Controls.Add(view);
            }
        }

        private void btnHourly_Click(object sender, EventArgs e)
        {
            List<string> location = GetIPAddress.IPAddress();
            List<List<string>> forecast = GetWeather.GetHourlyForcast(location);

            //set location for first ListView
            Point boxPoint = new Point(500, 60);

            //Build one ListView for each day in the forcecast
            foreach (var a in forecast)
            {
                ListView view = new ListView();
                view.AutoSize = true;
                view.Margin = new Padding(5);
                view.Width = 340;
                view.Height = 170;

                //Add time and description 
                Label labelDate = new Label();
                labelDate.Text = a[0] + " - " + a[3];
                labelDate.Font = new Font("Ariel", 12);
                labelDate.Location = new Point(10, 5);
                labelDate.AutoSize = true;
                view.Controls.Add(labelDate);

                //Add Temp
                Label labelTemp = new Label();
                labelTemp.Text = "Actual Temp: " + a[2] + "°C";
                labelTemp.Font = new Font("Ariel", 12);
                labelTemp.Location = new Point(10, 45);
                labelTemp.AutoSize = true;
                view.Controls.Add(labelTemp);

                //Add "Feels Like" temp
                Label labelFeelsLike = new Label();
                labelFeelsLike.Text = "'Feels' Like:   " + a[1] + "°C";
                labelFeelsLike.Font = new Font("Ariel", 12);
                labelFeelsLike.Location = new Point(10, 100);
                labelFeelsLike.AutoSize = true;
                view.Controls.Add(labelFeelsLike);

                //set location for listview and add to form1
                view.Location = boxPoint;
                boxPoint.Y += view.Height + 20;
                this.Controls.Add(view);

                view.Show();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = true;
        }
    }
}
