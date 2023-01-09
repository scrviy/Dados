namespace Dados
{
    public class Dados
    {
        public static void Main(string[] args)
        { 
             // Tipos integrais com sinal            
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

            // tipos integrais sem sinal
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"sbyte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

            //* Tipos de pontos flutuantes
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double  : {double.MinValue} to {float.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            //* Tipos de Referência
            int[] data = new int[3];

            string shortenedString = "Hello World!";
            Console.WriteLine(shortenedString);
            

             //Escrever o código que tenta adicionar um int e uma cadeia de caracteres e salvar o resultado em um int
            int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result);
            

            
            //Conversao implicita
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");
            

            // Conversao cast
            decimal PI = 3.14m;
            Console.WriteLine($"decimal: {PI}");

            int myPi = (int)PI;
            Console.WriteLine($"myPi: {myPi}");
            

            //converter um numero em uma cadeia de caracteres usando ToString()
            int number1 = 5;
            int number2 = 7;
            string message = number1.ToString() + number2.ToString();
            Console.WriteLine(message);
            

             //converter uma cadeia de caracteres em um numero usando Parse()
            string numberMath = "5";
            string number1_Math = "7";
            int sum = int.Parse(numberMath) + int.Parse(number1_Math);
            Console.WriteLine(sum);
            

             //converter cadeia de caracteres para um numero usando classe Convert
            string value1 = "5";
            string value2 = "7";
            int resulter = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(resulter);
            

            //comparar a conversao cast e a conversao decimal em int
            int valor = (int)1.5m; //casting truncates
            Console.WriteLine(valor);

            int valor2 = Convert.ToInt32(1.5m); //converting rounds up
            Console.WriteLine(value2);
        }
    }
}