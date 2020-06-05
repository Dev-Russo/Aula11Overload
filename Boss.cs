using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula11Overload
{
    public class Boss
    {

        public Boss(){
            Mecanicas = new List<int>();
            Mecanicas.Add(1);
            Mecanicas.Add(2);
            Mecanicas.Add(3);
            Danos = new List<int>();
            Danos.Add(10);
            Danos.Add(20);
            Danos.Add(30);
        }
        private List<int> Mecanicas { get; set; }
        private List<int> Danos { get; set; }
        private int ObterMecanica(){
            Mecanicas = Mecanicas.OrderBy(x => Guid.NewGuid()).ToList();
            return Mecanicas.ElementAt(0);
        }
        private int ObterDano(){
            Danos = Danos.OrderBy(x => Guid.NewGuid()).ToList();
            return Danos.ElementAt(0);
        }

        public string ObterMecanicaEDano(){
            return "Mecanica: " +ObterMecanica() + " Dano: " + ObterDano();        
        }

    }
}