'Jaden Torres'
'Assignment A7'
'GUI Development'
'Sources: https://www.youtube.com/watch?v=vYvI0Os8Rig&ab_channel=ProgrammingKnowledge , https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/arrays/ , and https://www.tutorialspoint.com/vb.net/vb.net_combobox.htm '
'Issues: None'



Public Class Form1

    Dim months = New Decimal() {38.17, 41.55, 27.02, 25.91, 3.28, 18.08, 45.66, 16.17, 3.98, 17.11, 25.78, 51.03} 'array of month prices'
    Dim wombocombo As String 'input variable from the comboBox'
    Dim month As Decimal 'month chosen by itself'

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.ResetText() 'reset box 1'
        GroupBox2.ResetText() 'reset box 2'
        GroupBox3.ResetText() 'reset box 3'

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wombocombo = ComboBox1.Text 'setting the active text to wombocombo for processing'
        combocheck() 'running computing class'
    End Sub

    Private Sub combocheck()
        month = 0 'resetting month number'
        If wombocombo = "January" Then 'each if statements accounts for each month'
            month = months(0) 'using the months array to call the individual bit'
        Else
            If wombocombo = "February" Then
                month = months(1)
            Else
                If wombocombo = "March" Then
                    month = months(2)
                Else
                    If wombocombo = "April" Then
                        month = months(3)
                    Else
                        If wombocombo = "May" Then
                            month = months(4)
                        Else
                            If wombocombo = "June" Then
                                month = months(5)
                            Else
                                If wombocombo = "July" Then
                                    month = months(6)
                                Else
                                    If wombocombo = "August" Then
                                        month = months(7)
                                    Else
                                        If wombocombo = "September" Then
                                            month = months(8)
                                        Else
                                            If wombocombo = "October" Then
                                                month = months(9)
                                            Else
                                                If wombocombo = "November" Then
                                                    month = months(10)
                                                Else
                                                    If wombocombo = "December" Then
                                                        month = months(11)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        StatOutput() 'Class that formats the output window'
    End Sub

    Private Sub StatOutput() 'Formats the Answer into sentences'
        GroupBox1.Text = "The electric savings for " + wombocombo.ToString() + " is $" + month.ToString()
        GroupBox2.Text = "The average monthly savings: $26.15"
        GroupBox3.Text = "December had the most significant monthly savings"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
