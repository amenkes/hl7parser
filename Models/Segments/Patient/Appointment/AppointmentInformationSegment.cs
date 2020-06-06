using HL7Data.Contracts.Segments.Patient.Appointment;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Appointment
{
    public class AppointmentInformationSegment : BaseSegment, IAppointmentInformationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.AIS;
    }
}