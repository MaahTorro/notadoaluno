namespace desafiocsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota = 0.00;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());

            if (nota <= 5.9)
            {
                Console.WriteLine(nome + " está de recuperação");
            }
            else if(nota >= 6)
            {
                Console.WriteLine(nome + " passou!");
            }
        }
    }
}
