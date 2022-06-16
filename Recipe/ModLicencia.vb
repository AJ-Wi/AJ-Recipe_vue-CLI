Imports System.Xml
Imports System.Management
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml

Module ModLicencia
    Public Const ArchivoLicenciaPredeterminado As String = "LicenciaCVCELL.lic"

    Public Enum EstatusLicencia
        LicenciaValida
        ArchivoLicenciaFaltante
        ArchivoLicenciaCorrupto
        FirmaNoValida
        AunNoLicenciada
        LicenciaExpirada
        VersionNoCoincidente
        LicenciaNoValida
        LicenciaEvaluacion
    End Enum

    Public Structure DetalleArchivoLicencia
        Public Estatus As EstatusLicencia
        Public Producto As String
        Public Licenciatario As String
        Public FechaLicencia As Date
        Public FechaExpiracion As Date
        Public VersionCubierta As String
        Public NumeroSerie As String
        Public DiasExpiracion As Integer
    End Structure

    Public Function ExaminarLicencia() As DetalleArchivoLicencia
        Dim Resultado As New DetalleArchivoLicencia
        Dim UsarRuta As String
        Dim ContenidoLicencia As XmlDocument
        Dim ClavePublica As RSA
        Dim DocumentoFirmado As SignedXml
        Dim NodosCoincidente As XmlNodeList
        Dim PartesVersion() As String
        Dim Contador As Integer
        Dim CompararParte As String
        Dim Dias As Integer

        Resultado.Estatus = EstatusLicencia.ArchivoLicenciaFaltante
        UsarRuta = My.Settings.UbicacionArchivoLicencia
        If UsarRuta = "" Then UsarRuta = My.Application.Info.DirectoryPath & "\" & ArchivoLicenciaPredeterminado
        If My.Computer.FileSystem.FileExists(UsarRuta) = False Then Return Resultado
        Resultado.Estatus = EstatusLicencia.ArchivoLicenciaCorrupto

        Try
            ContenidoLicencia = New XmlDocument()
            ContenidoLicencia.Load(UsarRuta)
        Catch ex As Exception
            ' ----- error silencioso.
            Return Resultado
        End Try

        ClavePublica = RSA.Create()
        ClavePublica.FromXmlString(My.Resources.ClavePublicaLicencia)
        Try
            DocumentoFirmado = New SignedXml(ContenidoLicencia)
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("Signature")
            DocumentoFirmado.LoadXml(CType(NodosCoincidente(0), XmlElement))
        Catch ex As Exception
            Return Resultado
        End Try

        If (DocumentoFirmado.CheckSignature(ClavePublica) = False) Then
            Resultado.Estatus = EstatusLicencia.FirmaNoValida
            Return Resultado
        End If

        Try
            ' ----- Obtener el nombre Producto.
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("Producto")
            Resultado.Producto = NodosCoincidente(0).InnerText

            ' ----- Obtener el nombre licenciatario.
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("Licenciatario")
            Resultado.Licenciatario = NodosCoincidente(0).InnerText

            ' ----- Obtener la fecha de la licencia.
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("FechaLicencia")
            Resultado.FechaLicencia = CDate(NodosCoincidente(0).InnerText)

            ' ----- Obtener la fecha de caducidad
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("FechaExpiracion")
            Resultado.FechaExpiracion = CDate(NodosCoincidente(0).InnerText)

            ' ----- Obtener el número de versión.
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("VersionCubierta")
            Resultado.VersionCubierta = NodosCoincidente(0).InnerText

            ' ----- Obtener el número de serie.
            NodosCoincidente = ContenidoLicencia.GetElementsByTagName("SerialDisco")
            Resultado.NumeroSerie = NodosCoincidente(0).InnerText

        Catch ex As Exception
            Return Resultado
        End Try

        If Resultado.Producto <> My.Application.Info.ProductName Then
            Resultado.Estatus = EstatusLicencia.LicenciaNoValida
            Return Resultado
        End If

        If (Resultado.FechaLicencia > Today) Then
            Resultado.Estatus = EstatusLicencia.AunNoLicenciada
            Return Resultado
        End If

        If (Resultado.FechaExpiracion < Today) Then
            Resultado.Estatus = EstatusLicencia.LicenciaExpirada
            Return Resultado
        End If

        PartesVersion = Split(Resultado.VersionCubierta, ".")
        For Contador = 0 To UBound(PartesVersion)
            If (IsNumeric(PartesVersion(Contador)) = True) Then

                Select Case Contador
                    Case 0 : CompararParte = CStr(My.Application.Info.Version.Major)
                    Case 1 : CompararParte = CStr(My.Application.Info.Version.Minor)
                    Case 2 : CompararParte = CStr(My.Application.Info.Version.Build)
                    Case 3 : CompararParte = CStr(My.Application.Info.Version.Revision)
                    Case Else
                        Return Resultado
                End Select

                If (Val(CompararParte) <> Val(PartesVersion(Contador))) Then
                    Resultado.Estatus = EstatusLicencia.VersionNoCoincidente
                    Return Resultado
                End If
            End If
        Next Contador

        Dias = CInt(DateDiff(DateInterval.Day, Resultado.FechaLicencia, Resultado.FechaExpiracion))
        If Dias <= 30 Then
            Resultado.DiasExpiracion = Dias
            Resultado.Estatus = EstatusLicencia.LicenciaEvaluacion
            Return Resultado
        End If

        If Resultado.Licenciatario <> My.Settings.NombreLicenciatario Then
            Resultado.Estatus = EstatusLicencia.LicenciaNoValida
            Return Resultado
        End If

        If Resultado.NumeroSerie <> My.Settings.NumeroSerialDD Then
            Resultado.Estatus = EstatusLicencia.LicenciaNoValida
            Return Resultado
        End If

        Resultado.Estatus = EstatusLicencia.LicenciaValida
        Return Resultado
    End Function

    Public Function SerialDD() As String

        Try

            Dim DiscoFisico As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")

            Return Trim(DiscoFisico.Properties("SerialNumber").Value.ToString)

        Catch x As Exception
            Errores(x)
            Return "00000000"
        End Try

    End Function

End Module
