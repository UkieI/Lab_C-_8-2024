namespace Lab2{
    class Dice{
        private int numberOfSides;
        private Random random;
        
        public Dice(int sides){
            numberOfSides = sides;
            random = new Random();
        }
        public int Roll()
        {   
            return random.Next(1, numberOfSides + 1);
        }
    }
    class Ex1 {
        public  void run(){
            Console.Write("Enter the number of sides for the dice: ");
            
            int sides;
            if (int.TryParse(Console.ReadLine(), out sides) && sides > 0)
            {
                Dice dice = new Dice(sides);

                int result = dice.Roll();
                Console.WriteLine($"You rolled a {result} on a {sides}-sided dice.");
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer for the number of sides.");
            }
        }
    }
}
