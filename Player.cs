namespace Aula11Overload
{
    public class Player
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public Player(){}

        public Player(string nome, string sobrenome, int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
    }
}