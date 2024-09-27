namespace Lab3
{

    public class Singleton
    {

        private static Singleton instance = null;
   
        private static readonly object padlock = new object();
 
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        public static Singleton Instance
        {
            get
            {
   
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine("Message Singleton: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
     
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
    
            if (s1 == s2)
            {
                Console.WriteLine("Both instances are the same.");
            }
        
            s1.ShowMessage("Hello, Singleton!");
            Console.ReadLine();
        }
    }

}