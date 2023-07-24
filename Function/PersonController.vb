Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity
Public Class PersonController

    Inherits Connection

    Dim cmd As New SqlCommand

    Public Function FnMostarPersons()
        Try

            FnConectado()
            cmd = New SqlCommand("SELECT * FROM person")
            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try

    End Function

    Public Function FnInsertarPersona(ByVal dts As Person) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("INSERT INTO person(identification,name,lastName,address,dateBirth,salary,favoriteNumber)VALUES(@IDENTIFICATION,@NAME,@LASTNAME,@ADDRESS,@DATEBIRTH,@SALARY,@FAVORITENUMBER)")

            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@IDENTIFICATION", dts.getIdentificacion)
            cmd.Parameters.AddWithValue("@NAME", dts.getName)
            cmd.Parameters.AddWithValue("@LASTNAME", dts.getLastName)
            cmd.Parameters.AddWithValue("@ADDRESS", dts.getAddress)
            cmd.Parameters.AddWithValue("@DATEBIRTH", dts.getDateBirth)
            cmd.Parameters.AddWithValue("@SALARY", dts.getSalary)
            cmd.Parameters.AddWithValue("@FAVORITENUMBER", dts.getFavoriteNumber)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()

        End Try
    End Function


    Public Function FnActualizarPersona(ByVal dts As Person) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("UPDATE person SET identification=@IDENTIFICATION,name=@NAME,lastName=@LASTNAME,address=@ADDRESS,dateBirth=@DATEBIRTH, salary=@SALARY,favoriteNumber=@FAVORITENUMBER WHERE id=@ID")

            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID", dts.getId)
            cmd.Parameters.AddWithValue("@IDENTIFICATION", dts.getIdentificacion)
            cmd.Parameters.AddWithValue("@NAME", dts.getName)
            cmd.Parameters.AddWithValue("@LASTNAME", dts.getLastName)
            cmd.Parameters.AddWithValue("@ADDRESS", dts.getAddress)
            cmd.Parameters.AddWithValue("@DATEBIRTH", dts.getDateBirth)
            cmd.Parameters.AddWithValue("@SALARY", dts.getSalary)
            cmd.Parameters.AddWithValue("@FAVORITENUMBER", dts.getFavoriteNumber)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()

        End Try
    End Function


    Public Function FnDeletePersona(ByVal dts As Person) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("DELETE FROM person WHERE id=@ID")

            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID", dts.getId)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()

        End Try
    End Function

    Public Function FnBuscarPersons(datoBusqueda As String)
        Try

            FnConectado()
            'cmd = New SqlCommand("SELECT * FROM person where identification like '%" & datoBusqueda & "%'")
            cmd = New SqlCommand("SELECT * FROM person where identification like @DATOBUSQUEDA")

            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@DATOBUSQUEDA", "%" + datoBusqueda + "%")


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try

    End Function
End Class
