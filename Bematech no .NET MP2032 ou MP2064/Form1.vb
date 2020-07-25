Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim iRetorno As Integer = 0

        'Select Case Runtime.InteropServices.Marshal.SizeOf(GetType(IntPtr)) * 8
        '    Case 32
        '        iRetorno = MP2032.ConfiguraModeloImpressora(7)
        '        iRetorno = MP2032.IniciaPorta("COM1")
        '        iRetorno = MP2032.FormataTX("Bematech – BSP", 2, 0, 0, 1, 1)
        '        Dim sComando As String = Chr(13) + Chr(10)
        '        iRetorno = MP2032.ComandoTX(sComando, Len(sComando))
        '        iRetorno = MP2032.FechaPorta()
        '        MsgBox("OK")
        '    Case 64
        iRetorno = MP2064.ConfiguraModeloImpressora(7)
        iRetorno = MP2064.IniciaPorta("COM1")
        iRetorno = MP2064.FormataTX("Bematech – BSP", 2, 0, 0, 1, 1)
        Dim sComando As String = Chr(13) + Chr(10)
        iRetorno = MP2064.ComandoTX(sComando, Len(sComando))
        iRetorno = MP2064.FechaPorta()
        MsgBox("OK")
        '    Case Else
        'Throw New Exception("Arquitetura desconhecida")
        'End Select

    End Sub

End Class
