using System.Security.Cryptography;
using System.Threading;
namespace ConsoleApp1
{
    internal class Quiz
    {
        static void myQuiz()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int xal = 0;
            int correctAnswer = 0;
            string[] questions = new string[10]
            {
                "1. C# dilində virtual və override açar sözləri hansı OOP prinsipini reallaşdırmaq üçün istifadə olunur?",
                "2. Bir class daxilində eyni adlı, lakin fərqli parametrlərə (data tiplərinə və ya sayına) malik birdən çox metodun yazılması necə adlanır?",
                "3. C# dilində encapsulation (inkapsulyasiya) tətbiq edərkən, sinif daxilindəki gizli (private) sahələrə təhlükəsiz şəkildə dəyər mənimsətmək və ya oxumaq üçün hansı strukturdan istifadə edilir?",
                "4. Əgər bir sinfin (class) başqa siniflər tərəfindən miras alınmasını (Inheritance) tamamilə əngəlləmək istəyirsinizsə, hansı açar sözdən istifadə etməlisiniz?",
                "5. C# dilində abstract class daxilində təyin olunmuş abstract metod haqqında hansı ifadə doğrudur?",
                "6. OOP-nin Abstraksiya prinsipini tətbiq edərkən C#-da Interface istifadə edirik. İnterfeyslər haqqında hansı fikir SƏHVDİR?",
                "7. C# OOP-də base açar sözünün funksiyası nədir?",
                "8. protected giriş təyinedicisi (access modifier) ilə işarələnmiş bir dəyişənə və ya metoda haradan müraciət etmək olar?",
                "9. OOP-də obyekt yaradılan zaman (instantiation) işə düşən və obyektin ilkin vəziyyətini (məsələn, dəyişənlərin ilkin dəyərlərini) təyin edən xüsusi metod necə adlanır?",
                "10. Polymorphism mövzusuna aid bir sual: Aşağıdakı kod sətirlərindən hansı \"Upcasting\" (törəmə sinif obyektinin valideyn sinif tipinə mənimsədilməsi) nümunəsidir? (Fərz edin ki, Dog sinfi Animal sinfindən miras alıb)."
            };

            string[,] answers = new string[10, 3]
            {
                { "İnkapsulyasiya (Encapsulation)","Polimorfizm (Polymorphism)","Abstraksiya (Abstraction)"},
                { "Method Overriding","Method Overloading","Method Hiding (new modifier)"},
                { "Properties (get və set accessor-ları)","Constructors (Konstruktorlar)","Namespaces (Ad fəzaları)"},
                { "static","abstract","sealed"},
                { "Metodun gövdəsi (kod bloku) mütləq elə abstract class-ın daxilində yazılmalıdır.","Bu metodun gövdəsi olmur və ondan miras alan törəmə siniflərdə mütləq override edilərək reallaşdırılmalıdır.","Törəmə siniflərdə bu metodu yazmaq məcburi deyil, istəyə bağlıdır."},
                { "İnterfeys daxilində field-lər (məsələn: private int id;) saxlamaq olar.","Bir sinif birdən çox interfeysi özünə tətbiq (implement) edə bilər.","İnterfeysdən new açar sözü ilə birbaşa obyekt yaratmaq olmaz."},
                { "Proqramın əsas giriş nöqtəsi olan Main metoduna müraciət edir.","Törəmə sinif daxilindən, miras alınan valideyn (parent) sinfin konstruktoruna, metodlarına və ya property-lərinə müraciət etmək üçün istifadə olunur.","Yaddaşın Heap hissəsindəki obyekti tamamilə silir."},
                { "Yalnız yazıldığı sinfin daxilindən və həmin sinifdən miras alan törəmə siniflərin daxilindən.","Layihənin (Assembly) istənilən yerindən və xarici layihələrdən.","Sırf eyni qovluqda (namespace) yerləşən digər bütün siniflərdən."},
                { "Destructor","Constructor","Initializer"},
                { "Dog myDog = new Animal();","Animal myAnimal = new Dog();","Dog myDog = (Dog)new Animal();"}

            };

            int[,] answersMatrix = new int[10, 3]{
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2},
                { 0,1,2}
            };

            int[] correctAnswersIndex = new int[10] { 1, 1, 0, 2, 1, 0, 1, 0, 1, 1 };


            Random rand = new Random();
            for (int q = 0; q < questions.Length; q++)
            {
                int select = 0;
                for (int a = 0; a < 3; a++)
                {
                    int randId = rand.Next(0, 3);

                    var temp = answers[q, a];
                    answers[q, a] = answers[q, randId];
                    answers[q, randId] = temp;

                    var tempMatrix = answersMatrix[q, a];
                    answersMatrix[q, a] = answersMatrix[q, randId];
                    answersMatrix[q, randId] = tempMatrix;
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(questions[q]);
                    for (int a = 0; a < 3; a++)
                    {
                        if (a == select)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine($">> {answers[q, a]}");
                            Console.ResetColor();
                        
                        }
                        else
                        {
                            Console.WriteLine($"   {answers[q, a]}");
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (answersMatrix[q, select] == correctAnswersIndex[q])
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("CORRECT!");
                            Console.ResetColor();
                            correctAnswer++;
                            xal += 10;
                            Thread.Sleep(700);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("WRONG!");
                            Console.ResetColor();
                            if (xal >= 10) {
                                xal -= 10;
                            }
                            else
                            {
                                xal = 0;
                            }
                            Thread.Sleep(700);
                        }

                        break;
                    }

                    if (key.Key == ConsoleKey.UpArrow && select > 0)
                    {
                        select--;
                    }

                    if (key.Key == ConsoleKey.DownArrow && select < 2)
                    {
                        select++;
                    }
                }
            }
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Result: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct answers: {correctAnswer}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong answers: {questions.Length - correctAnswer}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"XAL: {xal}");
            Thread.Sleep(5000);
        }
        static void Menu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int select = 0;
            string[] menu = new string[2] { "Start Quiz", "Exit" };
            while (true)
            {
                Console.Clear();
               
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine(" ////////////////////////////////////////");
                Console.WriteLine("//              QUIZ                  //");
                Console.WriteLine("////////////////////////////////////////");
                Console.ResetColor();
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == select)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($">> {menu[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   { menu[i]}");
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    if (select == 0) myQuiz();
                    else if (select == 1) { 
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You exited...");
                        Console.ResetColor();
                        break;
                    };
                }
                if (key.Key == ConsoleKey.UpArrow && select > 0)
                {
                    select--;
                }
                if (key.Key == ConsoleKey.DownArrow && select < menu.Length - 1)
                {
                    select++;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
