﻿using System.Collections.Generic;

namespace ESFA.DC.ILR.IO.Model.Validation
{
    public class ValidationError
    {
        public string LearnerReferenceNumber { get; set; }

        public long? AimSequenceNumber { get; set; }

        public string RuleName { get; set; }

        public string Severity { get; set; }

        public List<ValidationErrorParameter> ValidationErrorParameters { get; set; }
    }
}
