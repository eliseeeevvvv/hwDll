using System;
using GeometryLibrary;
using TextLibrary;
using ContactLibrary;

class Program
{
    static void Main()
    {
        // =========================
        // ЗАВДАННЯ 1
        // =========================

        Console.WriteLine("===== ЗАВДАННЯ 1 =====");

        double square = Geometry.SquareArea(5);

        double rectangle = Geometry.RectangleArea(10, 4);

        double triangle = Geometry.TriangleArea(6, 8);

        Console.WriteLine($"Площа квадрата: {square}");
        Console.WriteLine($"Площа прямокутника: {rectangle}");
        Console.WriteLine($"Площа трикутника: {triangle}");


        // =========================
        // ЗАВДАННЯ 2
        // =========================

        Console.WriteLine();
        Console.WriteLine("===== ЗАВДАННЯ 2 =====");

        string text = "Привіт. Як справи? Все добре!";

        Console.WriteLine($"Текст: {text}");

        Console.WriteLine(
            $"Кількість речень: {TextHelper.CountSentences(text)}"
        );

        Console.WriteLine(
            $"Перевернутий текст: {TextHelper.Reverse(text)}"
        );

        string palindrome = "А роза упала на лапу Азора";

        Console.WriteLine(
            $"Паліндром \"{palindrome}\": " +
            $"{TextHelper.IsPalindrome(palindrome)}"
        );


        // =========================
        // ЗАВДАННЯ 3
        // =========================

        Console.WriteLine();
        Console.WriteLine("===== ЗАВДАННЯ 3 =====");

        string name = "Олександр Єлісєєв";
        string age = "16";
        string phone = "+380671234567";
        string email = "test@gmail.com";

        Console.WriteLine(
            $"ПІБ: {ContactValidator.ValidateName(name)}"
        );

        Console.WriteLine(
            $"Вік: {ContactValidator.ValidateAge(age)}"
        );

        Console.WriteLine(
            $"Телефон: {ContactValidator.ValidatePhone(phone)}"
        );

        Console.WriteLine(
            $"Email: {ContactValidator.ValidateEmail(email)}"
        );

        Console.WriteLine();
        Console.WriteLine("Готово!");
        Console.ReadLine();
    }
}