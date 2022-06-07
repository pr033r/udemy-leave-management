﻿using HR.LeaveManagement.Application.DTO;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries {
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>> {
    }
}
