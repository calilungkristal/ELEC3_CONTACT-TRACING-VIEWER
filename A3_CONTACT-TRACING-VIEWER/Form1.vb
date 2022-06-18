Imports System.IO

Public Class Form1
    Private Sub btnOpenRecord_Click(sender As Object, e As EventArgs) Handles btnOpenRecord.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Filter = "txt Files (*.txt) | *.txt"

        If ofd.ShowDialog() = DialogResult.OK Then
            richTextBoxResult.Text = File.ReadAllText(ofd.FileName)
        End If
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        richTextBoxResult.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Confirm if you want to exit", "TRACEme.app", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If iExit = DialogResult.OK Then
                Application.[Exit]()
            ElseIf iExit = DialogResult.Cancel Then
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "TRACEme.app", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
