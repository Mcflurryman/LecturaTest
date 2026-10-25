<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnLeer = New Button()
        txtS1 = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        lblS1 = New Label()
        lblS2 = New Label()
        lblS3 = New Label()
        lblS4 = New Label()
        lblS5 = New Label()
        lblS6 = New Label()
        lblS7 = New Label()
        btnSaveDB = New Button()
        lblentera = New TextBox()
        SuspendLayout()
        ' 
        ' btnLeer
        ' 
        btnLeer.Location = New Point(142, 317)
        btnLeer.Name = "btnLeer"
        btnLeer.Size = New Size(222, 45)
        btnLeer.TabIndex = 0
        btnLeer.Text = "Lectura"
        btnLeer.UseVisualStyleBackColor = True
        ' 
        ' txtS1
        ' 
        txtS1.Location = New Point(275, 28)
        txtS1.Multiline = True
        txtS1.Name = "txtS1"
        txtS1.Size = New Size(89, 36)
        txtS1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(275, 95)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(89, 36)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(275, 159)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(89, 36)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(275, 223)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(89, 36)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(457, 28)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(89, 36)
        TextBox4.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(457, 95)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(89, 36)
        TextBox5.TabIndex = 6
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(457, 159)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(89, 36)
        TextBox6.TabIndex = 7
        ' 
        ' lblS1
        ' 
        lblS1.AutoSize = True
        lblS1.Location = New Point(309, 10)
        lblS1.Name = "lblS1"
        lblS1.Size = New Size(19, 15)
        lblS1.TabIndex = 8
        lblS1.Text = "S1"
        ' 
        ' lblS2
        ' 
        lblS2.AutoSize = True
        lblS2.Location = New Point(309, 77)
        lblS2.Name = "lblS2"
        lblS2.Size = New Size(19, 15)
        lblS2.TabIndex = 9
        lblS2.Text = "S2"
        ' 
        ' lblS3
        ' 
        lblS3.AutoSize = True
        lblS3.Location = New Point(309, 141)
        lblS3.Name = "lblS3"
        lblS3.Size = New Size(19, 15)
        lblS3.TabIndex = 10
        lblS3.Text = "S3"
        ' 
        ' lblS4
        ' 
        lblS4.AutoSize = True
        lblS4.Location = New Point(309, 205)
        lblS4.Name = "lblS4"
        lblS4.Size = New Size(19, 15)
        lblS4.TabIndex = 11
        lblS4.Text = "S4"
        ' 
        ' lblS5
        ' 
        lblS5.AutoSize = True
        lblS5.Location = New Point(494, 10)
        lblS5.Name = "lblS5"
        lblS5.Size = New Size(19, 15)
        lblS5.TabIndex = 12
        lblS5.Text = "S5"
        ' 
        ' lblS6
        ' 
        lblS6.AutoSize = True
        lblS6.Location = New Point(494, 77)
        lblS6.Name = "lblS6"
        lblS6.Size = New Size(19, 15)
        lblS6.TabIndex = 13
        lblS6.Text = "S6"
        ' 
        ' lblS7
        ' 
        lblS7.AutoSize = True
        lblS7.Location = New Point(494, 141)
        lblS7.Name = "lblS7"
        lblS7.Size = New Size(19, 15)
        lblS7.TabIndex = 14
        lblS7.Text = "S7"
        ' 
        ' btnSaveDB
        ' 
        btnSaveDB.Location = New Point(435, 317)
        btnSaveDB.Name = "btnSaveDB"
        btnSaveDB.Size = New Size(222, 45)
        btnSaveDB.TabIndex = 15
        btnSaveDB.Text = "Guardar BDD"
        btnSaveDB.UseVisualStyleBackColor = True
        ' 
        ' lblentera
        ' 
        lblentera.Location = New Point(507, 253)
        lblentera.Name = "lblentera"
        lblentera.Size = New Size(264, 23)
        lblentera.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblentera)
        Controls.Add(btnSaveDB)
        Controls.Add(lblS7)
        Controls.Add(lblS6)
        Controls.Add(lblS5)
        Controls.Add(lblS4)
        Controls.Add(lblS3)
        Controls.Add(lblS2)
        Controls.Add(lblS1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtS1)
        Controls.Add(btnLeer)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLeer As Button
    Friend WithEvents txtS1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblS1 As Label
    Friend WithEvents lblS2 As Label
    Friend WithEvents lblS3 As Label
    Friend WithEvents lblS4 As Label
    Friend WithEvents lblS5 As Label
    Friend WithEvents lblS6 As Label
    Friend WithEvents lblS7 As Label
    Friend WithEvents btnSaveDB As Button
    Friend WithEvents lblentera As TextBox

End Class
