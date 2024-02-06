using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Report
{
    internal class ExcelReportBuilder : ReportBuilder
    {
        public override void SetReportType()
        {
            report.ReportType = "Excel";
        }

        public override void SetReportHeader()
        {
            report.ReportHeader = "Excel Report Header";
        }
        public override void SetReportContent()
        {
            report.ReportContent = "Excel Report Content";
        }

        public override void SetReportFooter()
        {
            report.ReportFooter = "Excel Report Footer";
        }

    }
}
