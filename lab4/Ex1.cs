namespace Lab4
{

    class Ex1
    {   
        static List<decimal> SumAdjacentEqualNumbers(List<decimal> numbers)
        {
  

            int i = 0;
            while (i < numbers.Count)
            {
                int j = i + 1;
                
                if (j < numbers.Count && numbers[j] == numbers[i]){
            
                    numbers[i] = numbers[i] + numbers[i];
                    numbers.RemoveAt(j);
                    j++;
                 
                    i = -1;
                }
                i++;
              
            }

            return numbers;
        }
        public static void run()
        {
            List<decimal> numbers = new List<decimal> { 3.0m, 3.0m, 6.0m, 1.0m };
            List<decimal> result = SumAdjacentEqualNumbers(numbers);
            Console.WriteLine("Result: " + string.Join(", ", result));

            numbers = new List<decimal> { 8.0m, 2.0m, 2.0m, 4.0m, 8.0m, 16.0m };
            result = SumAdjacentEqualNumbers(numbers);
            Console.WriteLine("Result: " + string.Join(", ", result));

            numbers = new List<decimal> { 5.0m, 4.0m, 2.0m, 1.0m, 1.0m, 4.0m };
            result = SumAdjacentEqualNumbers(numbers);
            Console.WriteLine("Result: " + string.Join(", ", result));
        }   
    }

}
