using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearnerDestinationAndProgression
    {
        string LearnRefNumber { get; }

        long ULN { get; }

        IReadOnlyCollection<IDPOutcome> DPOutcomes { get; }
    }
}
