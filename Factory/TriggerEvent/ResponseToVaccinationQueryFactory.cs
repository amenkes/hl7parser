using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ResponseToVaccinationQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ResponseToVaccinationQueryFactory : AbstractTriggerEventFactory<ResponseToVaccinationQueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.VXX_V02:
                    return await Task.FromResult(new ResponseToVaccinationQuery());

                default:
                    return null;
            }
        }
    }
}