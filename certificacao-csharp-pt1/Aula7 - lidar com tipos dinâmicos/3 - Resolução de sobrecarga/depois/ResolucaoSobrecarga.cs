﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ResolucaoSobrecarga : IAulaItem
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;

            short short1 = 123;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;

            Console.WriteLine(Somar(int1, int2));
            Console.WriteLine(Somar(short1, short2));
            Console.WriteLine(Somar(double1, double2));
            Console.WriteLine(Somar("abc", "xyz"));
        }

        //int Somar(int parcela1, int parcela2)
        //{
        //    return parcela1 + parcela2;
        //}

        //short Somar(short parcela1, short parcela2)
        //{
        //    return (short)(parcela1 + parcela2);
        //}

        //object Somar(object parcela1, object parcela2)
        //{
        //    return (double)parcela1 + (double)parcela2;
        //}

        //como o dinamico pode receber qualquer tipo de variável
        //esse método substitui todos os outros acima.
        dynamic Somar(dynamic parcela1, dynamic parcela2)
        {
            return parcela1 + parcela2;
        }
    }
}
