using System;
using System.Collections.Generic;

namespace curso_csharp.OO
{
    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Áshtililililiimm";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá meu nome é Bixby!";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá meu nome é Siri!";
        }
    }
    public class Abstract
    {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}