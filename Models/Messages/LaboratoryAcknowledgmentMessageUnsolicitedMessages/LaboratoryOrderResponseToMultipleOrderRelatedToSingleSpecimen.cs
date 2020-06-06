﻿using HL7Data.Contracts.Messages.LaboratoryAcknowledgmentMessageUnsolicitedMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.LaboratoryAcknowledgmentMessageUnsolicitedMessages
{
    public class LaboratoryOrderResponseToMultipleOrderRelatedToSingleSpecimen : BaseLaboratoryAcknowledgmentMessageUnsolicitedMessage, ILaboratoryOrderResponseToMultipleOrderRelatedToSingleSpecimen
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORL_O34;
    }
}