<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.maxQueue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numberQueue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addQueue = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.waitingList8 = New System.Windows.Forms.Label()
        Me.waitingList7 = New System.Windows.Forms.Label()
        Me.waitingList6 = New System.Windows.Forms.Label()
        Me.waitingList5 = New System.Windows.Forms.Label()
        Me.waitingList4 = New System.Windows.Forms.Label()
        Me.waitingList3 = New System.Windows.Forms.Label()
        Me.waitingList2 = New System.Windows.Forms.Label()
        Me.waitingList1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.counterQueu5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CounterFive = New System.Windows.Forms.Button()
        Me.CounterFour = New System.Windows.Forms.Button()
        Me.CounterThree = New System.Windows.Forms.Button()
        Me.CounterTwo = New System.Windows.Forms.Button()
        Me.CounterOne = New System.Windows.Forms.Button()
        Me.counterQueu4 = New System.Windows.Forms.Label()
        Me.counterQueu3 = New System.Windows.Forms.Label()
        Me.counterQueu2 = New System.Windows.Forms.Label()
        Me.counterQueu1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.priorityList8 = New System.Windows.Forms.Label()
        Me.priorityList7 = New System.Windows.Forms.Label()
        Me.priorityList6 = New System.Windows.Forms.Label()
        Me.priorityList5 = New System.Windows.Forms.Label()
        Me.priorityList4 = New System.Windows.Forms.Label()
        Me.priorityList3 = New System.Windows.Forms.Label()
        Me.priorityList2 = New System.Windows.Forms.Label()
        Me.priorityList1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.priorityLabel = New System.Windows.Forms.Label()
        Me.priorityButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 79)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(348, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Simple Queueing System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.addQueue)
        Me.Panel2.Location = New System.Drawing.Point(-4, 518)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(943, 67)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel3.Controls.Add(Me.maxQueue)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.numberQueue)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(134, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(539, 40)
        Me.Panel3.TabIndex = 4
        '
        'maxQueue
        '
        Me.maxQueue.AutoSize = True
        Me.maxQueue.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.maxQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.maxQueue.Location = New System.Drawing.Point(472, 9)
        Me.maxQueue.Name = "maxQueue"
        Me.maxQueue.Size = New System.Drawing.Size(28, 21)
        Me.maxQueue.TabIndex = 6
        Me.maxQueue.Text = "50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(248, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Maximum Number of Queue:"
        '
        'numberQueue
        '
        Me.numberQueue.AutoSize = True
        Me.numberQueue.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.numberQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.numberQueue.Location = New System.Drawing.Point(215, 9)
        Me.numberQueue.Name = "numberQueue"
        Me.numberQueue.Size = New System.Drawing.Size(19, 21)
        Me.numberQueue.TabIndex = 4
        Me.numberQueue.Text = "0"
        Me.numberQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Number in Queue:"
        '
        'addQueue
        '
        Me.addQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.addQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addQueue.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.addQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.addQueue.Location = New System.Drawing.Point(679, 16)
        Me.addQueue.Name = "addQueue"
        Me.addQueue.Size = New System.Drawing.Size(104, 30)
        Me.addQueue.TabIndex = 4
        Me.addQueue.Text = "Add Queue"
        Me.addQueue.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(76, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COUNTER 1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.waitingList8)
        Me.GroupBox1.Controls.Add(Me.waitingList7)
        Me.GroupBox1.Controls.Add(Me.waitingList6)
        Me.GroupBox1.Controls.Add(Me.waitingList5)
        Me.GroupBox1.Controls.Add(Me.waitingList4)
        Me.GroupBox1.Controls.Add(Me.waitingList3)
        Me.GroupBox1.Controls.Add(Me.waitingList2)
        Me.GroupBox1.Controls.Add(Me.waitingList1)
        Me.GroupBox1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 460)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(903, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Waiting List"
        '
        'waitingList8
        '
        Me.waitingList8.AutoSize = True
        Me.waitingList8.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList8.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList8.Location = New System.Drawing.Point(765, 21)
        Me.waitingList8.Name = "waitingList8"
        Me.waitingList8.Size = New System.Drawing.Size(96, 21)
        Me.waitingList8.TabIndex = 19
        Me.waitingList8.Text = "TIN-000000"
        '
        'waitingList7
        '
        Me.waitingList7.AutoSize = True
        Me.waitingList7.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList7.Location = New System.Drawing.Point(663, 21)
        Me.waitingList7.Name = "waitingList7"
        Me.waitingList7.Size = New System.Drawing.Size(96, 21)
        Me.waitingList7.TabIndex = 18
        Me.waitingList7.Text = "TIN-000000"
        '
        'waitingList6
        '
        Me.waitingList6.AutoSize = True
        Me.waitingList6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList6.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList6.Location = New System.Drawing.Point(561, 21)
        Me.waitingList6.Name = "waitingList6"
        Me.waitingList6.Size = New System.Drawing.Size(96, 21)
        Me.waitingList6.TabIndex = 17
        Me.waitingList6.Text = "TIN-000000"
        '
        'waitingList5
        '
        Me.waitingList5.AutoSize = True
        Me.waitingList5.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList5.Location = New System.Drawing.Point(459, 21)
        Me.waitingList5.Name = "waitingList5"
        Me.waitingList5.Size = New System.Drawing.Size(96, 21)
        Me.waitingList5.TabIndex = 16
        Me.waitingList5.Text = "TIN-000000"
        '
        'waitingList4
        '
        Me.waitingList4.AutoSize = True
        Me.waitingList4.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList4.Location = New System.Drawing.Point(357, 21)
        Me.waitingList4.Name = "waitingList4"
        Me.waitingList4.Size = New System.Drawing.Size(96, 21)
        Me.waitingList4.TabIndex = 15
        Me.waitingList4.Text = "TIN-000000"
        '
        'waitingList3
        '
        Me.waitingList3.AutoSize = True
        Me.waitingList3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList3.Location = New System.Drawing.Point(255, 21)
        Me.waitingList3.Name = "waitingList3"
        Me.waitingList3.Size = New System.Drawing.Size(96, 21)
        Me.waitingList3.TabIndex = 14
        Me.waitingList3.Text = "TIN-000000"
        '
        'waitingList2
        '
        Me.waitingList2.AutoSize = True
        Me.waitingList2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList2.Location = New System.Drawing.Point(153, 21)
        Me.waitingList2.Name = "waitingList2"
        Me.waitingList2.Size = New System.Drawing.Size(96, 21)
        Me.waitingList2.TabIndex = 13
        Me.waitingList2.Text = "TIN-000000"
        '
        'waitingList1
        '
        Me.waitingList1.AutoSize = True
        Me.waitingList1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.waitingList1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.waitingList1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.waitingList1.Location = New System.Drawing.Point(51, 21)
        Me.waitingList1.Name = "waitingList1"
        Me.waitingList1.Size = New System.Drawing.Size(96, 21)
        Me.waitingList1.TabIndex = 13
        Me.waitingList1.Text = "TIN-000000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(43, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(830, 56)
        Me.Panel4.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(603, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 30)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Controls"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(303, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 30)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Ticket Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(64, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 30)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Counter Number"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel5.Controls.Add(Me.counterQueu5)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.counterQueu4)
        Me.Panel5.Controls.Add(Me.counterQueu3)
        Me.Panel5.Controls.Add(Me.counterQueu2)
        Me.Panel5.Controls.Add(Me.priorityLabel)
        Me.Panel5.Controls.Add(Me.counterQueu1)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(67, 147)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(779, 242)
        Me.Panel5.TabIndex = 6
        '
        'counterQueu5
        '
        Me.counterQueu5.AutoSize = True
        Me.counterQueu5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.counterQueu5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.counterQueu5.Location = New System.Drawing.Point(298, 203)
        Me.counterQueu5.Name = "counterQueu5"
        Me.counterQueu5.Size = New System.Drawing.Size(117, 25)
        Me.counterQueu5.TabIndex = 12
        Me.counterQueu5.Text = "TIN-000000"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel6.Controls.Add(Me.CounterFive)
        Me.Panel6.Controls.Add(Me.CounterFour)
        Me.Panel6.Controls.Add(Me.CounterThree)
        Me.Panel6.Controls.Add(Me.CounterTwo)
        Me.Panel6.Controls.Add(Me.priorityButton)
        Me.Panel6.Controls.Add(Me.CounterOne)
        Me.Panel6.Location = New System.Drawing.Point(497, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(281, 238)
        Me.Panel6.TabIndex = 13
        '
        'CounterFive
        '
        Me.CounterFive.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CounterFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CounterFive.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterFive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CounterFive.Location = New System.Drawing.Point(6, 197)
        Me.CounterFive.Name = "CounterFive"
        Me.CounterFive.Size = New System.Drawing.Size(270, 37)
        Me.CounterFive.TabIndex = 5
        Me.CounterFive.Text = "Next >>"
        Me.CounterFive.UseVisualStyleBackColor = False
        '
        'CounterFour
        '
        Me.CounterFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CounterFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CounterFour.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterFour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CounterFour.Location = New System.Drawing.Point(6, 162)
        Me.CounterFour.Name = "CounterFour"
        Me.CounterFour.Size = New System.Drawing.Size(270, 37)
        Me.CounterFour.TabIndex = 5
        Me.CounterFour.Text = "Next >>"
        Me.CounterFour.UseVisualStyleBackColor = False
        '
        'CounterThree
        '
        Me.CounterThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CounterThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CounterThree.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterThree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CounterThree.Location = New System.Drawing.Point(6, 127)
        Me.CounterThree.Name = "CounterThree"
        Me.CounterThree.Size = New System.Drawing.Size(270, 37)
        Me.CounterThree.TabIndex = 5
        Me.CounterThree.Text = "Next >>"
        Me.CounterThree.UseVisualStyleBackColor = False
        '
        'CounterTwo
        '
        Me.CounterTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CounterTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CounterTwo.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterTwo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CounterTwo.Location = New System.Drawing.Point(6, 92)
        Me.CounterTwo.Name = "CounterTwo"
        Me.CounterTwo.Size = New System.Drawing.Size(270, 37)
        Me.CounterTwo.TabIndex = 5
        Me.CounterTwo.Text = "Next >>"
        Me.CounterTwo.UseVisualStyleBackColor = False
        '
        'CounterOne
        '
        Me.CounterOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CounterOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CounterOne.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CounterOne.Location = New System.Drawing.Point(6, 57)
        Me.CounterOne.Name = "CounterOne"
        Me.CounterOne.Size = New System.Drawing.Size(270, 37)
        Me.CounterOne.TabIndex = 5
        Me.CounterOne.Text = "Next >>"
        Me.CounterOne.UseVisualStyleBackColor = False
        '
        'counterQueu4
        '
        Me.counterQueu4.AutoSize = True
        Me.counterQueu4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.counterQueu4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.counterQueu4.Location = New System.Drawing.Point(298, 168)
        Me.counterQueu4.Name = "counterQueu4"
        Me.counterQueu4.Size = New System.Drawing.Size(117, 25)
        Me.counterQueu4.TabIndex = 12
        Me.counterQueu4.Text = "TIN-000000"
        '
        'counterQueu3
        '
        Me.counterQueu3.AutoSize = True
        Me.counterQueu3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.counterQueu3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.counterQueu3.Location = New System.Drawing.Point(298, 133)
        Me.counterQueu3.Name = "counterQueu3"
        Me.counterQueu3.Size = New System.Drawing.Size(117, 25)
        Me.counterQueu3.TabIndex = 12
        Me.counterQueu3.Text = "TIN-000000"
        '
        'counterQueu2
        '
        Me.counterQueu2.AutoSize = True
        Me.counterQueu2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.counterQueu2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.counterQueu2.Location = New System.Drawing.Point(298, 98)
        Me.counterQueu2.Name = "counterQueu2"
        Me.counterQueu2.Size = New System.Drawing.Size(117, 25)
        Me.counterQueu2.TabIndex = 12
        Me.counterQueu2.Text = "TIN-000000"
        '
        'counterQueu1
        '
        Me.counterQueu1.AutoSize = True
        Me.counterQueu1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.counterQueu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.counterQueu1.Location = New System.Drawing.Point(298, 63)
        Me.counterQueu1.Name = "counterQueu1"
        Me.counterQueu1.Size = New System.Drawing.Size(117, 25)
        Me.counterQueu1.TabIndex = 12
        Me.counterQueu1.Text = "TIN-000000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(74, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "COUNTER 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(74, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "COUNTER 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(74, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "COUNTER 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(74, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "COUNTER 2"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(67, 153)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(497, 7)
        Me.Panel7.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.priorityList8)
        Me.GroupBox2.Controls.Add(Me.priorityList7)
        Me.GroupBox2.Controls.Add(Me.priorityList6)
        Me.GroupBox2.Controls.Add(Me.priorityList5)
        Me.GroupBox2.Controls.Add(Me.priorityList4)
        Me.GroupBox2.Controls.Add(Me.priorityList3)
        Me.GroupBox2.Controls.Add(Me.priorityList2)
        Me.GroupBox2.Controls.Add(Me.priorityList1)
        Me.GroupBox2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(903, 52)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PriorityList"
        '
        'priorityList8
        '
        Me.priorityList8.AutoSize = True
        Me.priorityList8.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList8.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList8.Location = New System.Drawing.Point(765, 21)
        Me.priorityList8.Name = "priorityList8"
        Me.priorityList8.Size = New System.Drawing.Size(96, 21)
        Me.priorityList8.TabIndex = 19
        Me.priorityList8.Text = "TIN-000000"
        '
        'priorityList7
        '
        Me.priorityList7.AutoSize = True
        Me.priorityList7.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList7.Location = New System.Drawing.Point(663, 21)
        Me.priorityList7.Name = "priorityList7"
        Me.priorityList7.Size = New System.Drawing.Size(96, 21)
        Me.priorityList7.TabIndex = 18
        Me.priorityList7.Text = "TIN-000000"
        '
        'priorityList6
        '
        Me.priorityList6.AutoSize = True
        Me.priorityList6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList6.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList6.Location = New System.Drawing.Point(561, 21)
        Me.priorityList6.Name = "priorityList6"
        Me.priorityList6.Size = New System.Drawing.Size(96, 21)
        Me.priorityList6.TabIndex = 17
        Me.priorityList6.Text = "TIN-000000"
        '
        'priorityList5
        '
        Me.priorityList5.AutoSize = True
        Me.priorityList5.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList5.Location = New System.Drawing.Point(459, 21)
        Me.priorityList5.Name = "priorityList5"
        Me.priorityList5.Size = New System.Drawing.Size(96, 21)
        Me.priorityList5.TabIndex = 16
        Me.priorityList5.Text = "TIN-000000"
        '
        'priorityList4
        '
        Me.priorityList4.AutoSize = True
        Me.priorityList4.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList4.Location = New System.Drawing.Point(357, 21)
        Me.priorityList4.Name = "priorityList4"
        Me.priorityList4.Size = New System.Drawing.Size(96, 21)
        Me.priorityList4.TabIndex = 15
        Me.priorityList4.Text = "TIN-000000"
        '
        'priorityList3
        '
        Me.priorityList3.AutoSize = True
        Me.priorityList3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList3.Location = New System.Drawing.Point(255, 21)
        Me.priorityList3.Name = "priorityList3"
        Me.priorityList3.Size = New System.Drawing.Size(96, 21)
        Me.priorityList3.TabIndex = 14
        Me.priorityList3.Text = "TIN-000000"
        '
        'priorityList2
        '
        Me.priorityList2.AutoSize = True
        Me.priorityList2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList2.Location = New System.Drawing.Point(153, 21)
        Me.priorityList2.Name = "priorityList2"
        Me.priorityList2.Size = New System.Drawing.Size(96, 21)
        Me.priorityList2.TabIndex = 13
        Me.priorityList2.Text = "TIN-000000"
        '
        'priorityList1
        '
        Me.priorityList1.AutoSize = True
        Me.priorityList1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.priorityList1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.priorityList1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityList1.Location = New System.Drawing.Point(51, 21)
        Me.priorityList1.Name = "priorityList1"
        Me.priorityList1.Size = New System.Drawing.Size(96, 21)
        Me.priorityList1.TabIndex = 13
        Me.priorityList1.Text = "TIN-000000"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(64, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 25)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "PRIORITY LIST"
        '
        'priorityLabel
        '
        Me.priorityLabel.AutoSize = True
        Me.priorityLabel.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.priorityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.priorityLabel.Location = New System.Drawing.Point(298, 28)
        Me.priorityLabel.Name = "priorityLabel"
        Me.priorityLabel.Size = New System.Drawing.Size(117, 25)
        Me.priorityLabel.TabIndex = 12
        Me.priorityLabel.Text = "TIN-000000"
        '
        'priorityButton
        '
        Me.priorityButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.priorityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.priorityButton.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.priorityButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.priorityButton.Location = New System.Drawing.Point(6, 22)
        Me.priorityButton.Name = "priorityButton"
        Me.priorityButton.Size = New System.Drawing.Size(270, 37)
        Me.priorityButton.TabIndex = 5
        Me.priorityButton.Text = "Next >>"
        Me.priorityButton.UseVisualStyleBackColor = False
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(927, 584)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MaximizeBox = False
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Water Billing System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addQueue As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents numberQueue As Label
    Friend WithEvents maxQueue As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents counterQueu5 As Label
    Friend WithEvents counterQueu4 As Label
    Friend WithEvents counterQueu3 As Label
    Friend WithEvents counterQueu2 As Label
    Friend WithEvents counterQueu1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CounterOne As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents CounterFive As Button
    Friend WithEvents CounterFour As Button
    Friend WithEvents CounterThree As Button
    Friend WithEvents CounterTwo As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents waitingList6 As Label
    Friend WithEvents waitingList5 As Label
    Friend WithEvents waitingList4 As Label
    Friend WithEvents waitingList3 As Label
    Friend WithEvents waitingList2 As Label
    Friend WithEvents waitingList1 As Label
    Friend WithEvents waitingList8 As Label
    Friend WithEvents waitingList7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents priorityButton As Button
    Friend WithEvents priorityLabel As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents priorityList8 As Label
    Friend WithEvents priorityList7 As Label
    Friend WithEvents priorityList6 As Label
    Friend WithEvents priorityList5 As Label
    Friend WithEvents priorityList4 As Label
    Friend WithEvents priorityList3 As Label
    Friend WithEvents priorityList2 As Label
    Friend WithEvents priorityList1 As Label
End Class
