Imports System.IO
Imports System.IO.Compression
Public Class Form1

    Dim logFile As String = String.Empty
    Dim transactionDate As String = String.Empty
    Dim transactionHour As String = String.Empty

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim selectedFile As String = String.Empty
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            selectedFile = OpenFileDialog1.FileName
            SelectedPath.Text = selectedFile
        Else
            Exit Sub
        End If

    End Sub

    Private Sub timeRangeEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles timeRangeEnabled.CheckedChanged

        If timeRangeEnabled.Checked Then
            fromTimePicker.Enabled = True
            toTimePicker.Enabled = True
        Else
            fromTimePicker.Enabled = False
            toTimePicker.Enabled = False
        End If

    End Sub

    Private Sub SelectedPath_TextChanged(sender As Object, e As EventArgs) Handles SelectedPath.TextChanged

        If IsValidFileNameOrPath(SelectedPath.Text) Then
            analyzeButton.Enabled = True
        Else
            analyzeButton.Enabled = False
        End If
    End Sub

    Function IsValidFileNameOrPath(ByVal name As String) As Boolean

        Dim isValid As Boolean = False

        If String.IsNullOrEmpty(name) Then
            isValid = False
        Else
            If File.Exists(name) AndAlso name.EndsWith(".zip") OrElse name.Contains("log.txt.") Then

                isValid = True
                logFile = name
            End If
        End If

        Return isValid

    End Function

    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        If logFile.EndsWith(".zip") Then
            extractLogFile(logFile)
        End If

    End Sub

    Private Sub extractLogFile(ByRef logFile As String)
        Dim extractPath As String = "C:\Users\roccos\Desktop\Log Analyzer\unzipped\"

        transactionDate = logFile.Split("-")(2)
        transactionHour = logFile.Split("-")(3)

        Dim zippedLogFile As String = "log.txt." + transactionDate + "-" + transactionHour

        Using archive = ZipFile.Open(logFile, ZipArchiveMode.Read)
            Dim entry = archive.GetEntry(zippedLogFile)
            If entry IsNot Nothing Then
                entry.ExtractToFile(extractPath + zippedLogFile)
                logFile = extractPath + zippedLogFile
            Else
                MessageBox.Show("Nessun file di log trovato all'interno dell'archivio", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Using

    End Sub

End Class