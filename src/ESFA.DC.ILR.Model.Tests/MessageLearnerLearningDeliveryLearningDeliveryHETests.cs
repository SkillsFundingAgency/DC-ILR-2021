using ESFA.DC.ILR.Model.Tests.Abstract;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageLearnerLearningDeliveryLearningDeliveryHETests : AbstractModelTests<MessageLearnerLearningDeliveryLearningDeliveryHE>
    {
        [Fact]
        public void SOC2000Nullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.SOC2000, Int(), l => l.SOC2000Specified, l => l.SOC2000Nullable);
        }

        [Fact]
        public void SOC2000Nullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.SOC2000, Int(), l => l.SOC2000Specified, l => l.SOC2000Nullable);
        }

        [Fact]
        public void SECNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.SEC, Int(), l => l.SECSpecified, l => l.SECNullable);
        }

        [Fact]
        public void SECNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.SEC, Int(), l => l.SECSpecified, l => l.SECNullable);
        }

        [Fact]
        public void STULOADNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.STULOAD, Long(), l => l.STULOADSpecified, l => l.STULOADNullable);
        }

        [Fact]
        public void STULOADNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.STULOAD, Long(), l => l.STULOADSpecified, l => l.STULOADNullable);
        }

        [Fact]
        public void PCOLABNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PCOLAB, Decimal(), l => l.PCOLABSpecified, l => l.PCOLABNullable);
        }

        [Fact]
        public void PCOLABNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PCOLAB, Decimal(), l => l.PCOLABSpecified, l => l.PCOLABNullable);
        }

        [Fact]
        public void PCFLDCSNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PCFLDCS, Decimal(), l => l.PCFLDCSSpecified, l => l.PCFLDCSNullable);
        }

        [Fact]
        public void PCFLDCSNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PCFLDCS, Decimal(), l => l.PCFLDCSSpecified, l => l.PCFLDCSNullable);
        }

        [Fact]
        public void PCSLDCSNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PCSLDCS, Decimal(), l => l.PCSLDCSSpecified, l => l.PCSLDCSNullable);
        }

        [Fact]
        public void PCSLDCSNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PCSLDCS, Decimal(), l => l.PCSLDCSSpecified, l => l.PCSLDCSNullable);
        }

        [Fact]
        public void PCTLDCSNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.PCTLDCS, Decimal(), l => l.PCTLDCSSpecified, l => l.PCTLDCSNullable);
        }

        [Fact]
        public void PCTLDCSNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.PCTLDCS, Decimal(), l => l.PCTLDCSSpecified, l => l.PCTLDCSNullable);
        }

        [Fact]
        public void NETFEENullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.NETFEE, Int(), l => l.NETFEESpecified, l => l.NETFEENullable);
        }

        [Fact]
        public void NETFEENullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.NETFEE, Int(), l => l.NETFEESpecified, l => l.NETFEENullable);
        }

        [Fact]
        public void ELQNullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.ELQ, Int(), l => l.ELQSpecified, l => l.ELQNullable);
        }

        [Fact]
        public void ELQNullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.ELQ, Int(), l => l.ELQSpecified, l => l.ELQNullable);
        }

        [Fact]
        public void GROSSFEENullable_Specified_True()
        {
            TestNullableSpecifiedTrue(l => l.GROSSFEE, Int(), l => l.GROSSFEESpecified, l => l.GROSSFEENullable);
        }

        [Fact]
        public void GROSSFEENullable_Specified_False()
        {
            TestNullableSpecifiedFalse(l => l.GROSSFEE, Int(), l => l.GROSSFEESpecified, l => l.GROSSFEENullable);
        }
    }
}
