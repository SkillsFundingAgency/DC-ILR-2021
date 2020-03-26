using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearnerEmploymentStatus
    {
        int EmpStat { get; }

        DateTime DateEmpStatApp { get; }

        int? EmpIdNullable { get; }

        IReadOnlyCollection<IEmploymentStatusMonitoring> EmploymentStatusMonitorings { get; }
    }
}
