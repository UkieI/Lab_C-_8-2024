namespace Lab4
{

    class Ex2
    {   

        static List<decimal> Tast2(List<decimal> numbers)
        {
            for (int i = 0 ; i < numbers.Count /2 + 1; i++){
                numbers[i] += numbers[numbers.Count -1];
                numbers.RemoveAt(numbers.Count -1);
            }
            return numbers;
        }
        public static void run()
        {
            List<decimal> numbers = new List<decimal> { 1.0m, 2.0m, 3.0m, 4.0m, 5.0m};
            List<decimal>  result = Tast2(numbers);
            Console.WriteLine("Result: " + string.Join(", ", result));

            numbers = new List<decimal> { 1.0m, 2.0m, 3.0m, 4.0m};
            result = Tast2(numbers);
            Console.WriteLine("Result: " + string.Join(", ", result));
        }   
    }


}
