using HL7Data.Contracts.Segments.Study;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Study
{
    public class CommonOrderSegment : BaseSegment, ICommonOrderSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.ORC;
    }
}