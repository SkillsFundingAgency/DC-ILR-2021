using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearningDeliveryWorkPlacement : ILearningDeliveryWorkPlacement
    {
        public DateTime WorkPlaceStartDate { get; set; }

        public DateTime? WorkPlaceEndDateNullable { get; set; }

        public int WorkPlaceHours { get; set; }

        public int WorkPlaceMode { get; set; }

        public int? WorkPlaceEmpIdNullable { get; set; }
    }
}
