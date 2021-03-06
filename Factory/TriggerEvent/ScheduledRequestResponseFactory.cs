using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ScheduledRequestResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ScheduledRequestResponseFactory : AbstractTriggerEventFactory<ScheduledRequestResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SRR_S01:
                    return await Task.FromResult(new ScheduledRequestResponse());

                default:
                    return null;
            }
        }
    }
}