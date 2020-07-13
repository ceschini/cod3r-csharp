﻿using System;
using System.Collections.Generic;
using System.Text;

namespace curso_csharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            // variável fracamente tipada
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.idade} {aluno.nota}");
        }
    }
}
