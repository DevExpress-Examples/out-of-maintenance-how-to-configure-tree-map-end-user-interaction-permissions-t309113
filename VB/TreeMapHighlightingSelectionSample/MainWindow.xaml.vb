Imports System.Windows
Imports Dxtm = DevExpress.Xpf.TreeMap

Namespace TreeMapHighlightingSelectionSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class SelectionModeWrapper
        Public Property ModeName() As String
        Public Property Mode() As DevExpress.Xpf.TreeMap.SelectionMode
    End Class
End Namespace
