using System;

public class Sorteador
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Sorteador em C#");
        Random random = new Random();
        
        
        //Sorteia um número
        int numeroSorteado = random.Next(0, 11);
        
        //Exibe o número sorteado para testes
        Console.WriteLine(numeroSorteado);

        //Variáveis para armazenar a quantidade de tentativas do usuário, e o máximo de tentativas possíveis
        int tentativaUsuario = 1;
        int maximoTentativas = 3;
        
        //Solicita que o usuário digite um número
        Console.Write("Digite um numero entre 0 e 10 e tente adivinhar: ");
        var numeroDigitado = int.Parse(Console.ReadLine());
                
        
        //Verifica se o número de tentativas está dentro das 3 possíveis
        while (tentativaUsuario < maximoTentativas) {                  

            //Verificar se o número digitado está no intervalo correto (entre 0 e 10)
            if (numeroDigitado < 0 || numeroDigitado > 10){
                Console.Write("Digite um numero valido. Ele precisa ser entre 0 e 10 ");
                numeroDigitado = int.Parse(Console.ReadLine());
            }
            
            //Se o número digitado estiver errado, exibe a mensagem de tentativa errada e pede um novo número. Incremente +1 nas tentativas
            else if (numeroDigitado != numeroSorteado) {
                Console.WriteLine(string.Format(tentativaUsuario + "ª tentativa errada. Tente novamente. "));
                numeroDigitado = int.Parse(Console.ReadLine());
                tentativaUsuario++;
            }
                      
            //Mensagem de acerto do usuário
            else {
                Console.Write("Parabens. Voce acertou na " + tentativaUsuario + "ª tentativa!!! O numero sorteado e o: " + numeroSorteado);
                break;    
            }
        }

        //Mensagem de tentativas esgotadas caso o usuário não acerte
        if (numeroDigitado != numeroSorteado && tentativaUsuario > 2){
                Console.Write("Você perdeu, o numero sorteado era o " + numeroSorteado);
        }       
    }
}