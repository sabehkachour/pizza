<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Rdprop1 = New RadioButton()
        Rdprop2 = New RadioButton()
        Rdprop3 = New RadioButton()
        Chkprop1 = New CheckBox()
        Chkprop2 = New CheckBox()
        Chkprop3 = New CheckBox()
        Chkprop4 = New CheckBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Rdprop1
        ' 
        Rdprop1.AutoSize = True
        Rdprop1.Location = New Point(111, 128)
        Rdprop1.Name = "Rdprop1"
        Rdprop1.Size = New Size(96, 24)
        Rdprop1.TabIndex = 1
        Rdprop1.TabStop = True
        Rdprop1.Text = "coute fine"
        Rdprop1.UseVisualStyleBackColor = True
        ' 
        ' Rdprop2
        ' 
        Rdprop2.AutoSize = True
        Rdprop2.Location = New Point(259, 128)
        Rdprop2.Name = "Rdprop2"
        Rdprop2.Size = New Size(131, 24)
        Rdprop2.TabIndex = 2
        Rdprop2.TabStop = True
        Rdprop2.Text = "coute classique"
        Rdprop2.UseVisualStyleBackColor = True
        ' 
        ' Rdprop3
        ' 
        Rdprop3.AutoSize = True
        Rdprop3.Location = New Point(416, 128)
        Rdprop3.Name = "Rdprop3"
        Rdprop3.Size = New Size(114, 24)
        Rdprop3.TabIndex = 3
        Rdprop3.TabStop = True
        Rdprop3.Text = "coute epaise"
        Rdprop3.UseVisualStyleBackColor = True
        ' 
        ' Chkprop1
        ' 
        Chkprop1.AutoSize = True
        Chkprop1.Location = New Point(111, 174)
        Chkprop1.Name = "Chkprop1"
        Chkprop1.Size = New Size(120, 24)
        Chkprop1.TabIndex = 4
        Chkprop1.Text = "champignons"
        Chkprop1.UseVisualStyleBackColor = True
        ' 
        ' Chkprop2
        ' 
        Chkprop2.AutoSize = True
        Chkprop2.Location = New Point(111, 221)
        Chkprop2.Name = "Chkprop2"
        Chkprop2.Size = New Size(69, 24)
        Chkprop2.TabIndex = 5
        Chkprop2.Text = "olives"
        Chkprop2.UseVisualStyleBackColor = True
        ' 
        ' Chkprop3
        ' 
        Chkprop3.AutoSize = True
        Chkprop3.Location = New Point(111, 260)
        Chkprop3.Name = "Chkprop3"
        Chkprop3.Size = New Size(88, 24)
        Chkprop3.TabIndex = 6
        Chkprop3.Text = "poivrons"
        Chkprop3.UseVisualStyleBackColor = True
        ' 
        ' Chkprop4
        ' 
        Chkprop4.AutoSize = True
        Chkprop4.Location = New Point(111, 300)
        Chkprop4.Name = "Chkprop4"
        Chkprop4.Size = New Size(195, 24)
        Chkprop4.TabIndex = 7
        Chkprop4.Text = "fromage supplémentaire" & vbCrLf
        Chkprop4.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"grande", "moyenne ", "petite"})
        ComboBox1.Location = New Point(155, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(291, 349)
        Button1.Name = "Button1"
        Button1.Size = New Size(265, 70)
        Button1.TabIndex = 10
        Button1.Text = "passer commande"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Chkprop4)
        Controls.Add(Chkprop3)
        Controls.Add(Chkprop2)
        Controls.Add(Chkprop1)
        Controls.Add(Rdprop3)
        Controls.Add(Rdprop2)
        Controls.Add(Rdprop1)
        Name = "form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Rdprop1 As RadioButton
    Friend WithEvents Rdprop2 As RadioButton
    Friend WithEvents Rdprop3 As RadioButton
    Friend WithEvents Chkprop1 As CheckBox
    Friend WithEvents Chkprop2 As CheckBox
    Friend WithEvents Chkprop3 As CheckBox
    Friend WithEvents Chkprop4 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button

End Class
