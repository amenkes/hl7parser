﻿namespace HL7Data.Models.Types
{
    public enum SegmentTypes
    {
        UNK = 0, // Unknown - I added this for a "catch-all" in case not found (new spec, for example)
        ABS = 1, // Abstract
        ACC = 2, // Accident
        ADD = 3, // Addendum
        ADJ = 4, // Adjustment
        AFF = 5, // Professional Affiliation
        AIG = 6, // Appointment Information - General Resource
        AIL = 7, // Appointment Information - Location Resource
        AIP = 8, // Appointment Information - Personnel Resource
        AIS = 9, // Appointment Information
        AL1 = 10, // Patient Allergy Information
        APR = 11, // Appointment Preferences
        ARQ = 12, // Appointment Request
        ARV = 13, // Access Restriction
        AUT = 14, // Authorization Information
        BHS = 15, // Batch Header
        BLC = 16, // Blood Code
        BLG = 17, // Billing
        BPO = 18, // Blood Product Order
        BPX = 19, // Blood Product Dispense Status
        BTS = 20, // Batch Trailer
        BTX = 21, // Blood Product Transfusion/disposition
        BUI = 1021, //Blood Unit Information
        CDM = 22, // Charge Description Master
        CDO = 1022, //Cumulative Dosage
        CER = 23, // Certificate Detail
        CM0 = 24, // Clinical Study Master
        CM1 = 25, // Clinical Study Phase Master
        CM2 = 26, // Clinical Study Schedule Master
        CNS = 27, // Clear Notification
        CON = 28, // Consent Segment
        CSP = 29, // Clinical Study Phase
        CSR = 30, // Clinical Study Registration
        CSS = 31, // Clinical Study Data Schedule Segment
        CTD = 32, // Contact Data
        CTI = 33, // Clinical Trial Identification
        DB1 = 34, // Disability
        DG1 = 35, // Diagnosis
        DMI = 36, // Drg Master File Information
        DRG = 37, // Diagnosis Related Group
        DSC = 38, // Continuation Pointer
        DSP = 39, // Display Data
        ECD = 40, // Equipment Command
        ECR = 41, // Equipment Command Response
        EDU = 42, // Educational Detail
        EQP = 43, // Equipment/log Service
        EQU = 44, // Equipment Detail
        ERR = 45, // Error
        EVN = 46, // Event Type
        FAC = 47, // Facility
        FHS = 48, // File Header
        FT1 = 49, // Financial Transaction
        FTS = 50, // File Trailer
        GOL = 51, // Goal Detail
        GP1 = 52, // Grouping/reimbursement - Visit
        GP2 = 53, // Grouping/reimbursement - Procedure Line Item
        GT1 = 54, // Guarantor
        Hxx = 55, // Any Hl7 Segment
        IAM = 56, // Patient Adverse Reaction Information
        IAR = 57, // Allergy Reaction
        IIM = 58, // Inventory Item Master
        ILT = 59, // Material Lot
        IN1 = 60, // Insurance
        IN2 = 61, // Insurance Additional Information
        IN3 = 62, // Insurance Additional Information, Certification
        INV = 63, // Inventory Detail
        IPC = 64, // Imaging Procedure Control Segment
        IPR = 65, // Invoice Processing Results
        ISD = 66, // Interaction Status Detail
        ITM = 67, // Material Item
        IVC = 68, // Invoice Segment
        IVT = 69, // Material Location
        LAN = 70, // Language Detail
        LCC = 71, // Location Charge Code
        LCH = 72, // Location Characteristic
        LDP = 73, // Location Department
        LOC = 74, // Location Identification
        LRL = 75, // Location Relationship
        MFA = 76, // Master File Acknowledgment
        MFE = 77, // Master File Entry
        MFI = 78, // Master File Identification
        MRG = 79, // Merge Patient Information
        MSA = 80, // Message Acknowledgment
        MSH = 81, // Message Header
        NCK = 82, // System Clock
        NDS = 83, // Notification Detail
        NK1 = 84, // Next Of Kin / Associated Parties
        NPU = 85, // Bed Status Update
        NSC = 86, // Application Status Change
        NST = 87, // Application Control Level Statistics
        NTE = 88, // Notes And Comments
        OBR = 89, // Observation Request
        OBX = 90, // Observation/result
        ODS = 91, // Dietary Orders, Supplements, And Preferences
        ODT = 92, // Diet Tray Instructions
        OM1 = 93, // General Segment
        OM2 = 94, // Numeric Observation
        OM3 = 95, // Categorical Service/test/observation
        OM4 = 96, // Observations That Require Specimens
        OM5 = 97, // Observation Batteries (sets)
        OM6 = 98, // Observations That Are Calculated From Other Observations
        OM7 = 99, // Additional Basic Attributes
        ORC = 100, // Common Order
        ORG = 101, // Practitioner Organization Unit S
        OVR = 102, // Override Segment
        PAC = 103, // Shipment Package
        PCE = 104, // Patient Charge Cost Center Exceptions
        PCR = 105, // Possible Causal Relationship
        PD1 = 106, // Patient Additional Demographic
        PDA = 107, // Patient Death And Autopsy
        PDC = 108, // Product Detail Country
        PEO = 109, // Product Experience Observation
        PES = 110, // Product Experience Sender
        PID = 111, // Patient Identification
        PKG = 112, // Item Packaging
        PMT = 113, // Payment Information
        PR1 = 114, // Procedures
        PRA = 115, // Practitioner Detail
        PRB = 116, // Problem Details
        PRC = 117, // Pricing
        PRD = 118, // Provider Data
        PRT = 119, // Participation Information
        PSG = 120, // Product/service Group
        PSH = 121, // Product Summary Header
        PSL = 122, // Product/service Line Item
        PSS = 123, // Product/service Section
        PTH = 124, // Pathway
        PV1 = 125, // Patient Visit
        PV2 = 126, // Patient Visit - Additional Information
        PYE = 127, // Payee Information
        QAK = 128, // Query Acknowledgment
        QID = 129, // Query Identification
        QPD = 130, // Query Parameter Definition
        QRD = 131, // Withdrawn
        QRF = 132, // Withdrawn
        QRI = 133, // Query Response Instance
        RCP = 134, // Response Control Parameter
        RDF = 135, // Table Row Definition
        RDT = 136, // Table Row Data
        REL = 137, // Clinical Relationship Segment
        RF1 = 138, // Referral Information
        RFI = 139, // Request For Information
        RGS = 140, // Resource Group
        RMI = 141, // Risk Management Incident
        ROL = 142, // Role
        RQ1 = 143, // Requisition Detail-1
        RQD = 144, // Requisition Detail
        RXA = 145, // Pharmacy/treatment Administration
        RXC = 146, // Pharmacy/treatment Component Order
        RXD = 147, // Pharmacy/treatment Dispense
        RXE = 148, // Pharmacy/treatment Encoded Order
        RXG = 149, // Pharmacy/treatment Give
        RXO = 150, // Pharmacy/treatment Order
        RXR = 151, // Pharmacy/treatment Route
        SAC = 152, // Specimen Container Detail
        SCD = 153, // Anti-microbial Cycle Data
        SCH = 154, // Scheduling Activity Information
        SCP = 155, // Sterilizer Configuration (anti-microbial Devices)
        SDD = 156, // Sterilization Device Data
        SFT = 157, // Software Segment
        SHP = 158, // Shipment
        SID = 159, // Substance Identifier
        SLT = 160, // Sterilization Lot
        SPM = 161, // Specimen
        STF = 162, // Staff Identification
        STZ = 163, // Sterilization Parameter
        TCC = 164, // Test Code Configuration
        TCD = 165, // Test Code Detail
        TQ1 = 166, // Timing/quantity
        TQ2 = 167, // Timing/quantity Relationship
        TXA = 168, // Transcription Document Header
        UAC = 169, // User Authentication Credential Segment
        UB1 = 170, // Ub82
        UB2 = 171, // Uniform Billing Data
        URD = 172, // Withdrawn
        URS = 173, // Withdrawn
        VAR = 174, // Variance
        VND = 175, // Purchasing Vendor
        ZL7 = 176, // (proposed Example Only)
        Zxx = 177 // Any Z Segment
    }
}