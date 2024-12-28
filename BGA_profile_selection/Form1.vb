Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("BGA rework profile selection" & Chr(10) & "Author: Frank Nguyen, qnguyenvan@purestorage.com")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set UI to full screen
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub go_button_Click(sender As Object, e As EventArgs) Handles go_button.Click
        'Variable Declaration
        Dim file_name As String,
            original_profile_path As String,
            original_profile_path_trim As String,
            product_profile_path As String,
            product_profile_path_trim As String,
            bga_rework_parameter As String,
            bga_profile As String,
            nozzle_type As String,
            nozzle_location As String

        file_name = "Cobalt_profile"
        original_profile_path_trim = ""
        product_profile_path_trim = ""
        nozzle_type = ""
        nozzle_location = ""
        bga_profile = ""

        'Read setting parameter
        'Read original profile path
        Using reader As New StreamReader("C:\BGA_profile_selection\setting.txt")
            While Not reader.EndOfStream
                original_profile_path = reader.ReadLine()
                If original_profile_path.Contains("[original_profile_path]") Then
                    original_profile_path_trim = original_profile_path.Substring(original_profile_path.IndexOf("]") + 1)   'cut string after ] character
                End If
            End While
        End Using
        'Read profile path
        Using reader As New StreamReader("C:\BGA_profile_selection\setting.txt")
            While Not reader.EndOfStream
                product_profile_path = reader.ReadLine()
                If product_profile_path.Contains("[product_profile_path]") Then
                    product_profile_path_trim = product_profile_path.Substring(product_profile_path.IndexOf("]") + 1)   'cut string after ] character
                End If
            End While
        End Using
        'Read profile and parameter
        Using reader As New StreamReader("C:\BGA_profile_selection\setting.txt")
            While Not reader.EndOfStream
                bga_rework_parameter = reader.ReadLine()
                If bga_rework_parameter.Contains("[PN#1]") Then
                    bga_profile = bga_rework_parameter.Substring(bga_rework_parameter.IndexOf("<Profile>") + 1)   'cut string after ] character
                    nozzle_type = bga_rework_parameter.Substring(bga_rework_parameter.IndexOf("<Nozzle>") + 1)   'cut string after ] character
                    nozzle_location = bga_rework_parameter.Substring(bga_rework_parameter.IndexOf("<Location>") + 1)   'cut string after ] character
                End If
            End While
        End Using
        'Read profile and parameter
        Using reader As New StreamReader("C:\BGA_profile_selection\setting.txt")
            While Not reader.EndOfStream
                bga_rework_parameter = reader.ReadLine()
                If bga_rework_parameter.Contains("[PN#1]") Then
                    bga_profile = bga_rework_parameter.Substring(bga_rework_parameter.IndexOf("<Profile>") + 1)   'cut string after ] character
                    nozzle_type = bga_rework_parameter.Substring(bga_rework_parameter.IndexOf("<Nozzle>") + 1)   'cut string after ] character
                    nozzle_location = bga_rework_parameter.Substring(bga_rework_parameter.IndexOf("<Location>") + 1)   'cut string after ] character
                End If
            End While
        End Using


        Label6.Text = original_profile_path_trim
        Label7.Text = product_profile_path_trim
        Label8.Text = pn_textbox.Text
        nozzle_type_textbox.Text = nozzle_type
        nozzle_location_textbox.Text = nozzle_location
        bga_rework_profile_textbox.Text = bga_profile



        'Delete files and folder on C:\BGA_profile_selection\Products\
        My.Computer.FileSystem.DeleteDirectory("C:\BGA_profile_selection\Products\", FileIO.DeleteDirectoryOption.DeleteAllContents)
        'Copy profiles
        If My.Computer.FileSystem.DirectoryExists("C:\BGA_profile_selection\" & file_name) Then    'Check the file exist
            My.Computer.FileSystem.CopyDirectory("C:\BGA_profile_selection\" & file_name, "C:\BGA_profile_selection\Products\" & file_name, overwrite:=True)     'Copy file
        Else
            MsgBox("BGA profile not found.")
        End If
    End Sub


End Class
