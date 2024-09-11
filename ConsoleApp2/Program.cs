using System;

class Program
{
    static void Main()
    {
        // Задача 1: Кількість символів «*» після першого пробілу
        string input = "Привіт * * *";
        int asteriskCount = input.IndexOf(' ') != -1 ? input.Substring(input.IndexOf(' ') + 1).Split('*').Length - 1 : 0;
        Console.WriteLine(asteriskCount);

        // Задача 2: Заміна літери на «???»
        string sentence = "Привіт світ";
        char letter = 'і';
        Console.WriteLine(sentence.Replace(letter.ToString(), "???"));

        // Задача 3: Перестановка першої літери в кінець
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
            words[i] = words[i].Substring(1) + words[i][0];
        Console.WriteLine(string.Join(" ", words));

        // Задача 4: Циклічний зсув слів на k позицій
        int k = 2;
        string[] shiftedWords = new string[words.Length];
        for (int i = 0; i < words.Length; i++)
            shiftedWords[i] = words[(i + k) % words.Length];
        Console.WriteLine(string.Join(" ", shiftedWords));
    }
}
