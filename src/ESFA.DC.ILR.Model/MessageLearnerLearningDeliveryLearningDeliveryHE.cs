using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDeliveryLearningDeliveryHE : ILearningDeliveryHE
    {
        public int? SOC2000Nullable => sOC2000FieldSpecified ? (int?)sOC2000Field : null;

        public int? SECNullable => sECFieldSpecified ? (int?)sECField : null;

        public decimal? STULOADNullable => sTULOADFieldSpecified ? (decimal?)sTULOADField : null;

        public decimal? PCOLABNullable => pCOLABFieldSpecified ? (decimal?)pCOLABField : null;

        public decimal? PCFLDCSNullable => pCFLDCSFieldSpecified ? (decimal?)pCFLDCSField : null;

        public decimal? PCSLDCSNullable => pCSLDCSFieldSpecified ? (decimal?)pCSLDCSField : null;

        public decimal? PCTLDCSNullable => pCTLDCSFieldSpecified ? (decimal?)pCTLDCSField : null;

        public int? NETFEENullable => nETFEEFieldSpecified ? (int?)nETFEEField : null;

        public int? ELQNullable => eLQFieldSpecified ? (int?)eLQField : null;

        public int? GROSSFEENullable => gROSSFEEFieldSpecified ? (int?)gROSSFEEField : null;
    }
}
