using ESFA.DC.ILR.Model.Tests.Abstract;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerLearningDeliveryLearningDeliveryWorkPlacementTests : AbstractModelTests<MessageLearnerLearningDeliveryLearningDeliveryWorkPlacement>
    {
        [Fact]
        public void WorkPlaceEndDateNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.WorkPlaceEndDate, DateTime(), l => l.WorkPlaceEndDateSpecified, l => l.WorkPlaceEndDateNullable);
        }

        [Fact]
        public void WorkPlaceEndDateNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.WorkPlaceEndDate, DateTime(), l => l.WorkPlaceEndDateSpecified, l => l.WorkPlaceEndDateNullable);
        }

        [Fact]
        public void WorkPlaceEmpIdNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.WorkPlaceEmpId, Int(), l => l.WorkPlaceEmpIdSpecified, l => l.WorkPlaceEmpIdNullable);
        }

        [Fact]
        public void WorkPlaceEmpIdNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.WorkPlaceEmpId, Int(), l => l.WorkPlaceEmpIdSpecified, l => l.WorkPlaceEmpIdNullable);
        }
    }
}
