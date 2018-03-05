<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbEmployeeOne = New System.Windows.Forms.Label()
        Me.lbEmployeeTwo = New System.Windows.Forms.Label()
        Me.lbEmployeeThree = New System.Windows.Forms.Label()
        Me.tbDisplayOne = New System.Windows.Forms.TextBox()
        Me.tbDisplayTwo = New System.Windows.Forms.TextBox()
        Me.tbDisplayThree = New System.Windows.Forms.TextBox()
        Me.lbAverageDisplay = New System.Windows.Forms.Label()
        Me.lbAverageOne = New System.Windows.Forms.Label()
        Me.lbAverageTwo = New System.Windows.Forms.Label()
        Me.lbAverageThree = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbDay
        '
        Me.lbDay.Location = New System.Drawing.Point(12, 25)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(39, 13)
        Me.lbDay.TabIndex = 0
        Me.lbDay.Text = "Day 1"
        Me.ToolTip1.SetToolTip(Me.lbDay, "Displays the current day")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(12, 57)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(39, 13)
        Me.lbUnits.TabIndex = 1
        Me.lbUnits.Text = "Units:"
        Me.ToolTip1.SetToolTip(Me.lbUnits, "Label that shows where to input units")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(52, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 20)
        Me.TextBox1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Texbox where you input the units for the day")
        '
        'lbEmployeeOne
        '
        Me.lbEmployeeOne.Location = New System.Drawing.Point(45, 94)
        Me.lbEmployeeOne.Name = "lbEmployeeOne"
        Me.lbEmployeeOne.Size = New System.Drawing.Size(64, 13)
        Me.lbEmployeeOne.TabIndex = 3
        Me.lbEmployeeOne.Text = "Employee 1"
        Me.lbEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbEmployeeOne, "Label that shows where employee ones units are stored")
        '
        'lbEmployeeTwo
        '
        Me.lbEmployeeTwo.Location = New System.Drawing.Point(177, 94)
        Me.lbEmployeeTwo.Name = "lbEmployeeTwo"
        Me.lbEmployeeTwo.Size = New System.Drawing.Size(65, 13)
        Me.lbEmployeeTwo.TabIndex = 6
        Me.lbEmployeeTwo.Text = "Employee 2"
        Me.lbEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbEmployeeTwo, "Label that shows where employee two's units are stored")
        '
        'lbEmployeeThree
        '
        Me.lbEmployeeThree.Location = New System.Drawing.Point(308, 94)
        Me.lbEmployeeThree.Name = "lbEmployeeThree"
        Me.lbEmployeeThree.Size = New System.Drawing.Size(63, 13)
        Me.lbEmployeeThree.TabIndex = 9
        Me.lbEmployeeThree.Text = "Employee 3"
        Me.lbEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbEmployeeThree, "Label that shows where employee three's units are stored")
        '
        'tbDisplayOne
        '
        Me.tbDisplayOne.Location = New System.Drawing.Point(26, 110)
        Me.tbDisplayOne.Multiline = True
        Me.tbDisplayOne.Name = "tbDisplayOne"
        Me.tbDisplayOne.Size = New System.Drawing.Size(100, 127)
        Me.tbDisplayOne.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.tbDisplayOne, "Displays the units  for employee 1")
        '
        'tbDisplayTwo
        '
        Me.tbDisplayTwo.Location = New System.Drawing.Point(156, 110)
        Me.tbDisplayTwo.Multiline = True
        Me.tbDisplayTwo.Name = "tbDisplayTwo"
        Me.tbDisplayTwo.Size = New System.Drawing.Size(100, 127)
        Me.tbDisplayTwo.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbDisplayTwo, "Displays the units  for employee 2")
        '
        'tbDisplayThree
        '
        Me.tbDisplayThree.Location = New System.Drawing.Point(284, 110)
        Me.tbDisplayThree.Multiline = True
        Me.tbDisplayThree.Name = "tbDisplayThree"
        Me.tbDisplayThree.Size = New System.Drawing.Size(100, 127)
        Me.tbDisplayThree.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.tbDisplayThree, "Displays the units  for employee 3")
        '
        'lbAverageDisplay
        '
        Me.lbAverageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageDisplay.Location = New System.Drawing.Point(26, 270)
        Me.lbAverageDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAverageDisplay.Name = "lbAverageDisplay"
        Me.lbAverageDisplay.Size = New System.Drawing.Size(358, 19)
        Me.lbAverageDisplay.TabIndex = 12
        Me.lbAverageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbAverageDisplay, "Displays average between all the units per day")
        '
        'lbAverageOne
        '
        Me.lbAverageOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageOne.Location = New System.Drawing.Point(26, 240)
        Me.lbAverageOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAverageOne.Name = "lbAverageOne"
        Me.lbAverageOne.Size = New System.Drawing.Size(100, 19)
        Me.lbAverageOne.TabIndex = 5
        Me.lbAverageOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbAverageOne, "Displays average for employee 1")
        '
        'lbAverageTwo
        '
        Me.lbAverageTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageTwo.Location = New System.Drawing.Point(156, 240)
        Me.lbAverageTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAverageTwo.Name = "lbAverageTwo"
        Me.lbAverageTwo.Size = New System.Drawing.Size(100, 19)
        Me.lbAverageTwo.TabIndex = 8
        Me.lbAverageTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbAverageTwo, "Displays average for employee 2")
        '
        'lbAverageThree
        '
        Me.lbAverageThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageThree.Location = New System.Drawing.Point(284, 240)
        Me.lbAverageThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAverageThree.Name = "lbAverageThree"
        Me.lbAverageThree.Size = New System.Drawing.Size(100, 19)
        Me.lbAverageThree.TabIndex = 11
        Me.lbAverageThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbAverageThree, "Displays average for employee 3")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(26, 292)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Click to input units")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(156, 292)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click to clear the screen")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 292)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(414, 336)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbAverageThree)
        Me.Controls.Add(Me.lbAverageTwo)
        Me.Controls.Add(Me.lbAverageOne)
        Me.Controls.Add(Me.lbAverageDisplay)
        Me.Controls.Add(Me.tbDisplayThree)
        Me.Controls.Add(Me.tbDisplayTwo)
        Me.Controls.Add(Me.tbDisplayOne)
        Me.Controls.Add(Me.lbEmployeeThree)
        Me.Controls.Add(Me.lbEmployeeTwo)
        Me.Controls.Add(Me.lbEmployeeOne)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ToolTip1.SetToolTip(Me, "9")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDay As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbEmployeeOne As Label
    Friend WithEvents lbEmployeeTwo As Label
    Friend WithEvents lbEmployeeThree As Label
    Friend WithEvents tbDisplayOne As TextBox
    Friend WithEvents tbDisplayTwo As TextBox
    Friend WithEvents tbDisplayThree As TextBox
    Friend WithEvents lbAverageDisplay As Label
    Friend WithEvents lbAverageOne As Label
    Friend WithEvents lbAverageTwo As Label
    Friend WithEvents lbAverageThree As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
