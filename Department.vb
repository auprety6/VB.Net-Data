' AU this class declares public properties and a shared property for the Department table
Public Class Department
    Public Shared Property DepartmentList As New List(Of Department)

    Public Property DepartmentId As Long
    Public Property DepartmentName As String
    Public Property DisciplineOffered As Long


End Class
