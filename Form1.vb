Imports System.Net
Imports System.Reflection.Metadata
Imports Microsoft.Identity

Public Class Form1

    Dim dt As New DataTable

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Identificacion_Click(sender As Object, e As EventArgs) Handles Identificacion.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            'If String.IsNullOrEmpty(Me.txtIdentificacion.Text) Then
            '    MsgBox("Ingresar identificacion")
            '    Return
            'End If

            'If String.IsNullOrEmpty(Me.txtNombres.Text) Then
            '    MsgBox("Ingresar nombre")
            '    Return
            'End If

            Dim funciones As New PersonController

            Dim logica As New Person


            logica.getIdentificacion = txtIdentificacion.Text
            logica.getName = txtName.Text
            logica.getLastName = txtLastName.Text
            logica.getAddress = txtAdderss.Text
            logica.getDateBirth = txtDateBirth.Text
            logica.getSalary = txtSalary.Text
            logica.getFavoriteNumber = txtFavoriteNumber.Text



            If funciones.FnInsertarPersona(logica) Then
                MsgBox("Datos insertados Correctamente")
                'SubMostrar()
                SubLimpia()
                getPerson()
            Else
                MsgBox("No se guardo el registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub SubLimpia()
        txtIdentificacion.Clear()
        txtIdentificacion.Clear()
        txtName.Clear()
        txtLastName.Clear()
        txtAdderss.Clear()
        'txtDateBirth.Clear()
        txtSalary.Clear()
        txtFavoriteNumber.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPerson()
    End Sub

    Private Sub txtFavoriteNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFavoriteNumber.KeyPress

        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            'MessageBox.Show(“Please enter numbers only”)
            e.Handled = True
        End If

    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            'MessageBox.Show(“Please enter numbers only”)
            e.Handled = True
        End If
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        'e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        'Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'e.Handled = Not (Char.IsDigit(e.KeyChar) Or
        '             Asc(e.KeyChar) = 8 Or
        '             (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))

    End Sub

    Private Sub getPerson()
        Try

            Dim funciones As New PersonController

            dt = funciones.FnMostarPersons()

            If dt.Rows.Count <> 0 Then
                'DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = dt
                'System.Console.WriteLine(dt)
            Else
                DataGridView1.DataSource = Nothing
            End If

            utilTable()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub utilTable()
        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderText = "Register No."
            .Columns(1).HeaderText = "Identificacion"
            .Columns(2).HeaderText = "Nombres"
            .Columns(3).HeaderText = "Apellidos"
            .Columns(4).HeaderText = "Direccion"
            .Columns(5).HeaderText = "Fecha Nacimiento"
            .Columns(6).HeaderText = "Salario"
            .Columns(7).HeaderText = "Nº Favorito"
        End With


        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).Width = 60
        End With
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        txtId.Text = DataGridView1.Item(0, i).Value()
        txtIdentificacion.Text = DataGridView1.Item(1, i).Value()
        txtName.Text = DataGridView1.Item(2, i).Value()
        txtLastName.Text = DataGridView1.Item(3, i).Value()
        txtAdderss.Text = DataGridView1.Item(4, i).Value()
        txtDateBirth.Text = DataGridView1.Item(5, i).Value()
        txtSalary.Text = DataGridView1.Item(6, i).Value()
        txtFavoriteNumber.Text = DataGridView1.Item(7, i).Value()

    End Sub

    Private Sub btnClearInput_Click(sender As Object, e As EventArgs) Handles btnClearInput.Click
        SubLimpia()
        getPerson()
        txtBusqueda.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim funciones As New PersonController

            Dim logica As New Person


            logica.getId = txtId.Text
            logica.getIdentificacion = txtIdentificacion.Text
            logica.getName = txtName.Text
            logica.getLastName = txtLastName.Text
            logica.getAddress = txtAdderss.Text
            logica.getDateBirth = txtDateBirth.Text
            logica.getSalary = txtSalary.Text
            logica.getFavoriteNumber = txtFavoriteNumber.Text



            If funciones.FnActualizarPersona(logica) Then
                MsgBox("Datos actualizados Correctamente")
                'SubMostrar()
                SubLimpia()
                getPerson()
            Else
                MsgBox("No se actualiza el registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim funciones As New PersonController

            Dim logica As New Person


            logica.getId = txtId.Text


            If funciones.FnDeletePersona(logica) Then
                MsgBox("Datos borrado Correctamente")
                'SubMostrar()
                SubLimpia()
                getPerson()
            Else
                MsgBox("No se ha podido borrar el registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            DataGridView1.DataSource = Nothing
            DataGridView1.Refresh()

            Dim funciones As New PersonController

            dt = funciones.FnBuscarPersons(txtBusqueda.Text)

            If dt.Rows.Count <> 0 Then
                'DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = dt
                'System.Console.WriteLine(dt)
            Else
                DataGridView1.DataSource = Nothing
            End If

            utilTable()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    'Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

    '    Try

    '        Dim funciones As New PersonController

    '        dt = funciones.FnBuscarPersons(txtIdentificacion.Text)

    '        If dt.Rows.Count <> 0 Then
    '            'DataGridView1.AutoGenerateColumns = False
    '            DataGridView1.DataSource = dt
    '            'System.Console.WriteLine(dt)
    '        Else
    '            DataGridView1.DataSource = Nothing
    '        End If

    '        utilTable()


    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try
    'End Sub
End Class
