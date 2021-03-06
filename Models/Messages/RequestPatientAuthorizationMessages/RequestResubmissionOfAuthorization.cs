﻿using HL7Data.Contracts.Messages.RequestPatientAuthorizationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientAuthorizationMessages
{
    public class RequestResubmissionOfAuthorization : BaseRequestPatientAuthorizationMessage, IRequestResubmissionOfAuthorization
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQA_I10;
    }
}