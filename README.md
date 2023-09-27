# CheckTelefono
Dato un vettore contenente stringhe di numeri, un algoritmo le passa in rassegna e comunica se i numeri possono essere numeri di telefono

## quando un numero è valido?
É stato deciso che un numero di telefono viene definito valido secondo queste specifiche: <br>
inizia con +39 (esattamente lungo 13) <br><br>
inizia con 0039 (esattamente lungo 14) <br><br>
inizia con un 3 (esattamente lungo 10) <br><br>

### Come funziona il codice
Il codice esegue prima un for per esaminare ogni stringa del vettore, ad ogni stringa vengono rimossi gli spazi e vengono passati nella
variabile "number". Se number ha i primi 3 caratteri che sono esattamente "+39" ed è lunga 13 oppure se inizia con "0039" ed è lunga 14
o se è lunga 10 ed ha il numero iniziale uguale a 3 allora considera il numero corretto e lo riporta indietro, altrimenti passa al prossimo.
c'è un try catch che impedisce al programma di generare errori nel caso venissero passati vettori con valori troppo bassi.

#### variabili e soluzioni basilari:
~~~C#

        for(int i = 0; i < input.Length; i++){
            try{
                string number = input[i].Replace(" ", "");
                if(((number.Substring(0,3) == "+39" && number.Length == 13) || number.Substring(0,4) == "0039" && number.Length  == 14) || (number[0] == '3' && number.Length == 10))
                    return input[i];
            }
            catch{}
        }
        return "";
