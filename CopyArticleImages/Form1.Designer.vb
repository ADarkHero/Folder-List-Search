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
        Me.SuspendLayout()
        '
        'logBox
        '
        Me.logBox.Location = New System.Drawing.Point(296, 66)
        Me.logBox.Name = "logBox"
        Me.logBox.Size = New System.Drawing.Size(400, 333)
        Me.logBox.TabIndex = 0
        Me.logBox.Text = ""
        '
        'logBoxButton
        '
        Me.logBoxButton.Location = New System.Drawing.Point(296, 12)
        Me.logBoxButton.Name = "logBoxButton"
        Me.logBoxButton.Size = New System.Drawing.Size(400, 35)
        Me.logBoxButton.TabIndex = 1
        Me.logBoxButton.Text = "Error Log..."
        Me.logBoxButton.UseVisualStyleBackColor = True
        '
        'sourceFolder
        '
        Me.sourceFolder.Location = New System.Drawing.Point(12, 95)
        Me.sourceFolder.Name = "sourceFolder"
        Me.sourceFolder.Size = New System.Drawing.Size(233, 20)
        Me.sourceFolder.TabIndex = 2
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
        Me.fileList.TabIndex = 4
        '
        'sourceFolderButton
        '
        Me.sourceFolderButton.Location = New System.Drawing.Point(12, 66)
        Me.sourceFolderButton.Name = "sourceFolderButton"
        Me.sourceFolderButton.Size = New System.Drawing.Size(278, 23)
        Me.sourceFolderButton.TabIndex = 5
        Me.sourceFolderButton.Text = "Source Folder"
        Me.sourceFolderButton.UseVisualStyleBackColor = True
        '
        'destinationFolderButton
        '
        Me.destinationFolderButton.Location = New System.Drawing.Point(12, 130)
        Me.destinationFolderButton.Name = "destinationFolderButton"
        Me.destinationFolderButton.Size = New System.Drawing.Size(278, 23)
        Me.destinationFolderButton.TabIndex = 6
        Me.destinationFolderButton.Text = "Destination Folder"
        Me.destinationFolderButton.UseVisualStyleBackColor = True
        '
        'fileListButton
        '
        Me.fileListButton.Location = New System.Drawing.Point(12, 196)
        Me.fileListButton.Name = "fileListButton"
        Me.fileListButton.Size = New System.Drawing.Size(278, 23)
        Me.fileListButton.TabIndex = 7
        Me.fileListButton.Text = "File List"
        Me.fileListButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(14, 329)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(275, 100)
        Me.startButton.TabIndex = 8
        Me.startButton.Text = "START!"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'settingsButton
        '
        Me.settingsButton.Location = New System.Drawing.Point(12, 12)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(279, 35)
        Me.settingsButton.TabIndex = 9
        Me.settingsButton.Text = "Settings"
        Me.settingsButton.UseVisualStyleBackColor = True
        '
        'clearErrorLog
        '
        Me.clearErrorLog.Location = New System.Drawing.Point(296, 405)
        Me.clearErrorLog.Name = "clearErrorLog"
        Me.clearErrorLog.Size = New System.Drawing.Size(130, 23)
        Me.clearErrorLog.TabIndex = 10
        Me.clearErrorLog.Text = "Clear Error Log"
        Me.clearErrorLog.UseVisualStyleBackColor = True
        '
        'chooseSourceFolder
        '
        Me.chooseSourceFolder.Location = New System.Drawing.Point(251, 95)
        Me.chooseSourceFolder.Name = "chooseSourceFolder"
        Me.chooseSourceFolder.Size = New System.Drawing.Size(37, 20)
        Me.chooseSourceFolder.TabIndex = 11
        Me.chooseSourceFolder.Text = "..."
        Me.chooseSourceFolder.UseVisualStyleBackColor = True
        '
        'chooseDestinationFolder
        '
        Me.chooseDestinationFolder.Location = New System.Drawing.Point(251, 159)
        Me.chooseDestinationFolder.Name = "chooseDestinationFolder"
        Me.chooseDestinationFolder.Size = New System.Drawing.Size(37, 20)
        Me.chooseDestinationFolder.TabIndex = 12
        Me.chooseDestinationFolder.Text = "..."
        Me.chooseDestinationFolder.UseVisualStyleBackColor = True
        '
        'chooseFileList
        '
        Me.chooseFileList.Location = New System.Drawing.Point(251, 225)
        Me.chooseFileList.Name = "chooseFileList"
        Me.chooseFileList.Size = New System.Drawing.Size(37, 20)
        Me.chooseFileList.TabIndex = 13
        Me.chooseFileList.Text = "..."
        Me.chooseFileList.UseVisualStyleBackColor = True
        '
        'exportErrorLog
        '
        Me.exportErrorLog.Location = New System.Drawing.Point(432, 405)
        Me.exportErrorLog.Name = "exportErrorLog"
        Me.exportErrorLog.Size = New System.Drawing.Size(130, 23)
        Me.exportErrorLog.TabIndex = 14
        Me.exportErrorLog.Text = "Export Error Log"
        Me.exportErrorLog.UseVisualStyleBackColor = True
        '
        'reducesLogging
        '
        Me.reducesLogging.AutoSize = True
        Me.reducesLogging.Checked = True
        Me.reducesLogging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.reducesLogging.Location = New System.Drawing.Point(568, 409)
        Me.reducesLogging.Name = "reducesLogging"
        Me.reducesLogging.Size = New System.Drawing.Size(111, 17)
        Me.reducesLogging.TabIndex = 16
        Me.reducesLogging.Text = "Reduced Logging"
        Me.reducesLogging.UseVisualStyleBackColor = True
        '
        'onlyCheckForExist
        '
        Me.onlyCheckForExist.AutoSize = True
        Me.onlyCheckForExist.Location = New System.Drawing.Point(12, 276)
        Me.onlyCheckForExist.Name = "onlyCheckForExist"
        Me.onlyCheckForExist.Size = New System.Drawing.Size(242, 17)
        Me.onlyCheckForExist.TabIndex = 17
        Me.onlyCheckForExist.Text = "Only check if files exist (without copying them)"
        Me.onlyCheckForExist.UseVisualStyleBackColor = True
        '
        'overwriteExistingFiles
        '
        Me.overwriteExistingFiles.AutoSize = True
        Me.overwriteExistingFiles.Location = New System.Drawing.Point(12, 299)
        Me.overwriteExistingFiles.Name = "overwriteExistingFiles"
        Me.overwriteExistingFiles.Size = New System.Drawing.Size(130, 17)
        Me.overwriteExistingFiles.TabIndex = 18
        Me.overwriteExistingFiles.Text = "Overwrite existing files"
        Me.overwriteExistingFiles.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
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
End Class
