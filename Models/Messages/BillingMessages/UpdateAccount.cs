using HL7Data.Contracts.Messages.BillingAccountMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BillingMessages
{
    public class UpdateAccount : BaseBillingAccountMessage, IUpdateAccount
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.BAR_P05;
    }
}