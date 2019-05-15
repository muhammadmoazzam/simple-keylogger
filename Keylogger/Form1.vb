Public Class Form1
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.ReadOnly = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hotkey99 As Boolean
        hotkey99 = GetAsyncKeyState(192)
        If hotkey99 = True Then
            RichTextBox1.Text = "`"
        End If
        Dim hotkey1 As Boolean
        hotkey1 = GetAsyncKeyState(Keys.A)
        If hotkey1 = True Then
            RichTextBox1.SelectedText = "A"
        End If
        Dim hotkey2 As Boolean
        hotkey2 = GetAsyncKeyState(Keys.B)
        If hotkey2 = True Then
            RichTextBox1.SelectedText = "B"
        End If

        Dim hotkey3 As Boolean
        hotkey3 = GetAsyncKeyState(Keys.C)
        If hotkey3 = True Then
            RichTextBox1.SelectedText = "C"
        End If

        Dim hotkey4 As Boolean
        hotkey4 = GetAsyncKeyState(Keys.D)
        If hotkey4 = True Then
            RichTextBox1.SelectedText = "D"
        End If

        Dim hotkey5 As Boolean
        hotkey5 = GetAsyncKeyState(Keys.E)
        If hotkey5 = True Then
            RichTextBox1.SelectedText = "E"
        End If

        Dim hotkey6 As Boolean
        hotkey6 = GetAsyncKeyState(Keys.F)
        If hotkey6 = True Then
            RichTextBox1.SelectedText = "F"
        End If

        Dim hotkey7 As Boolean
        hotkey7 = GetAsyncKeyState(Keys.G)
        If hotkey7 = True Then
            RichTextBox1.SelectedText = "G"
        End If

        Dim hotkey8 As Boolean
        hotkey8 = GetAsyncKeyState(Keys.H)
        If hotkey8 = True Then
            RichTextBox1.SelectedText = "H"
        End If

        Dim hotkey9 As Boolean
        hotkey9 = GetAsyncKeyState(Keys.I)
        If hotkey9 = True Then
            RichTextBox1.SelectedText = "I"
        End If

        Dim hotkey10 As Boolean
        hotkey10 = GetAsyncKeyState(Keys.J)
        If hotkey10 = True Then
            RichTextBox1.SelectedText = "J"
        End If

        Dim hotkey11 As Boolean
        hotkey11 = GetAsyncKeyState(Keys.K)
        If hotkey11 = True Then
            RichTextBox1.SelectedText = "K"
        End If

        Dim hotkey12 As Boolean
        hotkey12 = GetAsyncKeyState(Keys.L)
        If hotkey12 = True Then
            RichTextBox1.SelectedText = "L"
        End If

        Dim hotkey13 As Boolean
        hotkey13 = GetAsyncKeyState(Keys.M)
        If hotkey13 = True Then
            RichTextBox1.SelectedText = "M"
        End If

        Dim hotkey14 As Boolean
        hotkey14 = GetAsyncKeyState(Keys.N)
        If hotkey14 = True Then
            RichTextBox1.SelectedText = "N"
        End If

        Dim hotkey15 As Boolean
        hotkey15 = GetAsyncKeyState(Keys.O)
        If hotkey15 = True Then
            RichTextBox1.SelectedText = "O"
        End If

        Dim hotkey16 As Boolean
        hotkey16 = GetAsyncKeyState(Keys.P)
        If hotkey16 = True Then
            RichTextBox1.SelectedText = "P"
        End If

        Dim hotkey17 As Boolean
        hotkey17 = GetAsyncKeyState(Keys.Q)
        If hotkey17 = True Then
            RichTextBox1.SelectedText = "Q"
        End If

        Dim hotkey18 As Boolean
        hotkey18 = GetAsyncKeyState(Keys.R)
        If hotkey18 = True Then
            RichTextBox1.SelectedText = "R"
        End If

        Dim hotkey19 As Boolean
        hotkey19 = GetAsyncKeyState(Keys.S)
        If hotkey19 = True Then
            RichTextBox1.SelectedText = "S"
        End If

        Dim hotkey20 As Boolean
        hotkey20 = GetAsyncKeyState(Keys.T)
        If hotkey20 = True Then
            RichTextBox1.SelectedText = "T"
        End If

        Dim hotkey21 As Boolean
        hotkey21 = GetAsyncKeyState(Keys.U)
        If hotkey21 = True Then
            RichTextBox1.SelectedText = "U"
        End If

        Dim hotkey22 As Boolean
        hotkey22 = GetAsyncKeyState(Keys.V)
        If hotkey22 = True Then
            RichTextBox1.SelectedText = "V"
        End If

        Dim hotkey23 As Boolean
        hotkey23 = GetAsyncKeyState(Keys.X)
        If hotkey23 = True Then
            RichTextBox1.SelectedText = "X"
        End If

        Dim hotkey24 As Boolean
        hotkey24 = GetAsyncKeyState(Keys.Y)
        If hotkey24 = True Then
            RichTextBox1.SelectedText = "Y"
        End If

        Dim hotkey25 As Boolean
        hotkey25 = GetAsyncKeyState(Keys.Z)
        If hotkey25 = True Then
            RichTextBox1.SelectedText = "Z"
        End If

        Dim hotkey26 As Boolean
        hotkey26 = GetAsyncKeyState(Keys.Space)
        If hotkey26 = True Then
            RichTextBox1.SelectedText = " "
        End If

        Dim hotkey27 As Boolean
        hotkey27 = GetAsyncKeyState(Keys.Enter)
        If hotkey27 = True Then
            RichTextBox1.SelectedText = vbNewLine
        End If

        Dim hotkey28 As Boolean
        hotkey28 = GetAsyncKeyState(Keys.W)
        If hotkey28 = True Then
            RichTextBox1.SelectedText = "W"
        End If

        Dim hotkey29 As Boolean
        hotkey29 = GetAsyncKeyState(Keys.Back)
        If hotkey29 = True Then
            RichTextBox1.SelectedText = "(Backspace)"
        End If
    End Sub
End Class
