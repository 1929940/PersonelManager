﻿using API.Core.Logic;
using API.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.HR.Logic {
    public class LeaveManager : BaseEntityManager {

        public static LeaveDTO CreateDTO(Leave leave) {
            var dto = new LeaveDTO() {
                Id = leave.Id,
                Employee = EmployeeManager.CreateSimplifiedDTO(leave.Employee),
                From = leave.From,
                To = leave.To,
                Type = leave.Type,
                Comment = leave.Comment
            };
            CopyTags(leave, ref dto);
            return dto;
        }

        public static void UpdateWithDTO(LeaveDTO dto, ref Leave leave) {
            leave.Id = dto.Id;
            leave.EmployeeId = dto.Employee.Id;
            leave.From = dto.From;
            leave.To = dto.To;
            leave.Type = dto.Type;
            leave.Comment = dto.Comment;

            CopyTags(dto, ref leave);
        }
    }
}
