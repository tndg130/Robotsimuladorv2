Imports System.Math
Public Class Ventana
    Dim StrBufferOut As String
    Dim StrBufferIn As String


    Dim X As Double, Y As Double, Yaw As Double, Teta1 As Double, Teta2 As Double, Beta As Double, Alfa As Double, Z As Double, Teta3 As Double
    Dim pxl1 As Single, pyl1 As Single, pxl2 As Single, pyl2 As Single, Hipot As Double, Hipot2 As Double
    Dim PulsosX As Integer, PulsosY As Integer, Enviar As String, CteX As Double, CteY As Double, CteRelacion As Double, offset As Double
    Const L1 As Integer = (35.7)
    Const L2 As Integer = (35.7)

    Private Sub PB_Area_Click(sender As Object, e As EventArgs) Handles PB_Area.Click

    End Sub

    Private Sub Ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PB_Area.CreateGraphics.Clear(Color.Black)
        PB_Area2.CreateGraphics.Clear(Color.Black)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar2.Scroll, TrackBar3.Scroll
        X = TrackBar1.Value
        TB_X.Text = TrackBar1.Value
        pintar()

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar2.Scroll, TrackBar3.Scroll
        Y = TrackBar2.Value
        TB_Y.Text = TrackBar2.Value
        pintar()

    End Sub


    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar2.Scroll, TrackBar3.Scroll
        Z = TrackBar3.Value

        TB_Z.Text = TrackBar3.Value
        pintar()

    End Sub






    Private Sub BTN_Mover_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Mover.Click
        X = Val(TB_X.Text)
        Y = Val(TB_Y.Text)
        Z = Val(TB_Z.Text)
        TrackBar1.Value = TB_X.Text
        TrackBar2.Value = TB_Y.Text
        TrackBar3.Value = TB_Z.Text
        pintar()
    End Sub

    Private Sub CargarImagen()
        PB_Area.CreateGraphics.DrawLine(Pens.White, 100, 0, 100, 400)
        PB_Area.CreateGraphics.DrawLine(Pens.White, 0, 400 - 100, 600, 400 - 100)
        PB_Area2.CreateGraphics.DrawLine(Pens.White, 100, 0, 100, 400)
        PB_Area2.CreateGraphics.DrawLine(Pens.White, 0, 400 - 100, 600, 400 - 100)

    End Sub







    Private Function pintar()
        Hipot = Sqrt(X ^ 2 + Y ^ 2)
        Hipot2 = Sqrt(X ^ 2 + Y ^ 2 + Z ^ 2)

        Teta1 = Atan2(X, Y)
        Beta = Atan2(Z, Hipot)
        Yaw = Acos((L1 ^ 2 + Hipot2 ^ 2 - L1 ^ 2) / (2 * L1 * Hipot2))
        Teta2 = Beta + Yaw
        pxl1 = Convert.ToSingle(L1 * Cos(Teta2) + 100)
        pyl1 = Convert.ToSingle(L1 * -Sin(Teta2) + 300)

        Alfa = Acos((L1 ^ 2 + L2 ^ 2 - Hipot2 ^ 2) / (2 * L2 * L1))
        Teta3 = Alfa - PI

        pxl2 = Convert.ToSingle(L2 * Cos(Teta2 + Teta3)) + pxl1
        pyl2 = Convert.ToSingle(L2 * -Sin(Teta2 + Teta3)) + pyl1

        PB_Area.CreateGraphics.Clear(Color.Black)
        PB_Area2.CreateGraphics.Clear(Color.Black)
        CargarImagen()
        PB_Area.CreateGraphics.DrawLine(Pens.Red, 100, 300, pxl1, pyl1)
        PB_Area.CreateGraphics.DrawLine(Pens.Blue, pxl1, pyl1, pxl2, pyl2)
        PB_Area2.CreateGraphics.DrawLine(Pens.Green, 100, 300, Convert.ToSingle(L1 * Cos(Teta1) + 100), Convert.ToSingle(L1 * -Sin(Teta1) + 300))

        Teta1 = Teta1 * 180 / PI
        Teta2 = Teta2 * 180 / PI
        Teta3 = Teta3 * 180 / PI
        TSSL_Teta1.Text = "Teta1 = " + Convert.ToString(Format(Teta1, "0.00")) + "°"
        TSSL_Teta2.Text = "Teta2 = " + Convert.ToString(Format(Teta2, "0.00")) + "°"
        TSSL_Teta3.Text = "Teta3 = " + Convert.ToString(Format(Teta3, "0.00")) + "°"




        Enviar = "xp" + Format(PulsosX, "000000") + "*" + "yp" + Format(PulsosY, "000000") + "*"
        TSSL_Enviar.Text = Enviar


        If SP_Envio.IsOpen = True Then
            SP_Envio.DiscardOutBuffer()
            StrBufferOut = Enviar
            SP_Envio.Write(StrBufferOut)
        End If

        Return 0
    End Function


    Private Sub BTN_BuscarConec_Click(sender As System.Object, e As System.EventArgs) Handles BTN_BuscarConec.Click
        CB_Puertos.Items.Clear()

        For Each PuertosDisponibles As String In My.Computer.Ports.SerialPortNames
            CB_Puertos.Items.Add(PuertosDisponibles)
        Next

        If CB_Puertos.Items.Count > 0 Then
            CB_Puertos.Enabled = True

        Else
            MessageBox.Show("No se encontraron puertos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub CB_Puertos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_Puertos.SelectedIndexChanged
        If MessageBox.Show("¿Conectar al puerto " + CB_Puertos.SelectedItem + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            SP_Envio.PortName = CB_Puertos.SelectedItem
            Timer.Enabled = True
            SP_Envio.Open()
        End If

    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        StrBufferIn = SP_Envio.ReadExisting

        If StrBufferIn <> "" Then
            TSSL_BufferIn.Text = "Entrada: " + StrBufferIn
            StrBufferIn = ""
            SP_Envio.DiscardInBuffer()
        End If
    End Sub

    Private Sub TB_Y_TextChanged(sender As Object, e As EventArgs) Handles TB_Y.TextChanged

    End Sub
End Class
