using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romando = "MVMXXVIII";

            Contexto contexto = new Contexto(romando);

            List<Expressao> lista = new List<Expressao>();

            lista.Add(new MilharesExpressao());
            lista.Add(new CentenasExpressoes());
            lista.Add(new DezenasExpressoes());
            lista.Add(new UnidadeExpressao());

            foreach (Expressao expressao in lista)
                expressao.Interpretador(contexto);

            Console.WriteLine("{0} = {1}", romando, contexto.Output);

            Console.ReadKey();
        }
    }
}
