using System;
using System.Text;

class ExtractSentencesFromText_v2
{
    static void Main(string[] args)
    {
        //input and values
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string[] sentences = text.Split('.');
        StringBuilder nonLetterSymbols = new StringBuilder();
        StringBuilder result = new StringBuilder();
        //calculation
        foreach (var sentence in sentences)
        {
            nonLetterSymbols.Clear();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsLetter(sentence[i]) == false)
                {
                    nonLetterSymbols.Append(sentence[i]); //parse NON-letter symbols
                }
            }
            char[] splitChars = nonLetterSymbols.ToString().ToCharArray();
            string[] words = sentence.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            if (Array.IndexOf(words, word) > -1)
            {
                result.Append(sentence.Trim());
                result.Append(". ");
            }
        }
        //print
        Console.WriteLine(result.ToString().Trim());
    }
}

//Тази задача е по идея на едно задание от домашните в Телерик Академияа -> https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/08.%20Extract%20sentences/README.md
//ОПИСАНИЕ:
//На първия ред се подава като стринг, търсената дума ("word"), а на следващия ред текста ("text"), съставен от изречения РАЗДЕЛЕНИ с точка('.'), в който ще се търси. 
//Алгоритъма извлича тези изречения, от подадения текст, в които има съвпадение с думата , поне веднъж. Останалите които не съдържат думата , се пренебрегват.
//Този, последен вариянт на програмата, прихваща всеки разделител от небуквен тип и така разделя думите, не само по интервали(white-space) и запетайки, а по всичко що не е буква.


//ПРИМЕРЕН ВХОД (input):
//======================
//in
//We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
////////////////////////
//ИЗХОД (output):
//===============
//We are living in a yellow submarine. We will move out of it in 5 days.

//Погледни файла с име "huge_test.txt.7z" в директорията на програмата и тествай!