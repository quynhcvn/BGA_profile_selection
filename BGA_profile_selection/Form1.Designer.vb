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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        pn_textbox = New TextBox()
        get_product_info_button = New Button()
        Label5 = New Label()
        bga_rework_profile_textbox = New TextBox()
        Label4 = New Label()
        nozzle_type_textbox = New TextBox()
        Label3 = New Label()
        nozzle_location_textbox = New TextBox()
        Label2 = New Label()
        nozzle_picture = New PictureBox()
        MenuStrip1 = New MenuStrip()
        CreateProfileToolStripMenuItem1 = New ToolStripMenuItem()
        UserGuideToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem1 = New ToolStripMenuItem()
        Label6 = New Label()
        component_selection = New ComboBox()
        change_profile_button = New Button()
        product_info_label = New Label()
        CType(nozzle_picture, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 1
        Label1.Text = "Scan the PCBA PN:"
        ' 
        ' pn_textbox
        ' 
        pn_textbox.Location = New Point(147, 58)
        pn_textbox.Name = "pn_textbox"
        pn_textbox.Size = New Size(417, 23)
        pn_textbox.TabIndex = 0
        ' 
        ' get_product_info_button
        ' 
        get_product_info_button.Location = New Point(577, 58)
        get_product_info_button.Name = "get_product_info_button"
        get_product_info_button.Size = New Size(109, 23)
        get_product_info_button.TabIndex = 3
        get_product_info_button.Text = "Get product info"
        get_product_info_button.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 7
        Label5.Text = "Nozzle location:"
        ' 
        ' bga_rework_profile_textbox
        ' 
        bga_rework_profile_textbox.Location = New Point(147, 143)
        bga_rework_profile_textbox.Name = "bga_rework_profile_textbox"
        bga_rework_profile_textbox.ReadOnly = True
        bga_rework_profile_textbox.Size = New Size(417, 23)
        bga_rework_profile_textbox.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 6
        Label4.Text = "Nozzle picture"
        ' 
        ' nozzle_type_textbox
        ' 
        nozzle_type_textbox.Location = New Point(147, 172)
        nozzle_type_textbox.Name = "nozzle_type_textbox"
        nozzle_type_textbox.ReadOnly = True
        nozzle_type_textbox.Size = New Size(417, 23)
        nozzle_type_textbox.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 15)
        Label3.TabIndex = 5
        Label3.Text = "BGA rework profile:"
        ' 
        ' nozzle_location_textbox
        ' 
        nozzle_location_textbox.Location = New Point(147, 201)
        nozzle_location_textbox.Name = "nozzle_location_textbox"
        nozzle_location_textbox.ReadOnly = True
        nozzle_location_textbox.Size = New Size(417, 23)
        nozzle_location_textbox.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ImageAlign = ContentAlignment.BottomCenter
        Label2.Location = New Point(15, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 4
        Label2.Text = "Nozzle type:"
        ' 
        ' nozzle_picture
        ' 
        nozzle_picture.Location = New Point(147, 233)
        nozzle_picture.Name = "nozzle_picture"
        nozzle_picture.Size = New Size(417, 219)
        nozzle_picture.SizeMode = PictureBoxSizeMode.StretchImage
        nozzle_picture.TabIndex = 11
        nozzle_picture.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CreateProfileToolStripMenuItem1, UserGuideToolStripMenuItem, AboutToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(711, 24)
        MenuStrip1.TabIndex = 100
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 15)
        Label6.TabIndex = 101
        Label6.Text = "Component location:"
        ' 
        ' component_selection
        ' 
        component_selection.FormattingEnabled = True
        component_selection.Location = New Point(147, 91)
        component_selection.Name = "component_selection"
        component_selection.Size = New Size(417, 23)
        component_selection.TabIndex = 102
        ' 
        ' change_profile_button
        ' 
        change_profile_button.Location = New Point(577, 91)
        change_profile_button.Name = "change_profile_button"
        change_profile_button.Size = New Size(109, 23)
        change_profile_button.TabIndex = 103
        change_profile_button.Text = "Change profile"
        change_profile_button.UseVisualStyleBackColor = True
        ' 
        ' product_info_label
        ' 
        product_info_label.AutoSize = True
        product_info_label.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        product_info_label.Location = New Point(147, 120)
        product_info_label.Name = "product_info_label"
        product_info_label.RightToLeft = RightToLeft.Yes
        product_info_label.Size = New Size(0, 15)
        product_info_label.TabIndex = 104
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(711, 482)
        Controls.Add(product_info_label)
        Controls.Add(change_profile_button)
        Controls.Add(component_selection)
        Controls.Add(Label6)
        Controls.Add(nozzle_picture)
        Controls.Add(get_product_info_button)
        Controls.Add(Label2)
        Controls.Add(pn_textbox)
        Controls.Add(nozzle_location_textbox)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(nozzle_type_textbox)
        Controls.Add(Label4)
        Controls.Add(bga_rework_profile_textbox)
        Controls.Add(Label5)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BGA rework profile selection tool - Call a profile"
        CType(nozzle_picture, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pn_textbox As TextBox
    Friend WithEvents get_product_info_button As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents bga_rework_profile_textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nozzle_type_textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nozzle_location_textbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nozzle_picture As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CreateProfileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents component_selection As ComboBox
    Friend WithEvents change_profile_button As Button
    Friend WithEvents product_info_label As Label

End Class
