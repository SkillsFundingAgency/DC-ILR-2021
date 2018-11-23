using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDeliveryLearningDeliveryFAM : ILearningDeliveryFAM
    {
        public DateTime? LearnDelFAMDateFromNullable => learnDelFAMDateFromFieldSpecified ? (DateTime?)learnDelFAMDateFromField : null;

        public DateTime? LearnDelFAMDateToNullable => learnDelFAMDateToFieldSpecified ? (DateTime?)learnDelFAMDateToField : null;
    }
}
