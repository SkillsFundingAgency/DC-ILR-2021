using System;
using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearner : ILearner
    {
        public int? AccomNullable { get; set; }

        public string AddLine1 { get; set; }

        public string AddLine2 { get; set; }

        public string AddLine3 { get; set; }

        public string AddLine4 { get; set; }

        public int? ALSCostNullable { get; set; }

        public string CampId { get; set; }

        public DateTime? DateOfBirthNullable { get; set; }

        public string Email { get; set; }

        public int Ethnicity { get; set; }

        public string EngGrade { get; set; }

        public string FamilyName { get; set; }

        public string GivenNames { get; set; }

        public string LearnRefNumber { get; set; }

        public int LLDDHealthProb { get; set; }

        public string MathGrade { get; set; }

        public string NINumber { get; set; }

        public int? OTJHoursNullable { get; set; }

        public int? PlanEEPHoursNullable { get; set; }

        public int? PlanLearnHoursNullable { get; set; }

        public int? PMUKPRNNullable { get; set; }

        public string Postcode { get; set; }

        public string PostcodePrior { get; set; }

        public string PrevLearnRefNumber { get; set; }

        public int? PrevUKPRNNullable { get; set; }

        public int? PriorAttainNullable { get; set; }

        public long ULN { get; set; }

        public string Sex { get; set; }

        public string TelNo { get; set; }

        public ILearnerHE LearnerHEEntity { get; set; }

        public IReadOnlyCollection<IContactPreference> ContactPreferences { get; set; }

        public IReadOnlyCollection<ILearnerFAM> LearnerFAMs { get; set; }

        public IReadOnlyCollection<ILearningDelivery> LearningDeliveries { get; set; }

        public IReadOnlyCollection<ILLDDAndHealthProblem> LLDDAndHealthProblems { get; set; }

        public IReadOnlyCollection<IProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings { get; set; }

        public IReadOnlyCollection<ILearnerEmploymentStatus> LearnerEmploymentStatuses { get; set; }
    }
}
