﻿Imports System.Runtime.InteropServices

Namespace ExtractLargeIconFromFile.Shell
    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
End Namespace
