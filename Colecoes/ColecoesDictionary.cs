using System;
using System.Collections.Generic;

namespace curso_csharp.Colecoes
{
    public class ColecoesDictionary
    {
        public static void Executar() {
            // estrutura chave/valor (chave única)
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                // dá erro se chave passada não estiver presente no dicionário
                Console.WriteLine("2004: " + filmes[2004]);
                // retorna vazio se não estiver presente
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            // retorna se conseguiu ou não remover
            // remove elemento da chave passada
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme de 2006 encontrado: {filme2006}");

            filmes.TryGetValue(2016, out string filme2016);
            Console.WriteLine($"Filme de 2016 encontrado: {filme2016}");

            Console.WriteLine("***Percorrendo chaves***");
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }
            
            Console.WriteLine("***Percorrendo valores***");
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            
            Console.WriteLine("***Percorrendo chave valor***");
            // Modo hard
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
            // Modo easy (usando inferência)
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            } 
        }
    }
}