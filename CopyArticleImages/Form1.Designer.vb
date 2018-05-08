<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.logBox = New System.Windows.Forms.RichTextBox()
        Me.logBoxButton = New System.Windows.Forms.Button()
        Me.sourceFolder = New System.Windows.Forms.TextBox()
        Me.destinationFolder = New System.Windows.Forms.TextBox()
        Me.fileList = New System.Windows.Forms.TextBox()
        Me.sourceFolderButton = New System.Windows.Forms.Button()
        Me.destinationFolderButton = New System.Windows.Forms.Button()
        Me.fileListButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.settingsButton = New System.Windows.Forms.Button()
        Me.clearErrorLog = New System.Windows.Forms.Button()
        Me.chooseSourceFolder = New System.Windows.Forms.Button()
        Me.chooseDestinationFolder = New System.Windows.Forms.Button()
        Me.chooseFileList = New System.Windows.Forms.Button()
        Me.exportErrorLog = New System.Windows.Forms.Button()
        Me.reducesLogging = New System.Windows.Forms.CheckBox()
        Me.onlyCheckForExist = New System.Windows.Forms.CheckBox()
        Me.overwriteExistingFiles = New System.Windows.Forms.CheckBox()
        Me.columnNumber = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.textDelimiter = New System.Windows.Forms.TextBox()
        Me.deleteQuotes = New System.Windows.Forms.CheckBox()
        Me.skipFirstLine = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'logBox
        '
        Me.logBox.Location = New System.Drawing.Point(296, 66)
        Me.logBox.Name = "logBox"
        Me.logBox.Size = New System.Drawing.Size(400, 446)
        Me.logBox.TabIndex = 14
        Me.logBox.Text = ""
        '
        'logBoxButton
        '
        Me.logBoxButton.Location = New System.Drawing.Point(296, 12)
        Me.logBoxButton.Name = "logBoxButton"
        Me.logBoxButton.Size = New System.Drawing.Size(400, 35)
        Me.logBoxButton.TabIndex = 1
        Me.logBoxButton.TabStop = False
        Me.logBoxButton.Text = "Error Log..."
        Me.logBoxButton.UseVisualStyleBackColor = True
        '
        'sourceFolder
        '
        Me.sourceFolder.Location = New System.Drawing.Point(12, 95)
        Me.sourceFolder.Name = "sourceFolder"
        Me.sourceFolder.Size = New System.Drawing.Size(233, 20)
        Me.sourceFolder.TabIndex = 1
        '
        'destinationFolder
        '
        Me.destinationFolder.Location = New System.Drawing.Point(12, 159)
        Me.destinationFolder.Name = "destinationFolder"
        Me.destinationFolder.Size = New System.Drawing.Size(234, 20)
        Me.destinationFolder.TabIndex = 3
        '
        'fileList
        '
        Me.fileList.Location = New System.Drawing.Point(12, 225)
        Me.fileList.Name = "fileList"
        Me.fileList.Size = New System.Drawing.Size(233, 20)
        Me.fileList.TabIndex = 5
        '
        'sourceFolderButton
        '
        Me.sourceFolderButton.Location = New System.Drawing.Point(12, 66)
        Me.sourceFolderButton.Name = "sourceFolderButton"
        Me.sourceFolderButton.Size = New System.Drawing.Size(278, 23)
        Me.sourceFolderButton.TabIndex = 1001
        Me.sourceFolderButton.TabStop = False
        Me.sourceFolderButton.Text = "Source Folder"
        Me.sourceFolderButton.UseVisualStyleBackColor = True
        '
        'destinationFolderButton
        '
        Me.destinationFolderButton.Location = New System.Drawing.Point(12, 130)
        Me.destinationFolderButton.Name = "destinationFolderButton"
        Me.destinationFolderButton.Size = New System.Drawing.Size(278, 23)
        Me.destinationFolderButton.TabIndex = 6
        Me.destinationFolderButton.TabStop = False
        Me.destinationFolderButton.Text = "Destination Folder"
        Me.destinationFolderButton.UseVisualStyleBackColor = True
        '
        'fileListButton
        '
        Me.fileListButton.Location = New System.Drawing.Point(12, 196)
        Me.fileListButton.Name = "fileListButton"
        Me.fileListButton.Size = New System.Drawing.Size(278, 23)
        Me.fileListButton.TabIndex = 7
        Me.fileListButton.TabStop = False
        Me.fileListButton.Text = "File List"
        Me.fileListButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.BackColor = System.Drawing.Color.SeaGreen
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(12, 439)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(276, 100)
        Me.startButton.TabIndex = 13
        Me.startButton.Text = "START!"
        Me.startButton.UseVisualStyleBackColor = False
        '
        'settingsButton
        '
        Me.settingsButton.Location = New System.Drawing.Point(12, 12)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(279, 35)
        Me.settingsButton.TabIndex = 9
        Me.settingsButton.TabStop = False
        Me.settingsButton.Text = "Settings"
        Me.settingsButton.UseVisualStyleBackColor = True
        '
        'clearErrorLog
        '
        Me.clearErrorLog.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.clearErrorLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearErrorLog.Location = New System.Drawing.Point(296, 518)
        Me.clearErrorLog.Name = "clearErrorLog"
        Me.clearErrorLog.Size = New System.Drawing.Size(130, 23)
        Me.clearErrorLog.TabIndex = 15
        Me.clearErrorLog.Text = "Clear Error Log"
        Me.clearErrorLog.UseVisualStyleBackColor = False
        '
        'chooseSourceFolder
        '
        Me.chooseSourceFolder.Location = New System.Drawing.Point(251, 95)
        Me.chooseSourceFolder.Name = "chooseSourceFolder"
        Me.chooseSourceFolder.Size = New System.Drawing.Size(37, 20)
        Me.chooseSourceFolder.TabIndex = 2
        Me.chooseSourceFolder.Text = "..."
        Me.chooseSourceFolder.UseVisualStyleBackColor = True
        '
        'chooseDestinationFolder
        '
        Me.chooseDestinationFolder.Location = New System.Drawing.Point(251, 159)
        Me.chooseDestinationFolder.Name = "chooseDestinationFolder"
        Me.chooseDestinationFolder.Size = New System.Drawing.Size(37, 20)
        Me.chooseDestinationFolder.TabIndex = 4
        Me.chooseDestinationFolder.Text = "..."
        Me.chooseDestinationFolder.UseVisualStyleBackColor = True
        '
        'chooseFileList
        '
        Me.chooseFileList.Location = New System.Drawing.Point(251, 225)
        Me.chooseFileList.Name = "chooseFileList"
        Me.chooseFileList.Size = New System.Drawing.Size(37, 20)
        Me.chooseFileList.TabIndex = 6
        Me.chooseFileList.Text = "..."
        Me.chooseFileList.UseVisualStyleBackColor = True
        '
        'exportErrorLog
        '
        Me.exportErrorLog.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.exportErrorLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportErrorLog.Location = New System.Drawing.Point(432, 518)
        Me.exportErrorLog.Name = "exportErrorLog"
        Me.exportErrorLog.Size = New System.Drawing.Size(130, 23)
        Me.exportErrorLog.TabIndex = 16
        Me.exportErrorLog.Text = "Export Error Log"
        Me.exportErrorLog.UseVisualStyleBackColor = False
        '
        'reducesLogging
        '
        Me.reducesLogging.AutoSize = True
        Me.reducesLogging.Checked = True
        Me.reducesLogging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.reducesLogging.Location = New System.Drawing.Point(568, 522)
        Me.reducesLogging.Name = "reducesLogging"
        Me.reducesLogging.Size = New System.Drawing.Size(111, 17)
        Me.reducesLogging.TabIndex = 17
        Me.reducesLogging.Text = "Reduced Logging"
        Me.reducesLogging.UseVisualStyleBackColor = True
        '
        'onlyCheckForExist
        '
        Me.onlyCheckForExist.AutoSize = True
        Me.onlyCheckForExist.Location = New System.Drawing.Point(12, 394)
        Me.onlyCheckForExist.Name = "onlyCheckForExist"
        Me.onlyCheckForExist.Size = New System.Drawing.Size(242, 17)
        Me.onlyCheckForExist.TabIndex = 11
        Me.onlyCheckForExist.Text = "Only check if files exist (without copying them)"
        Me.onlyCheckForExist.UseVisualStyleBackColor = True
        '
        'overwriteExistingFiles
        '
        Me.overwriteExistingFiles.AutoSize = True
        Me.overwriteExistingFiles.Location = New System.Drawing.Point(12, 417)
        Me.overwriteExistingFiles.Name = "overwriteExistingFiles"
        Me.overwriteExistingFiles.Size = New System.Drawing.Size(130, 17)
        Me.overwriteExistingFiles.TabIndex = 12
        Me.overwriteExistingFiles.Text = "Overwrite existing files"
        Me.overwriteExistingFiles.UseVisualStyleBackColor = True
        '
        'columnNumber
        '
        Me.columnNumber.Location = New System.Drawing.Point(156, 275)
        Me.columnNumber.Name = "columnNumber"
        Me.columnNumber.Size = New System.Drawing.Size(132, 20)
        Me.columnNumber.TabIndex = 7
        Me.columnNumber.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 20)
        Me.Button1.TabIndex = 20
        Me.Button1.TabStop = False
        Me.Button1.Text = "Which column?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 20)
        Me.Button2.TabIndex = 21
        Me.Button2.TabStop = False
        Me.Button2.Text = "Which delimiter?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'textDelimiter
        '
        Me.textDelimiter.Location = New System.Drawing.Point(156, 301)
        Me.textDelimiter.Name = "textDelimiter"
        Me.textDelimiter.Size = New System.Drawing.Size(132, 20)
        Me.textDelimiter.TabIndex = 8
        Me.textDelimiter.Text = ";"
        '
        'deleteQuotes
        '
        Me.deleteQuotes.AutoSize = True
        Me.deleteQuotes.Location = New System.Drawing.Point(12, 348)
        Me.deleteQuotes.Name = "deleteQuotes"
        Me.deleteQuotes.Size = New System.Drawing.Size(156, 17)
        Me.deleteQuotes.TabIndex = 9
        Me.deleteQuotes.Text = "Delete "" and ' from filename"
        Me.deleteQuotes.UseVisualStyleBackColor = True
        '
        'skipFirstLine
        '
        Me.skipFirstLine.AutoSize = True
        Me.skipFirstLine.Location = New System.Drawing.Point(12, 371)
        Me.skipFirstLine.Name = "skipFirstLine"
        Me.skipFirstLine.Size = New System.Drawing.Size(85, 17)
        Me.skipFirstLine.TabIndex = 10
        Me.skipFirstLine.Text = "Skip first line"
        Me.skipFirstLine.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 553)
        Me.Controls.Add(Me.skipFirstLine)
        Me.Controls.Add(Me.deleteQuotes)
        Me.Controls.Add(Me.textDelimiter)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.columnNumber)
        Me.Controls.Add(Me.overwriteExistingFiles)
        Me.Controls.Add(Me.onlyCheckForExist)
        Me.Controls.Add(Me.reducesLogging)
        Me.Controls.Add(Me.exportErrorLog)
        Me.Controls.Add(Me.chooseFileList)
        Me.Controls.Add(Me.chooseDestinationFolder)
        Me.Controls.Add(Me.chooseSourceFolder)
        Me.Controls.Add(Me.clearErrorLog)
        Me.Controls.Add(Me.settingsButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.fileListButton)
        Me.Controls.Add(Me.destinationFolderButton)
        Me.Controls.Add(Me.sourceFolderButton)
        Me.Controls.Add(Me.fileList)
        Me.Controls.Add(Me.destinationFolder)
        Me.Controls.Add(Me.sourceFolder)
        Me.Controls.Add(Me.logBoxButton)
        Me.Controls.Add(Me.logBox)
        Me.Name = "Form1"
        Me.Text = "Search folder for files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logBox As RichTextBox
    Friend WithEvents logBoxButton As Button
    Friend WithEvents sourceFolder As TextBox
    Friend WithEvents destinationFolder As TextBox
    Friend WithEvents fileList As TextBox
    Friend WithEvents sourceFolderButton As Button
    Friend WithEvents destinationFolderButton As Button
    Friend WithEvents fileListButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents settingsButton As Button
    Friend WithEvents clearErrorLog As Button
    Friend WithEvents chooseSourceFolder As Button
    Friend WithEvents chooseDestinationFolder As Button
    Friend WithEvents chooseFileList As Button
    Friend WithEvents exportErrorLog As Button
    Friend WithEvents reducesLogging As CheckBox
    Friend WithEvents onlyCheckForExist As CheckBox
    Friend WithEvents overwriteExistingFiles As CheckBox
    Friend WithEvents columnNumber As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents textDelimiter As TextBox
    Friend WithEvents deleteQuotes As CheckBox
    Friend WithEvents skipFirstLine As CheckBox
End Class
