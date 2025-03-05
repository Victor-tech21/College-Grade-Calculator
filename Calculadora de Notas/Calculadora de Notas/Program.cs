using System;
class Program
{
    static void Main(string[] args)
    {

        double nota1, nota2, notapim, ms;


        Console.WriteLine("Digite a nota 1:");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota 2:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a Nota do PIM");
        notapim = Convert.ToDouble(Console.ReadLine());

      
        ms = ((nota1 * 0.4) + (nota2 * 0.4)) + (notapim * 0.2);



        if (ms >= 7)
        {
            Console.WriteLine("Aluno Aprovado!");
        } 
        else
        {
            Console.WriteLine("Aluno Reprovado!");
        }
        Console.ReadKey();

    }
}



