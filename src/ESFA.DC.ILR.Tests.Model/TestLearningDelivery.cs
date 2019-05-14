using System;
using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearningDelivery : ILearningDelivery
    {
        public DateTime? AchDateNullable { get; set; }

        public int? AddHoursNullable { get; set; }

        public int AimSeqNumber { get; set; }

        public int AimType { get; set; }

        public int CompStatus { get; set; }

        public string ConRefNumber { get; set; }

        public string DelLocPostCode { get; set; }

        public int? EmpOutcomeNullable { get; set; }

        public string EPAOrgID { get; set; }

        public int FundModel { get; set; }

        public int? FworkCodeNullable { get; set; }

        public string LearnAimRef { get; set; }

        public DateTime? LearnActEndDateNullable { get; set; }

        public DateTime LearnPlanEndDate { get; set; }

        public DateTime LearnStartDate { get; set; }

        public DateTime? OrigLearnStartDateNullable { get; set; }

        public int? OtherFundAdjNullable { get; set; }

        public int? OutcomeNullable { get; set; }

        public string OutGrade { get; set; }

        public int? PartnerUKPRNNullable { get; set; }

        public int? PriorLearnFundAdjNullable { get; set; }

        public int? ProgTypeNullable { get; set; }

        public int? PwayCodeNullable { get; set; }

        public int? StdCodeNullable { get; set; }

        public string SWSupAimId { get; set; }

        public int? WithdrawReasonNullable { get; set; }

        public ILearningDeliveryHE LearningDeliveryHEEntity { get; set; }

        public IReadOnlyCollection<IAppFinRecord> AppFinRecords { get; set; }

        public IReadOnlyCollection<ILearningDeliveryFAM> LearningDeliveryFAMs { get; set; }

        public IReadOnlyCollection<ILearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements { get; set; }

        public IReadOnlyCollection<IProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings { get; set; }
    }
}
