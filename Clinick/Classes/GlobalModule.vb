Module GlobalModule
    Public Service As String
    Public MaxPatients As Integer = 100
    Public CurrentCount As Integer = 0

    ' Requirement: Parallel Arrays — patient data
    Public arrID(100) As String
    Public arrNames(100) As String
    Public arrSex(100) As String
    Public arrContact(100) As String
    Public arrService(100) As String
    Public arrSchedule(100) As String
    Public arrStatus(100) As String
    Public arrCancelReason(100) As String
    Public arrAge(100) As Integer
    Public arrBday(100) As Date

    ' Medical Records — parallel arrays
    ' Each index matches the same patient index in the main arrays above
    Public arrDiagnosis(100) As String       ' e.g. "Hypertension, Stage 1"
    Public arrPrescription(100) As String    ' e.g. "Amlodipine 5mg once daily"
    Public arrConsultNotes(100) As String    ' e.g. "Patient reports occasional headaches"
    Public arrMedHistory(100) As String      ' e.g. "Diabetes (2018), Asthma (2015)"

    ' For Dashboard
    Public RecordCount As Integer = 0
    Public TotalGeneral As Integer = 0
    Public TotalDental As Integer = 0
    Public TotalPedia As Integer = 0

End Module