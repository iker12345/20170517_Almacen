﻿Imports System.IO

Public Class index
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        administradorLogin.ShowDialog()
    End Sub

    Private Sub btnInstrucciones_Click(sender As Object, e As EventArgs) Handles btnInstrucciones.Click
        Dim file As New StreamReader("ficheros/intrucciones.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnMinijuego.Click
        Dim minijuego As New minijuego
        minijuego.ShowDialog()
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim login As New Login
        login.ShowDialog()

    End Sub
End Class
