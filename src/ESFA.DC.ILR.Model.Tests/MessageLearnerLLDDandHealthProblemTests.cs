using ESFA.DC.ILR.Model.Tests.Abstract;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerLLDDandHealthProblemTests : AbstractModelTests<MessageLearnerLLDDandHealthProblem>
    {
        [Fact]
        public void PrimaryLLDDNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PrimaryLLDD, Int(), l => l.PrimaryLLDDSpecified, l => l.PrimaryLLDDNullable);
        }

        [Fact]
        public void PrimaryLLDDNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PrimaryLLDD, Int(), l => l.PrimaryLLDDSpecified, l => l.PrimaryLLDDNullable);
        }
    }
}
