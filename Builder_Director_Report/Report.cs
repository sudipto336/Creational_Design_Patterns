using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Report
{
    internal class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public string ReportFooter { get; set; }

        public void DisplayReport() {
            Console.WriteLine($"Report Type: {ReportType}");
            Console.WriteLine("Report Header: {0}", ReportHeader);
            Console.WriteLine($"Report Content: {ReportContent}");
            Console.WriteLine($"Report Footer: {ReportFooter}");
        }
    }
}
