using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EDS.Domain
{
    internal static class ValuesChecker
    {
        // Валидация строки на содержание в ней цифр и ничего другого
        public static string ValidateTextBoxInput(string TextBoxMssg)
        {
            string digits = "0123456789";

            for (int i = 0; i < TextBoxMssg.Length; i++)
            {
                if (!digits.Contains(TextBoxMssg[i]))
                {
                    TextBoxMssg = TextBoxMssg.Replace($"{TextBoxMssg[i]}", String.Empty);
                    i--;
                }
            }
            return TextBoxMssg;
        }

        // Проверка ввода p и q на правильность (без проверки на простоту)
        public static string CheckTextBoxForInputErrors(string text)
        {
            // Пустая строка
            if (string.IsNullOrEmpty(text))
                return "String can't be empty.";

            // Не число
            if (!BigInteger.TryParse(text, out BigInteger value))
                return "Input isn't a digit.";

            // Отрицательное число
            if (value < 0)
                return "Digit must be positive.";

            return string.Empty;
        }

        // Проверка ввода e на правильность и на диапазон с 1 и Ф(r)
        public static string CheckTextBoxWithEForInputErrors(string text, BigInteger Fr)
        {
            // Пустая строка
            if (string.IsNullOrEmpty(text))
                return "String can't be empty.";

            // Не число
            if (!BigInteger.TryParse(text, out BigInteger value))
                return "Input isn't a digit.";

            // Число меньше либо равное единице
            if (value <= 1)
                return "Digit must > 1.";

            // Число больше либо равное F(r)
            if (value >= Fr)
                return "Digit must be < Ф(r).";

            // Число не является взаимно простым с F(r)
            if (EvklidAlgorithm(value, Fr) != 1)
                return "e and Ф(r) must be coprime.";

            return string.Empty;
        }

        // Тест Миллера-Рабина на простоту числа
        public static bool IsPrimary_MillersRabinsTest(BigInteger n, int s) // s - число раундов для b_i
        {
            // если n == 2 или n == 3 - эти числа простые, возвращаем true
            if (n == 2 || n == 3)
                return true;

            // если n < 2 или n четное - возвращаем false
            if (n < 2 || n % 2 == 0)
                return false;


            // представим n − 1 в виде (2^k)*m, где m нечётно, это можно сделать последовательным делением n - 1 на 2
            BigInteger m = n - 1;

            int k = 0;

            while (m % 2 == 0)
            {
                m /= 2;
                k += 1;
            }

            // повторить s раз
            for (int i = 0; i < s; i++)
            {
                // выберем случайное целое число a в отрезке [2, n − 2]

                RNGCryptoServiceProvider rng = new();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);

                // b_i ← (a^m) mod n, вычислим с помощью быстрого алгоритма возведения в степень по модулю
                BigInteger b_i = FastPowModFunc(a, m, n);

                // если b_i == 1 или b_i == n − 1, то перейти на следующую итерацию цикла
                if (b_i == 1 || b_i == n - 1)
                    continue;

                // повторить k − 1 раз
                for (int r = 1; r < k; r++)
                {
                    // b_i ← (b_i)^2 mod n
                    b_i = FastPowModFunc(b_i, 2, n);

                    // если b_i == 1, то вернуть "составное"
                    if (b_i == 1)
                        return false;

                    // если b_i == n − 1, то перейти на следующую итерацию внешнего цикла
                    if (b_i == n - 1)
                        break;
                }

                if (b_i != n - 1)
                    return false;
            }

            // вернуть "вероятно простое"
            return true;

        }

        // Функция быстрого возведения в степень по модулю
        public static BigInteger FastPowModFunc(BigInteger Number, BigInteger Pow, BigInteger Mod)
        {
            BigInteger Result = 1;
            BigInteger Bit = Number % Mod;

            while (Pow > 0)
            {
                if ((Pow & 1) == 1)
                {
                    Result *= Bit;
                    Result %= Mod;
                }
                Bit *= Bit;
                Bit %= Mod;
                Pow >>= 1;
            }
            return Result;
        }

        // Алгоритм Евклида на нахождение НОД двух чисел
        public static BigInteger EvklidAlgorithm(BigInteger a, BigInteger b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        // Расширенный алгоритм Евклида на поиск коэффициентов Безу
        public static BigInteger GetGcdAndBezuDigits(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if(b < a)
            {
                BigInteger temp = a;
                a = b;
                b = temp;
            }

            if(a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            BigInteger gcd = GetGcdAndBezuDigits(b % a, a, out x, out y);

            BigInteger newY = x;
            BigInteger newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }
    }
}
