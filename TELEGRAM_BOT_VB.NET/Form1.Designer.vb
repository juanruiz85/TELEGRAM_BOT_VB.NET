<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Txt_ID_Test = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Btb_Test = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox_Test = New System.Windows.Forms.GroupBox()
        Me.Lbl_Test2 = New System.Windows.Forms.Label()
        Me.Lbl_test1 = New System.Windows.Forms.Label()
        Me.Txt_Text_Test = New System.Windows.Forms.TextBox()
        Me.Lbl_Debug_Info = New System.Windows.Forms.Label()
        Me.Lbl_Debug = New System.Windows.Forms.Label()
        Me.GroupBox_Test.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_ID_Test
        '
        Me.Txt_ID_Test.Location = New System.Drawing.Point(30, 14)
        Me.Txt_ID_Test.Multiline = True
        Me.Txt_ID_Test.Name = "Txt_ID_Test"
        Me.Txt_ID_Test.Size = New System.Drawing.Size(104, 21)
        Me.Txt_ID_Test.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(337, 47)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(402, 186)
        Me.ListBox2.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(5, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(326, 186)
        Me.ListBox1.TabIndex = 3
        '
        'Btb_Test
        '
        Me.Btb_Test.Location = New System.Drawing.Point(325, 13)
        Me.Btb_Test.Name = "Btb_Test"
        Me.Btb_Test.Size = New System.Drawing.Size(75, 23)
        Me.Btb_Test.TabIndex = 2
        Me.Btb_Test.Text = "Probar"
        Me.Btb_Test.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'GroupBox_Test
        '
        Me.GroupBox_Test.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Test.Controls.Add(Me.Lbl_Test2)
        Me.GroupBox_Test.Controls.Add(Me.Lbl_test1)
        Me.GroupBox_Test.Controls.Add(Me.Txt_Text_Test)
        Me.GroupBox_Test.Controls.Add(Me.Btb_Test)
        Me.GroupBox_Test.Controls.Add(Me.Txt_ID_Test)
        Me.GroupBox_Test.Location = New System.Drawing.Point(333, 7)
        Me.GroupBox_Test.Name = "GroupBox_Test"
        Me.GroupBox_Test.Size = New System.Drawing.Size(406, 40)
        Me.GroupBox_Test.TabIndex = 11
        Me.GroupBox_Test.TabStop = False
        Me.GroupBox_Test.Text = "Area de Pruebas"
        '
        'Lbl_Test2
        '
        Me.Lbl_Test2.AutoSize = True
        Me.Lbl_Test2.Location = New System.Drawing.Point(149, 19)
        Me.Lbl_Test2.Name = "Lbl_Test2"
        Me.Lbl_Test2.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_Test2.TabIndex = 8
        Me.Lbl_Test2.Text = "Mensaje"
        '
        'Lbl_test1
        '
        Me.Lbl_test1.AutoSize = True
        Me.Lbl_test1.Location = New System.Drawing.Point(6, 19)
        Me.Lbl_test1.Name = "Lbl_test1"
        Me.Lbl_test1.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_test1.TabIndex = 7
        Me.Lbl_test1.Text = "ID"
        '
        'Txt_Text_Test
        '
        Me.Txt_Text_Test.Location = New System.Drawing.Point(202, 14)
        Me.Txt_Text_Test.Multiline = True
        Me.Txt_Text_Test.Name = "Txt_Text_Test"
        Me.Txt_Text_Test.Size = New System.Drawing.Size(104, 21)
        Me.Txt_Text_Test.TabIndex = 1
        '
        'Lbl_Debug_Info
        '
        Me.Lbl_Debug_Info.AutoSize = True
        Me.Lbl_Debug_Info.Location = New System.Drawing.Point(47, 17)
        Me.Lbl_Debug_Info.Name = "Lbl_Debug_Info"
        Me.Lbl_Debug_Info.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Debug_Info.TabIndex = 10
        Me.Lbl_Debug_Info.Text = "Debug"
        '
        'Lbl_Debug
        '
        Me.Lbl_Debug.AutoSize = True
        Me.Lbl_Debug.Location = New System.Drawing.Point(2, 17)
        Me.Lbl_Debug.Name = "Lbl_Debug"
        Me.Lbl_Debug.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_Debug.TabIndex = 9
        Me.Lbl_Debug.Text = "Debug :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 248)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox_Test)
        Me.Controls.Add(Me.Lbl_Debug_Info)
        Me.Controls.Add(Me.Lbl_Debug)
        Me.Name = "Form1"
        Me.Text = "TELEGRAM_BOT_VB"
        Me.GroupBox_Test.ResumeLayout(False)
        Me.GroupBox_Test.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_ID_Test As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btb_Test As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox_Test As GroupBox
    Friend WithEvents Lbl_Test2 As Label
    Friend WithEvents Lbl_test1 As Label
    Friend WithEvents Txt_Text_Test As TextBox
    Friend WithEvents Lbl_Debug_Info As Label
    Friend WithEvents Lbl_Debug As Label
End Class
