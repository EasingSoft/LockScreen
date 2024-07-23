Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace WinHook
    Public Enum Device
        WM_KEYDOWN = &H100
        WM_KEYUP = &H101
        WM_SYSKEYDOWN = &H104
        WM_SYSKEYUP = &H105
        WM_MOUSEMOVE = &H200
        WM_LBUTTONDOWN = &H201
        WM_LBUTTONUP = &H202
        WM_RBUTTONDOWN = &H204
        WM_RBUTTONUP = &H205
        WM_MOUSEWHEEL = &H20A
        WM_MOUSEHWHEEL = &H20E
    End Enum
End Namespace
