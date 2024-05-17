class Program {
    static void Main(string[] args) {
        Console.WriteLine("Entre o lado A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine()); // lado A da hipotenusa;

        Console.WriteLine("Entre o lado B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine()); // lado B da hipotenusa;

        double hipotenusa = Math.Sqrt((ladoA * ladoA) + (ladoB * ladoB)); // Cálculo para descobrir a hipotenusa;
        Console.WriteLine("A hipotenusa é: " + hipotenusa);
    }
}

