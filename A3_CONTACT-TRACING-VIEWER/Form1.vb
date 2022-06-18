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
End Class
