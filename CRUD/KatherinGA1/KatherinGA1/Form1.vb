
Public Class Form1
    'Variable para acceder al Public Sub y la funcion de la clase Conexion'
    Dim conexion As Conexion = New Conexion

    Private Sub Ingresar_btn_Click(sender As Object, e As EventArgs) Handles Ingresar_btn.Click
        'Variable para modificar objetos del form2'
        Dim f2 = Form2
        'Variable que almacenan las consultas para determinar el rol asociado a las credenciales'
        Dim verificar As String = "update Ingresar set Rol=Rol where Nombre='" + Nombre_txt.Text + "' and Contraseña='" + Contra_txt.Text + "' and Rol='Administrador'"
        Dim verificar2 As String = "update Ingresar set Rol=Rol where Nombre='" + Nombre_txt.Text + "' and contraseña='" + Contra_txt.Text + "' and Rol='Usuario'"
        Dim verificar3 As String = "update Ingresar set Rol=Rol where Nombre='" + Nombre_txt.Text + "' and Contraseña='" + Contra_txt.Text + "' and Rol='Secretario'"
        'Comprobacion enviado las variables de antes a la funcion Verificacion de la clase conexion'
        If conexion.Verificacion(verificar) Then
            Me.Hide()
            Form2.Show()
            f2.lbl_cliente.Visible = False
            f2.lbl_secretario.Visible = False
        ElseIf conexion.Verificacion(verificar2) Then
            Me.Hide()
            Form2.Show()
            f2.borrar_btn.Visible = False
            f2.editar_btn.Visible = False
            f2.insertar_btn.Visible = False
            f2.cargar_btn.Visible = False
            f2.Label1.Visible = False
            f2.Label3.Visible = False
            f2.Label4.Visible = False
            f2.id_txt.Visible = False
            f2.correo_txt.Visible = False
            f2.pais_txt.Visible = False
            f2.borrar_btn.Location = New Point(123, 123)
            f2.lbl_admin.Visible = False
            f2.lbl_secretario.Visible = False
        ElseIf conexion.Verificacion(verificar3) Then
            Me.Hide()
            Form2.Show()
            f2.lbl_cliente.Visible = False
            f2.lbl_admin.Visible = False
        Else
            MsgBox("Error")
        End If

        If conexion.Verificacion(verificar3) Then
            Form2.Show()
            f2.editar_btn.Visible = False
            f2.borrar_btn.Visible = False
            f2.lbl_cliente.Visible = False
            f2.lbl_admin.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
