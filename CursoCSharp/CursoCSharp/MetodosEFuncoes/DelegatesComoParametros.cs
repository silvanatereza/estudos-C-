﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma( int x, int y )
        {
            return x + y;
        }
        public static string Calculadora(Operacao op , int x , int y)
        {
            var resultado = op(x,y );
            return "Resultado " + resultado;
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3 , 3 ));

            Console.WriteLine(Calculadora(Soma , 5 , 9));
        }
    }
}
