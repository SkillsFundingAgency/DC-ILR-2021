using ESFA.DC.ILR.Model.Interface;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearner : ILearner
    {
        [XmlIgnore]
        public int? AccomNullable => accomFieldSpecified ? (int?)accomField : null;

        [XmlIgnore]
        public int? ALSCostNullable => aLSCostFieldSpecified ? (int?)aLSCostField : null;

        [XmlIgnore]
        public DateTime? DateOfBirthNullable => dateOfBirthFieldSpecified ? (DateTime?)dateOfBirthField : null;

        [XmlIgnore]
        public int? OTJHoursNullable => oTJHoursFieldSpecified ? (int?)oTJHoursField : null;

        [XmlIgnore]
        public int? PlanEEPHoursNullable => planEEPHoursFieldSpecified ? (int?)planEEPHoursField : null;

        [XmlIgnore]
        public int? PlanLearnHoursNullable => planLearnHoursFieldSpecified ? (int?)planLearnHoursField : null;

        [XmlIgnore]
        public int? PMUKPRNNullable => pMUKPRNFieldSpecified ? (int?)pMUKPRNField : null;

        [XmlIgnore]
        public int? PrevUKPRNNullable => prevUKPRNFieldSpecified ? (int?)prevUKPRNField : null;

        [XmlIgnore]
        public int? PriorAttainNullable => priorAttainFieldSpecified ? (int?)priorAttainField : null;

        [XmlIgnore]
        public IReadOnlyCollection<IContactPreference> ContactPreferences => contactPreferenceField;

        [XmlIgnore]
        public IReadOnlyCollection<ILearnerEmploymentStatus> LearnerEmploymentStatuses => learnerEmploymentStatusField;

        [XmlIgnore]
        public IReadOnlyCollection<ILearnerFAM> LearnerFAMs => learnerFAMField;

        [XmlIgnore]
        public ILearnerHE LearnerHEEntity => learnerHEField;

        [XmlIgnore]
        public IReadOnlyCollection<ILearningDelivery> LearningDeliveries => learningDeliveryField;

        [XmlIgnore]
        public IReadOnlyCollection<ILLDDAndHealthProblem> LLDDAndHealthProblems => lLDDandHealthProblemField;

        [XmlIgnore]
        public IReadOnlyCollection<IProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings => providerSpecLearnerMonitoringField;
    }
}
