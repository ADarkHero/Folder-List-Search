Imports System.IO

Public Class Form1
    Dim list As String
    Dim srcFolder, destFolder As String
    Dim srcFile, destFile As String
    Dim settings As String = "settings.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Settings
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(settings)

        srcFolder = reader.ReadLine
        destFolder = reader.ReadLine
        list = reader.ReadLine

        reader.Close()


        fileList.Text = list
        sourceFolder.Text = srcFolder
        destinationFolder.Text = destFolder
    End Sub


    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        ' Read Settings from Textboxes
        list = fileList.Text
        srcFolder = sourceFolder.Text
        destFolder = destinationFolder.Text

        ' Write Settings to file
        System.IO.File.WriteAllText(settings, "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(settings, True)
        file.WriteLine(srcFolder)
        file.WriteLine(destFolder)
        file.WriteLine(list)
        file.Close()



        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(list)
        Dim a As String
        Dim i As Integer = 0                    ' Counts copied files
        Dim f As Integer = 0                    ' Counts all files
        logBox.Text = ""                        ' Clear error log

        ' Read filenames from txt and copy them from srcFolder to destFolder
        Do
            a = reader.ReadLine


            srcFile = srcFolder + a                 ' Define source file name.
            destFile = destFolder + a               ' Define target file name.
            Try
                FileCopy(srcFile, destFile)         ' Copy source to target.
                If (Not reducesLogging.Checked) Then
                    i += 1
                    f += 1                          ' Count the copied files
                End If
            Catch ex As Exception
                If (reducesLogging.Checked) Then
                    logBox.Text += srcFile + Environment.NewLine
                Else
                    logBox.Text += "NOT FOUND - " + srcFile + Environment.NewLine
                End If

                If (Not reducesLogging.Checked) Then
                    i += 1
                End If
            End Try



        Loop Until a Is Nothing


        If (Not reducesLogging.Checked) Then
            logBox.Text = "Files copied: " + f.ToString + " / " + i.ToString + Environment.NewLine + Environment.NewLine + logBox.Text
        End If

        reader.Close()
    End Sub

    Private Sub clearErrorLog_Click(sender As Object, e As EventArgs) Handles clearErrorLog.Click
        logBox.Text = ""
    End Sub

    Private Sub chooseSourceFolder_Click(sender As Object, e As EventArgs) Handles chooseSourceFolder.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            sourceFolder.Text = FolderBrowserDialog1.SelectedPath + "\"
        End If
    End Sub

    Private Sub configErrorLog_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub exportErrorLog_Click(sender As Object, e As EventArgs) Handles exportErrorLog.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Error log|*.txt"
        saveFileDialog1.Title = "Save error log"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, logBox.Text, False)
        End If
    End Sub

    Private Sub reducedLogging(sender As Object, e As EventArgs) Handles reducesLogging.CheckedChanged

    End Sub

    Private Sub chooseDestinationFolder_Click(sender As Object, e As EventArgs) Handles chooseDestinationFolder.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            destinationFolder.Text = FolderBrowserDialog1.SelectedPath + "\"
        End If
    End Sub

    Private Sub chooseFileList_Click(sender As Object, e As EventArgs) Handles chooseFileList.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            fileList.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class
