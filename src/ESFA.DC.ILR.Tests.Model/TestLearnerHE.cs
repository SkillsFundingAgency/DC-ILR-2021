using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearnerHE : ILearnerHE
    {
        public string UCASPERID { get; set; }

        public int? TTACCOMNullable { get; set; }

        public IReadOnlyCollection<ILearnerHEFinancialSupport> LearnerHEFinancialSupports { get; set; }
    }
}
