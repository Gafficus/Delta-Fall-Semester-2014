' Name:         Woods Project
' Purpose:      Calculates the gross pay for salaried and 
'               hourly employees and displays a report
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the gross pay and a report

        ' declare variables

        ' instantiate and initialize an Employee object

        ' determine the selected radio button


        ' display the gross pay and report

        txtNum.Focus()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged,
            lstRate.SelectedValueChanged, lstSalary.SelectedValueChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNum_Enter(sender As Object, e As EventArgs) Handles txtNum.Enter
        txtNum.SelectAll()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub radHourly_CheckedChanged(sender As Object, e As EventArgs) Handles radHourly.CheckedChanged
        ' displays the labels and list boxes used 
        ' to enter the number of hours worked and
        ' the rate of pay; hides the label and
        ' list box used to enter the salary

        lblGross.Text = String.Empty
        lblHoursId.Visible = True
        lstHours.Visible = True
        lblRateId.Visible = True
        lstRate.Visible = True
        lblSalaryId.Visible = False
        lstSalary.Visible = False
    End Sub

    Private Sub radSalaried_CheckedChanged(sender As Object, e As EventArgs) Handles radSalaried.CheckedChanged
        ' displays the label and list box used to 
        ' enter the salary; hides the labels and  
        ' list boxes used to enter the number of 
        ' hours worked and the rate of pay; 

        lblGross.Text = String.Empty
        lblSalaryId.Visible = True
        lstSalary.Visible = True
        lblHoursId.Visible = False
        lstHours.Visible = False
        lblRateId.Visible = False
        lstRate.Visible = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with values and then
        ' selects a default item in each list box

        For dblSalary As Double = 15000 To 35000 Step 1000
            lstSalary.Items.Add(dblSalary.ToString)
        Next dblSalary

        For dblHour As Double = 0.5 To 40 Step 0.5
            lstHours.Items.Add(dblHour.ToString("N1"))
        Next dblHour

        For dblRate As Double = 7 To 14 Step 0.5
            lstRate.Items.Add(dblRate.ToString("N2"))
        Next dblRate

        lstSalary.SelectedItem = "20000"
        lstHours.SelectedItem = "40.0"
        lstRate.SelectedItem = "10.00"
    End Sub
End Class
