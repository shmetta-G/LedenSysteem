<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LidToevoegen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LidToevoegen))
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReadEid = New System.Windows.Forms.Button()
        Me.btnManueel = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.TextBox()
        Me.lblBirthdate = New System.Windows.Forms.TextBox()
        Me.lblBirthplace = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.TextBox()
        Me.lblNatNr = New System.Windows.Forms.TextBox()
        Me.lblNat = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.TextBox()
        Me.lblLand = New System.Windows.Forms.TextBox()
        Me.lblGemeente = New System.Windows.Forms.TextBox()
        Me.lblPostcode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToevoegen
        '
        Me.btnToevoegen.BackColor = System.Drawing.Color.ForestGreen
        Me.btnToevoegen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToevoegen.Font = New System.Drawing.Font("Calibri", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btnToevoegen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnToevoegen.Location = New System.Drawing.Point(668, 277)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(199, 50)
        Me.btnToevoegen.TabIndex = 144
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = False
        '
        'pbBack
        '
        Me.pbBack.Image = Global.Ledensysteem.My.Resources.Resources.back
        Me.pbBack.Location = New System.Drawing.Point(38, 504)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(50, 50)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBack.TabIndex = 143
        Me.pbBack.TabStop = False
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(689, 17)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(162, 182)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 142
        Me.pbFoto.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(33, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 26)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Land:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(33, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 26)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Gemeente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(33, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 26)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Postcode:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(33, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 26)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Straat:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(33, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 26)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Rijksregisternummer.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(33, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 26)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Nationaliteit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(33, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 26)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Geslacht:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(33, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 26)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Geboortedatum:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(33, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 26)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Geboorteplaats:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(33, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 26)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Voornaam:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(33, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 26)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Naam:"
        '
        'btnReadEid
        '
        Me.btnReadEid.BackColor = System.Drawing.Color.ForestGreen
        Me.btnReadEid.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnReadEid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadEid.Font = New System.Drawing.Font("Calibri", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btnReadEid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReadEid.Location = New System.Drawing.Point(668, 223)
        Me.btnReadEid.Name = "btnReadEid"
        Me.btnReadEid.Size = New System.Drawing.Size(199, 50)
        Me.btnReadEid.TabIndex = 119
        Me.btnReadEid.Text = "Lees kaart"
        Me.btnReadEid.UseVisualStyleBackColor = False
        '
        'btnManueel
        '
        Me.btnManueel.BackColor = System.Drawing.Color.ForestGreen
        Me.btnManueel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnManueel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManueel.Font = New System.Drawing.Font("Calibri", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btnManueel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnManueel.Location = New System.Drawing.Point(94, 504)
        Me.btnManueel.Name = "btnManueel"
        Me.btnManueel.Size = New System.Drawing.Size(199, 50)
        Me.btnManueel.TabIndex = 145
        Me.btnManueel.Text = "Manueel"
        Me.btnManueel.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(235, 17)
        Me.lblName.Multiline = True
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(256, 25)
        Me.lblName.TabIndex = 146
        '
        'lblFirstname
        '
        Me.lblFirstname.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(235, 43)
        Me.lblFirstname.Multiline = True
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(256, 25)
        Me.lblFirstname.TabIndex = 147
        '
        'lblBirthdate
        '
        Me.lblBirthdate.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.Location = New System.Drawing.Point(235, 95)
        Me.lblBirthdate.Multiline = True
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(256, 25)
        Me.lblBirthdate.TabIndex = 149
        '
        'lblBirthplace
        '
        Me.lblBirthplace.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthplace.Location = New System.Drawing.Point(235, 69)
        Me.lblBirthplace.Multiline = True
        Me.lblBirthplace.Name = "lblBirthplace"
        Me.lblBirthplace.Size = New System.Drawing.Size(256, 25)
        Me.lblBirthplace.TabIndex = 148
        '
        'lblStreet
        '
        Me.lblStreet.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(235, 223)
        Me.lblStreet.Multiline = True
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(256, 25)
        Me.lblStreet.TabIndex = 153
        '
        'lblNatNr
        '
        Me.lblNatNr.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNatNr.Location = New System.Drawing.Point(235, 173)
        Me.lblNatNr.Multiline = True
        Me.lblNatNr.Name = "lblNatNr"
        Me.lblNatNr.Size = New System.Drawing.Size(256, 25)
        Me.lblNatNr.TabIndex = 152
        '
        'lblNat
        '
        Me.lblNat.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNat.Location = New System.Drawing.Point(235, 147)
        Me.lblNat.Multiline = True
        Me.lblNat.Name = "lblNat"
        Me.lblNat.Size = New System.Drawing.Size(256, 25)
        Me.lblNat.TabIndex = 151
        '
        'lblGender
        '
        Me.lblGender.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(235, 121)
        Me.lblGender.Multiline = True
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(256, 25)
        Me.lblGender.TabIndex = 150
        '
        'lblLand
        '
        Me.lblLand.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLand.Location = New System.Drawing.Point(235, 301)
        Me.lblLand.Multiline = True
        Me.lblLand.Name = "lblLand"
        Me.lblLand.Size = New System.Drawing.Size(256, 25)
        Me.lblLand.TabIndex = 156
        '
        'lblGemeente
        '
        Me.lblGemeente.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGemeente.Location = New System.Drawing.Point(235, 275)
        Me.lblGemeente.Multiline = True
        Me.lblGemeente.Name = "lblGemeente"
        Me.lblGemeente.Size = New System.Drawing.Size(256, 25)
        Me.lblGemeente.TabIndex = 155
        '
        'lblPostcode
        '
        Me.lblPostcode.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostcode.Location = New System.Drawing.Point(235, 249)
        Me.lblPostcode.Multiline = True
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(256, 25)
        Me.lblPostcode.TabIndex = 154
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(494, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 19)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "(dd/mm/yyyy)"
        '
        'LidToevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 566)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblLand)
        Me.Controls.Add(Me.lblGemeente)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblNatNr)
        Me.Controls.Add(Me.lblNat)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.lblBirthplace)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnManueel)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReadEid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LidToevoegen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lid toevoegen"
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnToevoegen As System.Windows.Forms.Button
    Friend WithEvents pbBack As System.Windows.Forms.PictureBox
    Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReadEid As System.Windows.Forms.Button
    Friend WithEvents btnManueel As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblBirthdate As System.Windows.Forms.TextBox
    Friend WithEvents lblBirthplace As System.Windows.Forms.TextBox
    Friend WithEvents lblStreet As System.Windows.Forms.TextBox
    Friend WithEvents lblNatNr As System.Windows.Forms.TextBox
    Friend WithEvents lblNat As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.TextBox
    Friend WithEvents lblLand As System.Windows.Forms.TextBox
    Friend WithEvents lblGemeente As System.Windows.Forms.TextBox
    Friend WithEvents lblPostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
