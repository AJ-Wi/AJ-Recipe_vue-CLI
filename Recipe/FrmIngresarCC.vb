Imports Recipe.BusinessLayer
Imports Recipe.Entities
Imports System.Net

Public Class FrmIngresarCC
    Private Enfermedades As EnfermedadesEntity
    Private Terapia As TerapiasEntity
    Private Dieta As DietasEntity
    Private Consejo As ConsejosEntity

    Private Sub FrmIngresarCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Ventana & " - " & My.Application.Info.Title

        Try

            If Ventana = "Nueva Enfermedad" Then
                LabelEnfermedad.Visible = True
                Enfermedad.Visible = True
                LabelVideo.Visible = True
                Video.Visible = True
                BuscarImagen.Visible = False
            ElseIf Ventana = "Nuevo Consejo" Then
                LabelEnfermedad.Visible = False
                Enfermedad.Visible = False
                LabelVideo.Text = "Ruta de Imagen"
                BuscarImagen.Visible = True
                LabelDescripcion.Location = LabelEnfermedad.Location
                Descripcion.Location = Enfermedad.Location
                LabelVideo.Location = New Point(12, LabelVideo.Location.Y - 39)
                Video.Location = New Point(12, Video.Location.Y - 39)
                Video.Width = Video.Width - 26
                Me.Size = New Size(719, 598)
            Else
                LabelEnfermedad.Visible = False
                Enfermedad.Visible = False
                LabelVideo.Visible = False
                Video.Visible = False
                BuscarImagen.Visible = False
                LabelDescripcion.Location = LabelEnfermedad.Location
                Descripcion.Location = Enfermedad.Location
                Me.Size = New Size(719, 552)
            End If

            If Nuevo = False Then

                Select Case Ventana
                    Case "Nueva Enfermedad"
                        Enfermedades = EnfermedadesBU.BuscarPorId(ID)
                        Enfermedad.Text = Enfermedades.Enfermedad
                        Descripcion.Text = Enfermedades.Medicamentos
                        Video.Text = Enfermedades.URLVideo
                    Case "Nueva Terapia"
                        Terapia = TerapiasBU.BuscarPorId(ID)
                        Descripcion.Text = Terapia.Terapia
                    Case "Nueva Dieta"
                        Dieta = DietasBU.BuscarPorId(ID)
                        Descripcion.Text = Dieta.Dieta
                    Case "Nuevo Consejo"
                        Consejo = ConsejosBU.BuscarPorId(ID)
                        Descripcion.Text = Consejo.Consejo
                        Video.Text = Consejo.RutaImagen
                End Select

                BtnEliminar.Enabled = True
                Guardar.Text = "Actualizar"
            Else
                BtnEliminar.Enabled = False
                Guardar.Text = "Guardar"
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        Try

            If Guardar.Text = "Nuevo" Then
                Dim x As Control
                For Each x In Me.Controls
                    If TypeOf x Is System.Windows.Forms.TextBox Then x.Text = ""
                    If TypeOf x Is System.Windows.Forms.RichTextBox Then x.Text = ""
                Next
                Me.Guardar.Text = "Guardar"
            Else
                MDIPrincipal.ProgresoGuardar()
                Select Case Ventana
                    Case "Nueva Enfermedad"
                        Enfermedades = New EnfermedadesEntity
                        Enfermedades.Enfermedad = Enfermedad.Text
                        Enfermedades.Medicamentos = Descripcion.Text
                        Enfermedades.URLVideo = Video.Text
                        If Guardar.Text = "Actualizar" Then Enfermedades.IDenfermedad = ID
                        Enfermedades = EnfermedadesBU.Guardar(Enfermedades)
                    Case "Nueva Terapia"
                        Terapia = New TerapiasEntity
                        Terapia.Terapia = Descripcion.Text
                        If Guardar.Text = "Actualizar" Then Terapia.IDterapia = ID
                        Terapia = TerapiasBU.Guardar(Terapia)
                    Case "Nueva Dieta"
                        Dieta = New DietasEntity
                        Dieta.Dieta = Descripcion.Text
                        If Guardar.Text = "Actualizar" Then Dieta.IDdieta = ID
                        Dieta = DietasBU.Guardar(Dieta)
                    Case "Nuevo Consejo"
                        Consejo = New ConsejosEntity
                        Consejo.Consejo = Descripcion.Text
                        Consejo.RutaImagen = Video.Text
                        If Guardar.Text = "Actualizar" Then Consejo.IDconsejo = ID
                        Consejo = ConsejosBU.Guardar(Consejo)
                End Select
                MDIPrincipal.BotonSubirBD.Visible = True
                Me.Guardar.Text = "Nuevo"
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub FrmIngresarCC_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ID = 0
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Try

            Select Case Ventana
                Case "Nueva Enfermedad"
                    EnfermedadesBU.EliminarPorID(ID)
                    Ventana = "Listar Enfermedad"
                Case "Nueva Terapia"
                    TerapiasBU.EliminarPorID(ID)
                    Ventana = "Listar Terapia"
                Case "Nueva Dieta"
                    DietasBU.EliminarPorID(ID)
                    Ventana = "Listar Dieta"
                Case "Nuevo Consejo"
                    ConsejosBU.EliminarPorID(ID)
                    Ventana = "Listar Consejo"
            End Select

            Nuevo = False
            FrmListar.MdiParent = MDIPrincipal
            FrmListar.Show()
            Me.Close()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub BuscarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarImagen.Click
        Try
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            openFileDialog.Filter = "Archivos de Imagenes (*.jpg, *.bmp, *.gif, *png)|*.jpg; *.bmp; *.gif; *png | Todas las Imagenes (*.*)|*.*"

            If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
                Dim fileName As String = openFileDialog.FileName
                Me.PictureBox1.Image = New Bitmap(fileName)
                Me.Video.Text = fileName
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Pegar()

        If Clipboard.ContainsData(DataFormats.Html) = True Then
            Dim Tmp As String = Clipboard.GetText.Trim
            Dim Imagen As ImagenHTML = Nothing

            Imagen = LeerHTML(Mid(CStr(Clipboard.GetData(DataFormats.Html)), InStr(CStr(Clipboard.GetData(DataFormats.Html)), "<html")))

            Dim Client As New WebClient

            Dim Destino As String = My.Application.Info.DirectoryPath & "\Imagenes\Consejos\" & Mid(Imagen.OrigenImagen, InStrRev(Imagen.OrigenImagen, "/") + 1)
            Me.Video.Text = Destino

            Client.DownloadFile(Imagen.OrigenImagen, Destino)
            Client.Dispose()

            PictureBox1.Load(Destino)


            'hasta aqui expandir el form y mostrar la imagen aparte

            If Imagen.ImagenInicio = True Then
                Clipboard.SetDataObject(PictureBox1.Image)
                Me.Descripcion.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap))
                Me.Descripcion.Text = vbCrLf & vbCrLf & Tmp
                Me.Descripcion.SelectionStart = Len(Me.Descripcion.Text)
            Else
                Me.Descripcion.Text = Tmp & vbCrLf & vbCrLf
                Clipboard.SetDataObject(PictureBox1.Image)
                Me.Descripcion.SelectionStart = Len(Me.Descripcion.Text)
                Me.Descripcion.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap))
            End If

        End If

    End Sub

    Private Function LeerHTML(ByVal DocumentoHTML As String) As ImagenHTML
        Dim Resultado As ImagenHTML = Nothing
        Dim ElementosHTML() As String = Nothing
        Dim Fragmento As String = Nothing
        Dim Posi As Integer = 0
        Dim i As Integer = 0

        Do While DocumentoHTML <> Nothing

            Fragmento = Mid(DocumentoHTML, 1, InStr(DocumentoHTML, ">"))

            If InStr(Fragmento, "<img") > 0 Then
                ReDim Preserve ElementosHTML(i)
                ElementosHTML(i) = Fragmento
                i += 1
            Else

                If InStr(Fragmento, "</") > 0 Then
                    Fragmento = Mid(Fragmento, 1, InStr(Fragmento, "</") - 1)
                ElseIf InStr(Fragmento, "<") > 0 Then
                    Fragmento = Mid(Fragmento, 1, InStr(Fragmento, "<") - 1).Trim
                End If

                If Fragmento <> Nothing Then
                    ReDim Preserve ElementosHTML(i)
                    ElementosHTML(i) = Fragmento
                    i += 1
                End If

            End If

            DocumentoHTML = Mid(DocumentoHTML, InStr(DocumentoHTML, ">") + 1)

        Loop

        For i = 0 To UBound(ElementosHTML) - 1
            If InStr(ElementosHTML(i), "<img") > 0 Then
                ElementosHTML(i) = Mid(ElementosHTML(i), InStr(ElementosHTML(i), "src=") + 5)
                ElementosHTML(i) = Mid(ElementosHTML(i), 1, InStr(ElementosHTML(i), """") - 1)
                Resultado.OrigenImagen = ElementosHTML(i)
                Posi = i + 1
                Exit For
            End If
        Next

        If Posi < UBound(ElementosHTML) / 2 Then
            Resultado.ImagenInicio = True
        Else
            Resultado.ImagenInicio = False
        End If

        Return Resultado
    End Function

    Private Structure ImagenHTML
        Dim OrigenImagen As String
        Dim ImagenInicio As Boolean
    End Structure

    Private Sub Descripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Descripcion.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            If Ventana = "Nuevo Consejo" Then
                Pegar()
            End If
        End If
    End Sub

End Class