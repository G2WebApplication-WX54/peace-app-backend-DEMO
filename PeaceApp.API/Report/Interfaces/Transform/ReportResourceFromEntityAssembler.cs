using PeaceApp.API.Report.Domain.Model.Aggregates;
using PeaceApp.API.Report.Interfaces.Resources;

namespace PeaceApp.API.Report.Interfaces.Transform;

public static class ReportResourceFromEntityAssembler
{
    public static ReportResource ToResourceFromEntity(ReportManagement entity)
    {
        return new ReportResource(entity.Id, entity.KindOfReport, entity.Date, entity.District, entity.Location,
            entity.Description);
    }
}