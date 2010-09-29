<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.mgc_min = New System.Windows.Forms.Label
        Me.mgc_max = New System.Windows.Forms.Label
        Me.mgc = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.maf_min = New System.Windows.Forms.Label
        Me.maf_max = New System.Windows.Forms.Label
        Me.map_min = New System.Windows.Forms.Label
        Me.map_max = New System.Windows.Forms.Label
        Me.egt_min = New System.Windows.Forms.Label
        Me.egt_max = New System.Windows.Forms.Label
        Me.afr_min = New System.Windows.Forms.Label
        Me.afr_max = New System.Windows.Forms.Label
        Me.rpm_min = New System.Windows.Forms.Label
        Me.rpm_max = New System.Windows.Forms.Label
        Me.rpm_bar = New System.Windows.Forms.ProgressBar
        Me.afr_bar = New System.Windows.Forms.ProgressBar
        Me.egt = New System.Windows.Forms.Label
        Me.maf = New System.Windows.Forms.Label
        Me.map = New System.Windows.Forms.Label
        Me.afr = New System.Windows.Forms.Label
        Me.rpm = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RPM_label = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.min_max_reset = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Received = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Status = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.mgc_min)
        Me.Panel1.Controls.Add(Me.mgc_max)
        Me.Panel1.Controls.Add(Me.mgc)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.maf_min)
        Me.Panel1.Controls.Add(Me.maf_max)
        Me.Panel1.Controls.Add(Me.map_min)
        Me.Panel1.Controls.Add(Me.map_max)
        Me.Panel1.Controls.Add(Me.egt_min)
        Me.Panel1.Controls.Add(Me.egt_max)
        Me.Panel1.Controls.Add(Me.afr_min)
        Me.Panel1.Controls.Add(Me.afr_max)
        Me.Panel1.Controls.Add(Me.rpm_min)
        Me.Panel1.Controls.Add(Me.rpm_max)
        Me.Panel1.Controls.Add(Me.rpm_bar)
        Me.Panel1.Controls.Add(Me.afr_bar)
        Me.Panel1.Controls.Add(Me.egt)
        Me.Panel1.Controls.Add(Me.maf)
        Me.Panel1.Controls.Add(Me.map)
        Me.Panel1.Controls.Add(Me.afr)
        Me.Panel1.Controls.Add(Me.rpm)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RPM_label)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 509)
        Me.Panel1.TabIndex = 0
        '
        'mgc_min
        '
        Me.mgc_min.AutoSize = True
        Me.mgc_min.BackColor = System.Drawing.Color.Black
        Me.mgc_min.ForeColor = System.Drawing.Color.Yellow
        Me.mgc_min.Location = New System.Drawing.Point(571, 435)
        Me.mgc_min.Name = "mgc_min"
        Me.mgc_min.Size = New System.Drawing.Size(31, 13)
        Me.mgc_min.TabIndex = 34
        Me.mgc_min.Text = "9999"
        '
        'mgc_max
        '
        Me.mgc_max.AutoSize = True
        Me.mgc_max.BackColor = System.Drawing.Color.Black
        Me.mgc_max.ForeColor = System.Drawing.Color.Yellow
        Me.mgc_max.Location = New System.Drawing.Point(580, 422)
        Me.mgc_max.Name = "mgc_max"
        Me.mgc_max.Size = New System.Drawing.Size(13, 13)
        Me.mgc_max.TabIndex = 33
        Me.mgc_max.Text = "0"
        '
        'mgc
        '
        Me.mgc.AutoSize = True
        Me.mgc.BackColor = System.Drawing.Color.Black
        Me.mgc.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mgc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mgc.Location = New System.Drawing.Point(642, 422)
        Me.mgc.Name = "mgc"
        Me.mgc.Size = New System.Drawing.Size(59, 46)
        Me.mgc.TabIndex = 32
        Me.mgc.Text = "---"
        Me.mgc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Olive
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.Location = New System.Drawing.Point(578, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 50)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "mg/c"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'maf_min
        '
        Me.maf_min.AutoSize = True
        Me.maf_min.BackColor = System.Drawing.Color.Black
        Me.maf_min.ForeColor = System.Drawing.Color.Yellow
        Me.maf_min.Location = New System.Drawing.Point(387, 435)
        Me.maf_min.Name = "maf_min"
        Me.maf_min.Size = New System.Drawing.Size(31, 13)
        Me.maf_min.TabIndex = 28
        Me.maf_min.Text = "9999"
        '
        'maf_max
        '
        Me.maf_max.AutoSize = True
        Me.maf_max.BackColor = System.Drawing.Color.Black
        Me.maf_max.ForeColor = System.Drawing.Color.Yellow
        Me.maf_max.Location = New System.Drawing.Point(396, 422)
        Me.maf_max.Name = "maf_max"
        Me.maf_max.Size = New System.Drawing.Size(13, 13)
        Me.maf_max.TabIndex = 27
        Me.maf_max.Text = "0"
        '
        'map_min
        '
        Me.map_min.AutoSize = True
        Me.map_min.BackColor = System.Drawing.Color.Black
        Me.map_min.ForeColor = System.Drawing.Color.Yellow
        Me.map_min.Location = New System.Drawing.Point(209, 435)
        Me.map_min.Name = "map_min"
        Me.map_min.Size = New System.Drawing.Size(31, 13)
        Me.map_min.TabIndex = 26
        Me.map_min.Text = "9999"
        '
        'map_max
        '
        Me.map_max.AutoSize = True
        Me.map_max.BackColor = System.Drawing.Color.Black
        Me.map_max.ForeColor = System.Drawing.Color.Yellow
        Me.map_max.Location = New System.Drawing.Point(218, 422)
        Me.map_max.Name = "map_max"
        Me.map_max.Size = New System.Drawing.Size(13, 13)
        Me.map_max.TabIndex = 25
        Me.map_max.Text = "0"
        '
        'egt_min
        '
        Me.egt_min.AutoSize = True
        Me.egt_min.BackColor = System.Drawing.Color.Black
        Me.egt_min.ForeColor = System.Drawing.Color.Yellow
        Me.egt_min.Location = New System.Drawing.Point(39, 435)
        Me.egt_min.Name = "egt_min"
        Me.egt_min.Size = New System.Drawing.Size(31, 13)
        Me.egt_min.TabIndex = 24
        Me.egt_min.Text = "9999"
        '
        'egt_max
        '
        Me.egt_max.AutoSize = True
        Me.egt_max.BackColor = System.Drawing.Color.Black
        Me.egt_max.ForeColor = System.Drawing.Color.Yellow
        Me.egt_max.Location = New System.Drawing.Point(48, 422)
        Me.egt_max.Name = "egt_max"
        Me.egt_max.Size = New System.Drawing.Size(13, 13)
        Me.egt_max.TabIndex = 23
        Me.egt_max.Text = "0"
        '
        'afr_min
        '
        Me.afr_min.AutoSize = True
        Me.afr_min.BackColor = System.Drawing.Color.Black
        Me.afr_min.ForeColor = System.Drawing.Color.Yellow
        Me.afr_min.Location = New System.Drawing.Point(387, 175)
        Me.afr_min.Name = "afr_min"
        Me.afr_min.Size = New System.Drawing.Size(31, 13)
        Me.afr_min.TabIndex = 22
        Me.afr_min.Text = "9999"
        '
        'afr_max
        '
        Me.afr_max.AutoSize = True
        Me.afr_max.BackColor = System.Drawing.Color.Black
        Me.afr_max.ForeColor = System.Drawing.Color.Yellow
        Me.afr_max.Location = New System.Drawing.Point(396, 162)
        Me.afr_max.Name = "afr_max"
        Me.afr_max.Size = New System.Drawing.Size(13, 13)
        Me.afr_max.TabIndex = 21
        Me.afr_max.Text = "0"
        '
        'rpm_min
        '
        Me.rpm_min.AutoSize = True
        Me.rpm_min.BackColor = System.Drawing.Color.Black
        Me.rpm_min.ForeColor = System.Drawing.Color.Yellow
        Me.rpm_min.Location = New System.Drawing.Point(31, 160)
        Me.rpm_min.Name = "rpm_min"
        Me.rpm_min.Size = New System.Drawing.Size(31, 13)
        Me.rpm_min.TabIndex = 20
        Me.rpm_min.Text = "9999"
        '
        'rpm_max
        '
        Me.rpm_max.AutoSize = True
        Me.rpm_max.BackColor = System.Drawing.Color.Black
        Me.rpm_max.ForeColor = System.Drawing.Color.Yellow
        Me.rpm_max.Location = New System.Drawing.Point(40, 147)
        Me.rpm_max.Name = "rpm_max"
        Me.rpm_max.Size = New System.Drawing.Size(13, 13)
        Me.rpm_max.TabIndex = 19
        Me.rpm_max.Text = "0"
        '
        'rpm_bar
        '
        Me.rpm_bar.BackColor = System.Drawing.Color.Black
        Me.rpm_bar.Location = New System.Drawing.Point(34, 230)
        Me.rpm_bar.Maximum = 8000
        Me.rpm_bar.Minimum = 600
        Me.rpm_bar.Name = "rpm_bar"
        Me.rpm_bar.Size = New System.Drawing.Size(287, 23)
        Me.rpm_bar.TabIndex = 18
        Me.rpm_bar.Value = 600
        '
        'afr_bar
        '
        Me.afr_bar.BackColor = System.Drawing.Color.Black
        Me.afr_bar.Location = New System.Drawing.Point(405, 230)
        Me.afr_bar.Name = "afr_bar"
        Me.afr_bar.Size = New System.Drawing.Size(308, 23)
        Me.afr_bar.TabIndex = 17
        '
        'egt
        '
        Me.egt.AutoSize = True
        Me.egt.BackColor = System.Drawing.Color.Black
        Me.egt.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.egt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.egt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.egt.Location = New System.Drawing.Point(76, 422)
        Me.egt.Name = "egt"
        Me.egt.Size = New System.Drawing.Size(59, 46)
        Me.egt.TabIndex = 9
        Me.egt.Text = "---"
        Me.egt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maf
        '
        Me.maf.AutoSize = True
        Me.maf.BackColor = System.Drawing.Color.Black
        Me.maf.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.maf.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.maf.Location = New System.Drawing.Point(424, 422)
        Me.maf.Name = "maf"
        Me.maf.Size = New System.Drawing.Size(59, 46)
        Me.maf.TabIndex = 7
        Me.maf.Text = "---"
        Me.maf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'map
        '
        Me.map.AutoSize = True
        Me.map.BackColor = System.Drawing.Color.Black
        Me.map.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.map.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.map.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.map.Location = New System.Drawing.Point(246, 422)
        Me.map.Name = "map"
        Me.map.Size = New System.Drawing.Size(59, 46)
        Me.map.TabIndex = 6
        Me.map.Text = "---"
        Me.map.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'afr
        '
        Me.afr.AutoSize = True
        Me.afr.BackColor = System.Drawing.Color.Black
        Me.afr.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.afr.Location = New System.Drawing.Point(472, 119)
        Me.afr.Name = "afr"
        Me.afr.Size = New System.Drawing.Size(141, 108)
        Me.afr.TabIndex = 5
        Me.afr.Text = "---"
        Me.afr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rpm
        '
        Me.rpm.AutoSize = True
        Me.rpm.BackColor = System.Drawing.SystemColors.WindowText
        Me.rpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rpm.Location = New System.Drawing.Point(95, 119)
        Me.rpm.Name = "rpm"
        Me.rpm.Size = New System.Drawing.Size(173, 108)
        Me.rpm.TabIndex = 4
        Me.rpm.Text = "----"
        Me.rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Olive
        Me.Label2.Location = New System.Drawing.Point(479, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 60)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AFR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RPM_label
        '
        Me.RPM_label.AutoSize = True
        Me.RPM_label.BackColor = System.Drawing.Color.Black
        Me.RPM_label.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPM_label.ForeColor = System.Drawing.Color.Olive
        Me.RPM_label.Location = New System.Drawing.Point(118, 32)
        Me.RPM_label.Name = "RPM_label"
        Me.RPM_label.Size = New System.Drawing.Size(134, 60)
        Me.RPM_label.TabIndex = 0
        Me.RPM_label.Text = "RPM"
        Me.RPM_label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Olive
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label9.Location = New System.Drawing.Point(53, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 50)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "EGT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Olive
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(404, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 50)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MAF"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Olive
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(214, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 50)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MAP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(754, 503)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'min_max_reset
        '
        Me.min_max_reset.Location = New System.Drawing.Point(462, 4)
        Me.min_max_reset.Name = "min_max_reset"
        Me.min_max_reset.Size = New System.Drawing.Size(75, 23)
        Me.min_max_reset.TabIndex = 30
        Me.min_max_reset.Text = "Reset"
        Me.min_max_reset.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(245, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Start logging"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Log"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(624, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Received
        '
        Me.Received.Location = New System.Drawing.Point(39, 7)
        Me.Received.Name = "Received"
        Me.Received.Size = New System.Drawing.Size(198, 20)
        Me.Received.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(543, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(701, 545)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(81, 18)
        Me.Status.TabIndex = 12
        Me.Status.Text = "started"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Received)
        Me.GroupBox1.Controls.Add(Me.min_max_reset)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 527)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 36)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lekonna Logger"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RPM_label As System.Windows.Forms.Label
    Friend WithEvents maf As System.Windows.Forms.Label
    Friend WithEvents map As System.Windows.Forms.Label
    Friend WithEvents afr As System.Windows.Forms.Label
    Friend WithEvents rpm As System.Windows.Forms.Label
    Friend WithEvents egt As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Received As System.Windows.Forms.TextBox
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents afr_bar As System.Windows.Forms.ProgressBar
    Friend WithEvents rpm_bar As System.Windows.Forms.ProgressBar
    Friend WithEvents afr_min As System.Windows.Forms.Label
    Friend WithEvents afr_max As System.Windows.Forms.Label
    Friend WithEvents rpm_min As System.Windows.Forms.Label
    Friend WithEvents rpm_max As System.Windows.Forms.Label
    Friend WithEvents maf_min As System.Windows.Forms.Label
    Friend WithEvents maf_max As System.Windows.Forms.Label
    Friend WithEvents map_min As System.Windows.Forms.Label
    Friend WithEvents map_max As System.Windows.Forms.Label
    Friend WithEvents egt_min As System.Windows.Forms.Label
    Friend WithEvents egt_max As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents min_max_reset As System.Windows.Forms.Button
    Friend WithEvents mgc_min As System.Windows.Forms.Label
    Friend WithEvents mgc_max As System.Windows.Forms.Label
    Friend WithEvents mgc As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
