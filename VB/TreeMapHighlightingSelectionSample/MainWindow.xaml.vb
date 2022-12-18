Imports System.Windows
Imports Dxtm = DevExpress.Xpf.TreeMap

Namespace TreeMapHighlightingSelectionSample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class SelectionModeWrapper

        Public Property ModeName As String

        Public Property Mode As Dxtm.SelectionMode
    End Class
End Namespace
