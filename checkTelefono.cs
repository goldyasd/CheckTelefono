using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json.Serialization;

public static class Telefono
{

    public static string Check(string[] input)
    {
        for(int i = 0; i < input.Length; i++){
            try{
                string number = input[i].Replace(" ", "");
                if(((number.Substring(0,3) == "+39" && number.Length == 13) || number.Substring(0,4) == "0039" && number.Length  == 14) || (number[0] == '3' && number.Length == 10))
                    return input[i];
            }
            catch{}
        }
        return "";
    }
}