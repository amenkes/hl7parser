using HL7Data.Contracts.Segments.Provider.Facility.Equipment;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider.Facility.Equipment
{
    public class MaterialLotSegment : BaseSegment, IMaterialLotSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.ILT;
    }
}