using ESFA.DC.ILR.Model.Tests.Abstract;
using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerLearningDeliveryTests : AbstractModelTests<MessageLearnerLearningDelivery>
    {
        [Fact]
        public void AchDateNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.AchDate, DateTime(), ld => ld.AchDateSpecified, ld => ld.AchDateNullable);
        }

        [Fact]
        public void AchDateNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.AchDate, DateTime(), ld => ld.AchDateSpecified, ld => ld.AchDateNullable);
        }

        [Fact]
        public void AddHoursNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.AddHours, Int(), ld => ld.AddHoursSpecified, ld => ld.AddHoursNullable);
        }

        [Fact]
        public void AddHoursNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.AddHours, Int(), ld => ld.AddHoursSpecified, ld => ld.AddHoursNullable);
        }

        [Fact]
        public void EmpOutcomeNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.EmpOutcome, Int(), ld => ld.EmpOutcomeSpecified, ld => ld.EmpOutcomeNullable);
        }

        [Fact]
        public void EmpOutcomeNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.EmpOutcome, Int(), ld => ld.EmpOutcomeSpecified, ld => ld.EmpOutcomeNullable);
        }

        [Fact]
        public void FworkCodeNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.FworkCode, Int(), ld => ld.FworkCodeSpecified, ld => ld.FworkCodeNullable);
        }

        [Fact]
        public void FworkCodeNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.FworkCode, Int(), ld => ld.FworkCodeSpecified, ld => ld.FworkCodeNullable);
        }

        [Fact]
        public void LearnActEndDateNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.LearnActEndDate, DateTime(), ld => ld.LearnActEndDateSpecified, ld => ld.LearnActEndDateNullable);
        }

        [Fact]
        public void LearnActEndDateNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.LearnActEndDate, DateTime(), ld => ld.LearnActEndDateSpecified, ld => ld.LearnActEndDateNullable);
        }

        [Fact]
        public void OrigLearnStartDateNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.OrigLearnStartDate, DateTime(), ld => ld.OrigLearnStartDateSpecified, ld => ld.OrigLearnStartDateNullable);
        }

        [Fact]
        public void OrigLearnStartDateNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.OrigLearnStartDate, DateTime(), ld => ld.OrigLearnStartDateSpecified, ld => ld.OrigLearnStartDateNullable);
        }

        [Fact]
        public void OtherFundAdjNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.OtherFundAdj, Int(), ld => ld.OtherFundAdjSpecified, ld => ld.OtherFundAdjNullable);
        }

        [Fact]
        public void OtherFundAdjNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.OtherFundAdj, Int(), ld => ld.OtherFundAdjSpecified, ld => ld.OtherFundAdjNullable);
        }

        [Fact]
        public void OutcomeNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.Outcome, Int(), ld => ld.OutcomeSpecified, ld => ld.OutcomeNullable);
        }

        [Fact]
        public void OutcomeNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.Outcome, Int(), ld => ld.OutcomeSpecified, ld => ld.OutcomeNullable);
        }

        [Fact]
        public void PartnerUKPRNNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.PartnerUKPRN, Int(), ld => ld.PartnerUKPRNSpecified, ld => ld.PartnerUKPRNNullable);
        }

        [Fact]
        public void PartnerUKPRNNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.PartnerUKPRN, Int(), ld => ld.PartnerUKPRNSpecified, ld => ld.PartnerUKPRNNullable);
        }

        [Fact]
        public void PriorLearnFundAdjNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.PriorLearnFundAdj, Int(), ld => ld.PriorLearnFundAdjSpecified, ld => ld.PriorLearnFundAdjNullable);
        }

        [Fact]
        public void PriorLearnFundAdjNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.PriorLearnFundAdj, Int(), ld => ld.PriorLearnFundAdjSpecified, ld => ld.PriorLearnFundAdjNullable);
        }

        [Fact]
        public void ProgTypeNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.ProgType, Int(), ld => ld.ProgTypeSpecified, ld => ld.ProgTypeNullable);
        }

        [Fact]
        public void ProgTypeNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.ProgType, Int(), ld => ld.ProgTypeSpecified, ld => ld.ProgTypeNullable);
        }

        [Fact]
        public void PwayCodeNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.PwayCode, Int(), ld => ld.PwayCodeSpecified, ld => ld.PwayCodeNullable);
        }

        [Fact]
        public void PwayCodeNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.PwayCode, Int(), ld => ld.PwayCodeSpecified, ld => ld.PwayCodeNullable);
        }

        [Fact]
        public void StdCodeNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.StdCode, Int(), ld => ld.StdCodeSpecified, ld => ld.StdCodeNullable);
        }

        [Fact]
        public void StdCodeNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.StdCode, Int(), ld => ld.StdCodeSpecified, ld => ld.StdCodeNullable);
        }

        [Fact]
        public void WithdrawReasonNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(ld => ld.WithdrawReason, Int(), ld => ld.WithdrawReasonSpecified, ld => ld.WithdrawReasonNullable);
        }

        [Fact]
        public void WithdrawReasonNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(ld => ld.WithdrawReason, Int(), ld => ld.WithdrawReasonSpecified, ld => ld.WithdrawReasonNullable);
        }

        [Fact]
        public void AppFinRecords()
        {
            var learningDelivery = new MessageLearnerLearningDelivery()
            {
                AppFinRecord = new MessageLearnerLearningDeliveryAppFinRecord[]
                {
                    new MessageLearnerLearningDeliveryAppFinRecord()
                }
            };

            learningDelivery.AppFinRecords.Should().BeSameAs(learningDelivery.AppFinRecord);
            learningDelivery.AppFinRecords.Should().HaveCount(1);
        }

        [Fact]
        public void LearningDeliveryFAMs()
        {
            var learningDelivery = new MessageLearnerLearningDelivery()
            {
                LearningDeliveryFAM = new MessageLearnerLearningDeliveryLearningDeliveryFAM[]
                {
                    new MessageLearnerLearningDeliveryLearningDeliveryFAM()
                }
            };

            learningDelivery.LearningDeliveryFAMs.Should().BeSameAs(learningDelivery.LearningDeliveryFAM);
            learningDelivery.LearningDeliveryFAMs.Should().HaveCount(1);
        }

        [Fact]
        public void LearningDeliveryHEEntity()
        {
            var learningDelivery = new MessageLearnerLearningDelivery()
            {
                LearningDeliveryHE = new MessageLearnerLearningDeliveryLearningDeliveryHE()
            };

            learningDelivery.LearningDeliveryHEEntity.Should().BeSameAs(learningDelivery.LearningDeliveryHE);
        }

        [Fact]
        public void LearningDeliveryWorkPlacements()
        {
            var learningDelivery = new MessageLearnerLearningDelivery()
            {
                LearningDeliveryWorkPlacement = new MessageLearnerLearningDeliveryLearningDeliveryWorkPlacement[]
                {
                    new MessageLearnerLearningDeliveryLearningDeliveryWorkPlacement()
                }
            };

            learningDelivery.LearningDeliveryWorkPlacements.Should().BeSameAs(learningDelivery.LearningDeliveryWorkPlacement);
            learningDelivery.LearningDeliveryWorkPlacements.Should().HaveCount(1);
        }

        [Fact]
        public void ProviderSpecDeliveryMonitorings()
        {
            var learningDelivery = new MessageLearnerLearningDelivery()
            {
                ProviderSpecDeliveryMonitoring = new MessageLearnerLearningDeliveryProviderSpecDeliveryMonitoring[]
                {
                    new MessageLearnerLearningDeliveryProviderSpecDeliveryMonitoring()
                }
            };

            learningDelivery.ProviderSpecDeliveryMonitorings.Should().BeSameAs(learningDelivery.ProviderSpecDeliveryMonitoring);
            learningDelivery.ProviderSpecDeliveryMonitorings.Should().HaveCount(1);
        }
    }
}
