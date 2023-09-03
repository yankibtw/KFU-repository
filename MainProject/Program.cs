using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Program
    {
        static void PrintOnConsole(){
            Console.WriteLine("Задание №1:\nМир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай\n");
        }
        static void TwoNumbers() {
            Console.WriteLine("Задание №2:\nВведите 2 числа(каждое с новой строки)(Примечание: Дробные числа важно вводить по образцу: 2,3):");
            string FirstNumber = Console.ReadLine(),
                   SecondNumber = Console.ReadLine();
            try {
                double FirstNumberInDouble = Double.Parse(FirstNumber);
                double SecondNumberInDouble = Double.Parse(SecondNumber);
            }
            catch (System.FormatException) { Console.WriteLine("Введите числа корректно!!!\n");
            }
            finally { Console.WriteLine($"Ваши числа в обратном порядке: {SecondNumber} {FirstNumber} \n");
            }
        }
        static void RadiusSearch() {
            Console.WriteLine("Задание №3:");
            // Console.WriteLine("Введите радиус окружности:");
            // uint CircleRadius = uint.Parse(Console.ReadLine());
            uint СircleRadius = 5;
            Console.WriteLine($"Длина окружности с радиусом {СircleRadius} равна - {2 * Math.PI * СircleRadius}");
            Console.WriteLine($"Площадь круга с радиусом {СircleRadius} равна - {Math.PI * Math.Pow(СircleRadius, 2)}\n");  
        }
        static void SinusSearch() {
            Console.WriteLine("Задание №4:");
            // Console.WriteLine("Введите значение X, синус которого нужно найти:");
            // int CircleRadius = int.Parse(Console.ReadLine());
            int x = 6;
            Console.WriteLine($"Синус числа {x} равен: {Math.Sin(x)}\n");
        }
        static void Roots() {
            Console.WriteLine("Задание №5:\nВведите коэффициенты квадратного уравнения(Каждое с новой строки):");
            double a = int.Parse(Console.ReadLine()), 
                   b = int.Parse(Console.ReadLine()), 
                   c = int.Parse(Console.ReadLine());
            double discriminant = (Math.Pow(b, 2) - 4 * a * c);
            if (discriminant < 0) {
                Console.WriteLine("Квадратное уравнение с данными коэффициентами корней не имеет!\n");
            } else if (discriminant == 0) {
                Console.WriteLine($"Квадратное уравнение с данными коэффициентами имеет 1 корень = {(-b + Math.Sqrt(discriminant)) / (2 * a)}!\n");
            } else {
                Console.WriteLine($"Квадратное уравнение с данными коэффициентами имеет 2 кореня = {(-b + Math.Sqrt(discriminant)) / (2 * a)}, {(-b - Math.Sqrt(discriminant)) / (2 * a)}!\n");
            }
        }
        static void Exchange() {
            Console.WriteLine("Задание №6:\nВведите числовые значения(Каждое с новой строки):");
            double a = double.Parse(Console.ReadLine()),
                   b = double.Parse(Console.ReadLine()),
                   c = double.Parse(Console.ReadLine());

            string ExA(double first, double second, double third){
                double BufferForB = second,
                       BufferForA = first;
                second = third;
                first = BufferForB;
                third = BufferForA;
                return ($"{first}, {second}, {third}");
            }
            string ExB(double first, double second, double third) {
                double BufferForB = second,
                       BufferForC = third;
                second = first;
                first = BufferForC;
                third = BufferForB;
                return ($"{first}, {second}, {third}");
            }
            Console.WriteLine($"Результат обмена значениями под пунктом A: {ExA(a, b, c)}");
            Console.WriteLine($"Результат обмена значениями под пунктом B: {ExB(a, b, c)}\n");
        }
        static void RandomValues() {
            Console.WriteLine("Задание №7:");
            Random random = new Random();
            Console.WriteLine($"Случайно сгенерированные числа:\n" +
                $"{random.Next()}\n" +
                $"{random.Next()}\n" +
                $"{random.Next()}\n" +
                $"{random.Next()}\n");
        }
        static void ChangeValue() {
            short value = 235;
            Console.WriteLine($"Задание №8:\nИсходное число: {value}");
            string valueToString = value.ToString();
            string newStringValue = valueToString[2] + "" + valueToString[0] + "" + valueToString[1];
            Console.WriteLine($"Результат выполнения программы: {short.Parse(newStringValue)}\n");
        }
        static void BasketPrice() {
            uint candiesPrice = 56,
                 cookiesPrice = 76,
                 applesPrice = 92;
            Console.WriteLine("Задание №8:\nСколько килограмм конфет, печенья и яблок Вы бы хотели приобрести?\n" +
                $"Цена за килограмм: Конфеты - {candiesPrice}, Печенье - {cookiesPrice}, Яблоки - {applesPrice}");
            uint candiesWeight = uint.Parse(Console.ReadLine()),
                 cookiesWeight = uint.Parse(Console.ReadLine()),
                 applesWeight = uint.Parse(Console.ReadLine());
            Console.WriteLine("Итоговая сумма корзины будет составлять: " +
                $"{(candiesPrice * candiesWeight) + (cookiesPrice * cookiesWeight) + (applesPrice * applesWeight)}");
        }
        static void Main(string[] args){
            PrintOnConsole();
            TwoNumbers();
            RadiusSearch();
            SinusSearch();
            Roots();
            Exchange();
            RandomValues();
            ChangeValue();
            BasketPrice();
        }
    }
}
