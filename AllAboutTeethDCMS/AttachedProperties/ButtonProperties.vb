﻿Public Class ButtonProperties
    Inherits DependencyObject

    Public Shared ReadOnly ImageProperty As DependencyProperty = DependencyProperty.RegisterAttached("Image", GetType(ImageSource), GetType(ButtonProperties), New PropertyMetadata(New ImageBrush().ImageSource))

    Public Shared Sub SetImage(ByVal button As DependencyObject, ByVal value As ImageSource)
        button.SetValue(ImageProperty, value)
    End Sub

    Public Shared Function GetImage(ByVal button As DependencyObject) As ImageSource
        Return button.GetValue(ImageProperty)
    End Function

    Public Shared ReadOnly VisibilityProperty As DependencyProperty = DependencyProperty.RegisterAttached("Visibility", GetType(Visibility), GetType(ButtonProperties), New PropertyMetadata(Visibility.Visible))

    Public Shared Sub SetVisibility(ByVal ribbon As DependencyObject, ByVal value As Visibility)
        ribbon.SetValue(VisibilityProperty, value)
    End Sub

    Public Shared Function GetVisibility(ByVal ribbon As DependencyObject) As Visibility
        Return ribbon.GetValue(VisibilityProperty)
    End Function

End Class
