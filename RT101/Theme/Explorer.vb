Imports System.Runtime.InteropServices

Public Class UnsafeNativeMethods

    '//the character set needs to be Unicode
    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Friend Shared Function SetWindowTheme(ByVal hWnd As IntPtr,
                                          ByVal pszSubAppName As String,
                                          ByVal pszSubIdList As String) As Integer
    End Function

End Class