﻿using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class EventType : ITableInfo
    {
        private static ITableInfo InstanceData => new EventType();
        public static ITableInfo Instance => InstanceData;
        private EventType() { }

        public int Id => 3;
        public string Name => "Event Type";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A01", "ADT/ACK - Admit/visit notification"},
            {"A02", "ADT/ACK - Transfer a patient"},
            {"A03", "ADT/ACK -  Discharge/end visit"},
            {"A04", "ADT/ACK -  Register a patient"},
            {"A05", "ADT/ACK -  Pre-admit a patient"},
            {"A06", "ADT/ACK -  Change an outpatient to an inpatient"},
            {"A07", "ADT/ACK -  Change an inpatient to an outpatient"},
            {"A08", "ADT/ACK -  Update patient information"},
            {"A09", "ADT/ACK -  Patient departing - tracking"},
            {"A10", "ADT/ACK -  Patient arriving - tracking"},
            {"A11", "ADT/ACK -  Cancel admit/visit notification"},
            {"A12", "ADT/ACK -  Cancel transfer"},
            {"A13", "ADT/ACK -  Cancel discharge/end visit"},
            {"A14", "ADT/ACK -  Pending admit"},
            {"A15", "ADT/ACK -  Pending transfer"},
            {"A16", "ADT/ACK -  Pending discharge"},
            {"A17", "ADT/ACK -  Swap patients"},
            {"A18", "ADT/ACK -  Merge patient information"},
            {"A19", "QRY/ADR -  Patient query"},
            {"A20", "ADT/ACK -  Bed status update"},
            {"A21", "ADT/ACK -  Patient goes on a 'leave of absence'"},
            {"A22", "ADT/ACK -  Patient returns from a 'leave of absence'"},
            {"A23", "ADT/ACK -  Delete a patient record"},
            {"A24", "ADT/ACK -  Link patient information"},
            {"A25", "ADT/ACK -  Cancel pending discharge"},
            {"A26", "ADT/ACK -  Cancel pending transfer"},
            {"A27", "ADT/ACK -  Cancel pending admit"},
            {"A28", "ADT/ACK -  Add person information"},
            {"A29", "ADT/ACK -  Delete person information"},
            {"A30", "ADT/ACK -  Merge person information"},
            {"A31", "ADT/ACK -  Update person information"},
            {"A32", "ADT/ACK -  Cancel patient arriving - tracking"},
            {"A33", "ADT/ACK -  Cancel patient departing - tracking"},
            {"A34", "ADT/ACK -  Merge patient information - patient ID only"},
            {"A35", "ADT/ACK -  Merge patient information - account number only"},
            {"A36", "ADT/ACK -  Merge patient information - patient ID and account number"},
            {"A37", "ADT/ACK -  Unlink patient information"},
            {"A38", "ADT/ACK - Cancel pre-admit"},
            {"A39", "ADT/ACK - Merge person – patient ID "},
            {"A40", "ADT/ACK - Merge patient – patient identifier list"},
            {"A41", "ADT/ACK - Merge account - patient account number"},
            {"A42", "ADT/ACK - Merge visit - visit number"},
            {"A43", "ADT/ACK - Move patient information – patient identifier list"},
            {"A44", "ADT/ACK - Move account information - patient account number"},
            {"A45", "ADT/ACK - Move visit information - visit number"},
            {"A46", "ADT/ACK - Change patient ID"},
            {"A47", "ADT/ACK - Change patient identifier list"},
            {"A48", "ADT/ACK - Change alternate patient ID"},
            {"A49", "ADT/ACK - Change patient account number"},
            {"A50", "ADT/ACK - Change visit number"},
            {"A51", "ADT/ACK - Change alternate visit ID"},
            {"A52", "ADT/ACK – Cancel leave of absence for a patient"},
            {"A53", "ADT/ACK – Cancel patient returns from a leave of absence"},
            {"A54", "ADT/ACK - Change attending doctor"},
            {"A55", "ADT/ACK – Cancel change attending doctor"},
            {"A60", "ADT/ACK – Update allergy information"},
            {"A61", "ADT/ACK – Change consulting doctor"},
            {"A62", "ADT/ACK – Cancel change consulting doctor"},
            {"B01", "PMU/ACK – Add personnel record"},
            {"B02", "PMU/ACK – Update personnel record"},
            {"B03", "PMU/ACK – Delete personnel re cord"},
            {"B04", "PMU/ACK – Active practicing person"},
            {"B05", "PMU/ACK – Deactivate practicing person"},
            {"B06", "PMU/ACK – Terminate practicing person"},
            {"B07", "PMU/ACK – Grant Certificate/Permission"},
            {"B08", "PMU/ACK – Revoke Certificate/Permission"},
            {"C01", "CRM - Register a patient on a clinical trial"},
            {"C02", "CRM - Cancel a patient registration on clinical trial (for clerical mistakes only)"},
            {"C03", "CRM - Correct/update registration information"},
            {"C04", "CRM - Patient has gone off a clinical trial"},
            {"C05", "CRM - Patient enters phase of clinical trial"},
            {"C06", "CRM - Cancel patient entering a phase (clerical mistake)"},
            {"C07", "CRM - Correct/update phase information"},
            {"C08", "CRM - Patient has gone off phase of clinical trial"},
            {"C09", "CSU - Automated time intervals for reporting, like monthly"},
            {"C10", "CSU - Patient completes the clinical trial"},
            {"C11", "CSU - Patient completes a phase of the clinical trial"},
            {"C12", "CSU - Update/correction of patient order/result information"},
            {"E01", "Submit Healthcare Services Invoice"},
            {"E02", "Cancel Healthcare Services Invoice"},
            {"E03", "Healthcare Services Invoice Status"},
            {"E04", "Re-Assess Healthcare Services Invoice Request"},
            {"E10", "Edit/Adjudication Results"},
            {"E12", "Request Additional Information"},
            {"E13", "Additional Information Response"},
            {"E15", "Payment/Remittance Advice"},
            {"E20", "Submit Authorization Request"},
            {"E21", "Cancel Authorization Request"},
            {"E22", "Authorization Request Status"},
            {"E24", "Authorization Response"},
            {"E30", "Submit Health Document related to Authorization Request"},
            {"E31", "Cancel Health Document related to Authorization Request"},
            {"I01", "RQI/RPI - Request for insurance information"},
            {"I02", "RQI/RPL - Request/receipt of patient selection display list"},
            {"I03", "RQI/RPR - Request/receipt of patient selection list"},
            {"I04", "RQD/RPI - Request for patient demographic data"},
            {"I05", "RQC/RCI - Request for patient clinical information"},
            {"I06", "RQC/RCL - Request/receipt of clinical data listing"},
            {"I07", "PIN/ACK - Unsolicited insurance information"},
            {"I08", "RQA/RPA - Request for treatment authorization information"},
            {"I09", "RQA/RPA - Request for modification to an authorization"},
            {"I10", "RQA/RPA - Request for resubmission of an authorization"},
            {"I11", "RQA/RPA - Request for cancellation of an authorization"},
            {"I12", "REF/RRI - Patient referral"},
            {"I13", "REF/RRI - Modify patient referral"},
            {"I14", "REF/RRI - Cancel patient referral"},
            {"I15", "REF/RRI - Request patient referral status"},
            {"I16", "Collaborative Care Referral"},
            {"I17", "Modify Collaborative Care Referral"},
            {"I18", "Cancel Collaborative Care Referral"},
            {"I19", "Collaborative Care Query/Collaborative Care Query Update"},
            {"I20", "Asynchronous Collaborative Care Update"},
            {"I21", "Collaborative Care Message"},
            {"I22", "Collaborative Care Fetch / Collaborative Care Information"},
            {"J01", "QCN/ACK – Cancel query/acknowledge message"},
            {"J02", "QSX/ACK – Cancel subscription/acknowledge message"},
            {"K11", "RSP - Segment pattern response in response to QBP^Q11"},
            {"K13", "RTB - Tabular response in response to QBP^Q13"},
            {"K15", "RDY - Display response in response to QBP^Q15"},
            {"K21", "RSP – Get person demographics response"},
            {"K22", "RSP – Find candidates response"},
            {"K23", "RSP – Get corresponding identifiers response"},
            {"K24", "RSP – Allocate identifiers response"},
            {"K25", "RSP - Personnel Information by Segment Response"},
            {"K31", "RSP –Dispense History Response"},
            {"K32", "Find Candidates including Visit Information Response"},
            {"M01", "MFN/MFK - Master file not otherwise specified"},
            {"M02", "MFN/MFK - Master file – staff practitioner"},
            {"M03", "MFN/MFK - Master file - test/observation"},
            {"M04", "MFN/MFK - Master files charge description"},
            {"M05", "MFN/MFK - Patient location master file"},
            {"M06", "MFN/MFK - Clinical study with phases and schedules master file"},
            {"M07", "MFN/MFK - Clinical study without phases but with schedules master file"},
            {"M08", "MFN/MFK - Test/observation (numeric) master file"},
            {"M09", "MFN/MFK - Test/observation (categorical) master file"},
            {"M10", "MFN/MFK - Test /observation batteries master file"},
            {"M11", "MFN/MFK - Test/calculated observations master file"},
            {"M12", "MFN/MFK – Master file notification message"},
            {"M13", "MFN/MFK - Master file notification – general"},
            {"M14", "MFN/MFK - Master file notification – site defined"},
            {"M15", "MFN/MFK – Inventory item master file notification"},
            {"M16", "MFN/MFK - Master File Notification Inventory Item Enhanced"},
            {"M17", "DRG Master File Message"},
            {"N01", "NMQ/NMR - Application management query message"},
            {"N02", "NMD/ACK - Application management data message (unsolicited)"},
            {"O01", "ORM - Order message (also RDE, RDS, RGV, RAS) "},
            {"O02", "ORR - Order response (also RRE, RRD, RRG, RRA) "},
            {"O03", "OMD – Diet order"},
            {"O04", "ORD – Diet order acknowledgment"},
            {"O05", "OMS – Stock requisition order"},
            {"O06", "ORS – Stock requisition acknowledgment"},
            {"O07", "OMN – Non-stock requisition order"},
            {"O08", "ORN – Non-stock requisition acknowledgment"},
            {"O09", "OMP – Pharmacy/treatment order"},
            {"O10", "ORP – Pharmacy/treatment order acknowledgment"},
            {"O11", "RDE – Pharmacy/treatment encoded order "},
            {"O12", "RRE – Pharmacy/treatment encoded order acknowledgment"},
            {"O13", "RDS – Pharmacy/treatment dispense"},
            {"O14", "RRD – Pharmacy/treatment dispense acknowledgment"},
            {"O15", "RGV – Pharmacy/treatment give"},
            {"O16", "RRG – Pharmacy/treatment give acknowledgment"},
            {"O17", "RAS – Pharmacy/treatment administration"},
            {"O18", "RRA – Pharmacy/treatment administration acknowledgment"},
            {"O19", "OMG – General clinical order"},
            {"O20", "ORG/ORL – General clinical order response"},
            {"O21", "OML - Laboratory order"},
            {"O22", "ORL - General laboratory order response message to any OML"},
            {"O23", "OMI – Imaging order"},
            {"O24", "ORI – Imaging order response message to any OMI"},
            {"O25", "RDE - Pharmacy/treatment refill authorization request"},
            {"O26", "RRE - Pharmacy/Treatment Refill Authorization Acknowledgement"},
            {"O27", "OMB – Blood product order"},
            {"O28", "ORB – Blood product order acknowledgment"},
            {"O29", "BPS – Blood product dispense status"},
            {"O30", "BRP – Blood product dispense status acknowledgment"},
            {"O31", "BTS – Blood product transfusion/disposition"},
            {"O32", "BRT – Blood product transfusion/disposition acknowledgment"},
            {"O33", "OML – Laboratory order for multiple orders related to a single specimen"},
            {"O34", "ORL – Laboratory order response message to a multiple order related to single specimen OML"},
            {"O35", "OML – Laboratory order for multiple orders related to a single container of a specimen"},
            {"O36", "ORL - Laboratory order response message to a single container of a specimen OML"},
            {"O37", "OPL – Population/Location-Based Laboratory Order Message"},
            {"O38", "OPR – Population/Location-Based Laboratory Order Acknowledgment Message"},
            {"O39", "Specimen shipment centric laboratory order"},
            {"O40", "Specimen Shipment Centric Laboratory Order Acknowledgment Message"},
            {"O41", "DBC - Create Donor Record Message"},
            {"O42", "DBU - Update Donor Record Message"},
            {"O43", "General Order Message with Document Payload Acknowledgement Message"},
            {"P01", "BAR/ACK - Add patient accounts"},
            {"P02", "BAR/ACK - Purge patient accounts"},
            {"P03", "DFT/ACK - Post detail financial transaction"},
            {"P04", "QRY/DSP – Generate bill and A/R statements"},
            {"P05", "BAR/ACK – Update account"},
            {"P06", "BAR/ACK - End account"},
            {"P07", "PEX - Unsolicited initial individual product experience report"},
            {"P08", "PEX - Unsolicited update individual product experience report"},
            {"P09", "SUR - Summary product experience report"},
            {"P10", "BAR/ACK –Transmit Ambulatory Payment  Classification(APC)"},
            {"P11", "DFT/ACK - Post Detail Financial Transactions - New"},
            {"P12", "BAR/ACK - Update Diagnosis/Procedure"},
            {"PC1", "PPR - PC/ problem add"},
            {"PC2", "PPR - PC/ problem update"},
            {"PC3", "PPR - PC/ problem delete "},
            {"PC4", "QRY - PC/ problem query"},
            {"PC5", "PRR - PC/ problem response"},
            {"PC6", "PGL - PC/ goal add"},
            {"PC7", "PGL - PC/ goal update"},
            {"PC8", "PGL - PC/ goal delete"},
            {"PC9", "QRY - PC/ goal query"},
            {"PCA", "PPV - PC/ goal response"},
            {"PCB", "PPP - PC/ pathway (problem-oriented) add"},
            {"PCC", "PPP - PC/ pathway (problem-oriented) update"},
            {"PCD", "PPP - PC/ pathway (problem-oriented) delete"},
            {"PCE", "QRY - PC/ pathway (problem-oriented) query"},
            {"PCF", "PTR - PC/ pathway (problem-oriented) query response"},
            {"PCG", "PPG - PC/ pathway (goal-oriented) add"},
            {"PCH", "PPG - PC/ pathway (goal-oriented) update "},
            {"PCJ", "PPG - PC/ pathway (goal-oriented) delete"},
            {"PCK", "QRY - PC/ pathway (goal-oriented) query"},
            {"PCL", "PPT - PC/ pathway (goal-oriented) query response"},
            {"Q01", "QRY/DSR - Query sent for immediate response"},
            {"Q02", "QRY/QCK - Query sent for deferred response"},
            {"Q03", "DSR/ACK - Deferred response to a query"},
            {"Q05", "UDM/ACK - Unsolicited display update message"},
            {"Q06", "OSQ/OSR - Query for order status"},
            {"Q11", "QBP - Query by parameter requesting an RSP segment pattern response"},
            {"Q13", "QBP - Query by parameter requesting an  RTB - tabular response"},
            {"Q15", "QBP - Query by parameter requesting an RDY display response"},
            {"Q16", "QSB – Create subscription"},
            {"Q17", "QVR – Query for previous events"},
            {"Q21", "QBP – Get person demographics"},
            {"Q22", "QBP – Find candidates"},
            {"Q23", "QBP – Get corresponding identifiers"},
            {"Q24", "QBP – Allocate identifiers"},
            {"Q25", "QBP - Personnel Information by Segment Query"},
            {"Q26", "ROR - Pharmacy/treatment order response"},
            {"Q27", "RAR - Pharmacy/treatment administration information"},
            {"Q28", "RDR - Pharmacy/treatment dispense information"},
            {"Q29", "RER - Pharmacy/treatment encoded order information"},
            {"Q30", "RGR - Pharmacy/treatment dose information"},
            {"Q31", "QBP Query Dispense history"},
            {"Q32", "Find Candidates including Visit Information"},
            {"R01", "ORU/ACK - Unsolicited transmission of an observation message"},
            {"R02", "QRY - Query for results of observation"},
            {"R04", "ORF - Response to query; transmission of requested observation"},
            {"ROR", "ROR - Pharmacy prescription order query response"},
            {"R21", "OUL – Unsolicited laboratory observation"},
            {"R22", "OUL – Unsolicited Specimen Oriented Observation Message"},
            {"R23", "OUL – Unsolicited Specimen Container Oriented Observation Message"},
            {"R24", "OUL – Unsolicited Order Oriented Observation Message"},
            {"R25", "OPU - Unsolicited Population/Location-Based Laboratory Observation Message"},
            {"R26", "OSM - Unsolicited Specimen Shipment Manifest Message"},
            {"R30", "ORU – Unsolicited Point-Of-Care Observation Message Without Existing Order – Place An Order"},
            {"R31", "ORU – Unsolicited New Point-Of-Care Observation Message – Search For An Order"},
            {"R32", "ORU – Unsolicited Pre-Ordered Point-Of-Care Observation"},
            {"R33", "ORA – Observation Report Acknowledgement"},
            {"R40", "ORU - Unsolicited Report Alarm"},
            {"S01", "SRM/SRR - Request new appointment booking"},
            {"S02", "SRM/SRR - Request appointment rescheduling"},
            {"S03", "SRM/SRR - Request appointment modification"},
            {"S04", "SRM/SRR - Request appointment cancellation"},
            {"S05", "SRM/SRR - Request appointment discontinuation"},
            {"S06", "SRM/SRR - Request appointment deletion"},
            {"S07", "SRM/SRR - Request addition of service/resource on appointment"},
            {"S08", "SRM/SRR - Request modification of service/resource on appointment"},
            {"S09", "SRM/SRR - Request cancellation of service/resource on appointment"},
            {"S10", "SRM/SRR - Request discontinuation of service/resource on appointment"},
            {"S11", "SRM/SRR - Request deletion of service/resource on appointment"},
            {"S12", "SIU/ACK - Notification of new appointment booking"},
            {"S13", "SIU/ACK - Notification of appointment rescheduling"},
            {"S14", "SIU/ACK - Notification of appointment modification"},
            {"S15", "SIU/ACK - Notification of appointment cancellation"},
            {"S16", "SIU/ACK - Notification of appointment discontinuation"},
            {"S17", "SIU/ACK - Notification of appointment deletion"},
            {"S18", "SIU/ACK - Notification of addition of service/resource on appointment"},
            {"S19", "SIU/ACK - Notification of modification of service/resource on appointment"},
            {"S20", "SIU/ACK - Notification of cancellation of service/resource on appointment"},
            {"S21", "SIU/ACK - Notification of discontinuation of service/resource on appointment"},
            {"S22", "SIU/ACK - Notification of deletion of service/resource on appointment"},
            {"S23", "SIU/ACK - Notification of blocked schedule time slot(s)"},
            {"S24", "SIU/ACK - Notification of opened ('unblocked') schedule time slot(s)"},
            {"S25", "SQM/SQR - Schedule query message and response"},
            {"S26", "SIU/ACK Notification that patient did not show up for schedule appointment"},
            {"S27", "SIU/ACK - Broadcast Notification of Scheduled Appointments"},
            {"S28", "SLR/SLS – Request new sterilization lot"},
            {"S29", "SLR/SLS - Request Sterilization lot deletion"},
            {"S30", "STI/STS - Request item"},
            {"S31", "SDR/SDS - Request anti-microbial device data"},
            {"S32", "SMD/SMS - Request anti-microbial device cycle data"},
            {"S33", "STC/ACK - Notification of sterilization configuration"},
            {"S34", "SLN/ACK - Notification of sterilization lot"},
            {"S35", "SLN/ACK - Notification of sterilization lot deletion"},
            {"S36", "SDN/ACK - Notification of anti-microbial device data"},
            {"S37", "SCN/ACK - Notification of anti-microbial device cycle data"},
            {"T01", "MDM/ACK - Original document notification"},
            {"T02", "MDM/ACK - Original document notification and content"},
            {"T03", "MDM/ACK - Document status change notification"},
            {"T04", "MDM/ACK - Document status change notification and content"},
            {"T05", "MDM/ACK - Document addendum notification"},
            {"T06", "MDM/ACK - Document addendum notification and content"},
            {"T07", "MDM/ACK - Document edit notification"},
            {"T08", "MDM/ACK - Document edit notification and content"},
            {"T09", "MDM/ACK - Document replacement notification"},
            {"T10", "MDM/ACK - Document replacement notification and content"},
            {"T11", "MDM/ACK - Document cancel notification"},
            {"T12", "QRY/DOC - Document query"},
            {"U01", "ESU/ACK – Automated equipment status update"},
            {"U02", "ESR/ACK – Automated equipment status request"},
            {"U03", "SSU/ACK - Specimen status update"},
            {"U04", "SSR/ACK - specimen status request"},
            {"U05", "INU/ACK  - Automated equipment inventory update"},
            {"U06", "INR/ACK – Automated equipment inventory request"},
            {"U07", "EAC/ACK – Automated equipment command"},
            {"U08", "EAR/ACK – Automated equipment response"},
            {"U09", "EAN/ACK – Automated equipment notification"},
            {"U10", "TCU/ACK – Automated equipment test code settings update"},
            {"U11", "TCR/ACK – Automated equipment test code settings request"},
            {"U12", "LSU/ACK – Automated equipment log/service update"},
            {"U13", "LSR/ACK – Automated equipment log/service request"},
            {"V01", "VXQ - Query for vaccination record"},
            {"V02", "VXX - Response to vaccination query returning multiple PID matches"},
            {"V03", "VXR - Vaccination record response"},
            {"V04", "VXU - Unsolicited vaccination record update"},
            {"Varies", "MFQ/MFR - Master files query (use event same as asking for e.g., M05 - location)"},
            {"W01", "ORU - Waveform result, unsolicited transmission of requested information"},
            {"W02", "QRF - Waveform result, response to query"}

        };
    }
}
