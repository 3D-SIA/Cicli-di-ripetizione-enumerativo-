Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i As Byte
        Dim voto, somma, media As Double
        Dim cognome As String

        n = InputBox("Inserisci il numero degli alunni")
        For i = 1 To n
            cognome = InputBox("Inserisci cognome")
            voto = InputBox("Inserisci voto di " & cognome)
            somma = somma + voto
        Next
        media = somma / n
        MsgBox("La media della classe è di " & media)
    End Sub
End Class
