using System.Text;

namespace Petshop
{
    internal class Program
    {
        public class Animal
        {

            public string Nickname { get; set; }
            public int Age { get; set; }
            public bool isMan { get; set; }
            public int Energy { get; set; }
            public double Price { get; set; }
            public int MealQuantity { get; set; }
            public virtual void Eat() { }
            public virtual void Sleep() { }
            public virtual void Play() { }
            public Animal(string nickname, int age, bool isMan, int energy, double price, int mealq)
            {
                Nickname = nickname;
                Age = age;
                this.isMan = isMan;
                Energy = energy;
                Price = price;
                MealQuantity = mealq;
            }

            public override string ToString() => $@"Nickname: {Nickname}
Age: {Age}
Gender: {(isMan ? "Man" : "Woman")}
Energy: {Energy}
Meal Quantity: {MealQuantity}";
        }

        public class Cat : Animal
        {
            public Cat(string nickname, int age, bool isMan, int energy, double price, int mealq) : base(nickname, age, isMan, energy, price, mealq)
            {
            }

            public void Meals() { Console.WriteLine($@"f-Fish-30$
ch-Chicken-25$
c-Cat Food-15$
m-Meat-40$
"); }
            public override void Eat()
            {
                bool isRun = true;

                while (isRun)
                {
                    Console.WriteLine(@"1-Choose meal
2-Exit");

                    int sec1 = Convert.ToInt32(Console.ReadLine());

                    switch (sec1)
                    {
                        case 1:
                            Meals();
                            Console.Write("Choose: ");
                            string sec = Console.ReadLine().ToLower();

                            switch (sec)
                            {
                                case "f":
                                    if (Price < 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given fish.");
                                    Console.ResetColor();
                                    Price -= 30;
                                    Energy += 10;
                                    break;

                                case "ch":
                                    if (Price < 25)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given chicken.");
                                    Console.ResetColor();
                                    Price -= 25;
                                    Energy += 8;
                                    break;

                                case "c":
                                    if (Price < 15)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given cat meal");
                                    Console.ResetColor();
                                    Price -= 15;
                                    Energy += 5;
                                    break;

                                case "m":
                                    if (Price < 40)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given meat");
                                    Console.ResetColor();
                                    Price -= 40;
                                    Energy += 15;
                                    break;

                                default:
                                    Console.WriteLine("Unknown");
                                    break;
                            }

                            if (Energy > 100)
                                Energy = 100;

                            if (Energy == 100)
                                Console.WriteLine($"{Nickname} is full. Doesn't want to eat anymore");

                            Console.WriteLine($"\nEnergy: {Energy}");
                            Console.WriteLine($"Price: {Price}$");
                            Console.WriteLine($"Meal Quantity: {MealQuantity}\n");

                            break;

                        case 2:
                            Console.WriteLine("You exited.");
                            isRun = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong choice");
                            Console.ResetColor();
                            break;
                    }
                }
            }

            public override void Sleep()
            {
                Console.Write("How long should he sleep?(20,40,60,80,100)");
                int cho1 = Convert.ToInt32(Console.ReadLine());
                switch (cho1)
                {
                    case 20:
                        Energy += 10;
                        break;

                    case 40:
                        Energy += 20;
                        break;

                    case 60:
                        Energy += 30;
                        break;

                    case 80:
                        Energy += 40;
                        break;

                    case 100:
                        Energy += 50;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong choice.");
                        Console.ResetColor();
                        return;
                }

                if (Energy > 100)
                    Energy = 100;

                Console.WriteLine($"{Nickname} slept and gained {cho1} energy.");
                Console.WriteLine($"Current energy: {Energy}");
            }

            public override void Play()
            {
                if (Energy <= 10)
                {
                    Console.WriteLine($"{Nickname} wants to sleep."); return;
                }
                Energy -= 15;

                if (Energy < 0)
                    Energy = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Nickname} played and used energy.");
                Console.WriteLine($"Current energy: {Energy}");
                Console.ResetColor();

            }
        }

        public class Dog : Animal
        {
            public Dog(string nickname, int age, bool isMan, int energy, double price, int mealq) : base(nickname, age, isMan, energy, price, mealq)
            {
            }

            public void Meals() { Console.WriteLine($@"b-Beef-30$
ch-Chicken-25$
d-Dog Food-15$
m-Meat-40$
"); }
            public override void Eat()
            {
                bool isRun = true;

                while (isRun)
                {
                    Console.WriteLine(@"1-Choose meal
2-Exit");

                    int sec1 = Convert.ToInt32(Console.ReadLine());

                    switch (sec1)
                    {
                        case 1:
                            Meals();
                            Console.Write("Choose: ");
                            string sec = Console.ReadLine().ToLower();

                            switch (sec)
                            {
                                case "b":
                                    if (Price < 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given beef.");
                                    Console.ResetColor();
                                    Price -= 30;
                                    Energy += 10;
                                    break;

                                case "ch":
                                    if (Price < 25)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given chicken.");
                                    Console.ResetColor();
                                    Price -= 25;
                                    Energy += 8;
                                    break;

                                case "d":
                                    if (Price < 15)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given dog meal");
                                    Console.ResetColor();
                                    Price -= 15;
                                    Energy += 5;
                                    break;

                                case "m":
                                    if (Price < 40)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} is given meat");
                                    Console.ResetColor();
                                    Price -= 40;
                                    Energy += 15;
                                    break;

                                default:
                                    Console.WriteLine("Unknown");
                                    break;
                            }

                            if (Energy > 100)
                                Energy = 100;

                            if (Energy == 100)
                                Console.WriteLine($"{Nickname} is full. Doesn't want to eat anymore");

                            Console.WriteLine($"\nEnergy: {Energy}");
                            Console.WriteLine($"Price: {Price}$");
                            Console.WriteLine($"Meal Quantity: {MealQuantity}\n");

                            break;

                        case 2:
                            Console.WriteLine("You exited.");
                            isRun = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong choice");
                            Console.ResetColor();
                            break;
                    }
                }
            }

            public override void Sleep()
            {
                Console.Write("How long should he sleep?(20,40,60,80,100)");
                int cho1 = Convert.ToInt32(Console.ReadLine());
                switch (cho1)
                {
                    case 20:
                        Energy += 10;
                        break;

                    case 40:
                        Energy += 20;
                        break;

                    case 60:
                        Energy += 30;
                        break;

                    case 80:
                        Energy += 40;
                        break;

                    case 100:
                        Energy += 50;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong choice.");
                        Console.ResetColor();
                        return;
                }

                if (Energy > 100)
                    Energy = 100;

                Console.WriteLine($"{Nickname} slept and gained {cho1} energy.");
                Console.WriteLine($"Current energy: {Energy}");
            }

            public override void Play()
            {
                if (Energy <= 10)
                {
                    Console.WriteLine($"{Nickname} wants to sleep."); return;
                }
                Energy -= 15;

                if (Energy < 0)
                    Energy = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Nickname} played and used energy.");
                Console.WriteLine($"Current energy: {Energy}");
                Console.ResetColor();
            }
        }
        public class Bird : Animal
        {
            public Bird(string nickname, int age, bool isMan, int energy, double price, int mealq) : base(nickname, age, isMan, energy, price, mealq)
            {
            }

            public void Meals() { Console.WriteLine($@"s-Seed-30$
g-Grains-25$
f-Fruits-15$
v-Vegtables-40$
"); }
            public override void Eat()
            {
                bool isRun = true;

                while (isRun)
                {
                    Console.WriteLine(@"1-Choose meal
2-Exit");

                    int sec1 = Convert.ToInt32(Console.ReadLine());

                    switch (sec1)
                    {
                        case 1:
                            Meals();
                            Console.Write("Choose: ");
                            string sec = Console.ReadLine().ToLower();

                            switch (sec)
                            {
                                case "s":
                                    if (Price < 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given seeds.");
                                    Console.ResetColor();
                                    Price -= 30;
                                    Energy += 10;
                                    break;

                                case "g":
                                    if (Price < 25)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given grains.");
                                    Console.ResetColor();
                                    Price -= 25;
                                    Energy += 8;
                                    break;

                                case "f":
                                    if (Price < 15)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given fruits");
                                    Console.ResetColor();
                                    Price -= 15;
                                    Energy += 5;
                                    break;

                                case "v":
                                    if (Price < 40)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given vegetables");
                                    Console.ResetColor();
                                    Price -= 40;
                                    Energy += 15;
                                    break;

                                default:
                                    Console.WriteLine("Unknown");
                                    break;
                            }

                            if (Energy > 100)
                                Energy = 100;

                            if (Energy == 100)
                                Console.WriteLine($"{Nickname} is full. Doesn't want to eat anymore");

                            Console.WriteLine($"\nEnergy: {Energy}");
                            Console.WriteLine($"Price: {Price}$");
                            Console.WriteLine($"Meal Quantity: {MealQuantity}\n");

                            break;

                        case 2:
                            Console.WriteLine("You exited.");
                            isRun = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong choice");
                            Console.ResetColor ();
                            break;
                    }
                }
            }

            public override void Sleep()
            {
                Console.Write("How long should he sleep?(20,40,60,80,100)");
                int cho1 = Convert.ToInt32(Console.ReadLine());
                switch (cho1)
                {
                    case 20:
                        Energy += 10;
                        break;

                    case 40:
                        Energy += 20;
                        break;

                    case 60:
                        Energy += 30;
                        break;

                    case 80:
                        Energy += 40;
                        break;

                    case 100:
                        Energy += 50;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong choice.");
                        Console.ResetColor();
                        return;
                }

                if (Energy > 100)
                    Energy = 100;

                Console.WriteLine($"{Nickname} slept and gained {cho1} energy.");
                Console.WriteLine($"Current energy: {Energy}");
            }

            public override void Play()
            {
                if (Energy <= 10)
                {
                    Console.WriteLine($"{Nickname} wants to sleep."); return;
                }
                Energy -= 15;

                if (Energy < 0)
                    Energy = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Nickname} played and used energy.");
                Console.WriteLine($"Current energy: {Energy}");
                Console.ResetColor();
            }
        }
        public class Fish : Animal
        {
            public Fish(string nickname, int age, bool isMan, int energy, double price, int mealq) : base(nickname, age, isMan, energy, price, mealq)
            {
            }

            public void Meals() { Console.WriteLine($@"s-Small Fish-30$
p-Fish Pieces-25$
m-Fish Meal-15$
d-Dried Fish-40$
"); }
            public override void Eat()
            {
                bool isRun = true;

                while (isRun)
                {
                    Console.WriteLine(@"1-Choose meal
2-Exit");

                    int sec1 = Convert.ToInt32(Console.ReadLine());

                    switch (sec1)
                    {
                        case 1:
                            Meals();
                            Console.Write("Choose: ");
                            string sec = Console.ReadLine().ToLower();

                            switch (sec)
                            {
                                case "s":
                                    if (Price < 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given small fish.");
                                    Price -= 30;
                                    Energy += 10;
                                    break;

                                case "p":
                                    if (Price < 25)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given fish pieces.");
                                    Price -= 25;
                                    Energy += 8;
                                    break;

                                case "m":
                                    if (Price < 15)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given fish meals");
                                    Price -= 15;
                                    Energy += 5;
                                    break;

                                case "d":
                                    if (Price < 40)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Not enough money");
                                        Console.ResetColor();
                                        break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{Nickname} are given dried fish");
                                    Price -= 40;
                                    Energy += 15;
                                    break;

                                default:
                                    Console.WriteLine("Unknown");
                                    break;
                            }

                            if (Energy > 100)
                                Energy = 100;

                            if (Energy == 100)
                                Console.WriteLine($"{Nickname} is full. Doesn't want to eat anymore");

                            Console.WriteLine($"\nEnergy: {Energy}");
                            Console.WriteLine($"Price: {Price}$");
                            Console.WriteLine($"Meal Quantity: {MealQuantity}\n");

                            break;

                        case 2:
                            Console.WriteLine("You exited.");
                            isRun = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong choice");
                            Console.ResetColor();
                            break;
                    }
                }
            }

            public override void Sleep()
            {
                Console.Write("How long should he sleep?(20,40,60,80,100)");
                int cho1 = Convert.ToInt32(Console.ReadLine());
                switch (cho1)
                {
                    case 20:
                        Energy += 10;
                        break;

                    case 40:
                        Energy += 20;
                        break;

                    case 60:
                        Energy += 30;
                        break;

                    case 80:
                        Energy += 40;
                        break;

                    case 100:
                        Energy += 50;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong choice.");
                        Console.ResetColor ();
                        return;
                }

                if (Energy > 100)
                    Energy = 100;

                Console.WriteLine($"{Nickname} slept and gained {cho1} energy.");
                Console.WriteLine($"Current energy: {Energy}");
            }

            public override void Play()
            {
                if (Energy <= 10)
                {
                    Console.WriteLine($"{Nickname} wants to sleep."); return;
                }
                Energy -= 15;

                if (Energy < 0)
                    Energy = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Nickname} played and used energy.");
                Console.WriteLine($"Current energy: {Energy}");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            bool IsRun1 = true;
            while (true)
            {
                Console.WriteLine(@"1-Cat
2-Dog
3-Bird
4-Fish");
                int cho2 = Convert.ToInt32(Console.ReadLine());
                switch (cho2)
                {
                    case 1:
                        bool catRun = true;
                        Cat cat = new Cat("Mestan", 3, true, 20, 400, 250);
                        Console.WriteLine(cat.ToString() + "\n");
                        while (catRun)
                        {
                            Console.Write("p-Play\ne-Eat\ns-Sleep\n0-exit: ");
                            char cho3 = Convert.ToChar(Console.ReadLine());
                            switch (cho3)
                            {
                                case 'p': cat.Play(); break;
                                case 'e': cat.Eat(); break;
                                case 's': cat.Sleep(); break;
                                case '0': catRun = false; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Wrong choice"); Console.ResetColor(); break;
                            }
                        }
                        break;
                    case 2:
                        bool dogRun = true;
                        Dog dog = new Dog("Bitbul", 3, true, 20, 400, 250);
                        Console.WriteLine(dog.ToString() + "\n");
                        while (dogRun)
                        {
                            Console.Write("p-Play\ne-Eat\ns-Sleep\n0-exit");
                            char cho3 = Convert.ToChar(Console.ReadLine());
                            switch (cho3)
                            {
                                case 'p': dog.Play(); break;
                                case 'e': dog.Eat(); break;
                                case 's': dog.Sleep(); break;
                                case '0': dogRun = false; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Wrong choice"); Console.ResetColor(); break; 
                            }
                        }
                        break;

                    case 3:
                        bool birdRun = true;
                        Bird bird = new Bird("Qargha", 3, true, 20, 400, 250);
                        Console.WriteLine(bird.ToString() + "\n");
                        while (birdRun)
                        {
                            Console.Write("p-Play\ne-Eat\ns-Sleep\n0-exit");
                            char cho3 = Convert.ToChar(Console.ReadLine());
                            switch (cho3)
                            {
                                case 'p': bird.Play(); break;
                                case 'e': bird.Eat(); break;
                                case 's': bird.Sleep(); break;
                                case '0': birdRun = false; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Wrong choice"); Console.ResetColor(); break;
                            }
                        }
                        break;
                    case 4:
                        bool fishRun = true;
                        Fish fish = new Fish("Akula", 3, true, 20, 400, 250);
                        Console.WriteLine(fish.ToString() + "\n");
                        while (fishRun)
                        {
                            Console.Write("p-Play\ne-Eat\ns-Sleep\n0-exit");
                            char cho3 = Convert.ToChar(Console.ReadLine());
                            switch (cho3)
                            {
                                case 'p': fish.Play(); break;
                                case 'e': fish.Eat(); break;
                                case 's': fish.Sleep(); break;
                                case '0': fishRun = false; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Wrong choice"); Console.ResetColor(); break;
                            }
                        }
                        break;

                }
                if (cho2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You exicted");
                    break;
                    Console.ResetColor();
                }
            }
        }
    }
}

