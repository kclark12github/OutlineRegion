''------------------------------------------------------------------------------
'' <copyright file="OutlineRegionClassificationDefinition.vb" company="Microsoft">
''     Copyright (c) Microsoft.  All rights reserved.
'' </copyright>
''------------------------------------------------------------------------------

Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.Text.Classification
Imports Microsoft.VisualStudio.Utilities

''' <summary>
''' Classification type definition export for OutlineRegion
''' </summary>
Friend Module OutlineRegionClassificationDefinition

    ''' <summary>
    ''' Defines the "OutlineRegion" classification type.
    ''' </summary>
    <Export(GetType(ClassificationTypeDefinition))>
    <Name("OutlineRegion")>
    Private OutlineRegionType As ClassificationTypeDefinition

End Module
