Imports System.IO

Public Class Form1
    Dim list As String
    Dim srcFolder, destFolder As String
    Dim srcFile, destFile As String
    Dim txtDelimiter, clmNumber As String
    Dim settings As String = "settings.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Settings
        loadSettings()
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        ' Read Settings from Textboxes
        readSettings()

        ' Write Settings to file
        writeSettings()

        main()
    End Sub

    Private Sub main()
        checkFolderBackslash()                   ' Checks, if src and dest folder end with a \ -> if not, add one

        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(list)
        Dim a As String
        Dim i As Integer = 0                    ' Counts copied files
        Dim f As Integer = 0                    ' Counts all files
        Dim firstlinechecked As Boolean = False


        ' Read filenames from txt and copy them from srcFolder to destFolder
        Do
            If (skipFirstLine.Checked And Not (firstlinechecked)) Then
                a = reader.ReadLine
                firstlinechecked = True
            End If

            a = reader.ReadLine

            If (deleteQuotes.Checked) Then
                a = delteteQuotesFromFilenames(a)
            End If

            Try
                a = a.Split(txtDelimiter)(Convert.ToInt16(clmNumber) - 1) ' Splits filename after xth delimiter
            Catch ex As Exception

            End Try


            Console.WriteLine(a)

            srcFile = srcFolder + a                 ' Define source file name.
            destFile = destFolder + a               ' Define target file name.



            Try
                ' Only check if files are existing
                If (onlyCheckForExist.Checked) Then
                    If (Not (System.IO.File.Exists(srcFile))) Then  ' Checks if file exists -> If not: Throw exception
                        Throw New System.Exception("File does not exist.")
                    ElseIf (System.IO.File.Exists(destFile) And Not reducesLogging.Checked) Then
                        logBox.Text += "ALREADY COPIED - " + srcFile + Environment.NewLine
                    End If

                    ' Copy the existing files
                Else
                    If (overwriteExistingFiles.Checked) Then
                        FileCopy(srcFile, destFile) ' Copy source to target - Overwrites existing files
                    Else
                        If (Not (System.IO.File.Exists(destFile))) Then
                            FileCopy(srcFile, destFile) ' Copy source to target - Don't overwrite existing files
                        ElseIf (Not reducesLogging.Checked) Then
                            logBox.Text += "ALREADY COPIED - " + srcFile + Environment.NewLine
                        End If
                    End If
                End If

                If (Not reducesLogging.Checked) Then
                    i += 1
                    f += 1                          ' Count the copied files
                End If
            Catch ex As Exception
                Try
                    Dim srcWithoutPath As String = Path.GetFileName(srcFile)    ' Get only the file 

                    If (Not (srcWithoutPath.Equals(""))) Then   ' Filters empty strings
                        If (reducesLogging.Checked) Then    ' Reduced logging
                            logBox.Text += srcWithoutPath + Environment.NewLine
                        Else
                            logBox.Text += "NOT FOUND - " + srcWithoutPath + Environment.NewLine
                        End If
                    End If
                Catch ex1 As Exception
                    If (Not reducesLogging.Checked) Then
                        logBox.Text += ex1.ToString + Environment.NewLine
                    End If
                End Try




                If (Not reducesLogging.Checked) Then
                    i += 1
                End If
            End Try

        Loop Until a Is Nothing

        logBox.Text = logBox.Text + Environment.NewLine

        If (Not reducesLogging.Checked) Then
            logBox.Text = "Files copied: " + f.ToString + " / " + i.ToString + Environment.NewLine + Environment.NewLine + logBox.Text
        End If

        reader.Close()
    End Sub

    Private Function delteteQuotesFromFilenames(filename As String) As String
        Try
            If (filename.Contains("""")) Then
                filename = filename.Replace("""", "")
            End If
            If (filename.Contains("'")) Then
                filename = filename.Replace("'", "")
            End If
        Catch ex As Exception

        End Try

        Return filename
    End Function

    Private Sub checkFolderBackslash()
        If (Not (srcFolder.Substring(srcFolder.Length - 1).Equals("\"))) Then
            srcFolder = srcFolder + "\"
        End If
        If (Not (destFolder.Substring(srcFolder.Length - 1).Equals("\"))) Then
            destFolder = destFolder + "\"
        End If
    End Sub

    Private Sub loadSettings()
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(settings)

        srcFolder = reader.ReadLine
        destFolder = reader.ReadLine
        list = reader.ReadLine
        reducesLogging.Checked = Convert.ToBoolean(reader.ReadLine)
        onlyCheckForExist.Checked = Convert.ToBoolean(reader.ReadLine)
        overwriteExistingFiles.Checked = Convert.ToBoolean(reader.ReadLine)
        deleteQuotes.Checked = Convert.ToBoolean(reader.ReadLine)
        skipFirstLine.Checked = Convert.ToBoolean(reader.ReadLine)
        clmNumber = reader.ReadLine
        txtDelimiter = reader.ReadLine


        reader.Close()


        fileList.Text = list
        sourceFolder.Text = srcFolder
        destinationFolder.Text = destFolder
        columnNumber.Text = clmNumber
        textDelimiter.Text = txtDelimiter
    End Sub

    Private Sub readSettings()
        list = fileList.Text
        srcFolder = sourceFolder.Text
        destFolder = destinationFolder.Text
        clmNumber = columnNumber.Text
        txtDelimiter = textDelimiter.Text
    End Sub

    Private Sub writeSettings()
        IO.File.WriteAllText(settings, "")

        Dim file As System.IO.StreamWriter


        file = My.Computer.FileSystem.OpenTextFileWriter(settings, True)

        file.WriteLine(srcFolder)
        file.WriteLine(destFolder)
        file.WriteLine(list)
        file.WriteLine(reducesLogging.Checked.ToString)
        file.WriteLine(onlyCheckForExist.Checked.ToString)
        file.WriteLine(overwriteExistingFiles.Checked.ToString)
        file.WriteLine(deleteQuotes.Checked.ToString)
        file.WriteLine(skipFirstLine.Checked.ToString)
        file.WriteLine(clmNumber)
        file.WriteLine(txtDelimiter)


        file.Close()
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

    Private Sub exportErrorLog_Click(sender As Object, e As EventArgs) Handles exportErrorLog.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Error log|*.txt"
        saveFileDialog1.Title = "Save error log"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, logBox.Text, False)
        End If
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
