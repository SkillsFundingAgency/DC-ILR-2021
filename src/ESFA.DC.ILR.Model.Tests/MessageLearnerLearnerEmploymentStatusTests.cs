using ESFA.DC.ILR.Model.Tests.Abstract;
using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerLearnerEmploymentStatusTests : AbstractModelTests<MessageLearnerLearnerEmploymentStatus>
    {
        [Fact]
        public void EmpIdNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.EmpId, Int(), l => l.EmpIdSpecified, l => l.EmpIdNullable);
        }

        [Fact]
        public void EmpIdNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.EmpId, Int(), l => l.EmpIdSpecified, l => l.EmpIdNullable);
        }

        [Fact]
        public void EmploymentStatusMonitorings()
        {
            var learnerEmploymentStatus = new MessageLearnerLearnerEmploymentStatus()
            {
                EmploymentStatusMonitoring = new MessageLearnerLearnerEmploymentStatusEmploymentStatusMonitoring[]
                {
                    new MessageLearnerLearnerEmploymentStatusEmploymentStatusMonitoring()
                }
            };

            learnerEmploymentStatus.EmploymentStatusMonitorings.Should().BeSameAs(learnerEmploymentStatus.EmploymentStatusMonitoring);
            learnerEmploymentStatus.EmploymentStatusMonitorings.Should().HaveCount(1);
        }
    }
}
