using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearnerEmploymentStatus
    {
        string AgreeId { get; }

        int EmpStat { get; }

        DateTime DateEmpStatApp { get; }

        int? EmpIdNullable { get; }

        IReadOnlyCollection<IEmploymentStatusMonitoring> EmploymentStatusMonitorings { get; }
    }
}
