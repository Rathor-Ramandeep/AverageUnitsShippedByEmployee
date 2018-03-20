<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnitsByEmployeeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbEmployeeOneOutput = New System.Windows.Forms.TextBox()
        Me.tbUnitsIn = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.tbEmployeeTwoOutput = New System.Windows.Forms.TextBox()
        Me.tbEmployeeThreeOutput = New System.Windows.Forms.TextBox()
        Me.lbEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lbDayNumber = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbAllAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeOne = New System.Windows.Forms.Label()
        Me.lbEmployeeTwo = New System.Windows.Forms.Label()
        Me.lbEmployeeThree = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'tbEmployeeOneOutput
        '
        Me.tbEmployeeOneOutput.BackColor = System.Drawing.Color.White
        Me.tbEmployeeOneOutput.Enabled = false
        Me.tbEmployeeOneOutput.Location = New System.Drawing.Point(12, 97)
        Me.tbEmployeeOneOutput.Multiline = true
        Me.tbEmployeeOneOutput.Name = "tbEmployeeOneOutput"
        Me.tbEmployeeOneOutput.Size = New System.Drawing.Size(207, 236)
        Me.tbEmployeeOneOutput.TabIndex = 4
        Me.tbEmployeeOneOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbEmployeeOneOutput, "Units For Employee One")
        '
        'tbUnitsIn
        '
        Me.tbUnitsIn.Location = New System.Drawing.Point(71, 33)
        Me.tbUnitsIn.Name = "tbUnitsIn"
        Me.tbUnitsIn.Size = New System.Drawing.Size(68, 22)
        Me.tbUnitsIn.TabIndex = 2
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbUnitsIn, "Input Number of Units Sold for Each Day Here")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(462, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(207, 37)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Exits Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(237, 417)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(207, 32)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Resets Application to Initial State")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 417)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(207, 32)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Calculates Average of Units Shipped")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'tbEmployeeTwoOutput
        '
        Me.tbEmployeeTwoOutput.BackColor = System.Drawing.Color.White
        Me.tbEmployeeTwoOutput.Enabled = False
        Me.tbEmployeeTwoOutput.Location = New System.Drawing.Point(237, 97)
        Me.tbEmployeeTwoOutput.Multiline = True
        Me.tbEmployeeTwoOutput.Name = "tbEmployeeTwoOutput"
        Me.tbEmployeeTwoOutput.Size = New System.Drawing.Size(207, 236)
        Me.tbEmployeeTwoOutput.TabIndex = 7
        Me.tbEmployeeTwoOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbEmployeeTwoOutput, "Units For Employee Two")
        '
        'tbEmployeeThreeOutput
        '
        Me.tbEmployeeThreeOutput.BackColor = System.Drawing.Color.White
        Me.tbEmployeeThreeOutput.Enabled = False
        Me.tbEmployeeThreeOutput.Location = New System.Drawing.Point(462, 97)
        Me.tbEmployeeThreeOutput.Multiline = True
        Me.tbEmployeeThreeOutput.Name = "tbEmployeeThreeOutput"
        Me.tbEmployeeThreeOutput.Size = New System.Drawing.Size(207, 236)
        Me.tbEmployeeThreeOutput.TabIndex = 10
        Me.tbEmployeeThreeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbEmployeeThreeOutput, "Units For Employee Three")
        '
        'lbEmployeeOneAverage
        '
        Me.lbEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeOneAverage.Location = New System.Drawing.Point(12, 342)
        Me.lbEmployeeOneAverage.Name = "lbEmployeeOneAverage"
        Me.lbEmployeeOneAverage.Size = New System.Drawing.Size(207, 30)
        Me.lbEmployeeOneAverage.TabIndex = 5
        Me.lbEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbEmployeeOneAverage, "Average For Employee One")
        '
        'lbDayNumber
        '
        Me.lbDayNumber.Location = New System.Drawing.Point(13, 9)
        Me.lbDayNumber.Name = "lbDayNumber"
        Me.lbDayNumber.Size = New System.Drawing.Size(52, 23)
        Me.lbDayNumber.TabIndex = 0
        Me.lbDayNumber.Text = "&Day 1"
        Me.lbDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbDayNumber, "Displays Day Number")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(13, 32)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(52, 23)
        Me.lbUnits.TabIndex = 1
        Me.lbUnits.Text = "&Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbUnits, "Enter Units To The Right")
        '
        'lbAllAverage
        '
        Me.lbAllAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAllAverage.Location = New System.Drawing.Point(12, 382)
        Me.lbAllAverage.Name = "lbAllAverage"
        Me.lbAllAverage.Size = New System.Drawing.Size(657, 30)
        Me.lbAllAverage.TabIndex = 12
        Me.lbAllAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbAllAverage, "Average For All Employees ")
        '
        'lbEmployeeTwoAverage
        '
        Me.lbEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeTwoAverage.Location = New System.Drawing.Point(237, 342)
        Me.lbEmployeeTwoAverage.Name = "lbEmployeeTwoAverage"
        Me.lbEmployeeTwoAverage.Size = New System.Drawing.Size(207, 30)
        Me.lbEmployeeTwoAverage.TabIndex = 8
        Me.lbEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbEmployeeTwoAverage, "Average For Employee Two")
        '
        'lbEmployeeThreeAverage
        '
        Me.lbEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeThreeAverage.Location = New System.Drawing.Point(462, 342)
        Me.lbEmployeeThreeAverage.Name = "lbEmployeeThreeAverage"
        Me.lbEmployeeThreeAverage.Size = New System.Drawing.Size(207, 30)
        Me.lbEmployeeThreeAverage.TabIndex = 11
        Me.lbEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbEmployeeThreeAverage, "Average For Employee Three")
        '
        'lbEmployeeOne
        '
        Me.lbEmployeeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmployeeOne.Location = New System.Drawing.Point(13, 67)
        Me.lbEmployeeOne.Name = "lbEmployeeOne"
        Me.lbEmployeeOne.Size = New System.Drawing.Size(206, 27)
        Me.lbEmployeeOne.TabIndex = 3
        Me.lbEmployeeOne.Text = "Employee &1"
        Me.lbEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbEmployeeOne, "Employee One")
        '
        'lbEmployeeTwo
        '
        Me.lbEmployeeTwo.Location = New System.Drawing.Point(238, 67)
        Me.lbEmployeeTwo.Name = "lbEmployeeTwo"
        Me.lbEmployeeTwo.Size = New System.Drawing.Size(206, 27)
        Me.lbEmployeeTwo.TabIndex = 6
        Me.lbEmployeeTwo.Text = "Employee &2"
        Me.lbEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbEmployeeTwo, "Employee Two")
        '
        'lbEmployeeThree
        '
        Me.lbEmployeeThree.Location = New System.Drawing.Point(459, 67)
        Me.lbEmployeeThree.Name = "lbEmployeeThree"
        Me.lbEmployeeThree.Size = New System.Drawing.Size(206, 27)
        Me.lbEmployeeThree.TabIndex = 9
        Me.lbEmployeeThree.Text = "Employee &3"
        Me.lbEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbEmployeeThree, "Employee Three")
        '
        'UnitsByEmployeeForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(686, 459)
        Me.Controls.Add(Me.lbEmployeeThree)
        Me.Controls.Add(Me.lbEmployeeTwo)
        Me.Controls.Add(Me.lbEmployeeOne)
        Me.Controls.Add(Me.lbEmployeeThreeAverage)
        Me.Controls.Add(Me.tbEmployeeThreeOutput)
        Me.Controls.Add(Me.lbEmployeeTwoAverage)
        Me.Controls.Add(Me.tbEmployeeTwoOutput)
        Me.Controls.Add(Me.lbAllAverage)
        Me.Controls.Add(Me.lbEmployeeOneAverage)
        Me.Controls.Add(Me.tbEmployeeOneOutput)
        Me.Controls.Add(Me.lbDayNumber)
        Me.Controls.Add(Me.tbUnitsIn)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnitsByEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me, "Average Units Shipped For Employees")
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
    Friend WithEvents tbEmployeeOneOutput As TextBox
    Friend WithEvents tbUnitsIn As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lbEmployeeOneAverage As Label
    Friend WithEvents lbDayNumber As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents lbAllAverage As Label
    Friend WithEvents lbEmployeeTwoAverage As Label
    Friend WithEvents tbEmployeeTwoOutput As TextBox
    Friend WithEvents lbEmployeeThreeAverage As Label
    Friend WithEvents tbEmployeeThreeOutput As TextBox
    Friend WithEvents lbEmployeeOne As Label
    Friend WithEvents lbEmployeeTwo As Label
    Friend WithEvents lbEmployeeThree As Label
End Class
