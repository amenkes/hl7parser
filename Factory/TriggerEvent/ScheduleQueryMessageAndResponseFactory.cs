using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ScheduleQueryMessageAndResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ScheduleQueryMessageAndResponseFactory : AbstractTriggerEventFactory<ScheduleQueryMessageAndResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SQR_S25:
                    return await Task.FromResult(new ScheduleQueryMessageAndResponse());

                default:
                    return null;
            }
        }
    }
}