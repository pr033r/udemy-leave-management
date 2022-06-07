﻿using HR.LeaveManagement.Application.DTO;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries {
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>> {
    }
}
