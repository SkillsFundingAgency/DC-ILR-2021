using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDeliveryLearningDeliveryWorkPlacement : ILearningDeliveryWorkPlacement
    {
        public DateTime? WorkPlaceEndDateNullable => workPlaceEndDateFieldSpecified ? (DateTime?)workPlaceEndDateField : null;

        public int? WorkPlaceEmpIdNullable => workPlaceEmpIdFieldSpecified ? (int?)workPlaceEmpIdField : null;
    }
}
