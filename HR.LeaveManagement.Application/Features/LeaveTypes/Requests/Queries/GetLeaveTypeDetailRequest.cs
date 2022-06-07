using HR.LeaveManagement.Application.DTO;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries {
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto> {
        public int Id { get; set; }
    }
}
