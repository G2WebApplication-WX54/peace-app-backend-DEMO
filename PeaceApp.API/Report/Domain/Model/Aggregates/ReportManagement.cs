using PeaceApp.API.Report.Domain.Model.Commands;

namespace PeaceApp.API.Report.Domain.Model.Aggregates;

public partial class ReportManagement
{
    public int Id { get; private set; }
    public string KindOfReport { get; set; }
    public string Date { get; set; }
    public string District { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }

    protected ReportManagement()
    {
        this.KindOfReport = string.Empty;
        this.Date = string.Empty;
        this.District = string.Empty;
        this.Location = string.Empty;
        this.Description = string.Empty;
    }

    public ReportManagement(CreateReportCommand command)
    {
        this.KindOfReport = command.KindOfReport;
        this.Date = command.Date;
        this.District = command.District;
        this.Location = command.Location;
        this.Description = command.Description;
    }
}