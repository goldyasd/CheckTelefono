# CheckTelefono
date delle stringhe di numeri, un algoritmo le passa in rassegna e comunica se sono numeri validi

## quando un numero è valido?
è stato deciso che un numero di telefono viene definito valido secondo queste specifiche: <br>
inizia con +39 (esattamente lungo 13) <br><br>
inizia con 0039 (esattamente lungo 14) <br><br>
inizia con un 3 (esattamente lungo 10) <br><br>

### variabili e soluzioni basilari:
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
