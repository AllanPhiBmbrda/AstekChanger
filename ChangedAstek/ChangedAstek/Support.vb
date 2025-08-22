Module Support


    Public PathStr As String
    Public SQL As String

    Public AsD As New ADODB.Connection
    Public AsTb1 As New ADODB.Recordset 'Seaching Item
    Public AsTb2 As New ADODB.Recordset 'Save Item

    Sub OpenDB(ByVal DBcon As ADODB.Connection, ByVal DBName As String, ByVal DBPass As String)

        PathStr = ""
        PathStr = "Provider=Microsoft.Jet.OLEDB.4.0;"
        PathStr = PathStr & "Data Source=" & Application.StartupPath + "\" & DBName & ";"
        PathStr = PathStr & "Persist Security Info=False;"
        PathStr = PathStr & "Jet OLEDB:database password= " & DBPass

        If DBcon.State = 1 Then DBcon.Close()
        DBcon.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        DBcon.ConnectionString = PathStr
        DBcon.Open()

    End Sub


    Sub OpenTbl(ByVal DB As ADODB.Connection, ByVal Tbl As ADODB.Recordset, ByVal SQL As String)

        If Tbl.State = 1 Then Tbl.Close()

        Tbl.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

    End Sub

    Public Sub LoadDB()
        OpenDB(AsD, "Sortasi1.mdb", "azure2013")

    End Sub



End Module
