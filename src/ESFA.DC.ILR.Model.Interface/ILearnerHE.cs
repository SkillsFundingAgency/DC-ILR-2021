using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearnerHE
    {
        string UCASPERID { get; }

        int? TTACCOMNullable { get; }

        IReadOnlyCollection<ILearnerHEFinancialSupport> LearnerHEFinancialSupports { get; }
    }
}
