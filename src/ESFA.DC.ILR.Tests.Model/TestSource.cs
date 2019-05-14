﻿using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestSource : ISource
    {
        public string ProtectiveMarkingString { get; set; }

        public int UKPRN { get; set; }

        public string SoftwareSupplier { get; set; }

        public string SoftwarePackage { get; set; }

        public string Release { get; set; }

        public string SerialNo { get; set; }

        public DateTime DateTime { get; set; }

        public string ReferenceData { get; set; }

        public string ComponentSetVersion { get; set; }
    }
}
