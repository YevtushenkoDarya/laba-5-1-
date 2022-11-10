using System;
using System.Globalization;

namespace LABORATORKA5
{
    public class Program
    {
        static void Main()
        {
            string inputstr; // обьявляем переменную чтобы в будущем хранить в ней все что введется в консолое
            float bprevious = float.NaN; // в этой переменной будем хранить предыдущее значения для сравнения с будущим, обьявим его "Not a Number"
            do // начинает цикл чтобы программа не завершалась после ввода одного значения, а возвращала нас на начало
            {
                bool TryParseResult;  // в этой переменной будем хранить результат парсинга инта или флоАт
                inputstr = Console.ReadLine(); // читаем введенную строку из консоля сохраняем ее в инпутстр
                int a; // в этой переменной будем хранить преобразованное со строки интовое значени
                float bcurrent; // в этой переменной будем хранить текущее флоат значение
                TryParseResult = int.TryParse(inputstr, out a); // попробовать преобразовать inputsts в int. Значение запишется в переменную а(в случае успеха)
                                                                // Результат  вызова tryparse записывается в переменную tryparseresult
                if (TryParseResult == true)     // если спарсилось успешно , то это int 
                {
                    char character = (char)a; // приводим int к char
                    Console.WriteLine(character); // выводит результат на консоль
                }
                else // в обратном случае у нас не int 
                {
                    do // делаем цикл чтобы не выпускать пользователя пока не введет флоат равный предыдущему
                    {

                        TryParseResult = float.TryParse(inputstr, NumberStyles.Any, CultureInfo.InvariantCulture, out bcurrent); // пробуем преобразовать во float
                        if (TryParseResult == true) // если получилось...
                        {

                            if (bcurrent.CompareTo(bprevious) == 0) // сравниваем с предыдущим введеным float значением
                            {
                                Console.WriteLine("равно предыдущему"); // если они равны, то...
                                break;
                            }
                            else
                            {
                                Console.WriteLine("значение с плавающей точкой не равно предыдущему, попробуйте еще"); // если не равны, то...
                                inputstr = Console.ReadLine(); // читаем введенную строку из консоля сохраняем ее в инпутстр
                            }
                            bprevious = bcurrent; // записываем в предыдущее значение из текущего, чтобы в будущем сравнивать с последним введенным 
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
            } while (inputstr != "q");
        }
    }
}









