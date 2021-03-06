Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms

Namespace DataGridTextBoxCombo
    Public Class NoKeyUpCombo
        Inherits ComboBox
        Private WM_KEYUP As Integer = &H101


        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
            If m.Msg = WM_KEYUP Then
                'ignore keyup to avoid problem with tabbing & dropdownlist;
                Return
            End If
            MyBase.WndProc(m)
        End Sub 'WndProc

        Private _ID As Object
        Public Property ID() As Object
            Get
                Return _ID
            End Get
            Set(ByVal Value As Object)
                _ID = Value
            End Set
        End Property
    End Class 'NoKeyUpCombo
End Namespace

