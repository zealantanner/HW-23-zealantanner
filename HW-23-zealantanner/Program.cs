using System;
using System.Linq;
//zʎxʍʌnʇsɹbdouɯๅʞſᴉɥɓɟǝpɔqɐ
//ɐqɔpǝɟɓɥᴉſʞๅɯuodbɹsʇnʌʍxʎz
//abcdefghijklmnopqrstuvwxyz
public class Program
{
    public delegate string Reverse(string s);
    public delegate string UpsideDown(string s);
    public static char FlipTheLetter(char letter)
    {
        switch (letter)
        {
            case 'a': return 'ɐ';
            case 'b': return 'q';
            case 'c': return 'ɔ';
            case 'd': return 'p';
            case 'e': return 'ǝ';
            case 'f': return 'ɟ';
            case 'g': return 'ɓ';
            case 'h': return 'ɥ';
            case 'i': return 'ᴉ';
            case 'j': return 'ſ';
            case 'k': return 'ʞ';
            case 'l': return 'ๅ';
            case 'm': return 'ɯ';
            case 'n': return 'u';
            case 'o': return 'o';
            case 'p': return 'd';
            case 'q': return 'b';
            case 'r': return 'ɹ';
            case 's': return 's';
            case 't': return 'ʇ';
            case 'u': return 'n';
            case 'v': return 'ʌ';
            case 'w': return 'ʍ';
            case 'x': return 'x';
            case 'y': return 'ʎ';
            case 'z': return 'z';
            default: return letter;
        }
    }
    static string ReverseString(string s)
    {
        return new string
        (
            s.Reverse().ToArray()
        );
    }
    
    static string UpsideDownString(string s)
    {
        char[] c = s.ToCharArray();
        foreach (char ch in c.Reverse())
        {  
            Console.Write(FlipTheLetter(ch));  
        }
        
        return new string
        (
            " "// i couldn't figure out how to convert it back into a string so i left this blank and just wrote it
        );
    }

    static void Main(string[] args)
    {
        Reverse rev = ReverseString;
        UpsideDown flip = UpsideDownString;
        string sentence = "hello there";
        Console.WriteLine(sentence);
        Console.WriteLine(rev(sentence));
        Console.WriteLine(flip(sentence));
        Console.WriteLine(flip(rev(sentence)));
    }
}