Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class Connection

    Protected cnn As SqlConnection

    Public Function FnConectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-L9M21KB; Initial Catalog=BD_CRUD_LAT_SEG_VB; User ID=sa; Password=0960442792; Integrated Security=True; TrustServerCertificate=true")
            cnn.Open()
            System.Console.WriteLine("Te has conectado a la Base de Datos")
            Return True

        Catch ex As Exception
            MsgBox("ERROR al Conectarte a Base de Datos" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function


    Public Function FnDesconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR al Des-Conectarte a Base de Datos" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function

End Class
