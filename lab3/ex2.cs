// namespace Lab3 
// {
//     public abstract class Animal
//     {
//         public string Type { get; private set; }
//         protected Animal(string type)
//         {
//             Type = type;
//         }
//         // Abstract method to get sound made by the animal
//         public abstract string GetSound();
//         // Abstract method to get information about the animal
//         public abstract string GetInfo();
//     }



//     public class Duck : Animal
//     {
//         public string Name { get; set; }

//         public Duck(string name) : base("Bird")
//         {
//             Name = name;
//         }
//         public override string GetSound()
//         {
//             return "Quack";
//         }
//         public override string GetInfo()
//         {
//             return $"Duck: Name={Name}";
//         }
//         public void Swim(string place)
//         {
//             Console.WriteLine($"{Name} is swimming in the {place}.");
//         }
//         public override string ToString()
//         {
//             return GetInfo() + $", Sound={GetSound()}";
//         }
//     }

//     public class Dog : Animal
//     {
//         public string Name { get; set; }
//         public string Breed { get; set; }

//         public Dog(string name, string breed) : base("Mammal")
//         {
//             Name = name;
//             Breed = breed;
//         }
//         public override string GetSound()
//         {
//             return "Woof";
//         }
//         public override string GetInfo()
//         {
//             return $"Dog: Name={Name}, Breed={Breed}";
//         }
//         public override string ToString()
//         {
//             return GetInfo() + $", Sound={GetSound()}";
//         }
//     }

//     public class Cat : Animal
//     {
//         public string Name { get; set; }

//         public Cat(string name) : base("Mammal")
//         {
//             Name = name;
//         }
//         public override string GetSound()
//         {
//             return "Meow";
//         }
//         public override string GetInfo()
//         {
//             return $"Cat: Name={Name}";
//         }
//         public void Climb(string place)
//         {
//             Console.WriteLine($"{Name} is climbing the {place}.");
//         }
//         public override string ToString()
//         {
//             return GetInfo() + $", Sound={GetSound()}";
//         }
//     }

    
//     class Ex2
//     {
//         public static void run()
//         {
       
//             Dog dog = new Dog("Doggy", "Spaniel");
//             Cat cat = new Cat("Kitten");
//             Duck duck = new Duck("Ducky");


//             Console.WriteLine(dog.ToString());
//             Console.WriteLine(cat.ToString());
//             Console.WriteLine(duck.ToString());
       
//             cat.Climb("tree");
//             duck.Swim("pond");
//         }
//     }

// }