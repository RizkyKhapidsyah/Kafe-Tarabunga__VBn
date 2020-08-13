<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKafe
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radPutih = New System.Windows.Forms.RadioButton()
        Me.radGandum = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkKejuKrim = New System.Windows.Forms.CheckBox()
        Me.chkMentega = New System.Windows.Forms.CheckBox()
        Me.chkBlueBerry = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radTidakKopi = New System.Windows.Forms.RadioButton()
        Me.radKopiBiasa = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPajak = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tombolHitung = New System.Windows.Forms.Button()
        Me.tombolReset = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGandum)
        Me.GroupBox1.Controls.Add(Me.radPutih)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Bagel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kafe Tarabunga"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radPutih
        '
        Me.radPutih.AutoSize = True
        Me.radPutih.Checked = True
        Me.radPutih.Location = New System.Drawing.Point(7, 19)
        Me.radPutih.Name = "radPutih"
        Me.radPutih.Size = New System.Drawing.Size(108, 17)
        Me.radPutih.TabIndex = 0
        Me.radPutih.TabStop = True
        Me.radPutih.Text = "Putih (Rp. 12500)"
        Me.ToolTip1.SetToolTip(Me.radPutih, "Klik di sini untuk memilih bagel putih")
        Me.radPutih.UseVisualStyleBackColor = True
        '
        'radGandum
        '
        Me.radGandum.AutoSize = True
        Me.radGandum.Location = New System.Drawing.Point(6, 43)
        Me.radGandum.Name = "radGandum"
        Me.radGandum.Size = New System.Drawing.Size(124, 17)
        Me.radGandum.TabIndex = 1
        Me.radGandum.TabStop = True
        Me.radGandum.Text = "Gandum (Rp. 15000)"
        Me.ToolTip1.SetToolTip(Me.radGandum, "Klik di sini untuk memilih bagel gandum")
        Me.radGandum.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPeach)
        Me.GroupBox2.Controls.Add(Me.chkRaspberry)
        Me.GroupBox2.Controls.Add(Me.chkBlueBerry)
        Me.GroupBox2.Controls.Add(Me.chkMentega)
        Me.GroupBox2.Controls.Add(Me.chkKejuKrim)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 173)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilih Topping"
        '
        'chkKejuKrim
        '
        Me.chkKejuKrim.AutoSize = True
        Me.chkKejuKrim.Location = New System.Drawing.Point(7, 20)
        Me.chkKejuKrim.Name = "chkKejuKrim"
        Me.chkKejuKrim.Size = New System.Drawing.Size(123, 17)
        Me.chkKejuKrim.TabIndex = 0
        Me.chkKejuKrim.Text = "Keju Krim (Rp. 5000)"
        Me.ToolTip1.SetToolTip(Me.chkKejuKrim, "Klik di sini untuk memilih krim keju")
        Me.chkKejuKrim.UseVisualStyleBackColor = True
        '
        'chkMentega
        '
        Me.chkMentega.AutoSize = True
        Me.chkMentega.Location = New System.Drawing.Point(7, 53)
        Me.chkMentega.Name = "chkMentega"
        Me.chkMentega.Size = New System.Drawing.Size(121, 17)
        Me.chkMentega.TabIndex = 1
        Me.chkMentega.Text = "Mentega (Rp. 2500)"
        Me.ToolTip1.SetToolTip(Me.chkMentega, "Klik di sini untuk memilih mentega")
        Me.chkMentega.UseVisualStyleBackColor = True
        '
        'chkBlueBerry
        '
        Me.chkBlueBerry.AutoSize = True
        Me.chkBlueBerry.Location = New System.Drawing.Point(7, 88)
        Me.chkBlueBerry.Name = "chkBlueBerry"
        Me.chkBlueBerry.Size = New System.Drawing.Size(149, 17)
        Me.chkBlueBerry.TabIndex = 2
        Me.chkBlueBerry.Text = "Selai Blueberry (Rp. 7500)"
        Me.ToolTip1.SetToolTip(Me.chkBlueBerry, "Klik di sini untuk memilih selai blueberry")
        Me.chkBlueBerry.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(6, 120)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(153, 17)
        Me.chkRaspberry.TabIndex = 3
        Me.chkRaspberry.Text = "Selai Raspberry (Rp. 7500)"
        Me.ToolTip1.SetToolTip(Me.chkRaspberry, "Klik di sini untuk memilih selai raspberry")
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(7, 150)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(128, 17)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Jeli Peach (Rp. 7500)"
        Me.ToolTip1.SetToolTip(Me.chkPeach, "Klik di sini untuk memilih jeli peach")
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox3.Controls.Add(Me.radCappuccino)
        Me.GroupBox3.Controls.Add(Me.radKopiBiasa)
        Me.GroupBox3.Controls.Add(Me.radTidakKopi)
        Me.GroupBox3.Location = New System.Drawing.Point(217, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 120)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mau Kopi?"
        '
        'radTidakKopi
        '
        Me.radTidakKopi.AutoSize = True
        Me.radTidakKopi.Location = New System.Drawing.Point(7, 20)
        Me.radTidakKopi.Name = "radTidakKopi"
        Me.radTidakKopi.Size = New System.Drawing.Size(52, 17)
        Me.radTidakKopi.TabIndex = 0
        Me.radTidakKopi.TabStop = True
        Me.radTidakKopi.Text = "Tidak"
        Me.ToolTip1.SetToolTip(Me.radTidakKopi, "Klik di sini untuk memilih tanpa kopi")
        Me.radTidakKopi.UseVisualStyleBackColor = True
        '
        'radKopiBiasa
        '
        Me.radKopiBiasa.AutoSize = True
        Me.radKopiBiasa.Location = New System.Drawing.Point(6, 43)
        Me.radKopiBiasa.Name = "radKopiBiasa"
        Me.radKopiBiasa.Size = New System.Drawing.Size(134, 17)
        Me.radKopiBiasa.TabIndex = 1
        Me.radKopiBiasa.TabStop = True
        Me.radKopiBiasa.Text = "Kopi Biasa (Rp. 12500)"
        Me.ToolTip1.SetToolTip(Me.radKopiBiasa, "Klik di sini untuk memilih kopi biasa")
        Me.radKopiBiasa.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(7, 66)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(141, 17)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Cappuccino (Rp. 20000)"
        Me.ToolTip1.SetToolTip(Me.radCappuccino, "Klik di sini untuk memilih cappuccino")
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(7, 89)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(137, 17)
        Me.radCafeAuLait.TabIndex = 3
        Me.radCafeAuLait.TabStop = True
        Me.radCafeAuLait.Text = "Cafe au lait (Rp. 17500)"
        Me.ToolTip1.SetToolTip(Me.radCafeAuLait, "Klik di sini untuk memilih cafe au lait")
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblPajak)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(217, 195)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(189, 124)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Harga "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(56, 21)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(120, 23)
        Me.lblSubtotal.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pajak"
        '
        'lblPajak
        '
        Me.lblPajak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPajak.Location = New System.Drawing.Point(56, 57)
        Me.lblPajak.Name = "lblPajak"
        Me.lblPajak.Size = New System.Drawing.Size(120, 23)
        Me.lblPajak.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(56, 93)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 23)
        Me.lblTotal.TabIndex = 5
        '
        'tombolHitung
        '
        Me.tombolHitung.Location = New System.Drawing.Point(12, 344)
        Me.tombolHitung.Name = "tombolHitung"
        Me.tombolHitung.Size = New System.Drawing.Size(128, 29)
        Me.tombolHitung.TabIndex = 5
        Me.tombolHitung.Text = "&Hitung Total"
        Me.ToolTip1.SetToolTip(Me.tombolHitung, "Klik di sini untuk menghitung biaya total pesanan")
        Me.tombolHitung.UseVisualStyleBackColor = True
        '
        'tombolReset
        '
        Me.tombolReset.Location = New System.Drawing.Point(152, 344)
        Me.tombolReset.Name = "tombolReset"
        Me.tombolReset.Size = New System.Drawing.Size(128, 29)
        Me.tombolReset.TabIndex = 6
        Me.tombolReset.Text = "&Reset Form"
        Me.ToolTip1.SetToolTip(Me.tombolReset, "Klik di sini untuk membersihkan form dan mulai dari awal")
        Me.tombolReset.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(296, 344)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(110, 29)
        Me.tombolKeluar.TabIndex = 7
        Me.tombolKeluar.Text = "&Keluar"
        Me.ToolTip1.SetToolTip(Me.tombolKeluar, "Klik di sini untuk keluar dari aplikasi")
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormKafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 385)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolReset)
        Me.Controls.Add(Me.tombolHitung)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormKafe"
        Me.Text = "Kalkulator Kafe Tarabunga"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radGandum As System.Windows.Forms.RadioButton
    Friend WithEvents radPutih As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPeach As System.Windows.Forms.CheckBox
    Friend WithEvents chkRaspberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlueBerry As System.Windows.Forms.CheckBox
    Friend WithEvents chkMentega As System.Windows.Forms.CheckBox
    Friend WithEvents chkKejuKrim As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radCafeAuLait As System.Windows.Forms.RadioButton
    Friend WithEvents radCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radKopiBiasa As System.Windows.Forms.RadioButton
    Friend WithEvents radTidakKopi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPajak As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tombolHitung As System.Windows.Forms.Button
    Friend WithEvents tombolReset As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
