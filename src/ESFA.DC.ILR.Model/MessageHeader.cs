using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageHeader : IHeader
    {
        public ICollectionDetails CollectionDetailsEntity => collectionDetailsField;

        public ISource SourceEntity => sourceField;
    }
}
