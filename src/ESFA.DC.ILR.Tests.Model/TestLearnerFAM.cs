using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearnerFAM : ILearnerFAM
    {
        public string LearnFAMType { get; set; }

        public int LearnFAMCode { get; set; }
    }
}
