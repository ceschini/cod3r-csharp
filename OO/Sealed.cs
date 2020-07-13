using System;

namespace curso_csharp.OO
{
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1407033.65;
        }
    }

    // class SouFilho : SemFilho {
        // não é possível herdar de classe selada
    // }
    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        // não é possível sobrescrever método selado
        // public override bool HonrarNomeFamilia() {
        //     return false;
        // } 
    }
    public class Sealed
    {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}