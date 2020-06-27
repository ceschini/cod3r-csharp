using System;
using System.Collections; // ArrayList tá aqui

namespace curso_csharp.Colecoes
{
    public class ColecoesArrayList
    {
        // tipos dados heterogeneos
        public static void Executar() {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };
            arraylist.Add(3.14);

            foreach (var item in arraylist) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}