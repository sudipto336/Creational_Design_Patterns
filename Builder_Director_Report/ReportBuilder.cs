using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Report
{
    internal abstract class ReportBuilder
    {
        protected Report report;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateReport()
        {
            report = new Report();
        }
        public Report GetReport()
        {
            return report;
        }

    }
}
