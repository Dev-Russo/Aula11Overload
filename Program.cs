using System;

namespace Aula11Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Dano dano = new Dano();
            Boss boss = new Boss();
            //Nome do Personagem / Sobrenome e Idade
            System.Console.WriteLine(dano.Damage(new Player("Gustavo", "Dias", 16)));
            System.Console.WriteLine(dano.Damage());
            System.Console.WriteLine("O ataque foi fraco no proximo turno troque de arma.");
            Console.WriteLine(boss.ObterMecanicaEDano());
            System.Console.WriteLine("Qual é sua arma?");
            string arma = Console.ReadLine();
            Console.WriteLine(dano.Damage(arma));
            Console.WriteLine(boss.ObterMecanicaEDano());
            System.Console.WriteLine("Qual sua arma de longe e sua munição? Defina primeiro a arma depois a munição.");
            string armadelonge = Console.ReadLine();
            string municao = Console.ReadLine();
            System.Console.WriteLine(dano.Damage(armadelonge, municao));
            System.Console.WriteLine("Parabens você ganhou");
        }
    }
}