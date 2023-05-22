<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Search = New System.Windows.Forms.Button()
        Me.SelectedPath = New System.Windows.Forms.TextBox()
        Me.analyzeButton = New System.Windows.Forms.Button()
        Me.timeRangeEnabled = New System.Windows.Forms.CheckBox()
        Me.fromLabel = New System.Windows.Forms.Label()
        Me.toLabel = New System.Windows.Forms.Label()
        Me.fromTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.toTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "C:\"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.ShowReadOnly = True
        Me.OpenFileDialog1.Title = "Pick source files"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(93, 94)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(64, 20)
        Me.Search.TabIndex = 0
        Me.Search.Text = "Select files"
        Me.Search.UseVisualStyleBackColor = True
        '
        'SelectedPath
        '
        Me.SelectedPath.Location = New System.Drawing.Point(162, 94)
        Me.SelectedPath.Name = "SelectedPath"
        Me.SelectedPath.Size = New System.Drawing.Size(308, 20)
        Me.SelectedPath.TabIndex = 1
        '
        'analyzeButton
        '
        Me.analyzeButton.BackColor = System.Drawing.SystemColors.Control
        Me.analyzeButton.Enabled = False
        Me.analyzeButton.Location = New System.Drawing.Point(501, 94)
        Me.analyzeButton.Name = "analyzeButton"
        Me.analyzeButton.Size = New System.Drawing.Size(64, 20)
        Me.analyzeButton.TabIndex = 2
        Me.analyzeButton.Text = "Analyze"
        Me.analyzeButton.UseVisualStyleBackColor = False
        '
        'timeRangeEnabled
        '
        Me.timeRangeEnabled.AutoSize = True
        Me.timeRangeEnabled.Location = New System.Drawing.Point(93, 151)
        Me.timeRangeEnabled.Name = "timeRangeEnabled"
        Me.timeRangeEnabled.Size = New System.Drawing.Size(108, 17)
        Me.timeRangeEnabled.TabIndex = 3
        Me.timeRangeEnabled.Text = "Select time range"
        Me.timeRangeEnabled.UseVisualStyleBackColor = True
        '
        'fromLabel
        '
        Me.fromLabel.AutoSize = True
        Me.fromLabel.Location = New System.Drawing.Point(93, 179)
        Me.fromLabel.Name = "fromLabel"
        Me.fromLabel.Size = New System.Drawing.Size(30, 13)
        Me.fromLabel.TabIndex = 4
        Me.fromLabel.Text = "From"
        '
        'toLabel
        '
        Me.toLabel.AutoSize = True
        Me.toLabel.Location = New System.Drawing.Point(219, 179)
        Me.toLabel.Name = "toLabel"
        Me.toLabel.Size = New System.Drawing.Size(20, 13)
        Me.toLabel.TabIndex = 5
        Me.toLabel.Text = "To"
        '
        'fromTimePicker
        '
        Me.fromTimePicker.CustomFormat = "HH:MM"
        Me.fromTimePicker.Enabled = False
        Me.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.fromTimePicker.Location = New System.Drawing.Point(93, 194)
        Me.fromTimePicker.Name = "fromTimePicker"
        Me.fromTimePicker.ShowUpDown = True
        Me.fromTimePicker.Size = New System.Drawing.Size(65, 20)
        Me.fromTimePicker.TabIndex = 6
        '
        'toTimePicker
        '
        Me.toTimePicker.AllowDrop = True
        Me.toTimePicker.CustomFormat = "HH:MM"
        Me.toTimePicker.Enabled = False
        Me.toTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.toTimePicker.Location = New System.Drawing.Point(219, 194)
        Me.toTimePicker.Name = "toTimePicker"
        Me.toTimePicker.ShowUpDown = True
        Me.toTimePicker.Size = New System.Drawing.Size(65, 20)
        Me.toTimePicker.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(296, 295)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 295)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hour"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toTimePicker)
        Me.Controls.Add(Me.fromTimePicker)
        Me.Controls.Add(Me.toLabel)
        Me.Controls.Add(Me.fromLabel)
        Me.Controls.Add(Me.timeRangeEnabled)
        Me.Controls.Add(Me.analyzeButton)
        Me.Controls.Add(Me.SelectedPath)
        Me.Controls.Add(Me.Search)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Search As Button
    Friend WithEvents SelectedPath As TextBox
    Friend WithEvents analyzeButton As Button
    Friend WithEvents timeRangeEnabled As CheckBox
    Friend WithEvents fromLabel As Label
    Friend WithEvents toLabel As Label
    Friend WithEvents fromTimePicker As DateTimePicker
    Friend WithEvents toTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
