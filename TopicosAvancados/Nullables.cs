using System;
using System.Collections.Generic;
using System.Text;

namespace curso_csharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            } 
            else
            {
                Console.WriteLine("A variável não possui valor");
            }
            // usar num1 ? ou ? valor padrão
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
