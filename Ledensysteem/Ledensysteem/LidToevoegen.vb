Imports EIDLIBCTRLLib1 = EIDLIBCTRLLib.EIDlib
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class LidToevoegen
    Dim strMode As String = ""
    Private Sub LidToevoegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnToevoegen.Enabled = False
    End Sub

    Private Sub btnReadEid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadEid.Click
        strMode = "kaart"
        pbFoto.Image = Nothing

        lblBirthplace.Enabled = True
        lblGender.Enabled = True
        lblNatNr.Enabled = True
        lblLand.Enabled = True

        Dim lHandle As Integer
        Dim EIDlib1 As New EIDLIBCTRLLib.EIDlib
        Dim RetStatus As EIDLIBCTRLLib.RetStatus
        Dim MapColPicture As New EIDLIBCTRLLib.MapCollection
        Dim MapColID As New EIDLIBCTRLLib.MapCollection
        Dim MapColAddress As New EIDLIBCTRLLib.MapCollection
        Dim CertifCheck As New EIDLIBCTRLLib.CertifCheck

        'BEID_ Kaart Info
        Dim strCardNumber As String
        Dim strChipNumber As String
        'Dim strBegValDag, strBegVal, strBegValMaand As Object
        'Dim strBegValJaar As String
        'Dim strEndValDag, strEndVal, strEndValMaand As Object
        'Dim strEndValJaar As String
        Dim strIssuingMunicipality As String
        'BEID Persoons Info
        Dim strName As String
        Dim strFirstName1 As String
        Dim strBirthPlace As String
        Dim strBirthDate As String
        Dim strGender As String
        Dim strNationality As String
        Dim strNationalNumber As String
        'BEID Adres Info
        Dim strStreet As String
        Dim strZIPCode As String
        Dim strMunicipality As String

        'voor de img
        Dim bytes() As Byte
        'Dim ms As System.IO.MemoryStream()


        Try
            RetStatus = EIDlib1.Init("", 0, 0, lHandle)
            If (RetStatus.GetGeneral = 0) Then
                RetStatus = EIDlib1.GetID(MapColID, CertifCheck)
                strChipNumber = MapColID.GetValue("ChipNumber").ToString
                strCardNumber = MapColID.GetValue("CardNumber").ToString
                'strBegVal = MapColID.GetValue("BeginValidityDate")
                'strEndVal = MapColID.GetValue("EndValidityDate")
                strIssuingMunicipality = MapColID.GetValue("IssuingMunicipality").ToString
                strName = MapColID.GetValue("Name").ToString
                strFirstName1 = MapColID.GetValue("FirstName1").ToString
                strBirthDate = MapColID.GetValue("BirthDate").ToString
                strBirthPlace = MapColID.GetValue("BirthPlace").ToString
                strGender = MapColID.GetValue("Gender").ToString
                strNationality = MapColID.GetValue("Nationality").ToString
                strNationalNumber = MapColID.GetValue("NationalNumber").ToString

                'Opsplitsen begindatum

                'strBegValDag = VB.Right(strBegVal.ToString, 2)
                'strBegValMaand = Mid(strBegVal.ToString, 5, 2)
                'strBegValJaar = VB.Left(strBegVal.ToString, 4)
                'Opsplitsen einddatum

                'strEndValDag = VB.Right(strEndVal.ToString, 2)
                'strEndValMaand = Mid(strEndVal.ToString, 5, 2)
                'strEndValJaar = VB.Left(strEndVal.ToString, 4)


            End If

            RetStatus = EIDlib1.GetAddress(MapColAddress, CertifCheck)

            strStreet = MapColAddress.GetValue("Street").ToString

            strZIPCode = MapColAddress.GetValue("ZIPCode").ToString

            strMunicipality = MapColAddress.GetValue("Municipality").ToString

            lblName.Text = strName
            lblFirstName.Text = strFirstName1
            lblBirthplace.Text = strBirthPlace
            lblBirthdate.Text = strBirthDate
            lblGender.Text = strGender
            lblNat.Text = strNationality
            lblNatNr.Text = strNationalNumber

            lblStreet.Text = strStreet
            lblPostCode.Text = strZIPCode
            lblGemeente.Text = strMunicipality
            lblLand.Text = "België"

            'lblChipNr.Text = strChipNumber
            'lblCardNr.Text = strCardNumber

            'lblBegVal.Text = strBegVal.ToString
            'lblEndVal.Text = strEndVal.ToString

            'lblUitreikGemeente.Text = strIssuingMunicipality

            RetStatus = EIDlib1.GetPicture(MapColPicture, CertifCheck)

            bytes = DirectCast(MapColPicture.GetValue("Picture"), Byte())

            'ms = DirectCast(bytes, System.IO.MemoryStream)
            Dim ms As New System.IO.MemoryStream(bytes)

            pbFoto.Image = System.Drawing.Image.FromStream(ms)
            'Dim deelnemer = New EidData(strCardNumber, strChipNumber, strBegValDag, strBegVal, strBegValMaand, strBegValJaar, strEndValDag, strEndVal, strEndValMaand, strEndValJaar, strIssuingMunicipality, strName, strFirstName1, strBirthPlace, strBirthDate, strGender, strNationality, strNationalNumber, strStreet, strZIPCode, strMunicipality, bytes)

            Dim kaartGelezen = 1
            btnToevoegen.Enabled = True

        Catch ex As NullReferenceException
            btnToevoegen.Enabled = False
            MessageBox.Show("Gelieve een geldige kaart in de reader te plaatsen.", "Plaats een kaart", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToevoegen.Click
        If lblName.Text <> "" And lblFirstname.Text <> "" And lblBirthdate.Text <> "" And lblNat.Text <> "" And lblStreet.Text <> "" And lblPostcode.Text <> "" And lblGemeente.Text <> "" Then
            Dim strNaam = lblName.Text
            Dim strVoornaam = lblFirstname.Text
            Dim strGeboortedatum = lblBirthdate.Text
            Dim strGeboortedatum2 As String

            If strMode = "kaart" Then
                Dim strGeboorteJaar = strGeboortedatum.Substring(0, 4)
                Dim strGeboorteMaand = strGeboortedatum.Substring(4, 2)
                Dim strGeboorteDag = strGeboortedatum.Substring(6, 2)

                strGeboortedatum2 = strGeboorteDag & "/" & strGeboorteMaand & "/" & strGeboorteJaar
            Else
                strGeboortedatum2 = strGeboortedatum
            End If

            Dim strNationaliteit = lblNat.Text
            Dim strStraat = lblStreet.Text
            Dim strPostcode = lblPostcode.Text
            Dim strGemeente = lblGemeente.Text

            Dim strOpslaan As String

            If pbFoto.Image Is Nothing Then
                strOpslaan = ""
            Else
                Dim strVolledigeNaam = strNaam & " " & strVoornaam
                strOpslaan = "C:\Pasfotos\" & strVolledigeNaam & ".jpeg"
                pbFoto.Image.Save(strOpslaan, Drawing.Imaging.ImageFormat.Jpeg)
            End If
            Try
                Dim sqlQuery As String = "INSERT INTO tblLeden (Naam, Voornaam, Geboortedatum, Nationaliteit, Straat, Postcode, Gemeente, Foto) VALUES ('" & strNaam & "', '" & strVoornaam & "', '" & strGeboortedatum2 & "', '" & strNationaliteit & "', '" & strStraat & "', '" & strPostcode & "', '" & strGemeente & "', '" & strOpslaan & "')"
                Dim sqlCommand As New OleDbCommand

                With sqlCommand
                    .CommandText = sqlQuery
                    .Connection = conn
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Het nieuwe lid is toegevoegd aan het ledenbestand", "Toegevoegd", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Gelieve alle velden in te vullen!", "Alle velden invullen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub pbBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBack.Click
        Me.Close()
    End Sub

    Private Sub btnManueel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManueel.Click
        strMode = "manueel"
        btnToevoegen.Enabled = True

        lblBirthplace.Enabled = False
        lblGender.Enabled = False
        lblNatNr.Enabled = False
        lblLand.Enabled = False

        lblName.Text = ""
        lblFirstname.Text = ""
        lblBirthdate.Text = ""
        lblBirthplace.Text = ""
        lblGender.Text = ""
        lblNat.Text = "be"
        lblNatNr.Text = ""
        lblStreet.Text = ""
        lblPostcode.Text = ""
        lblGemeente.Text = ""
        lblLand.Text = ""

        pbFoto.Image = Nothing
    End Sub
End Class