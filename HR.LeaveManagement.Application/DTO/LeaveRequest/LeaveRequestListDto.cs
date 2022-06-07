﻿using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO.LeaveRequest {
    public class LeaveRequestListDto : BaseDto {
        public LeaveTypeDto? LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
