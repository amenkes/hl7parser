using HL7Data.Contracts.Segments.Patient.Financial.Billing;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Financial.Billing
{
    public class InvoiceProcessingResultsSegment : BaseSegment, IInvoiceProcessingResultsSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.IPR;
    }
}