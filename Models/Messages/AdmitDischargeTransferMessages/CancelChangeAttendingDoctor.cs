using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class CancelChangeAttendingDoctor : BaseAdmitDischargeTransfer, ICancelChangeAttendingDoctor
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A55;
    }
}