using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Program
    {
        static void PrintOnConsole() {
            Console.WriteLine("Задание №1:\nМир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай\n");
        }
        static void TwoNumbers() {
            Console.WriteLine("Задание №2:\nВведите 2 числа(каждое с новой строки)(Примечание: Дробные числа важно вводить по образцу: 2,3):");
            string firstNumber = Console.ReadLine(),
                   secondNumber = Console.ReadLine();
            double firstValue, secondValue, bufferValue;

            if (!double.TryParse(firstNumber, out firstValue) || (!double.TryParse(secondNumber, out secondValue)))  {
                Console.WriteLine("Пожалуйста, введите корректные данные!!!");
            }else { 
                bufferValue = firstValue;
                firstValue = secondValue;
                secondValue = bufferValue;
                Console.WriteLine($"Ваши числа в обратном порядке: {firstValue} {secondValue}\n");
            }
        }
        static void RadiusSearch() {
            Console.WriteLine("Задание №3:\nВведите радиус окружности:");
            double circleRadius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Длина окружности с радиусом {circleRadius} равна - {2 * Math.PI * circleRadius}");
            Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна - {Math.PI * Math.Pow(circleRadius, 2)}\n");  
        }
        static void SinusSearch() {
            Console.WriteLine("Задание №4:\nВведите значение угла X, синус которого нужно найти:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Синус угла {x} равен: {Math.Sin(Math.PI * x / 180.0)}\n");
        }
        static void Roots() {
            Console.WriteLine("Задание №5:\nВведите коэффициенты квадратного уравнения(Каждое с новой строки):");
            double a = double.Parse(Console.ReadLine()), 
                   b = double.Parse(Console.ReadLine()), 
                   c = double.Parse(Console.ReadLine());
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
            Console.WriteLine("Задание №6:\nВведите числовые значения c которыми нужно проделать операции обмена(Каждое с новой строки):");
            double a = double.Parse(Console.ReadLine()),
                   b = double.Parse(Console.ReadLine()),
                   c = double.Parse(Console.ReadLine());

            string ExA(double first, double second, double third){
                double bufferForB = second;
                second = third;
                third = first;
                first = bufferForB;
                
                return ($"{first}, {second}, {third}");
            }
            string ExB(double first, double second, double third) {
                double bufferForB = second;
                second = first;
                first = third;
                third = bufferForB;
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
            Console.WriteLine("Задание №8:\nВведите трехзначное число, которое Вы бы хотели изменить:");
            string value = Console.ReadLine();
            if (value.Length != 3) {
                Console.WriteLine("Введите трехзначное число!!!\n");
            }
            else {
                uint valueToReverse = uint.Parse(value);
                uint newValue = ((valueToReverse % 10) * 100) + (valueToReverse / 10);
                Console.WriteLine($"Результат выполнения программы: {newValue}\n");
            }
        }
        static void BasketPrice() {
            Console.WriteLine("Задание №9:\nВведите цену Конфет, Печенья, Яблок за килограмм(Каждое значение с новой строки!): ");
            double candiesPrice = double.Parse(Console.ReadLine()),
                   cookiesPrice = double.Parse(Console.ReadLine()),
                   applesPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько килограмм конфет, печенья и яблок Вы бы хотели приобрести?");
            double candiesWeight = double.Parse(Console.ReadLine()),
                   cookiesWeight = double.Parse(Console.ReadLine()),
                   applesWeight = double.Parse(Console.ReadLine());
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
