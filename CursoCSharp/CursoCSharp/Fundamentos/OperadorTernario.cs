﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;      // expresão , 1° operando , 2° operando 
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado " ;
            Console.WriteLine(resultado);
        }
    }
}
