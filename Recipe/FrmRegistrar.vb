Imports System.Xml
Imports Actualizar
Imports System.Text.RegularExpressions

Public Class FrmRegistrar
    Dim ArchivoDlic As String = My.Computer.FileSystem.CurrentDirectory & "\LicenciaCVCELL.dlic"

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Dim DatosDlic As XmlDocument

        Try

            If EmailValido(Me.CorreoTextBox.Text) = False Then
                MsgBox("Correo no Valido", vbCritical, "AVISO")
                Me.CorreoTextBox.Text = ""
                Me.CorreoTextBox.Focus()
                Exit Sub
            End If

            If Me.Label1.Text = "Solicitud de licencia enviada." Then
                Me.Close()
                Return
            End If

            Me.Aceptar.Enabled = True
            DatosDlic = ContenidoDlic()
            If (DatosDlic Is Nothing) = False Then
                Me.NombreTextBox.Visible = False
                Me.IDTextBox.Visible = False
                Me.Label2.Visible = False
                Me.Label3.Visible = False
                Me.CorreoTextBox.Visible = False
                Me.Label1.Location = New Point(20, 28)
                Me.Label1.Text = "Procesando Solicitud, por favor espere."
                Me.Refresh()
                DatosDlic.Save(ArchivoDlic)
                EnviarCorreo()
                Me.Label1.Text = "Solicitud de licencia enviada."
                My.Settings.NumeroSerialDD = SerialDD()
                My.Settings.NombreLicenciatario = Me.NombreTextBox.Text
                Me.Aceptar.Enabled = True
            End If


        Catch x As Exception
            Errores(x)
        Finally
            If My.Computer.FileSystem.DirectoryExists(ArchivoDlic) Then My.Computer.FileSystem.DeleteFile(ArchivoDlic)
        End Try
    End Sub

    Private Function ContenidoDlic() As XmlDocument
        Dim Resultado As XmlDocument
        Dim ContenidoCabecera As XmlDeclaration
        Dim ElementoRaiz As XmlElement
        Dim DatoElemento As XmlElement

        Try

            Resultado = New XmlDocument
            ContenidoCabecera = Resultado.CreateXmlDeclaration("1.0", Nothing, String.Empty)
            Resultado.InsertBefore(ContenidoCabecera, Resultado.DocumentElement)

            ElementoRaiz = Resultado.CreateElement("DatosLicencia")
            Resultado.InsertAfter(ElementoRaiz, ContenidoCabecera)

            DatoElemento = Resultado.CreateElement("Producto")
            DatoElemento.InnerText = Trim(My.Application.Info.ProductName)
            ElementoRaiz.AppendChild(DatoElemento)

            DatoElemento = Resultado.CreateElement("VersionCubierta")
            DatoElemento.InnerText = Trim(My.Application.Info.Version.ToString)
            ElementoRaiz.AppendChild(DatoElemento)

            DatoElemento = Resultado.CreateElement("Licenciatario")
            DatoElemento.InnerText = Trim(Me.NombreTextBox.Text)
            ElementoRaiz.AppendChild(DatoElemento)

            DatoElemento = Resultado.CreateElement("LicenciatarioID")
            DatoElemento.InnerText = Trim(Me.IDTextBox.Text)
            ElementoRaiz.AppendChild(DatoElemento)

            DatoElemento = Resultado.CreateElement("SerialDisco")
            DatoElemento.InnerText = Trim(SerialDD)
            ElementoRaiz.AppendChild(DatoElemento)

        Catch x As Exception
            Errores(x)
            Resultado = Nothing
        End Try

        Return Resultado
    End Function

    Private Sub EnviarCorreo()
        Dim archivo As New System.Net.Mail.Attachment(ArchivoDlic)
        Dim correo As New System.Net.Mail.MailMessage()
        Dim Servidor As New System.Net.Mail.SmtpClient

        Try

            correo.From = New System.Net.Mail.MailAddress(Me.CorreoTextBox.Text, Me.NombreTextBox.Text)
            correo.Subject = "Nueva solicitud de Licencia"
            correo.To.Add("tropaguararia28@gmail.com")
            correo.Attachments.Add(archivo)
            correo.Body = "Nueva solicitud de Licencia" & vbCrLf & _
                          "Realizada por: " & NombreTextBox.Text & vbCrLf & _
                          "Correo: " & Me.CorreoTextBox.Text

            Servidor.Host = "smtp.live.com"
            Servidor.Port = 587
            Servidor.EnableSsl = True
            Servidor.Credentials = New System.Net.NetworkCredential("cvcell@hotmail.com", Cifrado.Cifrar("	9!v}xq`rry}u"))
            Servidor.Send(correo)

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Public Function EmailValido(ByVal email As String) As Boolean

        Try

            If email = String.Empty Then Return False
            ' Compruebo si el formato de la dirección es correcto.
            Dim re As Regex = New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
            Dim m As Match = re.Match(email)
            Return (m.Captures.Count <> 0)

        Catch x As Exception
            Errores(x)
            Return False
        End Try

    End Function

End Class