using PeaceApp.API.Report.Domain.Model.Aggregates;
using PeaceApp.API.Shared.Domain.Repositories;

namespace PeaceApp.API.Report.Domain.Repositories;

public interface IReportManagementRepository : IBaseRepository<ReportManagement>
{
    Task<IEnumerable<ReportManagement>> FindAllByDistrictAsync(string district);
    Task<IEnumerable<ReportManagement>> FindAllByKindOfReport(string kindOfReport);
    Task<IEnumerable<ReportManagement>> FindAllByDate(string date);
    Task<IEnumerable<ReportManagement>> FindAllByDistrictAndDate(string district, string date);
}