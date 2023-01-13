using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanallniyZadanieFour_Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(); // Экземпляр класса Bank - bank
            Console.Write("Введите сумму вклада(можно и с копейками влаживать(через запятую)): ");
            double amountDeposit = Convert.ToDouble(Console.ReadLine()); // пользователь вводит число - сумма вклада
            Console.Write("Введите на сколько лет положите вклад(3 или более): ");
            int ageDeposit = Convert.ToInt32(Console.ReadLine()); // пользователь вводит число - лет годов
            if (ageDeposit >= 3) // условие если года равны 3 или больше, то всё чики-пуки, а если пользователь, не знает русского языка, и не понял ЧТО ЕМУ НУЖНО ВВЕСТИ 3 ИЛИ БОЛЕЕ, то переходит в else
            {
                Console.WriteLine($"Через {ageDeposit} года/лет ваш вклад будет равен: {bank.DepositVariable(ageDeposit, amountDeposit)} рублей"); //На консоль выводится результат 4-ого задания
                Console.WriteLine($"Поздравляю вас, наш замечательный банк, за ваш вклад начисляет 15 Е-Баллов(не зависит от суммы вклада) и теперь ваша сумма вклада равна: {bank.DepositBonus(ageDeposit,amountDeposit)}");//На консоль выводится результат 5-ого задания
            }
            else
                Console.WriteLine("Не верно выбрано : на сколько лет(годов) будет сделан вклад");
            Console.ReadKey();
        }
    }
    public class Bank
    {
        public double DepositVariable(int ageDeposit, double amountDeposit) // метод возвращает дробное число
        {
            //если что не понятно, спросите на уроке пожалуйста, потому что я устал и ухожу, Всё! 
                double resultDeposit = 0;
                if (amountDeposit < 100 && amountDeposit !=0)
                    return resultDeposit = (((amountDeposit * 7) /100)+ amountDeposit) * ageDeposit ;
                if (amountDeposit >= 100 && amountDeposit <200)
                    return resultDeposit = (((amountDeposit * 9) / 100) + amountDeposit) * ageDeposit;
                else 
                    return resultDeposit = (((amountDeposit * 12) / 100) + amountDeposit) * ageDeposit;
           
        }
        public double DepositBonus(int ageDeposit, double amountDeposit)// метод возвращает дробное число (бонусы 5 задание)
        {
            //аналагично(
            double depositBonus = 15;
            double resultDeposit = 0;
            if (amountDeposit < 100 && amountDeposit != 0)
                return resultDeposit = (((amountDeposit * 7) / 100) + amountDeposit) * ageDeposit + depositBonus;
            if (amountDeposit >= 100 && amountDeposit < 200)
                return resultDeposit = (((amountDeposit * 9) / 100) + amountDeposit) * ageDeposit + depositBonus;
            else
                return resultDeposit = (((amountDeposit * 12) / 100) + amountDeposit) * ageDeposit + depositBonus;
            
        }
    }
}
