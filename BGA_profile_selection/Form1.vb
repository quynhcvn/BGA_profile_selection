Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq
Imports System
Imports Newtonsoft.Json

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set UI to full screen
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("BGA rework profile selection tool" & Chr(10) & "Version R20241229" & Chr(10) & "Author: Frank Nguyen, qnguyenvan@purestorage.com", Title:="About")
    End Sub

    Private Sub go_button_Click(sender As Object, e As EventArgs) Handles get_product_info_button.Click
        'Variable Declaration
        Dim setting_file As String,
            product_info As String,
            part_number As String,
            product_location_list As String,
            arrValues() As String,
            i As Integer

        part_number = pn_textbox.Text
        product_location_list = ""
        'Clear content of component selection combobox
        component_selection.Items.Clear()
        component_selection.Text = ""
        nozzle_type_textbox.Text = ""
        nozzle_location_textbox.Text = ""
        bga_rework_profile_textbox.Text = ""
        nozzle_picture.Image = Nothing
        product_info_label.Text = ""

        setting_file = My.Computer.FileSystem.ReadAllText("C:\BGA_profile_selection\setting.txt")   'read setting file
        'Mount json using Newtonsoft.Json.dll (reference: https://stackoverflow.com/questions/37766725/how-to-read-json-file-in-vb-net)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(setting_file)

        If read("profile_list")(part_number) Is Nothing Then   'Exeption control for no profile case
            MsgBox("There is no profile with provided part number " & part_number)
            nozzle_type_textbox.Text = ""
            nozzle_location_textbox.Text = ""
            bga_rework_profile_textbox.Text = ""
            nozzle_picture.Image = Nothing
        Else
            product_info = read.Item("product_info")(part_number).ToString
            product_location_list = read.Item("product_location_list")(part_number).ToString
            'split product_location_list into array
            arrValues = Split(product_location_list, ",")
            'Assign value to combobox component_selection that is splitted by comma
            For i = LBound(arrValues) To UBound(arrValues)
                component_selection.Items.Add(arrValues(i))
            Next i

            product_info_label.Text = "(Product info: " & product_info & ")"
        End If

    End Sub

    Private Sub CreateProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateProfileToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub change_profile_button_Click(sender As Object, e As EventArgs) Handles change_profile_button.Click
        Dim setting_file As String,
            part_number As String,
            original_profile_path As String,
            product_profile_path As String,
            nozzle_image_path As String,
            component_location As String,
            profile_name As String,
            nozzle_type As String,
            nozzle_location As String

        part_number = pn_textbox.Text
        component_location = component_selection.Text


        setting_file = My.Computer.FileSystem.ReadAllText("C:\BGA_profile_selection\setting.txt")   'read setting file
        'Mount json using Newtonsoft.Json.dll (reference: https://stackoverflow.com/questions/37766725/how-to-read-json-file-in-vb-net)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(setting_file)
        original_profile_path = read.Item("original_profile_path").ToString
        product_profile_path = read.Item("product_profile_path").ToString
        nozzle_image_path = read.Item("nozzle_image_path").ToString

        If read("profile_list")(part_number) Is Nothing Then   'Exeption control for no profile case
            MsgBox("There is no profile with provided part number " & part_number)
            nozzle_type_textbox.Text = ""
            nozzle_location_textbox.Text = ""
            bga_rework_profile_textbox.Text = ""
            nozzle_picture.Image = Nothing
        Else
            If component_location = "" Then
                MsgBox("No component is selected")
            Else
                profile_name = read.Item("profile_list")(part_number)(component_location)("profile").ToString
                nozzle_type = read.Item("profile_list")(part_number)(component_location)("nozzle").ToString
                nozzle_location = read.Item("profile_list")(part_number)(component_location)("location").ToString
                'mount to form's text box
                bga_rework_profile_textbox.Text = profile_name
                nozzle_type_textbox.Text = nozzle_type
                nozzle_location_textbox.Text = nozzle_location
                'Insert nozzle image
                Dim imageFileName = Path.Combine(Application.StartupPath, nozzle_image_path, nozzle_type & ".png")
                nozzle_picture.Image = Image.FromFile(imageFileName)

            End If
        End If
    End Sub

End Class
