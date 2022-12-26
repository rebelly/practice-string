using System;

class Program
{

    static string sep_num(string s, int n)
    {
        string res = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            res += s[s.Length - i - 1];
            if (i % n == 0 && i != 0) res += ".";

        }
        return res;
    }
    static void del_substr(ref string s, string subs)
    {
        while (s.Contains(subs))
        {
            s = s.Replace(subs, "");
        }

    }
    static void del_even_del_odd(ref string s)

    {
        s= s.Remove(s.Length / 2 - 1 + s.Length % 2, 2 - (s.Length%2));
    }
    public static void Main()
    {
        Console.WriteLine("Введите натуральное число, которое нужно поделить точками");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите натуральное число на группы по сколько будем делить предыдущее");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Натуральное число {s} разделенное точками на группы по {n} цифр");
        Console.WriteLine(sep_num(s.ToString(), n));
        Console.WriteLine("Введите строку, из которой нужно удалить подстроку");
        string s1 = Console.ReadLine();
        Console.WriteLine("Введите подстроку, от которой нужно очистить строку выше");
        string subs = Console.ReadLine();
        Console.WriteLine($"Строка {s1} без подстроки {subs}");
        del_substr(ref s1, subs);
        Console.WriteLine(s1);
        Console.WriteLine("Введите строку, в которой нужно удалить два средних символа если она четная и один если нет");
        string s2 = Console.ReadLine();
      
        Console.WriteLine($"Строка {s2}, изменненая в зависимости от четности ее длины");
        del_even_del_odd(ref s2);
        Console.WriteLine(s2);
    }
}
