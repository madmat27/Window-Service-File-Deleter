using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace LaserOpDeleter
{
    public partial class LaserOpDeleter : ServiceBase
    {
        public LaserOpDeleter()
        {
            InitializeComponent();
        }

        public void FileRemover()
        {
            // Add the path for the directory
            string FilePath = @"C:\MyPath";
            try
            {
                // Create an array for all the files contained in the directory
                string[] laserFiles = Directory.GetFiles(FilePath);
                for (int i = 0; i < laserFiles.Length; i++)
                {
                    //Delete all files that are older than 30 days
                    if (DateTime.Now.Subtract(File.GetLastWriteTime(laserFiles[i])).TotalDays > 30)
                    {
                        File.Delete(laserFiles[i]);
                    }
                }
            }
            catch
            {
            }
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // To do actions: 
            FileRemover();
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer(); // Set a timer to monitor the system
            timer.Interval = 60000; // Every 60 secs
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer); // Create a new handler
            // Timer is enabled and started
            timer.Enabled = true; 
            timer.Start();
        }

        protected override void OnStop()
        {
        }
    }
}
