' AU this class declares public properties and a shared property for the DepartmentDiscipline table
Public Class Discipline
    Public Shared Property DisciplineList As New List(Of Discipline)
    Public Property DisciplineId As Long
    Public Property DisciplineDescription As String


End Class
