using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ReturnClinicalInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ReturnClinicalInformationFactory : AbstractTriggerEventFactory<ReturnClinicalInformationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RCL_I06:
                    return await Task.FromResult(new ReturnClinicalInformation());

                default:
                    return null;
            }
        }
    }
}