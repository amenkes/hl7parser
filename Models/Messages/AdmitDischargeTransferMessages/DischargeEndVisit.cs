using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class DischargeEndVisit : BaseAdmitDischargeTransfer, IDischargeEndVisit
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A03;
    }

#if TODO

#endif
}