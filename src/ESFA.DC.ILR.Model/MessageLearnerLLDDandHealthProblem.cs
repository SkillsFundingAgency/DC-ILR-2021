﻿using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLLDDandHealthProblem : ILLDDAndHealthProblem
    {
        public int? PrimaryLLDDNullable => primaryLLDDFieldSpecified ? (int?)primaryLLDDField : null;
    }
}
