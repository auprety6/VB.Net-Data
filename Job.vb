' AU this class declares public properties and a shared property for the Jobs table
Public Class Jobs
    Public Shared Property JobList As New List(Of Jobs)

    Public Property JobID As Long
    Public Property CompanyName As String
    Public Property JobTitle As String
    Public Property DsiciplineRequired As Long
    Public Property Location As String
    Public Property Salary As Double
    Public Property NumberOfOpenings As Integer



End Class
