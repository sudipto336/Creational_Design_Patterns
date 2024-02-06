namespace Builder_Director_Report
{
    internal class ReportDirector
    {
        public Report CreateReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}
