Imports System.Data.OleDb
Public Class Ledensysteem

    Dim intBezoekersBinnen As Integer = 0
    Dim intBezoekersTotaal As Integer = 0
    Dim intKassa As Integer = 0

    Private Sub ILoveSummer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = connstring

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim sqlQuery As String = "SELECT * FROM tblGegevens"
        Dim sqlCommand As New OleDbCommand

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        Dim dr As OleDbDataReader
        dr = sqlCommand.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            intBezoekersTotaal = Integer.Parse(dr.Item("bezoekersTotaal"))
            intKassa = Integer.Parse(dr.Item("kassa"))

            dr.Close()
        End If

        lblBezoekersTotaal.Text = intBezoekersTotaal
    End Sub

    Private Sub btnLid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLid.Click
        intBezoekersTotaal += 1

        Try
            Dim sqlQuery As String = "UPDATE tblGegevens SET bezoekersTotaal='" & intBezoekersTotaal.ToString & "' WHERE Id='1' "
            Dim sqlCommand As New OleDbCommand

            With sqlCommand
                .CommandText = sqlQuery
                .Connection = conn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        lblBezoekersTotaal.Text = intBezoekersTotaal
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        dtgLeden.Rows.Clear()

        Dim strVoornaam As String = txtVoornaam.Text
        Dim strNaam As String = txtNaam.Text

        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM tblLeden WHERE Voornaam like '%" & strVoornaam & "%' AND Naam like '%" & strNaam & "%';"

        Dim sqlCommand As New OleDbCommand
        Dim sqlAdapter As New OleDbDataAdapter
        Dim TABLE As New DataTable

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)
        End With

        Dim dr As OleDbDataReader
        dr = sqlCommand.ExecuteReader

        Dim intAantal As Integer = TABLE.Rows.Count()

        For i As Integer = 0 To TABLE.Rows.Count - 1
            dtgLeden.Rows.Add(TABLE.Rows(i)("id"), TABLE.Rows(i)("Naam"), TABLE.Rows(i)("Voornaam"), TABLE.Rows(i)("Geboortedatum"), TABLE.Rows(i)("Straat"), TABLE.Rows(i)("Postcode"), TABLE.Rows(i)("Gemeente"), TABLE.Rows(i)("Foto"))
        Next
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MessageBox.Show("Bent u zeker dat u alle gegevens wilt resetten?", "Resetten", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            intBezoekersBinnen = 0
            intBezoekersTotaal = 0
            intKassa = 0

            Try
                Dim sqlQuery As String = "UPDATE tblGegevens SET BezoekersBinnen='" & intBezoekersBinnen.ToString & "', BezoekersTotaal='" & intBezoekersTotaal.ToString & "', Kassa='" & intKassa.ToString & "' WHERE Id='1' "
                Dim sqlCommand As New OleDbCommand

                With sqlCommand
                    .CommandText = sqlQuery
                    .Connection = conn
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            lblBezoekersTotaal.Text = intBezoekersTotaal
        End If
    End Sub

    Private Sub txtVoornaam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoornaam.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnFilter_Click(sender, e)
        End If
    End Sub

    Private Sub txtNaam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNaam.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnFilter_Click(sender, e)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        LidToevoegen.Show()
    End Sub

    Private Sub dtgLeden_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgLeden.SelectionChanged
        For Each rw As DataGridViewRow In dtgLeden.Rows
            If rw.Selected = True Then
                If rw.Cells(7).Value <> "" Then
                    Dim strFoto As String = rw.Cells(7).Value
                    pbFoto.ImageLocation = strFoto
                Else
                    pbFoto.ImageLocation = ""
                End If
            End If
        Next
    End Sub
End Class
