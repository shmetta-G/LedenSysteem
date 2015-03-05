Imports System.Data.OleDb
Module frmModule
    Public connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ledenbestand2014.accdb;persist security info = false"
    Public conn As New OleDbConnection
End Module
