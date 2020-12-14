﻿using Leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Contracts
{
    public interface ILeaveAllocationRepository:IRepositoryBase<LeaveAllocation>
    {
        bool CheckAllocation(int leavetypeid, string employeeid);
        ICollection<LeaveAllocation> GetLeaveAllocationByEmployee(string employeeid);
        LeaveAllocation GetLeaveAllocationByEmployeeAndType(string employeeid, int leaveTypeid);
    
    }
}
