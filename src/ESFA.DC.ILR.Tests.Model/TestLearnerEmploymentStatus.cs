using System;
using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearnerEmploymentStatus : ILearnerEmploymentStatus
    {
        public int EmpStat { get; set; }

        public DateTime DateEmpStatApp { get; set; }

        public int? EmpIdNullable { get; set; }

        public IReadOnlyCollection<IEmploymentStatusMonitoring> EmploymentStatusMonitorings { get; set; }
    }
}
