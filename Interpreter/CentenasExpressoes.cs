﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class CentenasExpressoes : Expressao
    {
        public override string Cinco()
        {
            return "D";
        }

        public override int Multiplicar()
        {
            return 100;
        }

        public override string Nove()
        {
            return "CM";
        }

        public override string Quatro()
        {
            return "CD";
        }

        public override string Um()
        {
            return "C";
        }
    }
}
