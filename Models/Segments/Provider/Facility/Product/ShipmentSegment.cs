using HL7Data.Contracts.Segments.Provider.Facility.Product;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider.Facility.Product
{
    public class ShipmentSegment : BaseSegment, IShipmentSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.SHP;
    }
}