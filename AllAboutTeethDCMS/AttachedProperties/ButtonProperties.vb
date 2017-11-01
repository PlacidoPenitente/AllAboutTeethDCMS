Public Class ButtonProperties
    Inherits DependencyObject

    Public Shared ReadOnly ImageProperty As DependencyProperty = DependencyProperty.RegisterAttached("Image", GetType(ImageSource), GetType(ButtonProperties), New PropertyMetadata(New ImageBrush().ImageSource))

    Public Shared Sub SetImage(ByVal button As DependencyObject, ByVal value As ImageSource)
        button.SetValue(ImageProperty, value)
    End Sub

    Public Shared Function GetImage(ByVal button As DependencyObject) As ImageSource
        Return button.GetValue(ImageProperty)
    End Function

    Public Shared ReadOnly SubImageProperty As DependencyProperty = DependencyProperty.RegisterAttached("SubImage", GetType(ImageSource), GetType(ButtonProperties), New PropertyMetadata(New ImageBrush().ImageSource))

    Public Shared Sub SetSubImage(ByVal button As DependencyObject, ByVal value As ImageSource)
        button.SetValue(SubImageProperty, value)
    End Sub

    Public Shared Function GetSubImage(ByVal button As DependencyObject) As ImageSource
        Return button.GetValue(SubImageProperty)
    End Function

End Class
