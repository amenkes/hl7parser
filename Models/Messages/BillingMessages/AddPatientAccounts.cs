using HL7Data.Contracts.Messages.BillingAccountMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BillingMessages
{
    public class AddPatientAccounts : BaseBillingAccountMessage, IAddPatientAccount
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.BAR_P01;
    }
}