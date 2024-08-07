using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Sorteador em C#");
        Random random = new Random();
        
        int numeroSorteado = random.Next(1, 11);
        Console.WriteLine(numeroSorteado);
        int tentativaUsuario = 1;
        int maximoTentativas = 3;
        
        Console.Write("Digite um número entre 0 e 10 e tente adivinhar: ");
        var numeroDigitado = int.Parse(Console.ReadLine());
                
        while (tentativaUsuario < maximoTentativas) {                  

            if (numeroDigitado < 0 || numeroDigitado > 10){
                Console.Write("Digite um numero valido. Ele precisa ser entre 0 e 10");
                numeroDigitado = int.Parse(Console.ReadLine());
            }
            else if (numeroDigitado != numeroSorteado) {
                Console.Write("Voce errou. Tente novamente. Digite um número entre 0 e 10: ");
                numeroDigitado = int.Parse(Console.ReadLine());
                tentativaUsuario++;
            }
            else if (numeroDigitado != numeroSorteado && tentativaUsuario >= 3){
                Console.Write("Você perdeu, seu fracassado inútil")
            }
            else {
                Console.Write("Parabéns. Você acertou!!! O número sorteado era o: ");
                numeroSorteado;
            }
            
            
        }
        
        
        
        
        
    }
}