namespace Lab2
{
    internal class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Mau so khong the la so 0");

            Numerator = numerator;
            Denominator = denominator;
            Normalize();
        }

        private void Normalize()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Denominator = -Denominator;
                Numerator = -Numerator;
            }
        }

        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Subtract(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiply(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Numerator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Divide(Fraction f1, Fraction f2)
        {
            if (f2.Numerator == 0)
                throw new DivideByZeroException("Khong the chia cho 0");

            int numerator = f1.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Numerator;
            return new Fraction(numerator, denominator);
        }

        public void DisplayFraction()
        {
            Console.WriteLine($"({Numerator}/{Denominator})");
        }

        public void DisplayDecimal()
        {
            Console.WriteLine($"{(double)Numerator / Denominator}");
        }

    }

    class Ex4
    {
        public static void run()
        {
            try
            {
                Console.WriteLine("Enter the first fraction: ");
                int num1 = int.Parse(Console.ReadLine() ?? "0");
                int denom1 = int.Parse(Console.ReadLine() ?? "1");

                Console.WriteLine("Enter the second fraction: ");
                int num2 = int.Parse(Console.ReadLine() ?? "0");
                int denom2 = int.Parse(Console.ReadLine() ?? "1") ;

                Fraction f1 = new Fraction(num1, denom1);

                Fraction f2 = new Fraction(num2, denom2);

                Console.WriteLine("\nFraction 1:");
                f1.DisplayFraction();
                f1.DisplayDecimal();

                Console.WriteLine("\nFraction 2:");
                f2.DisplayFraction();
                f2.DisplayDecimal();

                Console.WriteLine("\nAddition:");
                Fraction resultAdd = Fraction.Add(f1, f2);
                resultAdd.DisplayFraction();
                resultAdd.DisplayDecimal();

                Console.WriteLine("\nSubtraction:");
                Fraction resultSubtract = Fraction.Subtract(f1, f2);
                resultSubtract.DisplayFraction();
                resultSubtract.DisplayDecimal();

                Console.WriteLine("\nMultiplication:");
                Fraction resultMultiply = Fraction.Multiply(f1, f2);
                resultMultiply.DisplayFraction();
                resultMultiply.DisplayDecimal();

                Console.WriteLine("\nDivision:");
                Fraction resultDivide = Fraction.Divide(f1, f2);
                resultDivide.DisplayFraction();
                resultDivide.DisplayDecimal();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();
        }
    }

}
