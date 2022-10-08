Public Class Cashier
    Public queu As New ArrayList ''for queue list
    Dim nextQues As Integer = 5,
        maxQues As Integer = 0,
        addQues As Integer = 0


    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer.Show()
    End Sub

    Private Sub checkCounter(queues As Integer)



        If counterQueu1.Text = "TIN-000000" Then

            ''Cashier Form
            counterQueu1.Text = "TIN-" + queues.ToString().Remove(0, 1)
            counterQueu1.ForeColor = Color.Green

            ''Customer Form
            Customer.ClientCounterQueu1.Text = "TIN-" + queues.ToString().Remove(0, 1)
            Customer.ClientCounterQueu1.ForeColor = Color.Green

        ElseIf counterQueu2.Text = "TIN-000000" Then

            ''Cashier Form
            counterQueu2.Text = "TIN-" + queues.ToString().Remove(0, 1)
            counterQueu2.ForeColor = Color.Green

            ''Customer Form
            Customer.ClientCounterQueu2.Text = "TIN-" + queues.ToString().Remove(0, 1)
            Customer.ClientCounterQueu2.ForeColor = Color.Green

        ElseIf counterQueu3.Text = "TIN-000000" Then

            ''Cashier Form
            counterQueu3.Text = "TIN-" + queues.ToString().Remove(0, 1)
            counterQueu3.ForeColor = Color.Green

            ''Customer Form
            Customer.ClientCounterQueu3.Text = "TIN-" + queues.ToString().Remove(0, 1)
            Customer.ClientCounterQueu3.ForeColor = Color.Green

        ElseIf counterQueu4.Text = "TIN-000000" Then

            ''Cashier Form
            counterQueu4.Text = "TIN-" + queues.ToString().Remove(0, 1)
            counterQueu4.ForeColor = Color.Green

            ''Customer Form
            Customer.ClientCounterQueu4.Text = "TIN-" + queues.ToString().Remove(0, 1)
            Customer.ClientCounterQueu4.ForeColor = Color.Green
        Else

            ''Cashier Form
            counterQueu5.Text = "TIN-" + queues.ToString().Remove(0, 1)
            counterQueu5.ForeColor = Color.Green

            ''Customer Form
            Customer.ClientCounterQueu5.Text = "TIN-" + queues.ToString().Remove(0, 1)
            Customer.ClientCounterQueu5.ForeColor = Color.Green
        End If
    End Sub
    Private Sub addQueue_Click(sender As Object, e As EventArgs) Handles addQueue.Click
        maxQues += 1
        addQues += 1
        Dim queues As Integer = 1000000 + maxQues
        Dim result As DialogResult = MessageBox.Show("Would you really like to add the queue?",
                                                     "Water Billing System",
                                                     MessageBoxButtons.OKCancel,
                                                     MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            '' add to que
            Select Case addQues
                Case 1
                    checkCounter(queues)
                Case 2
                    checkCounter(queues)
                Case 3
                    checkCounter(queues)
                Case 4
                    checkCounter(queues)
                Case 5
                    checkCounter(queues)
                Case Else
                    queu.Add("TIN-" + queues.ToString().Remove(0, 1))
            End Select

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''Increment and decreement the number and max ques
        numberQueue.Text = maxQues
        maxQueue.Text = 50 - maxQues
        Customer.ClientNumberQueue.Text = maxQues

        ''disable add queue button
        If maxQueue.Text = 0 Then
            addQueue.Enabled = False
        Else
            addQueue.Enabled = True
        End If

        ''waiting list Cashier
        addingWaitingList(waitingList1, 0)
        addingWaitingList(waitingList2, 1)
        addingWaitingList(waitingList3, 2)
        addingWaitingList(waitingList4, 3)
        addingWaitingList(waitingList5, 4)
        addingWaitingList(waitingList6, 5)
        addingWaitingList(waitingList7, 6)
        addingWaitingList(waitingList8, 7)

        ''waiting list Customer
        addingWaitingList(Customer.ClientWaitingList1, 0)
        addingWaitingList(Customer.ClientWaitingList2, 1)
        addingWaitingList(Customer.ClientWaitingList3, 2)
        addingWaitingList(Customer.ClientWaitingList4, 3)
        addingWaitingList(Customer.ClientWaitingList5, 4)
        addingWaitingList(Customer.ClientWaitingList6, 5)
        addingWaitingList(Customer.ClientWaitingList7, 6)
        addingWaitingList(Customer.ClientWaitingList8, 7)

    End Sub

    Private Sub CounterOne_Click(sender As Object, e As EventArgs) Handles CounterOne.Click
        addingCounterList(counterQueu1, Customer.ClientCounterQueu1)
    End Sub

    Private Sub CounterTwo_Click(sender As Object, e As EventArgs) Handles CounterTwo.Click
        addingCounterList(counterQueu2, Customer.ClientCounterQueu2)
    End Sub

    Private Sub CounterThree_Click(sender As Object, e As EventArgs) Handles CounterThree.Click
        addingCounterList(counterQueu3, Customer.ClientCounterQueu3)
    End Sub

    Private Sub CounterFour_Click(sender As Object, e As EventArgs) Handles CounterFour.Click
        addingCounterList(counterQueu4, Customer.ClientCounterQueu4)
    End Sub

    Private Sub CounterFive_Click(sender As Object, e As EventArgs) Handles CounterFive.Click
        addingCounterList(counterQueu5, Customer.ClientCounterQueu5)
    End Sub

    Private Sub addingWaitingList(waitng As Label, number As Integer)
        ''adding a waiting List
        Try
            waitng.Text = queu.Item(number)
            waitng.ForeColor = Color.Red
        Catch ex As Exception
            waitng.Text = "TIN-000000"
            waitng.ForeColor = System.Drawing.Color.FromArgb(2, 46, 87)
        End Try
    End Sub
    Private Sub addingCounterList(counter As Label, counterClient As Label)

        Try
            ''Cashier Form
            counter.Text = queu.Item(0)
            counter.ForeColor = Color.Green

            ''Client Form
            counterClient.Text = queu.Item(0)
            counterClient.ForeColor = Color.Green

            queu.Remove(counter.Text)
        Catch ex As Exception

            ''Cashier form
            counter.Text = "TIN-000000"
            counter.ForeColor = System.Drawing.Color.FromArgb(2, 46, 87)

            counterClient.Text = "TIN-000000"
            MessageBox.Show("There is no waiting list",
            "Water Billing System",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        End Try
    End Sub
End Class