using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearningDelivery
    {
        DateTime? AchDateNullable { get; }

        int? AddHoursNullable { get; }

        int AimSeqNumber { get; }

        int AimType { get; }

        int CompStatus { get; }

        string ConRefNumber { get; }

        string DelLocPostCode { get; }

        int? EmpOutcomeNullable { get; }

        string EPAOrgID { get; }

        int FundModel { get; }

        int? FworkCodeNullable { get; }

        string LearnAimRef { get; }

        DateTime? LearnActEndDateNullable { get; }

        DateTime LearnPlanEndDate { get; }

        DateTime LearnStartDate { get; }

        DateTime? OrigLearnStartDateNullable { get; }

        int? OtherFundAdjNullable { get; }

        int? OutcomeNullable { get; }

        string OutGrade { get; }

        int? PartnerUKPRNNullable { get; }

        int? PriorLearnFundAdjNullable { get; }

        int? ProgTypeNullable { get; }

        int? PwayCodeNullable { get; }

        int? StdCodeNullable { get; }

        string SWSupAimId { get; }

        int? WithdrawReasonNullable { get; }

        ILearningDeliveryHE LearningDeliveryHEEntity { get; }

        IReadOnlyCollection<IAppFinRecord> AppFinRecords { get; }

        IReadOnlyCollection<ILearningDeliveryFAM> LearningDeliveryFAMs { get; }

        IReadOnlyCollection<ILearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements { get; }

        IReadOnlyCollection<IProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings { get; }
    }
}
