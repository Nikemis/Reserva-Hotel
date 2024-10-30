using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva_Hotel.Models
{
    public class Suite
    {
          public Suite() { }
       public Suite(string tiposuite, int capacidade, float valordiaria)
    {
    TipoSuite = tiposuite; 
    Capacidade = capacidade;
    ValorDiaria = valordiaria;
    }


        public string TipoSuite {get; set;}
        public int Capacidade {get; set;}
        public float ValorDiaria {get; set;}

    }
}