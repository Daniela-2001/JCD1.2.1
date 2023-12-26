namespace JCD1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Receber quatro números do usuário
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto número: ");
            double numero4 = Convert.ToDouble(Console.ReadLine());

            //Chamar a função para encontrar o maior número
            double resultado = EncontrarMaiorNumero(numero1, numero2, numero3 , numero4);

            //Exibir o resultado
            Console.WriteLine($"O maior número é: {resultado} ");
        }

        static double EncontrarMaiorNumero(double num1, double num2, double num3, double num4)
        {
            //Encontrar o maior número entre os quatro

            double maiorNumero = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));

            //Retornar o resultado

            return maiorNumero;*/


            // Outra forma de fazer este exercício:

            Console.WriteLine("Escreva quatro números");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());   
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            if(number1 >= number2 && number1 >= number3 && number1>= number4) 
            {
                Console.WriteLine($"O número maior é o {number1}");

            } else if (number2 >= number1 && number2>= number3 && number2 >= number4)
            
            {
                Console.WriteLine($"O número maior é o {number2}");
            } else if (number3 >= number1 && number3 >= number2 && number3 >= number4)
            {
                Console.WriteLine($"O número maior é o {number3}");
            } else
            {
                Console.WriteLine($"O número maior é o {number4}");
            }
        }
    }
}