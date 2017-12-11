Public Class CustomerSearchForm
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Function SearchValue(ByRef CusID As ToolStripTextBox, ByRef DL As ToolStripTextBox, ByRef Company As ToolStripTextBox, ByRef fname As ToolStripTextBox, ByRef lname As ToolStripTextBox) As Integer

        Dim intValue As Integer = 0
        If CusID.Text <> "" Then
            intValue += 10000
        End If
        If DL.Text <> "" Then
            intValue += 1000
        End If
        If Company.Text <> "" Then
            intValue += 100
        End If
        If fname.Text <> "" Then
            intValue += 10
        End If
        If lname.Text <> "" Then
            intValue += 1
        End If
        Return intValue
    End Function
    Private Function Searchstring(ByVal Searchvalue As Integer) As String
        Searchstring = ""

        Select Case Searchvalue


        End Select
        Return searchstring

    End Function

    Private Sub btnScanID_Click(sender As Object, e As EventArgs) Handles btnScanID.Click

    End Sub
End Class