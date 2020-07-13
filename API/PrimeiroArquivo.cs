using System;
using System.IO;

namespace curso_csharp.API
{   
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    public class PrimeiroArquivo
    {
        public static void Executar() {
            // @ faz com que compiler interprete literalmente
            // i.e: \n não quebra linha
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                // using faz com que o C# limpe os dados
                // do metodo em parenteses após sair do seu bloco
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("DJ Khaled!!!");
                }
            } else {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("");
                    sw.WriteLine("ANOTHER ONE...");
                }
            }
            System.Console.WriteLine("Executado com sucesso");
        }
    }
}