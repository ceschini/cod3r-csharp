using System;
using System.IO;

namespace curso_csharp.API
{
    public class ExemploDirectoryInfo
    {
        public static void Executar() {
            var dirProjeto = @"~/Documents/curso_csharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ======");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Diretórios =====");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}