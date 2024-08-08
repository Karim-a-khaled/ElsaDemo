using Domain.Entities;

namespace Application.Services;

public interface ILeaveRequestService
{
    Task<string> ApproveLeaveRequestAsync(Employee employee);
}
