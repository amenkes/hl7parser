using HL7Data.Contracts.Segments.Application;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application
{
    public class SystemClockSegment : BaseSegment, ISystemClockSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.NCK;
    }
}