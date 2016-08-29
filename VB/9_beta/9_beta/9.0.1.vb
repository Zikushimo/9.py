Public Class Form1
    Private e As Object

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        Dim a As String
        Dim b As String
        Dim c As String
        Dim d As String
        Dim ii As String
        Dim f As String
        Dim g As String
        Dim h As String
        Dim i As String
        Dim j As String
        Dim k As String
        Dim l As String
        Dim m As String
        Dim n As String
        Dim o As String
        Dim p As String
        Dim q As String
        Dim r As String
        Dim s As String
        Dim t As String
        Dim u As String
        Dim v As String
        Dim w As String
        Dim x As String
        Dim y As String
        Dim z As String
        a = "010101101"
        b = "110111110"
        c = "111100111"
        d = "110101110"
        ii = "111110111"
        f = "111110100"
        g = "110111111"
        h = "101111101"
        i = "010010010"
        j = "010010100"
        k = "101110101"
        l = "100100111"
        m = "101111111"
        n = "001111100"
        o = "111101111"
        p = "110110100"
        q = "010101011"
        r = "110110101"
        s = "011010110"
        t = "111010010"
        u = "101101111"
        v = "101101010"
        w = "111111101"
        x = "101010101"
        y = "101010010"
        z = "110010011"
        If e.KeyCode = Keys.A Then
            RichTextBox1.Text = RichTextBox1.Text + a
        End If
        If e.KeyCode = Keys.B Then
            RichTextBox1.Text = RichTextBox1.Text + b
        End If
        If e.KeyCode = Keys.C Then
            RichTextBox1.Text = RichTextBox1.Text + c
        End If
        If e.KeyCode = Keys.D Then
            RichTextBox1.Text = RichTextBox1.Text + d
        End If
        If e.KeyCode = Keys.E Then
            RichTextBox1.Text = RichTextBox1.Text + ii
        End If
        If e.KeyCode = Keys.F Then
            RichTextBox1.Text = RichTextBox1.Text + f
        End If
        If e.KeyCode = Keys.G Then
            RichTextBox1.Text = RichTextBox1.Text + g
        End If
        If e.KeyCode = Keys.H Then
            RichTextBox1.Text = RichTextBox1.Text + h
        End If
        If e.KeyCode = Keys.I Then
            RichTextBox1.Text = RichTextBox1.Text + i
        End If
        If e.KeyCode = Keys.J Then
            RichTextBox1.Text = RichTextBox1.Text + j
        End If
        If e.KeyCode = Keys.K Then
            RichTextBox1.Text = RichTextBox1.Text + k
        End If
        If e.KeyCode = Keys.L Then
            RichTextBox1.Text = RichTextBox1.Text + l
        End If
        If e.KeyCode = Keys.M Then
            RichTextBox1.Text = RichTextBox1.Text + m
        End If
        If e.KeyCode = Keys.N Then
            RichTextBox1.Text = RichTextBox1.Text + n
        End If
        If e.KeyCode = Keys.O Then
            RichTextBox1.Text = RichTextBox1.Text + o
        End If
        If e.KeyCode = Keys.P Then
            RichTextBox1.Text = RichTextBox1.Text + p
        End If
        If e.KeyCode = Keys.Q Then
            RichTextBox1.Text = RichTextBox1.Text + q
        End If
        If e.KeyCode = Keys.R Then
            RichTextBox1.Text = RichTextBox1.Text + r
        End If
        If e.KeyCode = Keys.S Then
            RichTextBox1.Text = RichTextBox1.Text + s
        End If
        If e.KeyCode = Keys.T Then
            RichTextBox1.Text = RichTextBox1.Text + t
        End If
        If e.KeyCode = Keys.U Then
            RichTextBox1.Text = RichTextBox1.Text + u
        End If
        If e.KeyCode = Keys.V Then
            RichTextBox1.Text = RichTextBox1.Text + v
        End If
        If e.KeyCode = Keys.W Then
            RichTextBox1.Text = RichTextBox1.Text + w
        End If
        If e.KeyCode = Keys.X Then
            RichTextBox1.Text = RichTextBox1.Text + x
        End If
        If e.KeyCode = Keys.Y Then
            RichTextBox1.Text = RichTextBox1.Text + y
        End If
        If e.KeyCode = Keys.Z Then
            RichTextBox1.Text = RichTextBox1.Text + z
        End If
        If e.KeyCode = Keys.Delete Then
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        My.Computer.Clipboard.SetText(RichTextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
    End Sub
End Class
