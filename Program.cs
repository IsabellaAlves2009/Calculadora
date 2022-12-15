namespace Calculadora 
{
    class Program 
    {
        static void Main(string[] args)
        {
          Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(" o que  deseja fazer?");
            Console.WriteLine("----------------------");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Mutliplicação");
            Console.WriteLine("5- Sair");
            
            Console.WriteLine("----------------------");
            Console.WriteLine("selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        
        
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor: ");
             float v2 = float.Parse(Console.ReadLine());

            float resultado = v1+v2;
            Console.Clear();
            Console.WriteLine("o resultado foi "+resultado);
            Console.ReadKey();

        }
        static void Subtracao()
        {   
            Console.Clear();

            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Clear();

            float resultado = v1 - v2;
            Console.WriteLine($"o resultado foi {resultado}");
            Console.ReadKey();


        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Clear();
            float resultado = v1 / v2;
            Console.WriteLine($"o resultado foi {resultado}");
            Console.ReadKey();

;
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($" o resultado foi {resultado}");
            Console.ReadKey();
            
        }
    }
        
}