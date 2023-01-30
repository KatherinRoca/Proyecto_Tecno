Imports System.Data.SqlClient
Public Class Form2

    Dim con As SqlConnection = New SqlConnection(My.Settings.conexion)
    Dim sentencia, mensaje As String

    Public Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub insertar_btn_Click(sender As Object, e As EventArgs) Handles insertar_btn.Click
        sentencia = "Insert Datos VALUES('" + id_txt.Text + "', '" + nombre_txt.Text + "', '" + correo_txt.Text + "', '" + pais_txt.Text + "')"
        mensaje = "Registro insertado "
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Datos", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cargar_btn_Click(sender As Object, e As EventArgs) Handles cargar_btn.Click
        Try
            Dim da As New SqlDataAdapter("Select * from Datos", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub borrar_btn_Click(sender As Object, e As EventArgs) Handles borrar_btn.Click
        sentencia = "Delete Datos Where Id='" + id_txt.Text + "'"
        mensaje = "Registro eliminado "
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Datos", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editar_btn_Click(sender As Object, e As EventArgs) Handles editar_btn.Click
        sentencia = "Update Datos Set Nombre='" + nombre_txt.Text + "', Correo='" + correo_txt.Text + "', Pais='" + pais_txt.Text + "' Where Id='" + id_txt.Text + "'"
        mensaje = "Datos actualizados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Datos", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter("Select * from Datos Where Nombre='" + nombre_txt.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DGV1.DataSource = ds.Tables(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f = Form1
        f.Close()
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class