Public Class Form1
    Dim carta1, carta2, carta3, carta4, apuesta, credito, ganancia As Integer
    Private Sub BtnJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJugar.Click
        apuesta = LblApostar.Text
        Lblapostar.Enabled = False
        If Lblsaldo.Text <= 0 Then
            MsgBox("ponga saldo para poder jugar")
        Else
            If apuesta > credito Then
                MsgBox("Error!!... su apuesta es mayor que su credito, baje su apuesta o ponga mas credito")
                BtnCredito.Enabled = True
            Else
                Picture1.Visible = False
                Picture2.Visible = False
                Picture3.Visible = False
                Picture4.Visible = False
                picture5.Visible = True
                picture6.Visible = True
                picture7.Visible = True
                picture8.Visible = True

                Timer1.Enabled = True
                BtnJugar.Enabled = False
                BtnApostar.Enabled = False
                resultado()

            End If

        End If
    End Sub
    Sub aleatorio()
        carta1 = 0
        carta2 = 0
        carta3 = 0
        carta4 = 0
        Randomize()
        carta1 = Int(6 * Rnd() + 1)
        carta2 = Int(6 * Rnd() + 1)
        carta3 = Int(6 * Rnd() + 1)
        carta4 = Int(6 * Rnd() + 1)
    End Sub
    Sub carta_1()

        If carta1 = 1 Then

            Picture1.Image = Picture1.ErrorImage
        End If
        If carta1 = 2 Then
            Picture1.Image = Picture2.ErrorImage
        End If
        If carta1 = 3 Then
            Picture1.Image = Picture3.ErrorImage
        End If
        If carta1 = 4 Then
            Picture1.Image = Picture4.ErrorImage
        End If
        If carta1 = 5 Then
            Picture1.Image = picture5.ErrorImage
        End If
        If carta1 = 6 Then
            Picture1.Image = picture6.ErrorImage
        End If
    End Sub
    Sub carta_2()

        If carta2 = 1 Then

            Picture2.Image = Picture1.ErrorImage
        End If
        If carta2 = 2 Then
            Picture2.Image = Picture2.ErrorImage
        End If
        If carta2 = 3 Then
            Picture2.Image = Picture3.ErrorImage
        End If
        If carta2 = 4 Then
            Picture2.Image = Picture4.ErrorImage
        End If
        If carta2 = 5 Then
            Picture2.Image = picture5.ErrorImage
        End If
        If carta2 = 6 Then
            Picture2.Image = picture6.ErrorImage
        End If
    End Sub
    Sub carta_3()

        If carta3 = 1 Then

            Picture3.Image = Picture1.ErrorImage
        End If
        If carta3 = 2 Then
            Picture3.Image = Picture2.ErrorImage
        End If
        If carta3 = 3 Then
            Picture3.Image = Picture3.ErrorImage
        End If
        If carta3 = 4 Then
            Picture3.Image = Picture4.ErrorImage
        End If
        If carta3 = 5 Then
            Picture3.Image = picture5.ErrorImage
        End If
        If carta3 = 6 Then
            Picture3.Image = picture6.ErrorImage
        End If
    End Sub
    Sub carta_4()

        If carta4 = 1 Then
            Picture4.Image = picture7.ErrorImage
        End If
        If carta4 = 2 Then
            Picture4.Image = picture8.ErrorImage
        End If
        If carta4 = 3 Then
            Picture4.Image = picture7.ErrorImage
        End If
        If carta4 = 4 Then
            Picture4.Image = picture8.ErrorImage
        End If
        If carta4 = 5 Then
            Picture4.Image = picture7.ErrorImage
        End If
        If carta4 = 6 Then
            Picture4.Image = Picture9.ErrorImage
        End If
        
    End Sub
    Sub resultado()
        aleatorio()
        carta_1()
        carta_2()
        carta_3()
        carta_4()
        credito = credito - apuesta
        If carta1 = 1 And carta2 = 1 And carta3 = 1 Then
            If carta4 = 1 Or carta4 = 3 Or carta4 = 5 Then
                ganancia = apuesta * 4
                MsgBox("ganaste: " & ganancia)
                credito = credito + ganancia
            End If
            If carta4 = 2 Or carta4 = 4 Then
                ganancia = apuesta * 8
                MsgBox("ganaste: " & ganancia)
                credito = credito + ganancia
            End If
            If carta4 = 6 Then
                ganancia = apuesta * 12
                MsgBox("ganaste: " & ganancia)
                credito = credito + ganancia
            End If
            
        Else
            If carta1 = 2 And carta2 = 2 And carta3 = 2 Then
                If carta4 = 1 Or carta4 = 3 Or carta4 = 5 Then
                    ganancia = apuesta * 8
                    MsgBox("ganaste: " & ganancia)
                    credito = credito + ganancia
                End If
                If carta4 = 2 Or carta4 = 4 Then
                    ganancia = apuesta * 16
                    MsgBox("ganaste: " & ganancia)
                    credito = credito + ganancia
                End If
                If carta4 = 6 Then
                    ganancia = apuesta * 24
                    MsgBox("ganaste: " & ganancia)
                    credito = credito + ganancia
                End If

            Else
                If carta1 = 3 And carta2 = 3 And carta3 = 3 Then
                    If carta4 = 1 Or carta4 = 3 Or carta4 = 5 Then
                        ganancia = apuesta * 12
                        MsgBox("ganaste: " & ganancia)
                        credito = credito + ganancia
                    End If
                    If carta4 = 2 Or carta4 = 4 Then
                        ganancia = apuesta * 24
                        MsgBox("ganaste: " & ganancia)
                        credito = credito + ganancia
                    End If
                    If carta4 = 6 Then
                        ganancia = apuesta * 36
                        MsgBox("ganaste: " & ganancia)
                        credito = credito + ganancia
                    End If
                Else
                    If carta1 = 4 And carta2 = 4 And carta3 = 4 Then
                        If carta4 = 1 Or carta4 = 3 Or carta4 = 5 Then
                            ganancia = apuesta * 16
                            MsgBox("ganaste: " & ganancia)
                            credito = credito + ganancia
                        End If
                        If carta4 = 2 Or carta4 = 4 Then
                            ganancia = apuesta * 32
                            MsgBox("ganaste: " & ganancia)
                            credito = credito + ganancia
                        End If
                        If carta4 = 6 Then
                            ganancia = apuesta * 48
                            MsgBox("ganaste: " & ganancia)
                            credito = credito + ganancia
                        End If
                    Else
                        If carta1 = 5 And carta2 = 5 And carta3 = 5 Then
                            If carta4 = 1 Or carta4 = 3 Or carta4 = 5 Then
                                ganancia = apuesta * 20
                                MsgBox("ganaste: " & ganancia)
                                credito = credito + ganancia
                            End If
                            If carta4 = 2 Or carta4 = 4 Then
                                ganancia = apuesta * 40
                                MsgBox("ganaste: " & ganancia)
                                credito = credito + ganancia
                            End If
                            If carta4 = 6 Then
                                ganancia = apuesta * 60
                                MsgBox("ganaste: " & ganancia)
                                credito = credito + ganancia
                            End If
                        Else
                            If carta1 = 6 And carta2 = 6 And carta3 = 6 Then
                                If carta4 = 1 Or carta4 = 3 Or carta4 = 5 Then
                                    ganancia = apuesta * 24
                                    MsgBox("ganaste: " & ganancia)
                                    credito = credito + ganancia
                                End If
                                If carta4 = 2 Or carta4 = 4 Then
                                    ganancia = apuesta * 48
                                    MsgBox("ganaste: " & ganancia)
                                    credito = credito + ganancia
                                End If
                                If carta4 = 6 Then
                                    ganancia = apuesta * 72
                                    MsgBox("ganaste: " & ganancia)
                                    credito = credito + ganancia
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        LblSaldo.Text = credito
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer2.Enabled = False
        Picture1.Visible = True
        Picture2.Visible = True
        Picture3.Visible = True
        Picture4.Visible = True
        Picture5.visible = False
        picture6.visible = False
        picture7.visible = False
        picture8.visible = False
        BtnJugar.Enabled = True
        BtnApostar.Enabled = True
        carta_1()
        carta_2()
        carta_3()
        carta_4()
        If LblSaldo.Text = 0 Then
            BtnCredito.Enabled = True

        End If
    End Sub

  


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lblapostar.Enabled = False

    End Sub

    Private Sub BtnCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCredito.Click
        credito = InputBox("Credito a depositar", "Casino JPC")
        LblSaldo.Text = LblSaldo.Text + credito
        If credito > 0 Then
            BtnCredito.Enabled = False
        End If

    End Sub

    Private Sub BtnApostar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApostar.Click
        Lblapostar.Enabled = True
        apuesta = Lblapostar.Text
        LblApostar.Text = apuesta
        
    End Sub

    
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Dim result As DialogResult
        result = MsgBox("¿Realmente deseas salir?", MsgBoxStyle.YesNo, "Salir")
        If result = Windows.Forms.DialogResult.Yes Then
            If credito > 0 Then
                MsgBox("Te retiras con: " & credito)
                End
            End If
            MsgBox("Suerte para la proxima")
            Me.Close()
            End
        End If

    End Sub
End Class
