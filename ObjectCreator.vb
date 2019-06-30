Public Class ObjectCreator
    Public Sub CreateObjectsAndLists()
        'AU: Initialize the connection string to the database for this project
        Dim Hw4SQL As String
        Dim HW4ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\HW4_SP19.mdb"
        Dim Hw4DataSet As New DataSet
        Dim tableName As String
        Dim myDbms As New DBMS


        'AU: We set properties of the Job objects from data in the Jobs table
        tableName = "Jobs"
        Hw4SQL = "SELECT * FROM " & tableName                               'AU: This SQL selects all columns from the Job table in MS Access
        myDbms.RunSQL(tableName, Hw4SQL, Hw4DataSet, HW4ConnectionString)  'AU: We execute the query
        '
        'AU: We create the objects of the Job Class from the data in the Jobs table
        For rowNumber As Integer = 0 To Hw4DataSet.Tables(tableName).Rows.Count - 1
            Dim myJobs As New Jobs
            myJobs.JobID = Hw4DataSet.Tables(tableName).Rows(rowNumber)("ID")
            myJobs.CompanyName = Hw4DataSet.Tables(tableName).Rows(rowNumber)("CompanyName")
            myJobs.JobTitle = Hw4DataSet.Tables(tableName).Rows(rowNumber)("JobTitle")
            myJobs.DsiciplineRequired = Hw4DataSet.Tables(tableName).Rows(rowNumber)("DisciplineRequired")
            myJobs.Location = Hw4DataSet.Tables(tableName).Rows(rowNumber)("Location")
            myJobs.Salary = Hw4DataSet.Tables(tableName).Rows(rowNumber)("Salary")
            myJobs.NumberOfOpenings = Hw4DataSet.Tables(tableName).Rows(rowNumber)("NumberOfOpenings")

            Jobs.JobList.Add(myJobs)
        Next
        '
        'RDB: We set properties of the Discipline objects from data in the Discipline table
        tableName = "Discipline"
        Hw4SQL = "SELECT * FROM " & tableName                               'AU: This SQL selects all columns from the Discipline table in MS Access
        myDbms.RunSQL(tableName, Hw4SQL, Hw4DataSet, HW4ConnectionString)  'AU: We execute the query
        '
        'AU: We create the objects of the Discipline Class
        For rowNumber As Integer = 0 To Hw4DataSet.Tables(tableName).Rows.Count - 1
            Dim myDiscipline As New Discipline
            myDiscipline.DisciplineId = Hw4DataSet.Tables(tableName).Rows(rowNumber)("ID")
            myDiscipline.DisciplineDescription = Hw4DataSet.Tables(tableName).Rows(rowNumber)("DisciplineDescription")


            Discipline.DisciplineList.Add(myDiscipline)
        Next
        '
        'Au: We set properties of the Department objects from DepartmentDiscipline in the Departmentdiscipline table
        tableName = "DepartmentDiscipline"
        Hw4SQL = "SELECT * FROM " & tableName                               'AU: This SQL selects all columns from the DepartmentDiscipline table in MS Access
        myDbms.RunSQL(tableName, Hw4SQL, Hw4DataSet, HW4ConnectionString)  'AU: We execute the query
        '
        'AU: We create the objects of the Department Class
        For rowNumber As Integer = 0 To Hw4DataSet.Tables(tableName).Rows.Count - 1
            Dim myDepartment As New Department
            myDepartment.DepartmentId = Hw4DataSet.Tables(tableName).Rows(rowNumber)("ID")
            myDepartment.DepartmentName = Hw4DataSet.Tables(tableName).Rows(rowNumber)("DepartmentName")
            myDepartment.DisciplineOffered = Hw4DataSet.Tables(tableName).Rows(rowNumber)("DisciplineOffered")

            Department.DepartmentList.Add(myDepartment)
        Next
    End Sub
End Class
