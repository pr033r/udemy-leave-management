using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts {
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest> {
        Task<LeaveAllocation> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveRequestsWithDetails();
    }
}
