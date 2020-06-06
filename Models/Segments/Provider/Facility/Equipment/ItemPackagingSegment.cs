using HL7Data.Contracts.Segments.Provider.Facility.Equipment;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider.Facility.Equipment
{
    public class ItemPackagingSegment : BaseSegment, IItemPackagingSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.PKG;
    }
}