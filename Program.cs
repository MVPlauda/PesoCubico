internal class Program
{
    private static void Main(string[]args)
    {
        double comprimento, largura, altura, peso, pesocubico;

        Console.WriteLine("Qual o comprimento da caixa em cm?: ");
        comprimento = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a largura da caixa em cm?: ");
        largura = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a altura da caixa em cm?: ");
        altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual o peso da caixa em Kg?: ");
        peso = double.Parse(Console.ReadLine());

        double volume = comprimento * largura * altura;

        pesocubico = volume * peso;

        Console.WriteLine("O peso cúbico da caixa é: " + pesocubico + "kg/cm3.");
    }
}
