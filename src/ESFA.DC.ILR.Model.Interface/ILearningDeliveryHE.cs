namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearningDeliveryHE
    {
        string NUMHUS { get; }

        string SSN { get; }

        string QUALENT3 { get; }

        int? SOC2000Nullable { get; }

        int? SECNullable { get; }

        string UCASAPPID { get; }

        int TYPEYR { get; }

        int MODESTUD { get; }

        int FUNDLEV { get; }

        int FUNDCOMP { get; }

        decimal? STULOADNullable { get; }

        int YEARSTU { get; }

        int MSTUFEE { get; }

        decimal? PCOLABNullable { get; }

        decimal? PCFLDCSNullable { get; }

        decimal? PCSLDCSNullable { get; }

        decimal? PCTLDCSNullable { get; }

        int SPECFEE { get; }

        int? NETFEENullable { get; }

        int? GROSSFEENullable { get; }

        string DOMICILE { get; }

        int? ELQNullable { get; }

        string HEPostCode { get; }
    }
}
