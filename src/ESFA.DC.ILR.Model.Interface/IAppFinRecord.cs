using System;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface IAppFinRecord
    {
        string AFinType { get; }

        int AFinCode { get; }

        DateTime AFinDate { get; }

        int AFinAmount { get; }
    }
}
