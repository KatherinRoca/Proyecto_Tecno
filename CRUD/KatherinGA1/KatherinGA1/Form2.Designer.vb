<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.nombre_txt = New System.Windows.Forms.TextBox()
        Me.correo_txt = New System.Windows.Forms.TextBox()
        Me.insertar_btn = New System.Windows.Forms.Button()
        Me.cargar_btn = New System.Windows.Forms.Button()
        Me.borrar_btn = New System.Windows.Forms.Button()
        Me.editar_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pais_txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_secretario = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(320, 44)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(349, 219)
        Me.DGV1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CORREO:"
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(150, 74)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(137, 20)
        Me.id_txt.TabIndex = 6
        '
        'nombre_txt
        '
        Me.nombre_txt.Location = New System.Drawing.Point(150, 115)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(137, 20)
        Me.nombre_txt.TabIndex = 7
        '
        'correo_txt
        '
        Me.correo_txt.Location = New System.Drawing.Point(150, 151)
        Me.correo_txt.Name = "correo_txt"
        Me.correo_txt.Size = New System.Drawing.Size(137, 20)
        Me.correo_txt.TabIndex = 8
        '
        'insertar_btn
        '
        Me.insertar_btn.Location = New System.Drawing.Point(43, 288)
        Me.insertar_btn.Name = "insertar_btn"
        Me.insertar_btn.Size = New System.Drawing.Size(75, 23)
        Me.insertar_btn.TabIndex = 11
        Me.insertar_btn.Text = "INSERTAR"
        Me.insertar_btn.UseVisualStyleBackColor = True
        '
        'cargar_btn
        '
        Me.cargar_btn.Location = New System.Drawing.Point(136, 288)
        Me.cargar_btn.Name = "cargar_btn"
        Me.cargar_btn.Size = New System.Drawing.Size(75, 23)
        Me.cargar_btn.TabIndex = 12
        Me.cargar_btn.Text = "CARGAR"
        Me.cargar_btn.UseVisualStyleBackColor = True
        '
        'borrar_btn
        '
        Me.borrar_btn.Location = New System.Drawing.Point(231, 288)
        Me.borrar_btn.Name = "borrar_btn"
        Me.borrar_btn.Size = New System.Drawing.Size(75, 23)
        Me.borrar_btn.TabIndex = 13
        Me.borrar_btn.Text = "BORRAR"
        Me.borrar_btn.UseVisualStyleBackColor = True
        '
        'editar_btn
        '
        Me.editar_btn.Location = New System.Drawing.Point(43, 332)
        Me.editar_btn.Name = "editar_btn"
        Me.editar_btn.Size = New System.Drawing.Size(75, 23)
        Me.editar_btn.TabIndex = 14
        Me.editar_btn.Text = "EDITAR"
        Me.editar_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PAIS:"
        '
        'pais_txt
        '
        Me.pais_txt.Location = New System.Drawing.Point(150, 187)
        Me.pais_txt.Name = "pais_txt"
        Me.pais_txt.Size = New System.Drawing.Size(137, 20)
        Me.pais_txt.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KatherinGA1.My.Resources.Resources.cerrar_el_simbolo_de_la_cruz_en_un_circulo
        Me.PictureBox1.Location = New System.Drawing.Point(651, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.KatherinGA1.My.Resources.Resources.flecha_izquierda
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.Location = New System.Drawing.Point(100, 10)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(333, 31)
        Me.lbl_admin.TabIndex = 20
        Me.lbl_admin.Text = "Bienvenido Administrador"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(100, 9)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(251, 31)
        Me.lbl_cliente.TabIndex = 21
        Me.lbl_cliente.Text = "Bienvenido Usuario"
        '
        'lbl_secretario
        '
        Me.lbl_secretario.AutoSize = True
        Me.lbl_secretario.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secretario.Location = New System.Drawing.Point(100, 7)
        Me.lbl_secretario.Name = "lbl_secretario"
        Me.lbl_secretario.Size = New System.Drawing.Size(278, 31)
        Me.lbl_secretario.TabIndex = 22
        Me.lbl_secretario.Text = "Bienvenido Secretario"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 391)
        Me.Controls.Add(Me.lbl_secretario)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.lbl_admin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pais_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.editar_btn)
        Me.Controls.Add(Me.borrar_btn)
        Me.Controls.Add(Me.cargar_btn)
        Me.Controls.Add(Me.insertar_btn)
        Me.Controls.Add(Me.correo_txt)
        Me.Controls.Add(Me.nombre_txt)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "V"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents id_txt As TextBox
    Friend WithEvents nombre_txt As TextBox
    Friend WithEvents correo_txt As TextBox
    Friend WithEvents insertar_btn As Button
    Friend WithEvents cargar_btn As Button
    Friend WithEvents borrar_btn As Button
    Friend WithEvents editar_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pais_txt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_admin As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_secretario As Label
End Class
