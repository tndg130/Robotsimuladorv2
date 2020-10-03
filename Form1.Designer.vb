<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana))
        Me.Lbl_X = New System.Windows.Forms.Label()
        Me.Lbl_Y = New System.Windows.Forms.Label()
        Me.TB_X = New System.Windows.Forms.TextBox()
        Me.TB_Y = New System.Windows.Forms.TextBox()
        Me.BTN_Mover = New System.Windows.Forms.Button()
        Me.PB_Area = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSL_Teta1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Teta2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Teta3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Enviar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_BufferIn = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SP_Envio = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PB_Area2 = New System.Windows.Forms.PictureBox()
        Me.TB_Z = New System.Windows.Forms.TextBox()
        Me.Lbl_Z = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_BuscarConec = New System.Windows.Forms.Button()
        Me.CB_Puertos = New System.Windows.Forms.ComboBox()
        CType(Me.PB_Area, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PB_Area2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_X
        '
        Me.Lbl_X.AutoSize = True
        Me.Lbl_X.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_X.Location = New System.Drawing.Point(16, 37)
        Me.Lbl_X.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_X.Name = "Lbl_X"
        Me.Lbl_X.Size = New System.Drawing.Size(54, 17)
        Me.Lbl_X.TabIndex = 1
        Me.Lbl_X.Text = "Valor X"
        '
        'Lbl_Y
        '
        Me.Lbl_Y.AutoSize = True
        Me.Lbl_Y.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Y.Location = New System.Drawing.Point(16, 86)
        Me.Lbl_Y.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Y.Name = "Lbl_Y"
        Me.Lbl_Y.Size = New System.Drawing.Size(54, 17)
        Me.Lbl_Y.TabIndex = 2
        Me.Lbl_Y.Text = "Valor Y"
        '
        'TB_X
        '
        Me.TB_X.Location = New System.Drawing.Point(79, 33)
        Me.TB_X.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_X.Name = "TB_X"
        Me.TB_X.Size = New System.Drawing.Size(53, 22)
        Me.TB_X.TabIndex = 3
        Me.TB_X.Text = "35.7"
        '
        'TB_Y
        '
        Me.TB_Y.Location = New System.Drawing.Point(79, 82)
        Me.TB_Y.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_Y.Name = "TB_Y"
        Me.TB_Y.Size = New System.Drawing.Size(53, 22)
        Me.TB_Y.TabIndex = 4
        Me.TB_Y.Text = "35.7"
        '
        'BTN_Mover
        '
        Me.BTN_Mover.Location = New System.Drawing.Point(20, 166)
        Me.BTN_Mover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_Mover.Name = "BTN_Mover"
        Me.BTN_Mover.Size = New System.Drawing.Size(113, 28)
        Me.BTN_Mover.TabIndex = 5
        Me.BTN_Mover.Text = "Mover"
        Me.BTN_Mover.UseVisualStyleBackColor = True
        '
        'PB_Area
        '
        Me.PB_Area.Location = New System.Drawing.Point(153, 15)
        Me.PB_Area.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB_Area.Name = "PB_Area"
        Me.PB_Area.Size = New System.Drawing.Size(800, 492)
        Me.PB_Area.TabIndex = 6
        Me.PB_Area.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_Teta1, Me.TSSL_Teta2, Me.TSSL_Teta3, Me.TSSL_Enviar, Me.TSSL_BufferIn})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 716)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1363, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL_Teta1
        '
        Me.TSSL_Teta1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TSSL_Teta1.Name = "TSSL_Teta1"
        Me.TSSL_Teta1.Size = New System.Drawing.Size(45, 20)
        Me.TSSL_Teta1.Text = "Teta1"
        '
        'TSSL_Teta2
        '
        Me.TSSL_Teta2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TSSL_Teta2.Name = "TSSL_Teta2"
        Me.TSSL_Teta2.Size = New System.Drawing.Size(45, 20)
        Me.TSSL_Teta2.Text = "Teta2"
        '
        'TSSL_Teta3
        '
        Me.TSSL_Teta3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TSSL_Teta3.Name = "TSSL_Teta3"
        Me.TSSL_Teta3.Size = New System.Drawing.Size(45, 20)
        Me.TSSL_Teta3.Text = "Teta3"
        '
        'TSSL_Enviar
        '
        Me.TSSL_Enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TSSL_Enviar.Name = "TSSL_Enviar"
        Me.TSSL_Enviar.Size = New System.Drawing.Size(0, 20)
        '
        'TSSL_BufferIn
        '
        Me.TSSL_BufferIn.Name = "TSSL_BufferIn"
        Me.TSSL_BufferIn.Size = New System.Drawing.Size(67, 20)
        Me.TSSL_BufferIn.Text = "Entrada: "
        '
        'Timer
        '
        Me.Timer.Interval = 60
        '
        'PB_Area2
        '
        Me.PB_Area2.Location = New System.Drawing.Point(976, 15)
        Me.PB_Area2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB_Area2.Name = "PB_Area2"
        Me.PB_Area2.Size = New System.Drawing.Size(487, 492)
        Me.PB_Area2.TabIndex = 10
        Me.PB_Area2.TabStop = False
        '
        'TB_Z
        '
        Me.TB_Z.Location = New System.Drawing.Point(79, 129)
        Me.TB_Z.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_Z.Name = "TB_Z"
        Me.TB_Z.Size = New System.Drawing.Size(53, 22)
        Me.TB_Z.TabIndex = 12
        Me.TB_Z.Text = "35.7"
        '
        'Lbl_Z
        '
        Me.Lbl_Z.AutoSize = True
        Me.Lbl_Z.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Z.Location = New System.Drawing.Point(16, 133)
        Me.Lbl_Z.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Z.Name = "Lbl_Z"
        Me.Lbl_Z.Size = New System.Drawing.Size(54, 17)
        Me.Lbl_Z.TabIndex = 11
        Me.Lbl_Z.Text = "Valor Z"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(221, 518)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar1.Maximum = 200
        Me.TrackBar1.Minimum = -200
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(452, 56)
        Me.TrackBar1.TabIndex = 13
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(221, 580)
        Me.TrackBar2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar2.Maximum = 200
        Me.TrackBar2.Minimum = -200
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(452, 56)
        Me.TrackBar2.TabIndex = 13
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(221, 642)
        Me.TrackBar3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar3.Maximum = 200
        Me.TrackBar3.Minimum = -200
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(452, 56)
        Me.TrackBar3.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(187, 518)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(187, 580)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(187, 642)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Z"
        '
        'BTN_BuscarConec
        '
        Me.BTN_BuscarConec.Location = New System.Drawing.Point(20, 330)
        Me.BTN_BuscarConec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_BuscarConec.Name = "BTN_BuscarConec"
        Me.BTN_BuscarConec.Size = New System.Drawing.Size(100, 28)
        Me.BTN_BuscarConec.TabIndex = 15
        Me.BTN_BuscarConec.Text = "Buscar"
        Me.BTN_BuscarConec.UseVisualStyleBackColor = True
        '
        'CB_Puertos
        '
        Me.CB_Puertos.FormattingEnabled = True
        Me.CB_Puertos.Location = New System.Drawing.Point(20, 297)
        Me.CB_Puertos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_Puertos.Name = "CB_Puertos"
        Me.CB_Puertos.Size = New System.Drawing.Size(99, 24)
        Me.CB_Puertos.TabIndex = 16
        '
        'Ventana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1363, 741)
        Me.Controls.Add(Me.CB_Puertos)
        Me.Controls.Add(Me.BTN_BuscarConec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.TB_Z)
        Me.Controls.Add(Me.Lbl_Z)
        Me.Controls.Add(Me.PB_Area2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PB_Area)
        Me.Controls.Add(Me.BTN_Mover)
        Me.Controls.Add(Me.TB_Y)
        Me.Controls.Add(Me.TB_X)
        Me.Controls.Add(Me.Lbl_Y)
        Me.Controls.Add(Me.Lbl_X)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Ventana"
        Me.Text = "Perro Del Mal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PB_Area, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PB_Area2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_X As System.Windows.Forms.Label
    Friend WithEvents Lbl_Y As System.Windows.Forms.Label
    Friend WithEvents TB_X As System.Windows.Forms.TextBox
    Friend WithEvents TB_Y As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Mover As System.Windows.Forms.Button
    Friend WithEvents PB_Area As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSL_Teta1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Teta2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SP_Envio As System.IO.Ports.SerialPort
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents PB_Area2 As System.Windows.Forms.PictureBox
    Friend WithEvents TB_Z As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Z As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TSSL_Teta3 As ToolStripStatusLabel
    Friend WithEvents TSSL_Enviar As ToolStripStatusLabel
    Friend WithEvents BTN_BuscarConec As Button
    Friend WithEvents CB_Puertos As ComboBox
    Friend WithEvents TSSL_BufferIn As ToolStripStatusLabel
End Class
