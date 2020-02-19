# Ciclo di ripetizione
Si usa quando una o più istruzioni devono essere ripetute

### Tipo enumerativo
Serve principalmente per i numeri

Esempio:

Dim N, I as byte
Dim voto, somma, media As integer
Dim cognome as string

N = InputBox("Inserisci numero alunni della classe")
For I = 1 to N
cognome = InputBox("Inserisci cognome")
voto = InputBox("Inserisci voto di " & cognome)
somma = somma + voto
Next
media = somma / N
MsgBox("La media della classe è di " & media)
End sub


