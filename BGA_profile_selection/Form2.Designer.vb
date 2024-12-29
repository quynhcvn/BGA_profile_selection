<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        CreateProfileToolStripMenuItem1 = New ToolStripMenuItem()
        UserGuideToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CreateProfileToolStripMenuItem1, UserGuideToolStripMenuItem, AboutToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(711, 24)
        MenuStrip1.TabIndex = 101
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CreateProfileToolStripMenuItem1
        ' 
        CreateProfileToolStripMenuItem1.Name = "CreateProfileToolStripMenuItem1"
        CreateProfileToolStripMenuItem1.Size = New Size(90, 20)
        CreateProfileToolStripMenuItem1.Text = "Create profile"
        ' 
        ' UserGuideToolStripMenuItem
        ' 
        UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem"
        UserGuideToolStripMenuItem.Size = New Size(75, 20)
        UserGuideToolStripMenuItem.Text = "User guide"
        ' 
        ' AboutToolStripMenuItem1
        ' 
        AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        AboutToolStripMenuItem1.Size = New Size(52, 20)
        AboutToolStripMenuItem1.Text = "About"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(711, 465)
        Controls.Add(MenuStrip1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BGA rework profile selection tool - Create profile"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CreateProfileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
