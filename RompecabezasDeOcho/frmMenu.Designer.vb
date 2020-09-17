<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lbTittle = New System.Windows.Forms.Label()
        Me.lbSubtitle = New System.Windows.Forms.Label()
        Me.btMode3x3 = New System.Windows.Forms.Button()
        Me.btMode4x4 = New System.Windows.Forms.Button()
        Me.lbMode3x3 = New System.Windows.Forms.Label()
        Me.lbMode4x4 = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTittle
        '
        Me.lbTittle.AutoSize = True
        Me.lbTittle.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTittle.Location = New System.Drawing.Point(20, 30)
        Me.lbTittle.Name = "lbTittle"
        Me.lbTittle.Size = New System.Drawing.Size(373, 35)
        Me.lbTittle.TabIndex = 0
        Me.lbTittle.Text = "Bienvenido a Rompecabezas de Ocho!"
        Me.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSubtitle
        '
        Me.lbSubtitle.AutoSize = True
        Me.lbSubtitle.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubtitle.Location = New System.Drawing.Point(45, 80)
        Me.lbSubtitle.Name = "lbSubtitle"
        Me.lbSubtitle.Size = New System.Drawing.Size(174, 19)
        Me.lbSubtitle.TabIndex = 1
        Me.lbSubtitle.Text = "Elija un modo de juego"
        '
        'btMode3x3
        '
        Me.btMode3x3.BackgroundImage = CType(resources.GetObject("btMode3x3.BackgroundImage"), System.Drawing.Image)
        Me.btMode3x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMode3x3.Location = New System.Drawing.Point(37, 165)
        Me.btMode3x3.Name = "btMode3x3"
        Me.btMode3x3.Size = New System.Drawing.Size(150, 136)
        Me.btMode3x3.TabIndex = 2
        Me.btMode3x3.UseVisualStyleBackColor = True
        '
        'btMode4x4
        '
        Me.btMode4x4.BackgroundImage = CType(resources.GetObject("btMode4x4.BackgroundImage"), System.Drawing.Image)
        Me.btMode4x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMode4x4.Location = New System.Drawing.Point(222, 165)
        Me.btMode4x4.Name = "btMode4x4"
        Me.btMode4x4.Size = New System.Drawing.Size(150, 136)
        Me.btMode4x4.TabIndex = 3
        Me.btMode4x4.UseVisualStyleBackColor = True
        '
        'lbMode3x3
        '
        Me.lbMode3x3.AutoSize = True
        Me.lbMode3x3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMode3x3.Location = New System.Drawing.Point(89, 124)
        Me.lbMode3x3.Name = "lbMode3x3"
        Me.lbMode3x3.Size = New System.Drawing.Size(44, 25)
        Me.lbMode3x3.TabIndex = 4
        Me.lbMode3x3.Text = "3 x 3"
        '
        'lbMode4x4
        '
        Me.lbMode4x4.AutoSize = True
        Me.lbMode4x4.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMode4x4.Location = New System.Drawing.Point(275, 124)
        Me.lbMode4x4.Name = "lbMode4x4"
        Me.lbMode4x4.Size = New System.Drawing.Size(46, 25)
        Me.lbMode4x4.TabIndex = 5
        Me.lbMode4x4.Text = "4 x 4"
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(162, 321)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(87, 23)
        Me.btExit.TabIndex = 6
        Me.btExit.Text = "Salir"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 359)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.lbMode4x4)
        Me.Controls.Add(Me.lbMode3x3)
        Me.Controls.Add(Me.btMode4x4)
        Me.Controls.Add(Me.btMode3x3)
        Me.Controls.Add(Me.lbSubtitle)
        Me.Controls.Add(Me.lbTittle)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTittle As Label
    Friend WithEvents lbSubtitle As Label
    Friend WithEvents btMode3x3 As Button
    Friend WithEvents btMode4x4 As Button
    Friend WithEvents lbMode3x3 As Label
    Friend WithEvents lbMode4x4 As Label
    Friend WithEvents btExit As Button
End Class
