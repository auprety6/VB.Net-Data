Public Class AUForm1
    Private Sub AUbutton1_Click(sender As Object, e As EventArgs) Handles AUButton1.Click
        Dim userDepartment As String
        userDepartment = AUTextBox1.Text

        'AU: We call a sub to perform the query on the tour data 
        Query(userDepartment)
    End Sub
    '**************************************************************************************************************************
    Public Sub Query(depts As String)
        '
        'AU: This sub runs the query on the dataset using LINQ commands
        Dim d = From myDepartment In Department.DepartmentList
                Where myDepartment.DepartmentName = depts
                Join myDiscipline In Discipline.DisciplineList On myDiscipline.DisciplineId Equals myDepartment.DisciplineOffered
                Join myJobs In Jobs.JobList On myJobs.DsiciplineRequired Equals myDiscipline.DisciplineId
                Select myJobs.CompanyName, myJobs.Salary, myJobs.Location

        '
        'AU: Now we display the query results in a dialog box using the string formatting method
        'AU:  First, we construct the column headingsin the display string
        Dim displayQuery = String.Format("{0}" + vbTab + "{1}" + vbTab + "{2}" + vbNewLine, "Company Name", "Salary", "Location")
        'AU: Now we construct each row of the query
        For Each record In d
            displayQuery &= String.Format("{0}" + vbTab + "{1}" + vbTab + "{2}" + vbNewLine, record.CompanyName, record.Salary, record.Location)
        Next
        MessageBox.Show(displayQuery)
    End Sub
    '**************************************************************************************************************************
    Private Sub AuForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AU: This subroutine calls the object creator that transfers data from the database to the properties of objects
        '
        Dim myCreateObjects As New ObjectCreator
        myCreateObjects.CreateObjectsAndLists()
    End Sub
End Class


