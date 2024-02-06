using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Report
{
    internal class PdfReportBuilder : ReportBuilder
    {
        public override void SetReportType()
        {
            report.ReportType = "PDF";
        }

        public override void SetReportHeader()
        {
            report.ReportHeader = "PDF Report Header";
        }
        public override void SetReportContent()
        {
            report.ReportContent = "PDF Report Content";
        }

        public override void SetReportFooter()
        {
            report.ReportFooter = "PDF Report Footer";
        }

    }
}
