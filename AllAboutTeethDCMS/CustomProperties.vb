Imports System.Windows
Imports System.Windows.Media

Public Class CustomProperties
    Inherits DependencyObject

    Public Shared ReadOnly ImageProperty As DependencyProperty = DependencyProperty.RegisterAttached("Image", GetType(ImageSource), GetType(CustomProperties), New PropertyMetadata(New ImageBrush().ImageSource))

    Public Shared Sub SetImage(ByVal button As DependencyObject, ByVal value As ImageSource)
        button.SetValue(ImageProperty, value)
    End Sub

    Public Shared Function GetImage(ByVal button As DependencyObject) As ImageSource
        Return CType(button.GetValue(ImageProperty), ImageSource)
    End Function

    Public Shared ReadOnly VisibilityProperty As DependencyProperty = DependencyProperty.RegisterAttached("Visibility", GetType(Visibility), GetType(CustomProperties), New PropertyMetadata(Visibility.Visible))

    Public Shared Sub SetVisibility(ByVal element As System.Windows.DependencyObject, ByVal value As Visibility)
        element.SetValue(VisibilityProperty, value)
    End Sub

    Public Shared Function GetVisibility(ByVal element As DependencyObject) As Visibility
        Return CType(element.GetValue(VisibilityProperty), Visibility)
    End Function

    Public Shared ReadOnly LabelProperty As DependencyProperty = DependencyProperty.RegisterAttached("Label", GetType(String), GetType(CustomProperties), New PropertyMetadata(""))

    Public Shared Sub SetLabel(ByVal element As DependencyObject, ByVal value As String)
        element.SetValue(LabelProperty, value)
    End Sub

    Public Shared Function GetLabel(ByVal element As DependencyObject) As String
        Return CType(element.GetValue(LabelProperty), String)
    End Function

    Public Shared ReadOnly HintProperty As DependencyProperty = DependencyProperty.RegisterAttached("Hint", GetType(String), GetType(CustomProperties), New PropertyMetadata(""))

    Public Shared Sub SetHint(ByVal element As DependencyObject, ByVal value As String)
        element.SetValue(HintProperty, value)
    End Sub

    Public Shared Function GetHint(ByVal element As DependencyObject) As String
        Return CType(element.GetValue(HintProperty), String)
    End Function

End Class
