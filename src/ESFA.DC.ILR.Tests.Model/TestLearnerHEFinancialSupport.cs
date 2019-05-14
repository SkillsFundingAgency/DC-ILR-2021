using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearnerHEFinancialSupport : ILearnerHEFinancialSupport
    {
        public int FINTYPE { get; set; }

        public int FINAMOUNT { get; set; }
    }
}
