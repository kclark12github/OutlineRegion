''------------------------------------------------------------------------------
'' <copyright file="OutlineRegionFormat.vb" company="Microsoft">
''     Copyright (c) Microsoft.  All rights reserved.
'' </copyright>
''------------------------------------------------------------------------------

Imports System.ComponentModel.Composition
Imports System.Windows.Media
Imports Microsoft.VisualStudio.Text.Classification
Imports Microsoft.VisualStudio.Utilities

''' <summary>
''' Defines an editor format for our OutlineRegion type that has a purple background
''' and is underlined.
''' </summary>
<Export(GetType(EditorFormatDefinition))>
<ClassificationType(ClassificationTypeNames:="OutlineRegion")>
<Name("OutlineRegion")>
<UserVisible(True)>
<Order(After:=Priority.Default)>
Friend NotInheritable Class OutlineRegionFormat
    Inherits ClassificationFormatDefinition

    ''' <summary>
    ''' Initializes a new instance of the <see cref="OutlineRegionFormat"/> class.
    ''' </summary>
    Public Sub New()

        Me.DisplayName = "OutlineRegion"
        Me.BackgroundColor = Colors.BlueViolet
        Me.TextDecorations = System.Windows.TextDecorations.Underline

    End Sub

End Class
