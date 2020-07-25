Imports System.Runtime.InteropServices

'Public Class MP2032

'    'Configura o modelo da impressora
'    <DllImport("MP2032.dll")> _
'    Public Shared Function ConfiguraModeloImpressora(modelo As Integer) As Integer
'    End Function

'    'Inicia Porta
'    <DllImport("MP2032.dll")> _
'    Public Shared Function IniciaPorta(porta As [String]) As Integer
'    End Function

'    'Enviar texto formatado
'    <DllImport("MP2032.dll")> _
'    Public Shared Function FormataTX(texto As [String], TipoLetra As Integer, italico As Integer, sublinhado As Integer, expandido As Integer, enfatizado As Integer) As Integer
'    End Function

'    'Enviar comandos para a impressora
'    <DllImport("MP2032.dll")> _
'    Public Shared Function ComandoTX(comando As [String], tComando As Integer) As Integer
'    End Function

'    'Fecha a porta
'    <DllImport("MP2032.dll")> _
'    Public Shared Function FechaPorta() As Integer
'    End Function

'End Class


Public Class MP2064

    'Configura o modelo da impressora
    <DllImport("MP2064.dll")> _
    Public Shared Function ConfiguraModeloImpressora(modelo As Integer) As Integer
    End Function


    'Inicia Porta
    <DllImport("MP2064.dll")> _
    Public Shared Function IniciaPorta(porta As [String]) As Integer
    End Function

    'Enviar texto formatado
    <DllImport("MP2064.dll")> _
    Public Shared Function FormataTX(texto As [String], TipoLetra As Integer, italico As Integer, sublinhado As Integer, expandido As Integer, enfatizado As Integer) As Integer
    End Function

    'Enviar comandos para a impressora
    <DllImport("MP2064.dll")> _
    Public Shared Function ComandoTX(comando As [String], tComando As Integer) As Integer
    End Function

    'Fecha a porta
    <DllImport("MP2064.dll")> _
    Public Shared Function FechaPorta() As Integer
    End Function

End Class
