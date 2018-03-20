Option Strict On

''' <summary>
''' Author:         Ramandeep Rathor
''' Project Name:   UnitsByEmployee
''' Date:           01-Mar-2018
''' Description:    Calulcates average for number of units shipped
'''                 over the course of seven days for three employees.
'''                 Displays average for each employee and average for all three.
''' </summary>

Public Class UnitsByEmployeeForm
    Private rowCounter As Integer = 0 'Declares private global variable counter as integer starting at 0 for days_array's rows
    Private columnCounter As Integer = 0 'Declares private global variable counter as integer starting at 0 for days_array's columns
    Private Const MaximumEmployees = 3 'Declares a constant for the maximum amount of employees 
    Private Const MaximumDays = 7 'Declares a constand for the minimum amount of employees
    Private days_array(MaximumEmployees - 1, MaximumDays - 1) As Integer 'Declares private global 2D array days_array of type integer with 3 columns and 7 rows
    Private runningTotal As Double = 0.0 'Declares private new double runningTotal
    Private employeeCounter As Integer = 0 'Declares private new integer employeeCounter

    ''' <summary>
    ''' Changes style for font between bold or regular
    ''' </summary>
    ''' <param name="labelControl"></param>
    ''' <param name="bold"></param>
    Private Sub BoldFont(labelControl As Label, bold As Boolean)
        If bold = True Then 'If bold is true
            labelControl.Font = New Font(labelControl.Font, FontStyle.Bold) 'set font to bold
        Else 'if bold is false
            labelControl.Font = New Font(labelControl.Font, FontStyle.Regular) 'set font back to regular
        End If
    End Sub

    ''' <summary>
    ''' Closes and exits application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Closes and exits application
    End Sub

    ''' <summary>
    ''' Resets form to initial state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets textboxs to default value
        tbUnitsIn.ResetText()
        tbEmployeeOneOutput.ResetText()
        tbEmployeeTwoOutput.ResetText()
        tbEmployeeThreeOutput.ResetText()
        tbUnitsIn.ResetText()

        tbUnitsIn.Focus() 'sets focus to units in textbox
        tbUnitsIn.Select() 'Selects textbox units in

        'Resets labels to default value
        lbEmployeeOneAverage.ResetText()
        lbEmployeeTwoAverage.ResetText()
        lbEmployeeThreeAverage.ResetText()
        lbAllAverage.ResetText()
        lbDayNumber.Text = "Day 1"

        'Makes lbEmployeeOne bold and other two regular
        BoldFont(lbEmployeeOne, True)
        BoldFont(lbEmployeeTwo, False)
        BoldFont(lbEmployeeThree, False)

        runningTotal = 0.0 'Resets running total
        rowCounter = 0 'Resets row counter

        CounterReset(rowCounter, columnCounter) 'executes subroute CounterReset to reset rowCounter and columnCounter back to 0

        Array.Clear(days_array, MaximumEmployees - 1, MaximumDays - 1) 'Clears array

        tbUnitsIn.Enabled = True 'enables units in textbox
        btnEnter.Enabled = True 'enables enter button
    End Sub

    ''' <summary>
    ''' Calculates average whenever button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim input As Integer = 0 'Declares new integer input and initializes to 0
        ' Dim counter As Integer
        'Input
        If Integer.TryParse(tbUnitsIn.Text, input) Then 'If input is a valid integer
            If (0 <= input And input <= 1000) Then 'If input is above 0

                'Starts checking from most specific (employee 3) to least specific (employee 1)

                If (employeeCounter = 2) Then 'If employee 3
                    BoldFont(lbEmployeeThree, True) 'Make text for employee 3 bold
                    If (columnCounter < MaximumDays) Then 'if column counter is less than 7
                        days_array(rowCounter, columnCounter) = input 'Add input to days_array at position counter
                        tbEmployeeThreeOutput.Text += days_array(rowCounter, columnCounter).ToString() & vbCrLf 'append input to textbook and carriage return line feed
                        runningTotal += input 'append input to running total
                        columnCounter += 1 'Increment counter 

                        If (columnCounter = 7) Then 'if column counter is equal to 7
                            CalculateEmployeeThree(runningTotal) 'execute subroutine CalculateEmployeeThree with the parameters runningTotal
                            CounterReset(rowCounter, columnCounter) 'executes subroute CounterReset to reset rowCounter and columnCounter back to 0
                            CalculateAll(days_array) 'execute subroutine to calculate average for all employees
                            Exit Sub 'exits subroutine btnEnter_Click to suspend any further processing
                        End If
                        lbDayNumber.Text = "Day " & (columnCounter + 1).ToString() 'Increment lbDayNumber by 1 (to the next day of the week)
                    End If
                End If


                If (employeeCounter = 1) Then 'If employee 2
                    BoldFont(lbEmployeeTwo, True) 'Make text for employee 2 bold
                    If (columnCounter < MaximumDays) Then 'if column counter is less than 7
                        days_array(rowCounter, columnCounter) = input 'Add input to days_array at position counter
                        tbEmployeeTwoOutput.Text += days_array(rowCounter, columnCounter).ToString() & vbCrLf 'append input to textbook and carriage return line feed
                        runningTotal += input 'append input to running total
                        columnCounter += 1 'Increment counter 

                        If (columnCounter = 7) Then 'if column counter is equal to 7
                            CalculateEmployeeTwo(runningTotal) 'execute subroutine CalculateEmployeeTwo with the parameters runningTotal
                            columnCounter = 0 'Set columnCounter to 0
                            employeeCounter += 1 'increment EmployeeCounter by 1
                        End If
                        lbDayNumber.Text = "Day " & (columnCounter + 1).ToString() 'Increment lbDayNumber by 1 (to the next day of the week)
                    End If
                End If


                If (employeeCounter = 0) Then 'If employee 3
                    BoldFont(lbEmployeeOne, True) 'Make text for employee 3 bold
                    If (columnCounter < MaximumDays) Then
                        days_array(rowCounter, columnCounter) = input 'Add input to days_array at position counter
                        tbEmployeeOneOutput.Text += days_array(rowCounter, columnCounter).ToString() & vbCrLf 'append input to textbook and carriage return line feed
                        runningTotal += input  'append input to running total
                        columnCounter += 1 'Increment column counter

                        If (columnCounter = 7) Then 'if column counter is equal to 7
                            CalculateEmployeeOne(runningTotal) 'execute subroutine CalculateEmployeeThree with the parameters runningTotal
                            columnCounter = 0 'Set columnCounter to 0
                            employeeCounter += 1 'increment EmployeeCounter by 1
                        End If
                        lbDayNumber.Text = "Day " & (columnCounter + 1).ToString() 'Increment lbDayNumber by 1 (to the next day of the week)
                    End If
                End If

            Else 'Else if input is a negetive number
                MessageBox.Show("ERROR: Input must be between 0 and 1000 inclusive!") 'Throw error if input is out of range
            End If 'End if

        Else 'Else if input is not a valid number
            MessageBox.Show("ERROR: Input must be a whole number!") 'Throw error if input is not a whole number
        End If 'End if

        tbUnitsIn.ResetText() 'Resets text in tbUnitsIn for next input
    End Sub

    ''' <summary>
    ''' Calculates average for Employee One
    ''' </summary>
    ''' <param name="runningTotal"></param>
    Private Sub CalculateEmployeeOne(ByRef runningTotal As Double)
        Dim average As Double = 0.0 'Declares new string average and initializes with a blank string

        average = runningTotal / MaximumDays 'Calculates average by dividing runningTotal by maximumDays (7)
        lbEmployeeOneAverage.Text = "Average : " & average.ToString("n2") 'prints output to lbEmployeeOneAverage rounded to 2 decimal places
        BoldFont(lbEmployeeOne, False) 'resets text for employee one to regular
        BoldFont(lbEmployeeTwo, True) 'sets text for employee two to bold
        runningTotal = 0.0 'set running total to 0
    End Sub

    ''' <summary>
    ''' Calculates average for Employee Two
    ''' </summary>
    ''' <param name="runningTotal"></param>
    Private Sub CalculateEmployeeTwo(ByRef runningTotal As Double)
        Dim average As Double = 0.0 'Declares new string average and initializes with a blank string

        average = runningTotal / MaximumDays 'Calculates average by dividing runningTotal by maximumDays (7)
        lbEmployeeTwoAverage.Text = "Average : " & average.ToString("n2") 'prints output to lbEmployeeTwoAverage rounded to 2 decimal places
        BoldFont(lbEmployeeTwo, False) 'resets text for employee two to regular
        BoldFont(lbEmployeeThree, True) 'sets text for employee three to bold
        runningTotal = 0.0 'set running total to 0
    End Sub

    ''' <summary>
    ''' Calculates average for Employee Three
    ''' </summary>
    ''' <param name="runningTotal"></param>
    Private Sub CalculateEmployeeThree(ByRef runningTotal As Double)
        Dim average As Double = 0.0 'Declares new string average and initializes with a blank string

        average = runningTotal / MaximumDays 'Calculates average by dividing runningTotal by maximumDays (7)
        lbEmployeeThreeAverage.Text = "Average : " & average.ToString("n2") 'prints output to lbEmployeeThreeAverage rounded to 2 decimal places
        BoldFont(lbEmployeeThree, False) 'resets text for employee three to regular
        runningTotal = 0.0 'set runningTotal to 0
    End Sub

    ''' <summary>
    ''' Calculates average for all employees
    ''' </summary>
    ''' <param name="days_array"></param>
    Private Sub CalculateAll(days_array(,) As Integer)
        Dim average As Double = 0.0 'Declares new string average and initializes with a blank string
        runningTotal = 0 'set runningTotal to 0

        'Nested for loops will iterate through the 2D array by row and column
        For rowIterator As Integer = rowCounter To days_array.GetLength(0) - 1
            For columnIterator As Integer = columnCounter To days_array.GetLength(1) - 1
                runningTotal += days_array(rowIterator, columnIterator) 'append value at indicated spot of days_array to runningTotal
            Next
        Next
        average = runningTotal / MaximumDays 'Calculates average by dividing runningTotal by maximumDays (7)
        lbAllAverage.Text = "Average per day: " & average.ToString("n2") 'prints output to lbAllAverage rounded to 2 decimal places
        tbUnitsIn.Enabled = False 'disables input textbox
        btnEnter.Enabled = False 'disables enter button
        lbDayNumber.Text = "Done" 'sets Day Number label to "Done"
    End Sub

    ''' <summary>
    '''  Resets row counter and array counter to 0
    ''' </summary>
    ''' <param name="rowCounter"></param>
    ''' <param name="columnCounter"></param>
    Private Sub CounterReset(ByRef rowCounter As Integer, ByRef columnCounter As Integer)
        columnCounter = 0 'Resets column counter
        employeeCounter = 0 'Resets employee counter
    End Sub
End Class