Module GlobalModule
    'General Variables'
    Public UserID(100) As String
    Public PatientNam(100) As String
    Public ContactInfo(100) As String
    Public ApptSched(100) As String
    Public ApptStatus(100) As String
    Public CancelReason(100) As String
    Public ServiceType(100) As String

    'General Consultation Variables'
    Public GenUrgency(100) As String
    Public GenConcern(100) As String

    'Dental Services Variables'
    Public DenProcedure(100) As String
    Public DenPatientType(100) As String

    'Pediatrics Variables'
    Public PediaAgeGroup(100) As String
    Public PediaVisitType(100) As String
    Public PediaGuardian(100) As String

    'For Dashboard'
    Public RecordCount As Integer = 0
    Public TotalGeneral As Integer = 0
    Public TotalDental As Integer = 0
    Public TotalPedia As Integer = 0


End Module
