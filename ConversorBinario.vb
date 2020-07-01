Public Class ConversorBinario
    Function Convertidor(Numero As String)
        Dim Total As Long 'Acumulador
        Dim Constante, Temp As Integer 'Constante que irá cambiando en x 2
        Constante = 1 'Iniciamos la contantes en 1 (ver tabla de conversiones)
        Do
            Temp = Val(Right(Numero, 1)) 'obtengo el primer numero de la derecha
            Numero = Left(Numero, Len(Numero) - 1) ' Al binario le quito el ultimo digito
            Total = Total + (Temp * Constante) 'El primer digito que saqué de la derecho lo multiplico con la constante
            Constante = Constante * 2 ' la constante será 1,2,4,8,16,32, etc es decir, x 2
        Loop Until Len(Numero) = 0 'Seguimos haciendo la operación hasta la cadena binario se quede sin digitos
        Return Total
    End Function




End Class
