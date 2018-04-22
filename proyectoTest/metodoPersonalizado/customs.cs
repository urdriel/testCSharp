
using System;

namespace extensionesPersonalizadas
{
    //la definicion de la extension del metodo debe ser una clase estatica
    public static class cambiosString
    {
        // This is the extension method.
        // The first parameter takes the "this" modifier
        // and specifies the type for which the method is defined.
        public static int CountCustom(this string str)
        {
            int numerovocales=0;
            
            for(int x=0;x<=str.Length-1;x++){

                char comprobarC=str[x]; //recojo valor de la posicion x
                
                string comprobar=Convert.ToString(comprobarC); // convierto a string
                
                string comprobarM = comprobar.ToLower(); // antes de comprobar lo paso todo a minuscula
               // Console.WriteLine(comprobar.ToLower());

                if(comprobarM=="a" || comprobarM=="e" || comprobarM=="i" || comprobarM=="o" || comprobarM=="u"){
                    numerovocales++;
                }
            }
            return numerovocales;
        }
    }

}

