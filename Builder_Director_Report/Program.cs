namespace Builder_Director_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportDirector director = new ReportDirector();
            ReportBuilder pdfBuilder = new PdfReportBuilder();
            ReportBuilder excelBuilder = new ExcelReportBuilder();
            Report pdfReport = director.CreateReport(pdfBuilder);
            Report excelReport = director.CreateReport(excelBuilder);
            pdfReport.DisplayReport();
            excelReport.DisplayReport();
        }
    }
}
