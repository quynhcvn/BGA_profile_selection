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
        Button1 = New Button()
        Label1 = New Label()
        pn_textbox = New TextBox()
        go_button = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        bga_rework_profile_textbox = New TextBox()
        nozzle_type_textbox = New TextBox()
        nozzle_location_textbox = New TextBox()
        nozzle_picture = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(nozzle_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(698, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 25)
        Button1.TabIndex = 99
        Button1.Text = "Introduction"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 1
        Label1.Text = "Scan the PCBA PN:"
        ' 
        ' pn_textbox
        ' 
        pn_textbox.Location = New Point(149, 17)
        pn_textbox.Name = "pn_textbox"
        pn_textbox.Size = New Size(417, 23)
        pn_textbox.TabIndex = 0
        ' 
        ' go_button
        ' 
        go_button.Location = New Point(577, 17)
        go_button.Name = "go_button"
        go_button.Size = New Size(64, 23)
        go_button.TabIndex = 3
        go_button.Text = "Go"
        go_button.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ImageAlign = ContentAlignment.BottomCenter
        Label2.Location = New Point(27, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 4
        Label2.Text = "Nozzle type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 15)
        Label3.TabIndex = 5
        Label3.Text = "BGA rework profile:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 6
        Label4.Text = "Nozzle picture"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 7
        Label5.Text = "Nozzle location:"
        ' 
        ' bga_rework_profile_textbox
        ' 
        bga_rework_profile_textbox.Location = New Point(149, 60)
        bga_rework_profile_textbox.Name = "bga_rework_profile_textbox"
        bga_rework_profile_textbox.ReadOnly = True
        bga_rework_profile_textbox.Size = New Size(417, 23)
        bga_rework_profile_textbox.TabIndex = 8
        ' 
        ' nozzle_type_textbox
        ' 
        nozzle_type_textbox.Location = New Point(149, 89)
        nozzle_type_textbox.Name = "nozzle_type_textbox"
        nozzle_type_textbox.ReadOnly = True
        nozzle_type_textbox.Size = New Size(417, 23)
        nozzle_type_textbox.TabIndex = 9
        ' 
        ' nozzle_location_textbox
        ' 
        nozzle_location_textbox.Location = New Point(149, 118)
        nozzle_location_textbox.Name = "nozzle_location_textbox"
        nozzle_location_textbox.ReadOnly = True
        nozzle_location_textbox.Size = New Size(417, 23)
        nozzle_location_textbox.TabIndex = 10
        ' 
        ' nozzle_picture
        ' 
        nozzle_picture.Location = New Point(149, 150)
        nozzle_picture.Name = "nozzle_picture"
        nozzle_picture.Size = New Size(417, 219)
        nozzle_picture.TabIndex = 11
        nozzle_picture.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(645, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 12
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(645, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 13
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(645, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 14
        Label8.Text = "Label8"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 389)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(nozzle_picture)
        Controls.Add(nozzle_location_textbox)
        Controls.Add(nozzle_type_textbox)
        Controls.Add(bga_rework_profile_textbox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(go_button)
        Controls.Add(pn_textbox)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "BGA rework profile selection, Author: Frank Nguyen (qnguyenvan@purestorage.com)"
        CType(nozzle_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pn_textbox As TextBox
    Friend WithEvents go_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bga_rework_profile_textbox As TextBox
    Friend WithEvents nozzle_type_textbox As TextBox
    Friend WithEvents nozzle_location_textbox As TextBox
    Friend WithEvents nozzle_picture As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
