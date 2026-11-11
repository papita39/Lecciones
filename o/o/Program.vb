Imports System.IO
Imports System.Net

Public Sub AbrirFotoAleatoriaDeInternet()
    ' 1. Lista de URLs de imágenes públicas (puedes cambiar o añadir las que quieras)
    Dim listaUrls As New List(Of String) From {
        "https://images.unsplash.com/photo-1574068469710-db3cf928a702",
        "https://images.unsplash.com/photo-1561948955-570b270e7c36",
        "https://images.unsplash.com/photo-1543466835-00a7907e9de1"
    }

    If listaUrls.Count > 0 Then
        ' 2. Seleccionar una URL de forma aleatoria
        Dim rnd As New Random()
        Dim indiceAleatorio As Integer = rnd.Next(0, listaUrls.Count)
        Dim urlSeleccionada As String = listaUrls(indiceAleatorio)

        ' 3. Crear una ruta temporal para guardar la imagen descargada
        Dim rutaTemporal As String = Path.Combine(Path.GetTempPath(), "foto_aleatoria_" & Guid.NewGuid().ToString() & ".jpg")

        Try
            ' 4. Descargar la imagen desde internet
            Using cliente As New WebClient()
                cliente.DownloadFile(urlSeleccionada, rutaTemporal)
            End If

    ' 5. Abrir la imagen descargada con el visor predeterminado de Windows
    Process.Start(New ProcessStartInfo(rutaTemporal) With {.UseShellExecute = True})

    Catch ex As Exception
    MessageBox.Show("Error al descargar o abrir la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    Else
    MessageBox.Show("La lista de enlaces está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End If
End Sub
