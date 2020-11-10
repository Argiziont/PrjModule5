using String_Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrjModule5
{
    class Program
    {
        static void Main()
        {
            StringUtils utils = new StringUtils();
            while (true)
            {
                Console.Write("\nWhat you want to use(string|StringBuiler):");
                string wordType = Console.ReadLine();
                switch (wordType)
                {
                    case "string":
                        Console.Write("\nEnter your string:");
                        string editString = Console.ReadLine();

                        while (true)
                        {
                            Console.WriteLine("\nChoose your otion:\n" + "FindSubstring-1\n" + "CountWords-2\n" + "CountChars-3\n" + "FindShortestWord-4\n" + "FindLongestWord-5\n" + "Edit text-6\n" + "Exit from editing-7\n");
                            string func = Console.ReadLine();
                           switch (func)
                            {
                                case "1":
                                    Console.Write("\nEnter your substring:");
                                    string editSubString = Console.ReadLine();
                                    KeyValuePair<string,int>findresult= utils.FindSubstring(editString, editSubString);
                                    if (findresult.Value==-1)
                                    {
                                        Console.WriteLine("Nothing was found");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your word {findresult.Key} was found at positiong {findresult.Value}");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine($"Your srting have {utils.CountWords(editString)} words");
                                    break;
                                case "3":
                                    Console.WriteLine("Choose your search type:\n" + "WithSpaces-1\n" + "WithoutSpaces-2\n" + "OnlyVowels-3\n" + "OnlyConsonant-4\n");
                                    string searchtype = Console.ReadLine();
                                    switch (searchtype)
                                    {
                                        case "1":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editString,StringSearchType.WithSpaces)} chars");
                                            break;
                                        case "2":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editString, StringSearchType.WithoutSpaces)} chars");
                                            break;
                                        case "3":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editString, StringSearchType.OnlyVowels)} chars");
                                            break;
                                        case "4":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editString, StringSearchType.OnlyConsonant)} chars");
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "4":
                                    KeyValuePair<string, int> findShortestResult = utils.FindShortestWord(editString);
                                    Console.WriteLine($"Your shortest word {findShortestResult.Key} was found at positiong {findShortestResult.Value}");
                                    break;
                                case "5":
                                    KeyValuePair<string, int> findLongestResult = utils.FindLongestWord(editString);
                                    Console.WriteLine($"Your longest word {findLongestResult.Key} was found at positiong {findLongestResult.Value}");
                                    break;
                                case "6":
                                    Console.WriteLine($"You can edit this text:");
                                    editString = ReadLine(editString);
                                    break;
                                case "7":
                                    break;
                                default:
                                    Console.WriteLine("There no such function");
                                    continue;
                            }
                            Console.WriteLine("Press 'e' for exit cycle or 'enter' for continue");

                            ConsoleKeyInfo contStringState = Console.ReadKey();
                            switch (contStringState.Key)
                            {
                                case ConsoleKey.Enter:
                                    continue;
                                case ConsoleKey.E:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }
                        break;
                    case "StringBuiler":
                        Console.Write("\nEnter your string:");
                        StringBuilder editStringBuilder = new StringBuilder(Console.ReadLine());

                        while (true)
                        {
                            Console.WriteLine("\nChoose your otion:\n" + "FindSubstring-1\n" + "CountWords-2\n" + "CountChars-3\n" + "FindShortestWord-4\n" + "FindLongestWord-5\n" + "Edit text-6\n" + "Exit from editing-7\n");
                            string func = Console.ReadLine();
                            switch (func)
                            {
                                case "1":
                                    Console.Write("\nEnter your substring:");
                                    StringBuilder editSubString = new StringBuilder(Console.ReadLine());
                                    KeyValuePair<StringBuilder, int> findresult = utils.FindSubstring(editStringBuilder, editSubString);
                                    if (findresult.Value == -1)
                                    {
                                        Console.WriteLine("Nothing was found");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your word {findresult.Key} was found at positiong {findresult.Value}");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine($"Your srting have {utils.CountWords(editStringBuilder)} words");
                                    break;
                                case "3":
                                    Console.WriteLine("Choose your search type:\n" + "WithSpaces-1\n" + "WithoutSpaces-2\n" + "OnlyVowels-3\n" + "OnlyConsonant-4\n");
                                    string searchtype = Console.ReadLine();
                                    switch (searchtype)
                                    {
                                        case "1":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editStringBuilder, StringSearchType.WithSpaces)} chars");
                                            break;
                                        case "2":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editStringBuilder, StringSearchType.WithoutSpaces)} chars");
                                            break;
                                        case "3":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editStringBuilder, StringSearchType.OnlyVowels)} chars");
                                            break;
                                        case "4":
                                            Console.WriteLine($"Your srting have {utils.CountChars(editStringBuilder, StringSearchType.OnlyConsonant)} chars");
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "4":
                                    KeyValuePair<StringBuilder, int> findShortestResult = utils.FindShortestWord(editStringBuilder);
                                    Console.WriteLine($"Your shortest word {findShortestResult.Key} was found at positiong {findShortestResult.Value}");
                                    break;
                                case "5":
                                    KeyValuePair<StringBuilder, int> findLongestResult = utils.FindLongestWord(editStringBuilder);
                                    Console.WriteLine($"Your longest word {findLongestResult.Key} was found at positiong {findLongestResult.Value}");
                                    break;
                                case "6":
                                    Console.WriteLine($"You can edit this text:");
                                    editStringBuilder = new StringBuilder( ReadLine(editStringBuilder.ToString()));
                                    break;
                                case "7":
                                    break;
                                default:
                                    Console.WriteLine("There no such function");
                                    continue;
                            }
                            Console.WriteLine("Press 'e' for exit cycle or 'enter' for continue");

                            ConsoleKeyInfo contStringState = Console.ReadKey();
                            switch (contStringState.Key)
                            {
                                case ConsoleKey.Enter:
                                    continue;
                                case ConsoleKey.E:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("There no such method");
                        continue;

                }

                Console.WriteLine("Press 'e' for close programm or 'enter' for continue");

                ConsoleKeyInfo exitState = Console.ReadKey();
                switch (exitState.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        continue;
                    case ConsoleKey.E:
                        return; ;
                    default:
                        return;
                }
            }
        }
        static string ReadLine(string Default)
        {
            int pos = Console.CursorLeft;
            Console.Write(Default);
            ConsoleKeyInfo info;
            List<char> chars = new List<char>();
            if (string.IsNullOrEmpty(Default) == false)
            {
                chars.AddRange(Default.ToCharArray());
            }

            while (true)
            {
                info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Backspace && Console.CursorLeft > pos)
                {
                    chars.RemoveAt(chars.Count - 1);
                    Console.CursorLeft -= 1;
                    Console.Write(' ');
                    Console.CursorLeft -= 1;

                }
                else if (info.Key == ConsoleKey.Spacebar) { Console.Write(' '); chars.Add(info.KeyChar); }
                else if (info.Key == ConsoleKey.Enter) { Console.Write(Environment.NewLine); break; }
                //Here you need create own checking of symbols
                else if (char.IsLetterOrDigit(info.KeyChar))
                {
                    Console.Write(info.KeyChar);
                    chars.Add(info.KeyChar);
                }
            }
            return new string(chars.ToArray());
        }
    }
}
