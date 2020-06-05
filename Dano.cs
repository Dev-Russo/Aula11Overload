namespace Aula11Overload
{
    public class Dano
    {
        public string Damage(Player player){
            return "O personagem " + player.Nome + " " + player.Sobrenome +" tem a idade de " + player.Idade; 
        }
        public string Damage(){
            return "Ataque fraco tirou apenas 1% da vida do boss";
        }
        public string Damage(string arma){
            return "O ataque com " + arma +" foi igual a 40% da vida do boss"; 
        }
        public string Damage(string armadelonge, string municao){
            return "O ataque com a " +armadelonge +", " +municao + " foi igual a 59% da vida do boss";
        }
    }
}
