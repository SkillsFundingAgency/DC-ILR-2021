using ESFA.DC.ILR.Model.Tests.Abstract;
using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerTests : AbstractModelTests<MessageLearner>
    {
        [Fact]
        public void AccomNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.Accom, Int(), l => l.AccomSpecified, l => l.AccomNullable);
        }

        [Fact]
        public void AccomNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.Accom, Int(), l => l.AccomSpecified, l => l.AccomNullable);
        }

        [Fact]
        public void ALSCostNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.ALSCost, Int(), l => l.ALSCostSpecified, l => l.ALSCostNullable);
        }

        [Fact]
        public void ALSCostNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.ALSCost, Int(), l => l.ALSCostSpecified, l => l.ALSCostNullable);
        }

        [Fact]
        public void DateOfBirthNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.DateOfBirth, DateTime(), l => l.DateOfBirthSpecified, l => l.DateOfBirthNullable);
        }

        [Fact]
        public void DateOfBirthNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.DateOfBirth, DateTime(), l => l.DateOfBirthSpecified, l => l.DateOfBirthNullable);
        }

        [Fact]
        public void PMUKPRNNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PMUKPRN, Int(), l => l.PMUKPRNSpecified, l => l.PMUKPRNNullable);
        }

        [Fact]
        public void PMUKPRNNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PMUKPRN, Int(), l => l.PMUKPRNSpecified, l => l.PMUKPRNNullable);
        }

        [Fact]
        public void PrevUKPRNNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PrevUKPRN, Int(), l => l.PrevUKPRNSpecified, l => l.PrevUKPRNNullable);
        }

        [Fact]
        public void PrevUKPRNNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PrevUKPRN, Int(), l => l.PrevUKPRNSpecified, l => l.PrevUKPRNNullable);
        }

        [Fact]
        public void PlanEEPHoursNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PlanEEPHours, Int(), l => l.PlanEEPHoursSpecified, l => l.PlanEEPHoursNullable);
        }

        [Fact]
        public void PlanEEPHoursNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PlanEEPHours, Int(), l => l.PlanEEPHoursSpecified, l => l.PlanEEPHoursNullable);
        }

        [Fact]
        public void PlanLearnHoursNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PlanLearnHours, Int(), l => l.PlanLearnHoursSpecified, l => l.PlanLearnHoursNullable);
        }

        [Fact]
        public void PlanLearnHoursNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PlanLearnHours, Int(), l => l.PlanLearnHoursSpecified, l => l.PlanEEPHoursNullable);
        }

        [Fact]
        public void PriorAttainNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PriorAttain, Int(), l => l.PriorAttainSpecified, l => l.PriorAttainNullable);
        }

        [Fact]
        public void PriorAttainNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PriorAttain, Int(), l => l.PriorAttainSpecified, l => l.PriorAttainNullable);
        }

        [Fact]
        public void ContactPreferences()
        {
            var learner = new MessageLearner()
            {
                ContactPreference = new MessageLearnerContactPreference[]
                {
                    new MessageLearnerContactPreference()
                }
            };

            learner.ContactPreferences.Should().BeSameAs(learner.ContactPreference);
            learner.ContactPreferences.Should().HaveCount(1);
        }

        [Fact]
        public void LearnerEmploymentStatuses()
        {
            var learner = new MessageLearner()
            {
                LearnerEmploymentStatus = new MessageLearnerLearnerEmploymentStatus[]
                {
                    new MessageLearnerLearnerEmploymentStatus()
                }
            };

            learner.LearnerEmploymentStatuses.Should().BeSameAs(learner.LearnerEmploymentStatus);
            learner.LearnerEmploymentStatuses.Should().HaveCount(1);
        }

        [Fact]
        public void LearnerFAMs()
        {
            var learner = new MessageLearner()
            {
                LearnerFAM = new MessageLearnerLearnerFAM[]
                {
                    new MessageLearnerLearnerFAM()
                }
            };

            learner.LearnerFAMs.Should().BeSameAs(learner.LearnerFAM);
            learner.LearnerFAMs.Should().HaveCount(1);
        }

        [Fact]
        public void LearnerHEEntity()
        {
            var learner = new MessageLearner()
            {
                LearnerHE = new MessageLearnerLearnerHE()
            };

            learner.LearnerHEEntity.Should().BeSameAs(learner.LearnerHE);
        }

        [Fact]
        public void LearningDeliveries()
        {
            var learner = new MessageLearner()
            {
                LearningDelivery = new MessageLearnerLearningDelivery[]
                {
                    new MessageLearnerLearningDelivery()
                }
            };

            learner.LearningDeliveries.Should().BeSameAs(learner.LearningDelivery);
            learner.LearningDeliveries.Should().HaveCount(1);
        }

        [Fact]
        public void LLDDAndHealthProblems()
        {
            var learner = new MessageLearner()
            {
                LLDDandHealthProblem = new MessageLearnerLLDDandHealthProblem[]
                {
                    new MessageLearnerLLDDandHealthProblem()
                }
            };

            learner.LLDDAndHealthProblems.Should().BeSameAs(learner.LLDDandHealthProblem);
            learner.LLDDAndHealthProblems.Should().HaveCount(1);
        }

        [Fact]
        public void ProviderSpecLearnerMonitorings()
        {
            var learner = new MessageLearner()
            {
                ProviderSpecLearnerMonitoring = new MessageLearnerProviderSpecLearnerMonitoring[]
                {
                    new MessageLearnerProviderSpecLearnerMonitoring()
                }
            };

            learner.ProviderSpecLearnerMonitorings.Should().BeSameAs(learner.ProviderSpecLearnerMonitoring);
            learner.ProviderSpecLearnerMonitorings.Should().HaveCount(1);
        }
    }
}
