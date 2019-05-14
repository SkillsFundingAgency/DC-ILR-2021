using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class Message : IMessage
    {
        public IReadOnlyCollection<ILearner> Learners => learnerField;

        public IReadOnlyCollection<ILearnerDestinationAndProgression> LearnerDestinationAndProgressions => learnerDestinationandProgressionField;

        public IReadOnlyCollection<ISourceFile> SourceFilesCollection => sourceFilesField;

        public ILearningProvider LearningProviderEntity => learningProviderField;

        public IHeader HeaderEntity => headerField;
    }
}
