﻿using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestEmploymentStatusMonitoring : IEmploymentStatusMonitoring
    {
        public string ESMType { get; set; }

        public int ESMCode { get; set; }
    }
}
