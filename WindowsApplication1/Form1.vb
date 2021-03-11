Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const procCAS As Double = 0.105
        Const procCASS As Double = 0.055
        Const procSomaj As Double = 0.005
        Const procimp As Double = 0.16
        Dim salBrut, salNet, venitNet, venitimp, impozit, valCAS, valCASS, valSomaj, Contributii As Double
        If IsNumeric(TextBox1.Text) Then
            salBrut = Val(TextBox1.Text)
            valCAS = TextBox1.Text * procCAS
            valCASS = TextBox1.Text * procCASS
            valSomaj = TextBox1.Text * procSomaj
            Contributii = valCAS + valCASS + valSomaj
            venitNet = TextBox1.Text - Contributii
            If CHimpozabil.Checked Then
                venitimp = venitNet

                If CHfunctie.Checked Then
                    If TextBox1.Text < 3000 Then
                        If CMBpersoane.SelectedIndex <> -1 Then
                            venitimp = venitimp - (250 + 100 * CMBpersoane.SelectedIndex)
                        Else
                            MsgBox("Selectati numarul de persoane")
                        End If
                    End If

                    impozit = procimp * venitimp
                Else
                    impozit = 0
                End If
                salNet = venitNet - impozit
                TextBox2.Text = salNet
            End If
        End If
    End Sub
End Class
