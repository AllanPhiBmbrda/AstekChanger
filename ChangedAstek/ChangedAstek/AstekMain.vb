Public Class AstekMain

    Dim NikAs As String ' Nik
    Dim NameAs As String ' Name
    Dim AsAs As String ' Astek

    Dim SaveNikAs As String
    Dim SaveNameAs As String
    Dim SaveAsAs As String

    Private Sub AstekMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadDB()

    End Sub

    Sub GridHeader01()

        With ACGrid01

            .Columns.Clear()
            .Rows.Clear()
            .Columns.Add("col1", "Nik")
            .Columns.Add("col2", "Name")
            .Columns.Add("col3", "Astek")
            .Columns.Add("col4", "Result")

            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 100
            .Columns(3).Width = 150

        End With

    End Sub

    Sub SearchAstekPeople() ' Search People with existing Astek

        GridHeader01()

        SQL = ""
        SQL = SQL & "Select * From 02_Name_Table "
        SQL = SQL & "Where Jamsostek = cstr('" & ACTb01.Text & " ')"
        OpenTbl(AsD, AsTb1, SQL)
        If AsTb1.RecordCount <> 0 Then

            AsTb1.MoveFirst()
            Do While Not AsTb1.EOF

                NikAs = IIf(IsDBNull(AsTb1("Nik").Value), "", AsTb1("Nik").Value)
                NameAs = IIf(IsDBNull(AsTb1("Name").Value), "", AsTb1("Name").Value)
                AsAs = IIf(IsDBNull(AsTb1("Jamsostek").Value), "", AsTb1("Jamsostek").Value)

                ACGrid01.Rows.Add(NikAs, NameAs, AsAs)

                AsTb1.MoveNext()

            Loop

        End If

    End Sub

    Sub SaveAstekPeople()

        For i = 0 To ACGrid01.Rows.Count - 1

            SaveNikAs = ACGrid01(0, i).Value

            SQL = ""
            SQL = SQL & "Select * From 02_Name_Table "
            SQL = SQL & "Where Nik = cstr('" & SaveNikAs & " ')"
            OpenTbl(AsD, AsTb2, SQL)

            If AsTb2.RecordCount > 0 Then

                AsTb2("Nik").Value = SaveNikAs
                AsTb2("Jamsostek").Value = ACTb02.Text

                AsTb2.Update()
                ACGrid01(3, i).Value = "Has Been Updated"

            End If

        Next

    End Sub

    Private Sub ACBtn01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACBtn01.Click

        SearchAstekPeople()

    End Sub

    Private Sub ACBtn02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACBtn02.Click

        SaveAstekPeople()

    End Sub

    Private Sub ACTb02_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ACTb02.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True ' No Alphabet 

        End If
    End Sub

    Private Sub ACTb01_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ACTb01.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True ' No Alphabet 

        End If
    End Sub


End Class
