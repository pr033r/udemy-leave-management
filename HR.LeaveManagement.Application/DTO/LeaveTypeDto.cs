﻿using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO {
    public class LeaveTypeDto : BaseDto {
        public string? Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
