using System;

namespace curso_csharp.MetodosEFuncoes
{
    public class DelegateFuncAnonima
    {   
        delegate string StringOperacao(string s);
        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}