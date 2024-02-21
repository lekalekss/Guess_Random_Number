using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

class RandomNumberGenerator
{    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Welcome to the game 'Guess the number!'");
        Console.WriteLine("I guessed the number between: 1 to 100");
        Console.WriteLine("Try to guess");
        Random guess = new Random();

        int guessNumber = guess.Next(1, 100);
                        
        List<int> guessList = new List<int>();

        while (true)
        {            
            string try1 = Console.ReadLine();
            bool tryConsole = int.TryParse(try1 , out int number);

            if (tryConsole == true)
            {                
                guessList.Add(number);
                int countTimesToGuess = guessList.Count;
                
                if (guessNumber == number)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Good job!!!");
                    Console.WriteLine("You guessed this number by " + countTimesToGuess + " times");
                    Console.ResetColor();

                    break;
                }

                if (number != guessNumber)
                {
                    if (number < guessNumber && number >0)
                    {
                        Console.WriteLine("The hidden number is higher. \nNext chance: ");
                        continue;
                    }

                    if (number > guessNumber && number < 100)
                    {
                        Console.WriteLine("The hidden number is lower. \nNext chance: ");
                        continue;
                    }
                    if (number < 0 || number > 100)
                    {
                        Console.WriteLine("The hidden number is between 1 and 100");
                        continue;
                    }
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please choose number from 1 to 100");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}

































        //Random guess = new Random();

        
        //    int guessNumber = guess.Next(1,100);
        

        //Console.WriteLine(guessNumber);
        //while (true)
        //{
        //        string try1 = Console.ReadLine();
        //        int tryNumber = int.Parse(try1);

        //    int count = tryNumber.ToString().Count();
        //    Console.WriteLine(count);

            
        
        //    if (guessNumber == tryNumber)
        //    {
        //        Console.WriteLine("Good job");

        //        break;
        //    }

        //    if (guessNumber != tryNumber) 
        //    {
        //        Console.WriteLine("Next chance");
        //        continue;
        //    }
        //}
        

        
        


      

        // Создаем объект для генерации чисел
        
        // Создаем переменную для хранения случайного числа
        
        // Создаем переменную для хранения числа попыток
        
        // 1. Создаем цикл, который будет выполняться до тех пор, пока не будет угадано число
        
        
        // 2. В теле цикла:
            // 2.1. Увеличиваем счетчик попыток на 1
            
            // 2.2. Считываем число с клавиатуры и сохраняем в переменную
            
            // 2.3. Сравниваем загаданное число с введенным пользователем
            
            // 2.4. Если числа равны, то выводим сообщение о победе и о количестве попыток
            
            // 2.5. Если число пользователя больше загаданного, то выводим сообщение, что число больше загаданного
            
            // 2.6. Если число пользователя меньше загаданного, то выводим сообщение, что число меньше загаданного
            
            // 2.7. Если число попыток равно 10, то выводим сообщение о проигрыше и загаданное число
        
            
        // Так же помним что надо проверять ввод пользователя на корректность
        // Если пользователь ввел не число, то выводим сообщение об ошибке и просим ввести число еще раз
        // Число джолжно быть в диапазоне от 1 до 100 и целое
        
    

   

