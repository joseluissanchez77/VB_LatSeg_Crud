<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        txtBusqueda = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        txtId = New TextBox()
        txtDateBirth = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtFavoriteNumber = New TextBox()
        txtSalary = New TextBox()
        txtAdderss = New TextBox()
        txtLastName = New TextBox()
        txtName = New TextBox()
        Label2 = New Label()
        txtIdentificacion = New TextBox()
        Identificacion = New Label()
        GroupBox3 = New GroupBox()
        btnClearInput = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnBuscar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 289)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(659, 121)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(txtBusqueda)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(650, 46)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar"
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(230, 15)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(287, 23)
        txtBusqueda.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 15)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese dato de busqueda Identificacion"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtId)
        GroupBox2.Controls.Add(txtDateBirth)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtFavoriteNumber)
        GroupBox2.Controls.Add(txtSalary)
        GroupBox2.Controls.Add(txtAdderss)
        GroupBox2.Controls.Add(txtLastName)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtIdentificacion)
        GroupBox2.Controls.Add(Identificacion)
        GroupBox2.Location = New Point(12, 66)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(650, 162)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos Personales"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(450, 124)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 15
        txtId.Visible = False
        ' 
        ' txtDateBirth
        ' 
        txtDateBirth.Format = DateTimePickerFormat.Short
        txtDateBirth.Location = New Point(451, 30)
        txtDateBirth.Name = "txtDateBirth"
        txtDateBirth.Size = New Size(193, 23)
        txtDateBirth.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(342, 88)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 15)
        Label7.TabIndex = 13
        Label7.Text = "Numero favorito"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(342, 59)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 12
        Label6.Text = "Salario"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(342, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 15)
        Label5.TabIndex = 11
        Label5.Text = "Fecha Nacimiento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 10
        Label4.Text = "Direccion"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 9
        Label3.Text = "Apellidos"
        ' 
        ' txtFavoriteNumber
        ' 
        txtFavoriteNumber.Location = New Point(451, 85)
        txtFavoriteNumber.Name = "txtFavoriteNumber"
        txtFavoriteNumber.Size = New Size(193, 23)
        txtFavoriteNumber.TabIndex = 8
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(451, 56)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(193, 23)
        txtSalary.TabIndex = 7
        ' 
        ' txtAdderss
        ' 
        txtAdderss.Location = New Point(91, 114)
        txtAdderss.Name = "txtAdderss"
        txtAdderss.Size = New Size(193, 23)
        txtAdderss.TabIndex = 5
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(91, 85)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(193, 23)
        txtLastName.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(91, 56)
        txtName.Name = "txtName"
        txtName.Size = New Size(193, 23)
        txtName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nombres"
        ' 
        ' txtIdentificacion
        ' 
        txtIdentificacion.Location = New Point(91, 27)
        txtIdentificacion.Name = "txtIdentificacion"
        txtIdentificacion.Size = New Size(193, 23)
        txtIdentificacion.TabIndex = 1
        ' 
        ' Identificacion
        ' 
        Identificacion.AutoSize = True
        Identificacion.Location = New Point(6, 30)
        Identificacion.Name = "Identificacion"
        Identificacion.Size = New Size(79, 15)
        Identificacion.TabIndex = 0
        Identificacion.Text = "Identificacion"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnClearInput)
        GroupBox3.Controls.Add(btnEliminar)
        GroupBox3.Controls.Add(btnEditar)
        GroupBox3.Controls.Add(btnGuardar)
        GroupBox3.Location = New Point(12, 234)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(650, 49)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Acciones"
        ' 
        ' btnClearInput
        ' 
        btnClearInput.Location = New Point(421, 20)
        btnClearInput.Name = "btnClearInput"
        btnClearInput.Size = New Size(125, 23)
        btnClearInput.TabIndex = 3
        btnClearInput.Text = "Limpiar"
        btnClearInput.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.LightCoral
        btnEliminar.Location = New Point(290, 20)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(125, 23)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.Cyan
        btnEditar.Location = New Point(159, 20)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(125, 23)
        btnEditar.TabIndex = 1
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnGuardar.Location = New Point(28, 20)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(125, 23)
        btnGuardar.TabIndex = 0
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(569, 14)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(683, 422)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Identificacion As Label
    Friend WithEvents btnClearInput As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFavoriteNumber As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAdderss As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDateBirth As DateTimePicker
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnBuscar As Button
End Class
