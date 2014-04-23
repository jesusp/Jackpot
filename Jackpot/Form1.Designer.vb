<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnCredito = New System.Windows.Forms.Button()
        Me.BtnJugar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnApostar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Picture14 = New System.Windows.Forms.PictureBox()
        Me.Picture12 = New System.Windows.Forms.PictureBox()
        Me.Picture11 = New System.Windows.Forms.PictureBox()
        Me.Picture10 = New System.Windows.Forms.PictureBox()
        Me.Picture9 = New System.Windows.Forms.PictureBox()
        Me.Picture13 = New System.Windows.Forms.PictureBox()
        Me.Picture4 = New System.Windows.Forms.PictureBox()
        Me.Picture3 = New System.Windows.Forms.PictureBox()
        Me.Picture2 = New System.Windows.Forms.PictureBox()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.picture5 = New System.Windows.Forms.PictureBox()
        Me.picture6 = New System.Windows.Forms.PictureBox()
        Me.picture7 = New System.Windows.Forms.PictureBox()
        Me.picture8 = New System.Windows.Forms.PictureBox()
        Me.Lblapostar = New System.Windows.Forms.TextBox()
        Me.Lblsaldo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Picture14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCredito
        '
        Me.BtnCredito.Location = New System.Drawing.Point(52, 288)
        Me.BtnCredito.Name = "BtnCredito"
        Me.BtnCredito.Size = New System.Drawing.Size(96, 23)
        Me.BtnCredito.TabIndex = 4
        Me.BtnCredito.Text = "poner credito"
        Me.BtnCredito.UseVisualStyleBackColor = True
        '
        'BtnJugar
        '
        Me.BtnJugar.Location = New System.Drawing.Point(166, 288)
        Me.BtnJugar.Name = "BtnJugar"
        Me.BtnJugar.Size = New System.Drawing.Size(96, 23)
        Me.BtnJugar.TabIndex = 5
        Me.BtnJugar.Text = "Jugar"
        Me.BtnJugar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(290, 288)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(49, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Credito disponible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(83, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apuesta"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'BtnApostar
        '
        Me.BtnApostar.Location = New System.Drawing.Point(247, 229)
        Me.BtnApostar.Name = "BtnApostar"
        Me.BtnApostar.Size = New System.Drawing.Size(106, 23)
        Me.BtnApostar.TabIndex = 15
        Me.BtnApostar.Text = "Cambiar apuesta"
        Me.BtnApostar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Picture14)
        Me.GroupBox1.Controls.Add(Me.Picture12)
        Me.GroupBox1.Controls.Add(Me.Picture11)
        Me.GroupBox1.Controls.Add(Me.Picture10)
        Me.GroupBox1.Controls.Add(Me.Picture9)
        Me.GroupBox1.Controls.Add(Me.Picture13)
        Me.GroupBox1.Location = New System.Drawing.Point(489, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 303)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ganancia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(258, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "apuesta x 24"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(258, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "apuesta x 20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(258, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "apuesta x 16"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(79, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "apuesta x 12"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(79, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "apuesta x 8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(79, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "apuesta x 4"
        '
        'Picture14
        '
        Me.Picture14.Image = Global.Jackpot.My.Resources.Resources.ESTRELLA
        Me.Picture14.Location = New System.Drawing.Point(184, 202)
        Me.Picture14.Name = "Picture14"
        Me.Picture14.Size = New System.Drawing.Size(51, 82)
        Me.Picture14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture14.TabIndex = 5
        Me.Picture14.TabStop = False
        '
        'Picture12
        '
        Me.Picture12.Image = Global.Jackpot.My.Resources.Resources.bar_bar_bar_bar
        Me.Picture12.Location = New System.Drawing.Point(184, 19)
        Me.Picture12.Name = "Picture12"
        Me.Picture12.Size = New System.Drawing.Size(51, 82)
        Me.Picture12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture12.TabIndex = 4
        Me.Picture12.TabStop = False
        '
        'Picture11
        '
        Me.Picture11.Image = Global.Jackpot.My.Resources.Resources.bar_bar_bar
        Me.Picture11.Location = New System.Drawing.Point(6, 202)
        Me.Picture11.Name = "Picture11"
        Me.Picture11.Size = New System.Drawing.Size(51, 82)
        Me.Picture11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture11.TabIndex = 3
        Me.Picture11.TabStop = False
        '
        'Picture10
        '
        Me.Picture10.ErrorImage = Global.Jackpot.My.Resources.Resources.x4
        Me.Picture10.Image = Global.Jackpot.My.Resources.Resources.bar_bar
        Me.Picture10.Location = New System.Drawing.Point(6, 108)
        Me.Picture10.Name = "Picture10"
        Me.Picture10.Size = New System.Drawing.Size(51, 82)
        Me.Picture10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture10.TabIndex = 2
        Me.Picture10.TabStop = False
        '
        'Picture9
        '
        Me.Picture9.ErrorImage = Global.Jackpot.My.Resources.Resources.x3
        Me.Picture9.Image = Global.Jackpot.My.Resources.Resources.bar
        Me.Picture9.Location = New System.Drawing.Point(6, 19)
        Me.Picture9.Name = "Picture9"
        Me.Picture9.Size = New System.Drawing.Size(51, 82)
        Me.Picture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture9.TabIndex = 1
        Me.Picture9.TabStop = False
        '
        'Picture13
        '
        Me.Picture13.Image = Global.Jackpot.My.Resources.Resources._7
        Me.Picture13.Location = New System.Drawing.Point(184, 108)
        Me.Picture13.Name = "Picture13"
        Me.Picture13.Size = New System.Drawing.Size(51, 82)
        Me.Picture13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture13.TabIndex = 0
        Me.Picture13.TabStop = False
        '
        'Picture4
        '
        Me.Picture4.ErrorImage = Global.Jackpot.My.Resources.Resources.bar_bar_bar_bar
        Me.Picture4.Image = Global.Jackpot.My.Resources.Resources.empty
        Me.Picture4.Location = New System.Drawing.Point(380, 27)
        Me.Picture4.Name = "Picture4"
        Me.Picture4.Size = New System.Drawing.Size(103, 152)
        Me.Picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture4.TabIndex = 3
        Me.Picture4.TabStop = False
        '
        'Picture3
        '
        Me.Picture3.ErrorImage = Global.Jackpot.My.Resources.Resources.bar_bar_bar
        Me.Picture3.Image = Global.Jackpot.My.Resources.Resources.bar_bar_bar
        Me.Picture3.Location = New System.Drawing.Point(262, 27)
        Me.Picture3.Name = "Picture3"
        Me.Picture3.Size = New System.Drawing.Size(103, 152)
        Me.Picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture3.TabIndex = 2
        Me.Picture3.TabStop = False
        '
        'Picture2
        '
        Me.Picture2.ErrorImage = Global.Jackpot.My.Resources.Resources.bar_bar
        Me.Picture2.Image = Global.Jackpot.My.Resources.Resources.bar_bar
        Me.Picture2.Location = New System.Drawing.Point(144, 27)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.Size = New System.Drawing.Size(103, 152)
        Me.Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture2.TabIndex = 1
        Me.Picture2.TabStop = False
        '
        'Picture1
        '
        Me.Picture1.ErrorImage = Global.Jackpot.My.Resources.Resources.bar
        Me.Picture1.Image = Global.Jackpot.My.Resources.Resources.bar
        Me.Picture1.Location = New System.Drawing.Point(26, 27)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(103, 152)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 0
        Me.Picture1.TabStop = False
        '
        'picture5
        '
        Me.picture5.ErrorImage = Global.Jackpot.My.Resources.Resources._7
        Me.picture5.Image = Global.Jackpot.My.Resources.Resources.giro
        Me.picture5.Location = New System.Drawing.Point(26, 27)
        Me.picture5.Name = "picture5"
        Me.picture5.Size = New System.Drawing.Size(103, 152)
        Me.picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture5.TabIndex = 11
        Me.picture5.TabStop = False
        '
        'picture6
        '
        Me.picture6.ErrorImage = Global.Jackpot.My.Resources.Resources.ESTRELLA
        Me.picture6.Image = Global.Jackpot.My.Resources.Resources.giro
        Me.picture6.Location = New System.Drawing.Point(144, 27)
        Me.picture6.Name = "picture6"
        Me.picture6.Size = New System.Drawing.Size(103, 152)
        Me.picture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture6.TabIndex = 12
        Me.picture6.TabStop = False
        '
        'picture7
        '
        Me.picture7.ErrorImage = Global.Jackpot.My.Resources.Resources.empty
        Me.picture7.Image = Global.Jackpot.My.Resources.Resources.giro
        Me.picture7.Location = New System.Drawing.Point(262, 27)
        Me.picture7.Name = "picture7"
        Me.picture7.Size = New System.Drawing.Size(103, 152)
        Me.picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture7.TabIndex = 13
        Me.picture7.TabStop = False
        '
        'picture8
        '
        Me.picture8.ErrorImage = Global.Jackpot.My.Resources.Resources.x2
        Me.picture8.Image = Global.Jackpot.My.Resources.Resources.giro
        Me.picture8.Location = New System.Drawing.Point(380, 27)
        Me.picture8.Name = "picture8"
        Me.picture8.Size = New System.Drawing.Size(103, 152)
        Me.picture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture8.TabIndex = 14
        Me.picture8.TabStop = False
        '
        'Lblapostar
        '
        Me.Lblapostar.BackColor = System.Drawing.SystemColors.Desktop
        Me.Lblapostar.ForeColor = System.Drawing.SystemColors.Window
        Me.Lblapostar.Location = New System.Drawing.Point(144, 252)
        Me.Lblapostar.Name = "Lblapostar"
        Me.Lblapostar.Size = New System.Drawing.Size(44, 20)
        Me.Lblapostar.TabIndex = 18
        Me.Lblapostar.Text = "1"
        '
        'Lblsaldo
        '
        Me.Lblsaldo.AutoSize = True
        Me.Lblsaldo.BackColor = System.Drawing.SystemColors.ControlText
        Me.Lblsaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblsaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lblsaldo.Location = New System.Drawing.Point(145, 221)
        Me.Lblsaldo.Name = "Lblsaldo"
        Me.Lblsaldo.Size = New System.Drawing.Size(15, 15)
        Me.Lblsaldo.TabIndex = 19
        Me.Lblsaldo.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(844, 342)
        Me.Controls.Add(Me.Lblsaldo)
        Me.Controls.Add(Me.Lblapostar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnApostar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnJugar)
        Me.Controls.Add(Me.BtnCredito)
        Me.Controls.Add(Me.Picture4)
        Me.Controls.Add(Me.Picture3)
        Me.Controls.Add(Me.Picture2)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.picture5)
        Me.Controls.Add(Me.picture6)
        Me.Controls.Add(Me.picture7)
        Me.Controls.Add(Me.picture8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "JPC's Jackpot "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Picture14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picture2 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture3 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture4 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCredito As System.Windows.Forms.Button
    Friend WithEvents BtnJugar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picture5 As System.Windows.Forms.PictureBox
    Friend WithEvents picture6 As System.Windows.Forms.PictureBox
    Friend WithEvents picture7 As System.Windows.Forms.PictureBox
    Friend WithEvents picture8 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BtnApostar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Picture14 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture12 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture11 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture10 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture9 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lblapostar As System.Windows.Forms.TextBox
    Friend WithEvents Lblsaldo As System.Windows.Forms.Label

End Class
