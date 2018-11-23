using System;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearningDeliveryWorkPlacement
    {
        DateTime WorkPlaceStartDate { get; }

        DateTime? WorkPlaceEndDateNullable { get; }

        int WorkPlaceHours { get; }

        int WorkPlaceMode { get; }

        int? WorkPlaceEmpIdNullable { get; }
    }
}
