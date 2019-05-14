using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerDestinationandProgression : ILearnerDestinationAndProgression
    {
        public IReadOnlyCollection<IDPOutcome> DPOutcomes => dPOutcomeField;
    }
}
