using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearningDeliveryHE : ILearningDeliveryHE
    {
        public string NUMHUS { get; set; }

        public string SSN { get; set; }

        public string QUALENT3 { get; set; }

        public int? SOC2000Nullable { get; set; }

        public int? SECNullable { get; set; }

        public string UCASAPPID { get; set; }

        public int TYPEYR { get; set; }

        public int MODESTUD { get; set; }

        public int FUNDLEV { get; set; }

        public int FUNDCOMP { get; set; }

        public decimal? STULOADNullable { get; set; }

        public int YEARSTU { get; set; }

        public int MSTUFEE { get; set; }

        public decimal? PCOLABNullable { get; set; }

        public decimal? PCFLDCSNullable { get; set; }

        public decimal? PCSLDCSNullable { get; set; }

        public decimal? PCTLDCSNullable { get; set; }

        public int SPECFEE { get; set; }

        public int? NETFEENullable { get; set; }

        public int? GROSSFEENullable { get; set; }

        public string DOMICILE { get; set; }

        public int? ELQNullable { get; set; }

        public string HEPostCode { get; set; }
    }
}
