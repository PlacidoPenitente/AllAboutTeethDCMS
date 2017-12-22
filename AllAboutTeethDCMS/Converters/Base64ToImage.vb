Imports System.Globalization
Imports System.IO

Public Class Base64ToImage
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        'Dim imageByte As Byte()
        'imageByte = System.Convert.FromBase64String(value)
        'Dim stream As MemoryStream = New MemoryStream(imageByte, 0, imageByte.Length)
        MessageBox.Show(value)
        Dim image As ImageSource = Nothing
        'Try
        '    image = System.Drawing.Image.FromStream(stream, True)
        'Catch ex As Exception

        'End Try
        image = New BitmapImage(New Uri(value, UriKind.RelativeOrAbsolute))
        Return image
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
