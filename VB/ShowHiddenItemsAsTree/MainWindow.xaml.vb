Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace ShowHiddenItemsAsTree
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class HiddenItemTemplateSelector
        Inherits DataTemplateSelector

        Public Property ItemTemplate() As DataTemplate
        Public Property GroupTemplate() As DataTemplate
        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            If TypeOf item Is DevExpress.Xpf.Docking.LayoutGroup Then
                Return GroupTemplate
            End If
            If TypeOf item Is DevExpress.Xpf.Docking.BaseLayoutItem Then
                Return ItemTemplate
            End If
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class
End Namespace
