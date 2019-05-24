using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3

{
    public class Reports
    {
        private string BrowserType;
        private string url;
        private DateTime date;
        //private FileStream fs;
        private StringBuilder reportcsv;
        private string filePath;
        private string fileName;

        public Reports(string BrowserType, string url)
        {
            this.BrowserType = BrowserType;
            this.url = url;
            date = DateTime.Now;
            //fileName = date.Date.Date.ToShortDateString() + date.TimeOfDay.Hours.ToString() + date.TimeOfDay.Minutes.ToString();
            fileName = date.ToString("yyyy-dd-M--HH-mm-ss");
            reportcsv = new StringBuilder();
            filePath = @"C:\C-sharpAsFuck\report1\" + fileName + ".csv";
            createCsvFile();
        }

        private void createCsvFile()
        {
            reportcsv.Append("StepDescription,");
            reportcsv.Append("Pass/Fail,");
            reportcsv.Append("Exception");
            File.AppendAllText(filePath, reportcsv.ToString());
        }

        public void addLine(string description, string result, string exception)
        {
            reportcsv.Append(Environment.NewLine);
            reportcsv.Append(description + ",");
            reportcsv.Append(result + ",");
            reportcsv.Append(exception + ",");
            reportcsv.Append(Environment.NewLine);
            File.WriteAllText(filePath, reportcsv.ToString());
        }
    }
}