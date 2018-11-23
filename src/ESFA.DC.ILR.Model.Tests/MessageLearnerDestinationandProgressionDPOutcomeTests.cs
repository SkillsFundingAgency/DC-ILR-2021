using ESFA.DC.ILR.Model.Tests.Abstract;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerDestinationandProgressionDPOutcomeTests : AbstractModelTests<MessageLearnerDestinationandProgressionDPOutcome>
    {
        [Fact]
        public void OutStartEndNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.OutEndDate, DateTime(), l => l.OutEndDateSpecified, l => l.OutEndDateNullable);
        }

        [Fact]
        public void OutEndateNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.OutEndDate, DateTime(), l => l.OutEndDateSpecified, l => l.OutEndDateNullable);
        }
    }
}
