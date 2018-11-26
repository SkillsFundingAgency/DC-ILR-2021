using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearner
    {
        int? AccomNullable { get; }

        string AddLine1 { get; }

        string AddLine2 { get; }

        string AddLine3 { get; }

        string AddLine4 { get; }

        int? ALSCostNullable { get; }

        string CampId { get; }

        DateTime? DateOfBirthNullable { get; }

        string Email { get; }

        int Ethnicity { get; }

        string EngGrade { get; }

        string FamilyName { get; }

        string GivenNames { get; }

        string LearnRefNumber { get; }

        int LLDDHealthProb { get; }

        string MathGrade { get; }

        string NINumber { get; }

        int? OTJHoursNullable { get; }

        int? PlanEEPHoursNullable { get; }

        int? PlanLearnHoursNullable { get; }

        int? PMUKPRNNullable { get; }

        string Postcode { get; }

        string PostcodePrior { get; }

        string PrevLearnRefNumber { get; }

        int? PrevUKPRNNullable { get; }

        int? PriorAttainNullable { get; }

        long ULN { get; }

        string Sex { get; }

        string TelNo { get; }

        ILearnerHE LearnerHEEntity { get; }

        IReadOnlyCollection<IContactPreference> ContactPreferences { get; }

        IReadOnlyCollection<ILearnerFAM> LearnerFAMs { get; }

        IReadOnlyCollection<ILearningDelivery> LearningDeliveries { get; }

        IReadOnlyCollection<ILLDDAndHealthProblem> LLDDAndHealthProblems { get; }

        IReadOnlyCollection<IProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings { get; }

        IReadOnlyCollection<ILearnerEmploymentStatus> LearnerEmploymentStatuses { get; }
    }
}
