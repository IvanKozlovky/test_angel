﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtA = New TextBox()
        txtB = New TextBox()
        txtC = New TextBox()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(245, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(13, 15)
        Label1.TabIndex = 0
        Label1.Text = "a"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(430, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(14, 15)
        Label2.TabIndex = 1
        Label2.Text = "b"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(603, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 2
        Label3.Text = "c"' 
        ' txtA
        ' 
        txtA.Location = New Point(206, 113)
        txtA.Name = "txtA"
        txtA.Size = New Size(100, 23)
        txtA.TabIndex = 3
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(394, 113)
        txtB.Name = "txtB"
        txtB.Size = New Size(100, 23)
        txtB.TabIndex = 4
        ' 
        ' txtC
        ' 
        txtC.Location = New Point(566, 113)
        txtC.Name = "txtC"
        txtC.Size = New Size(100, 23)
        txtC.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(394, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Розв'язати"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(347, 176)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 15)
        lblResult.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(txtC)
        Controls.Add(txtB)
        Controls.Add(txtA)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
