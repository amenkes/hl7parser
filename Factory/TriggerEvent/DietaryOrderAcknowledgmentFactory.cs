using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.DietaryOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class DietaryOrderAcknowledgmentFactory : AbstractTriggerEventFactory<DietaryOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORD_O04:
                    return await Task.FromResult(new DietaryOrderAcknowledgement());

                default:
                    return null;
            }
        }
    }
}