namespace HMS.Domain.Enums
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum BloodGroup
    {
        APositive,
        ANegative,
        BPositive,
        BNegative,
        ABPositive,
        ABNegative,
        OPositive,
        ONegative,
        Unknown
    }

    public enum MaritalStatus
    {
        Single,
        Married,
        Divorced,
        Widowed,
        Separated,
        Unknown
    }

    public enum RegistrationSource
    {
        Receptionist,
        SelfPortal,
        MobileApp,
        Referral
    }

    public enum PatientStatus
    {
        Active,
        Inactive,
        Deceased,
        Merged
    }

    public enum AddressType
    {
        Permanent,
        Current,
        Billing
    }

    public enum EmergencyRelationship
    {
        Spouse,
        Parent,
        Child,
        Sibling,
        Friend,
        Guardian,
        Other
    }

    public enum MedicalHistoryCategory
    {
        ChronicCondition,
        PastSurgery,
        FamilyHistory,
        Immunization,
        SocialHistory,
        Other
    }

    public enum HistoryStatus
    {
        Active,
        Resolved,
        Chronic,
        Unknown
    }

    public enum AllergyType
    {
        Drug,
        Food,
        Environmental,
        Other
    }

    public enum AllergySeverity
    {
        Mild,
        Moderate,
        Severe,
        LifeThreatening
    }

    public enum AllergyStatus
    {
        Active,
        Inactive,
        Resolved
    }

    public enum DocumentType
    {
        IDProof,
        AddressProof,
        InsuranceCard,
        OldMedicalReport,
        LabReport,
        Prescription,
        ConsentForm,
        Other
    }
}