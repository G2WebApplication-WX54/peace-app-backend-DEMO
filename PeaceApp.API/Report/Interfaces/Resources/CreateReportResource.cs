namespace PeaceApp.API.Report.Interfaces.Resources;

public record CreateReportResource(string KindOfReport, string Date, string District, string Location, string Description );
