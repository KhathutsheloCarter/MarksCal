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
        btnResults = New Button()
        lblMarks = New Label()
        txtMarks = New TextBox()
        SuspendLayout()
        ' 
        ' btnResults
        ' 
        btnResults.Location = New Point(115, 211)
        btnResults.Name = "btnResults"
        btnResults.Size = New Size(273, 142)
        btnResults.TabIndex = 0
        btnResults.Text = "Results"
        btnResults.UseVisualStyleBackColor = True
        ' 
        ' lblMarks
        ' 
        lblMarks.AutoSize = True
        lblMarks.Location = New Point(87, 79)
        lblMarks.Name = "lblMarks"
        lblMarks.Size = New Size(86, 20)
        lblMarks.TabIndex = 1
        lblMarks.Text = "Enter Marks"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(223, 79)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(125, 27)
        txtMarks.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMarks)
        Controls.Add(lblMarks)
        Controls.Add(btnResults)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnResults As Button
    Friend WithEvents lblMarks As Label
    Friend WithEvents txtMarks As TextBox
End Class
