using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestDPOutcome : IDPOutcome
    {
        public string OutType { get; set; }

        public int OutCode { get; set; }

        public DateTime OutStartDate { get; set; }

        public DateTime? OutEndDateNullable { get; set; }

        public DateTime OutCollDate { get; set; }
    }
}
