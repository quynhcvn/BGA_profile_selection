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
            setting_file As String


        file_name = "Cobalt_profile"


        setting_file = My.Computer.FileSystem.ReadAllText("C:\BGA_profile_selection\setting.txt")   'read setting file
        'Mount json using Newtonsoft.Json.dll (reference: https://stackoverflow.com/questions/37766725/how-to-read-json-file-in-vb-net)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(setting_file)
        Label6.Text = read.Item("original_profile_path").ToString
        Label7.Text = read.Item("product_profile_path").ToString
        bga_rework_profile_textbox.Text = read.Item("profile_list")("PN#1")("profile").ToString
        nozzle_type_textbox.Text = read.Item("profile_list")("PN#1")("nozzle").ToString
        nozzle_location_textbox.Text = read.Item("profile_list")("PN#1")("location").ToString
        Label8.Text = pn_textbox.Text



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
