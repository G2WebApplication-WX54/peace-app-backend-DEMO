using PeaceApp.API.Report.Domain.Model.Aggregates;
using PeaceApp.API.Report.Domain.Model.Queries;

namespace PeaceApp.API.Report.Domain.Services;

public interface IReportManagementQueryService
{
    Task<ReportManagement> Handle(GetReportByIdQuery query);
    Task<List<ReportManagement>> Handle(GetAllReportsByDateQuery query);
    Task<List<ReportManagement>> Handle(GetAllReportsByDistrictAndDateQuery query);
    Task<List<ReportManagement>> Handle(GetAllReportsByDistrictQuery query);
    Task<List<ReportManagement>> Handle(GetAllReportsByKindOfReportQuery query);
}