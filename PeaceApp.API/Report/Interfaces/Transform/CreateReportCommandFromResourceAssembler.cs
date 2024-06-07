using PeaceApp.API.Report.Domain.Model.Commands;
using PeaceApp.API.Report.Interfaces.Resources;

namespace PeaceApp.API.Report.Interfaces.Transform;

public static class CreateReportCommandFromResourceAssembler
{
    public static CreateReportCommand ToCommandFromResource(CreateReportResource resource)
    {
        return new CreateReportCommand(resource.KindOfReport, resource.Date, resource.District, resource.Location,
            resource.Description);
        
    }
}