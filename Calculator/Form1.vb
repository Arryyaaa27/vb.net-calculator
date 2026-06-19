Public Class Form1
    Dim angka1 As Double
    Dim operasi As String
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"
        End If
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        TextBox1.Text = "0"
        angka1 = 0
        operasi = ""
    End Sub

    Private Sub BtnHapussatu_Click(sender As Object, e As EventArgs) Handles BtnHapussatu.Click
        If TextBox1.Text.Length > 1 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        angka1 = Val(TextBox1.Text)
        operasi = "+"
        TextBox1.Text = "0"
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        angka1 = Val(TextBox1.Text)
        operasi = "-"
        TextBox1.Text = "0"
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        angka1 = Val(TextBox1.Text)
        operasi = "*"
        TextBox1.Text = "0"
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        angka1 = Val(TextBox1.Text)
        operasi = "/"
        TextBox1.Text = "0"
    End Sub

    Private Sub BtnSamadengan_Click(sender As Object, e As EventArgs) Handles BtnSamadengan.Click
        Dim angka2 As Double
        Dim hasil As Double

        angka2 = Val(TextBox1.Text)

        Select Case operasi

            Case "+"
                hasil = angka1 + angka2

            Case "-"
                hasil = angka1 - angka2

            Case "*"
                hasil = angka1 * angka2

            Case "/"
                If angka2 = 0 Then
                    MessageBox.Show("Tidak bisa dibagi 0")
                    Exit Sub
                End If

                hasil = angka1 / angka2

        End Select

        TextBox1.Text = hasil.ToString()

    End Sub
End Class
