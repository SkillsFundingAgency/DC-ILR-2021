using ESFA.DC.ILR.Model.Interface;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDelivery : ILearningDelivery
    {
        [XmlIgnore]
        public DateTime? AchDateNullable => achDateFieldSpecified ? (DateTime?)achDateField : null;

        [XmlIgnore]
        public int? AddHoursNullable => addHoursFieldSpecified ? (int?)addHoursField : null;

        [XmlIgnore]
        public int? EmpOutcomeNullable => empOutcomeFieldSpecified ? (int?)empOutcomeField : null;

        [XmlIgnore]
        public int? FworkCodeNullable => fworkCodeFieldSpecified ? (int?)fworkCodeField : null;

        [XmlIgnore]
        public DateTime? LearnActEndDateNullable => learnActEndDateFieldSpecified ? (DateTime?)learnActEndDateField : null;

        [XmlIgnore]
        public DateTime? OrigLearnStartDateNullable => origLearnStartDateFieldSpecified ? (DateTime?)origLearnStartDateField : null;

        [XmlIgnore]
        public int? OtherFundAdjNullable => otherFundAdjFieldSpecified ? (int?)otherFundAdjField : null;

        [XmlIgnore]
        public int? OutcomeNullable => outcomeFieldSpecified ? (int?)outcomeField : null;

        [XmlIgnore]
        public int? PartnerUKPRNNullable => partnerUKPRNFieldSpecified ? (int?)partnerUKPRNField : null;

        [XmlIgnore]
        public int? PHoursNullable => pHoursFieldSpecified ? (int?)pHoursField : null;

        [XmlIgnore]
        public int? PriorLearnFundAdjNullable => priorLearnFundAdjFieldSpecified ? (int?)priorLearnFundAdjField : null;

        [XmlIgnore]
        public int? ProgTypeNullable => progTypeFieldSpecified ? (int?)progTypeField : null;

        [XmlIgnore]
        public int? PwayCodeNullable => pwayCodeFieldSpecified ? (int?)pwayCodeField : null;

        [XmlIgnore]
        public int? StdCodeNullable => stdCodeFieldSpecified ? (int?)stdCodeField : null;

        [XmlIgnore]
        public int? WithdrawReasonNullable => withdrawReasonFieldSpecified ? (int?)withdrawReasonField : null;

        [XmlIgnore]
        public ILearningDeliveryHE LearningDeliveryHEEntity => learningDeliveryHEField;

        [XmlIgnore]
        public IReadOnlyCollection<IAppFinRecord> AppFinRecords => appFinRecordField;

        [XmlIgnore]
        public IReadOnlyCollection<ILearningDeliveryFAM> LearningDeliveryFAMs => learningDeliveryFAMField;

        public IReadOnlyCollection<ILearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements => learningDeliveryWorkPlacementField;

        public IReadOnlyCollection<IProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings => providerSpecDeliveryMonitoringField;
    }
}
