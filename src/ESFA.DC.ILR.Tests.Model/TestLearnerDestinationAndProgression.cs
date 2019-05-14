using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearnerDestinationAndProgression : ILearnerDestinationAndProgression
    {
        public string LearnRefNumber { get; set; }

        public long ULN { get; set; }

        public IReadOnlyCollection<IDPOutcome> DPOutcomes { get; set; }
    }
}
