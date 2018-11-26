using System;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface IDPOutcome
    {
        string OutType { get; }

        int OutCode { get; }

        DateTime OutStartDate { get; }

        DateTime? OutEndDateNullable { get; }

        DateTime OutCollDate { get; }
    }
}