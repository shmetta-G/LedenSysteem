<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ledensysteem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ledensysteem))
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLid = New System.Windows.Forms.Button()
        Me.txtVoornaam = New System.Windows.Forms.TextBox()
        Me.lblBezoekersTotaal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgLeden = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Achternaam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Voornaam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Geboortedatum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Straat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Postcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gemeente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blacklist = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLeden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(12, 419)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(94, 135)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 129
        Me.pbFoto.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ledensysteem.My.Resources.Resources.add2_256
        Me.PictureBox1.Location = New System.Drawing.Point(954, 504)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 128
        Me.PictureBox1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.ForestGreen
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Location = New System.Drawing.Point(902, 26)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(102, 33)
        Me.btnReset.TabIndex = 127
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.ForestGreen
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFilter.Location = New System.Drawing.Point(902, 88)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(102, 33)
        Me.btnFilter.TabIndex = 121
        Me.btnFilter.Text = "FILTER"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(498, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 33)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Naam"
        '
        'txtNaam
        '
        Me.txtNaam.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaam.Location = New System.Drawing.Point(584, 88)
        Me.txtNaam.Multiline = True
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(312, 33)
        Me.txtNaam.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 33)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Voornaam"
        '
        'btnLid
        '
        Me.btnLid.BackColor = System.Drawing.Color.ForestGreen
        Me.btnLid.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnLid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLid.Font = New System.Drawing.Font("Calibri", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btnLid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLid.Location = New System.Drawing.Point(18, 11)
        Me.btnLid.Name = "btnLid"
        Me.btnLid.Size = New System.Drawing.Size(474, 55)
        Me.btnLid.TabIndex = 124
        Me.btnLid.Text = "LID"
        Me.btnLid.UseVisualStyleBackColor = False
        '
        'txtVoornaam
        '
        Me.txtVoornaam.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoornaam.Location = New System.Drawing.Point(147, 88)
        Me.txtVoornaam.Multiline = True
        Me.txtVoornaam.Name = "txtVoornaam"
        Me.txtVoornaam.Size = New System.Drawing.Size(345, 33)
        Me.txtVoornaam.TabIndex = 119
        '
        'lblBezoekersTotaal
        '
        Me.lblBezoekersTotaal.AutoSize = True
        Me.lblBezoekersTotaal.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBezoekersTotaal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBezoekersTotaal.Location = New System.Drawing.Point(718, 23)
        Me.lblBezoekersTotaal.Name = "lblBezoekersTotaal"
        Me.lblBezoekersTotaal.Size = New System.Drawing.Size(0, 33)
        Me.lblBezoekersTotaal.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(498, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 33)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Bezoekers totaal:"
        '
        'dtgLeden
        '
        Me.dtgLeden.AllowUserToAddRows = False
        Me.dtgLeden.AllowUserToResizeColumns = False
        Me.dtgLeden.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgLeden.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgLeden.BackgroundColor = System.Drawing.Color.White
        Me.dtgLeden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLeden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtgLeden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgLeden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgLeden.ColumnHeadersHeight = 30
        Me.dtgLeden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgLeden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Achternaam, Me.Voornaam, Me.Geboortedatum, Me.Straat, Me.Postcode, Me.Gemeente, Me.Foto, Me.Blacklist})
        Me.dtgLeden.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dtgLeden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgLeden.Location = New System.Drawing.Point(12, 127)
        Me.dtgLeden.Name = "dtgLeden"
        Me.dtgLeden.ReadOnly = True
        Me.dtgLeden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLeden.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgLeden.RowHeadersVisible = False
        Me.dtgLeden.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dtgLeden.RowTemplate.Height = 30
        Me.dtgLeden.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgLeden.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgLeden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgLeden.Size = New System.Drawing.Size(992, 286)
        Me.dtgLeden.TabIndex = 118
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Achternaam
        '
        Me.Achternaam.HeaderText = "Naam"
        Me.Achternaam.Name = "Achternaam"
        Me.Achternaam.ReadOnly = True
        Me.Achternaam.Width = 250
        '
        'Voornaam
        '
        Me.Voornaam.HeaderText = "Voornaam"
        Me.Voornaam.Name = "Voornaam"
        Me.Voornaam.ReadOnly = True
        Me.Voornaam.Width = 213
        '
        'Geboortedatum
        '
        Me.Geboortedatum.HeaderText = "Geboortedatum"
        Me.Geboortedatum.Name = "Geboortedatum"
        Me.Geboortedatum.ReadOnly = True
        '
        'Straat
        '
        Me.Straat.HeaderText = "Straat"
        Me.Straat.Name = "Straat"
        Me.Straat.ReadOnly = True
        Me.Straat.Width = 150
        '
        'Postcode
        '
        Me.Postcode.HeaderText = "Postcode"
        Me.Postcode.Name = "Postcode"
        Me.Postcode.ReadOnly = True
        '
        'Gemeente
        '
        Me.Gemeente.HeaderText = "Gemeente"
        Me.Gemeente.Name = "Gemeente"
        Me.Gemeente.ReadOnly = True
        Me.Gemeente.Width = 119
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        Me.Foto.Visible = False
        '
        'Blacklist
        '
        Me.Blacklist.HeaderText = "Blacklist"
        Me.Blacklist.Name = "Blacklist"
        Me.Blacklist.ReadOnly = True
        Me.Blacklist.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Blacklist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Blacklist.Width = 60
        '
        'Ledensysteem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 566)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLid)
        Me.Controls.Add(Me.txtVoornaam)
        Me.Controls.Add(Me.lblBezoekersTotaal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgLeden)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ledensysteem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledensysteem"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLeden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNaam As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLid As System.Windows.Forms.Button
    Friend WithEvents txtVoornaam As System.Windows.Forms.TextBox
    Friend WithEvents lblBezoekersTotaal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgLeden As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Achternaam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Voornaam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Geboortedatum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Straat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Postcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gemeente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Foto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Blacklist As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
