<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Txt_ID_Test = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Btb_Test = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Lbl_Debug = New System.Windows.Forms.Label()
        Me.Lbl_Debug_Info = New System.Windows.Forms.Label()
        Me.GroupBox_Test = New System.Windows.Forms.GroupBox()
        Me.Txt_Text_Test = New System.Windows.Forms.TextBox()
        Me.Lbl_test1 = New System.Windows.Forms.Label()
        Me.Lbl_Test2 = New System.Windows.Forms.Label()
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
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(240, 264)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(258, 39)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(399, 264)
        Me.ListBox2.TabIndex = 2
        '
        'Btb_Test
        '
        Me.Btb_Test.Location = New System.Drawing.Point(325, 13)
        Me.Btb_Test.Name = "Btb_Test"
        Me.Btb_Test.Size = New System.Drawing.Size(75, 23)
        Me.Btb_Test.TabIndex = 3
        Me.Btb_Test.Text = "Probar"
        Me.Btb_Test.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Lbl_Debug
        '
        Me.Lbl_Debug.AutoSize = True
        Me.Lbl_Debug.Location = New System.Drawing.Point(9, 9)
        Me.Lbl_Debug.Name = "Lbl_Debug"
        Me.Lbl_Debug.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_Debug.TabIndex = 4
        Me.Lbl_Debug.Text = "Debug :"
        '
        'Lbl_Debug_Info
        '
        Me.Lbl_Debug_Info.AutoSize = True
        Me.Lbl_Debug_Info.Location = New System.Drawing.Point(54, 9)
        Me.Lbl_Debug_Info.Name = "Lbl_Debug_Info"
        Me.Lbl_Debug_Info.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Debug_Info.TabIndex = 5
        Me.Lbl_Debug_Info.Text = "Debug"
        '
        'GroupBox_Test
        '
        Me.GroupBox_Test.Controls.Add(Me.Lbl_Test2)
        Me.GroupBox_Test.Controls.Add(Me.Lbl_test1)
        Me.GroupBox_Test.Controls.Add(Me.Txt_Text_Test)
        Me.GroupBox_Test.Controls.Add(Me.Btb_Test)
        Me.GroupBox_Test.Controls.Add(Me.Txt_ID_Test)
        Me.GroupBox_Test.Location = New System.Drawing.Point(251, -1)
        Me.GroupBox_Test.Name = "GroupBox_Test"
        Me.GroupBox_Test.Size = New System.Drawing.Size(406, 40)
        Me.GroupBox_Test.TabIndex = 6
        Me.GroupBox_Test.TabStop = False
        Me.GroupBox_Test.Text = "Area de Pruebas"
        '
        'Txt_Text_Test
        '
        Me.Txt_Text_Test.Location = New System.Drawing.Point(202, 14)
        Me.Txt_Text_Test.Multiline = True
        Me.Txt_Text_Test.Name = "Txt_Text_Test"
        Me.Txt_Text_Test.Size = New System.Drawing.Size(104, 21)
        Me.Txt_Text_Test.TabIndex = 4
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
        'Lbl_Test2
        '
        Me.Lbl_Test2.AutoSize = True
        Me.Lbl_Test2.Location = New System.Drawing.Point(149, 19)
        Me.Lbl_Test2.Name = "Lbl_Test2"
        Me.Lbl_Test2.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_Test2.TabIndex = 8
        Me.Lbl_Test2.Text = "Mensaje"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 310)
        Me.Controls.Add(Me.GroupBox_Test)
        Me.Controls.Add(Me.Lbl_Debug_Info)
        Me.Controls.Add(Me.Lbl_Debug)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox_Test.ResumeLayout(False)
        Me.GroupBox_Test.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_ID_Test As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Btb_Test As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_Debug As Label
    Friend WithEvents Lbl_Debug_Info As Label
    Friend WithEvents GroupBox_Test As GroupBox
    Friend WithEvents Lbl_Test2 As Label
    Friend WithEvents Lbl_test1 As Label
    Friend WithEvents Txt_Text_Test As TextBox
End Class
