Imports System.Data.SqlClient
Public Class FrmLogIn
    Dim cadenaConex As SqlConnection
    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    'Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
    '    Dim principal As New FrmPrincipal
    '    principal.Show()
    '    Me.Close()
    'End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtUsuario.Text <> "" And TxtContrase�a.Text <> "" Then
            Dim principal As New FrmPrincipal()
            principal.Show()
            Me.Close()
        Else
            MsgBox("Debes poner usuario y contrase�a")
        End If
    End Sub
    Private Sub FrmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New conexion
        Me.cadenaConex = conexion.conexion
    End Sub
End Class