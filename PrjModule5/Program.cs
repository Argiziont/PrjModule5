using System;
using System.Collections.Generic;
using System.Text;
using String_Utilities;

namespace PrjModule5
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("\nWhat you want to use(string|StringBuilder):");
                var wordType = Console.ReadLine();
                switch (wordType)
                {
                    case "string":
                        Console.Write("\nEnter your string:");
                        var editString = Console.ReadLine();

                        while (true)
                        {
                            Console.WriteLine("\nChoose your option:\n" + "FindSubstring-1\n" + "CountWords-2\n" +
                                              "CountChars-3\n" + "FindShortestWord-4\n" + "FindLongestWord-5\n" +
                                              "Edit text-6\n" + "Exit from editing-7\n");
                            var func = Console.ReadLine();
                            switch (func)
                            {
                                case "1":
                                    Console.Write("\nEnter your substring:");
                                    var editSubString = Console.ReadLine();
                                    var findResult = StringUtils.FindSubstring(editString, editSubString);
                                    Console.WriteLine(findResult == -1
                                        ? "Nothing was found"
                                        : $"Your word {editSubString} was found at position {findResult}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Your string have {StringUtils.CountWords(editString)} words");
                                    break;
                                case "3":
                                    Console.WriteLine("Choose your search type:\n" + "WithSpaces-1\n" +
                                                      "WithoutSpaces-2\n" + "OnlyVowels-3\n" + "OnlyConsonant-4\n");
                                    var searchType = Console.ReadLine();
                                    switch (searchType)
                                    {
                                        case "1":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editString, StringSearchType.WithSpaces)} chars");
                                            break;
                                        case "2":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editString, StringSearchType.WithoutSpaces)} chars");
                                            break;
                                        case "3":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editString, StringSearchType.OnlyVowels)} chars");
                                            break;
                                        case "4":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editString, StringSearchType.OnlyConsonant)} chars");
                                            break;
                                    }

                                    break;
                                case "4":
                                    var findShortestResult = StringUtils.FindShortestWord(editString);
                                    Console.WriteLine($"Your shortest word {findShortestResult} was found");
                                    break;
                                case "5":
                                    var findLongestResult = StringUtils.FindLongestWord(editString);
                                    Console.WriteLine($"Your longest word {findLongestResult} was found");
                                    break;
                                case "6":
                                    Console.WriteLine("You can edit this text:");
                                    editString = ReadLine(editString);
                                    break;
                                case "7":
                                    break;
                                default:
                                    Console.WriteLine("There no such function");
                                    continue;
                            }

                            Console.WriteLine("Press 'e' for exit cycle or 'enter' for continue");

                            var contStringState = Console.ReadKey();
                            switch (contStringState.Key)
                            {
                                case ConsoleKey.Enter:
                                    continue;
                                case ConsoleKey.E:
                                    break;
                            }

                            break;
                        }

                        break;
                    case "StringBuilder":
                        Console.Write("\nEnter your string:");
                        var editStringBuilder = new StringBuilder(Console.ReadLine());

                        while (true)
                        {
                            Console.WriteLine("\nChoose your option:\n" + "FindSubstring-1\n" + "CountWords-2\n" +
                                              "CountChars-3\n" + "FindShortestWord-4\n" + "FindLongestWord-5\n" +
                                              "Edit text-6\n" + "Exit from editing-7\n");
                            var func = Console.ReadLine();
                            switch (func)
                            {
                                case "1":
                                    Console.Write("\nEnter your substring:");
                                    var editSubString = new StringBuilder(Console.ReadLine());
                                    var findResult = StringUtils.FindSubstring(editStringBuilder, editSubString);
                                    Console.WriteLine(findResult == -1
                                        ? "Nothing was found"
                                        : $"Your word {editSubString} was found at position {findResult}");
                                    break;
                                case "2":
                                    Console.WriteLine(
                                        $"Your string have {StringUtils.CountWords(editStringBuilder)} words");
                                    break;
                                case "3":
                                    Console.WriteLine("Choose your search type:\n" + "WithSpaces-1\n" +
                                                      "WithoutSpaces-2\n" + "OnlyVowels-3\n" + "OnlyConsonant-4\n");
                                    var searchType = Console.ReadLine();
                                    switch (searchType)
                                    {
                                        case "1":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editStringBuilder, StringSearchType.WithSpaces)} chars");
                                            break;
                                        case "2":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editStringBuilder, StringSearchType.WithoutSpaces)} chars");
                                            break;
                                        case "3":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editStringBuilder, StringSearchType.OnlyVowels)} chars");
                                            break;
                                        case "4":
                                            Console.WriteLine(
                                                $"Your string have {StringUtils.CountChars(editStringBuilder, StringSearchType.OnlyConsonant)} chars");
                                            break;
                                    }

                                    break;
                                case "4":
                                    var findShortestResult = StringUtils.FindShortestWord(editStringBuilder);
                                    Console.WriteLine($"Your shortest word {findShortestResult} was found");
                                    break;
                                case "5":
                                    var findLongestResult = StringUtils.FindLongestWord(editStringBuilder);
                                    Console.WriteLine($"Your longest word {findLongestResult} was found");
                                    break;
                                case "6":
                                    Console.WriteLine("You can edit this text:");
                                    editStringBuilder = new StringBuilder(ReadLine(editStringBuilder.ToString()));
                                    break;
                                case "7":
                                    break;
                                default:
                                    Console.WriteLine("There no such function");
                                    continue;
                            }

                            Console.WriteLine("Press 'e' for exit cycle or 'enter' for continue");

                            var contStringState = Console.ReadKey();
                            switch (contStringState.Key)
                            {
                                case ConsoleKey.Enter:
                                    continue;
                                case ConsoleKey.E:
                                    break;
                            }

                            break;
                        }

                        break;
                    default:
                        Console.WriteLine("There no such method");
                        continue;
                }

                Console.WriteLine("Press 'e' for close program or 'enter' for continue");

                var exitState = Console.ReadKey();
                switch (exitState.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        continue;
                    case ConsoleKey.E:
                        return;
                    default:
                        return;
                }
            }
        }

        private static string ReadLine(string @default)
        {
            var pos = Console.CursorLeft;
            Console.Write(@default);
            var chars = new List<char>();
            if (string.IsNullOrEmpty(@default) == false) chars.AddRange(@default.ToCharArray());

            while (true)
            {
                var info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Backspace && Console.CursorLeft > pos)
                {
                    chars.RemoveAt(chars.Count - 1);
                    Console.CursorLeft -= 1;
                    Console.Write(' ');
                    Console.CursorLeft -= 1;
                }
                else if (info.Key == ConsoleKey.Spacebar)
                {
                    Console.Write(' ');
                    chars.Add(info.KeyChar);
                }
                else if (info.Key == ConsoleKey.Enter)
                {
                    Console.Write(Environment.NewLine);
                    break;
                }
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