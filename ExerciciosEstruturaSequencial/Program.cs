using System.Diagnostics.Metrics;
using System.Globalization;

namespace ExerciciosEstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
        }

        static void Exercicio1()
        {
            int primeiroNumero, segundoNumero, soma;

            Console.WriteLine("Digite dois numeros inteiros:");
            primeiroNumero = int.Parse(Console.ReadLine());
            segundoNumero = int.Parse(Console.ReadLine());

            soma = primeiroNumero + segundoNumero;

            Console.WriteLine($"\nSOMA = {soma}");
        }

        static void Exercicio2()
        {
            double raioCirculo, areaCirculo;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o raio do circulo: ");
            raioCirculo = double.Parse(Console.ReadLine(), CI);

            areaCirculo = Math.PI * Math.Pow(raioCirculo, 2);

            Console.WriteLine($"\nAREA = {areaCirculo.ToString("F4", CI)}");
        }

        static void Exercicio3()
        {
            int a, b, c, d, diferenca;

            Console.WriteLine("Digite quatro valores:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine($"\nDIFERENÇA = {diferenca}");
        }

        static void Exercicio4()
        {
            int employeeNumber;
            double hourQuantity, hourlyRate, salary;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o numero do funcionario: ");
            employeeNumber = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de horas trabalhadas: ");
            hourQuantity = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o valor pago por hora: ");
            hourlyRate = double.Parse(Console.ReadLine(), CI);

            salary = hourQuantity * hourlyRate;

            Console.Write($"\nNUMBER = {employeeNumber}");
            Console.Write($"\nSALARY = U$ {salary.ToString("F2", CI)}");
        }

        static void Exercicio5()
        {
            int partCode1, partCode2, partQuantity1, partQuantity2;
            double partValue1, partValue2, amountToPay;

            CultureInfo CI = CultureInfo.InvariantCulture;

            string[] valores = Console.ReadLine().Split(' ');
            partCode1 = int.Parse(valores[0]);
            partQuantity1 = int.Parse(valores[1]);
            partValue1 = double.Parse(valores[2], CI);

            valores = Console.ReadLine().Split(' ');
            partCode2 = int.Parse(valores[0]);
            partQuantity2 = int.Parse(valores[1]);
            partValue2 = double.Parse(valores[2], CI);

            amountToPay = partQuantity1 * partValue1 + partQuantity2 * partValue2;

            Console.WriteLine($"\nAMOUNT TO PAY: R$ {amountToPay.ToString("F2", CI)}");
        }

        static void Exercicio6()
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            CultureInfo CI = CultureInfo.InvariantCulture;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CI);
            b = double.Parse(valores[1], CI);
            c = double.Parse(valores[2], CI);

            triangulo = (a * c) / 2;
            circulo = Math.PI * Math.Pow(c, 2);
            trapezio = ((a + b) * c) / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"\nTRIANGULO: {triangulo.ToString("F3", CI)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CI)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CI)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CI)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CI)}");
        }
    }
}
