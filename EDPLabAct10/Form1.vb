Imports System.IO

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using sw As New StreamWriter(filePath)
            For Each number As Integer In numbers
                sw.WriteLine(number) ' Or comma-separated, etc.
            Next
        End Using
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim sortedNumbers = numbers.OrderBy(Function(x) x).ToList()
    End Sub


End Class
