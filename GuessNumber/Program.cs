using Microsoft.Extensions.DependencyInjection;

namespace GuessNumber
{
    class Program
    {
        static void Main()
        {
            using (var serviceProvider = SetupDI())
            {
                serviceProvider.GetService<App>().Run();
            }
        }

        private static ServiceProvider SetupDI()
        {
            var services = new ServiceCollection();

            services.AddTransient<IAnimation, TrainAnimation>();
            services.AddTransient<IGame, Game>();

            services.AddTransient<App>();

            return services.BuildServiceProvider();
        }
    }

}

//Игра “Угадай число” (консольное приложение):

//компьютер “загадывает” целое число от 0 до 100 (включительно).

//Человек вводит ответ, программа должна:
//-если введено не число - вывести ошибку, предложить повторно ввести число.
//- если введенное число больше/меньше - вывести подсказку для игрока “загаданное число меньше/больше”, предложить повторно ввести число.
//- если угадал - поздравить и предложить сыграть ещё раз.
