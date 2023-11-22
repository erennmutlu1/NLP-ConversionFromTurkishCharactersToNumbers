using Microsoft.AspNetCore.Mvc;
using NLP_KarakterdenNumarayaDonusum.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace NLP_KarakterdenNumarayaDonusum.Controllers
{
    [ApiController]
    public class InputController : Controller
    {
        [HttpPost]
        [Route("api/[controller]/convert")]
        public IActionResult Convert(ConversionModel model)
        {
            model.OutputText = ConvertTextToNumber(model.UserText).ToString();
            return View("Index", model);
        }

        static Dictionary<string, int> numberTable = new Dictionary<string, int>
        {
                {"sıfır", 0},
                {"bir", 1},
                {"iki", 2},
                {"üç", 3},
                {"dört", 4},
                {"beş", 5},
                {"altı", 6},
                {"yedi", 7},
                {"sekiz", 8},
                {"dokuz", 9},
                {"on", 10},
                {"yirmi", 20},
                {"otuz", 30},
                {"kırk", 40},
                {"elli", 50},
                {"altmış", 60},
                {"yetmiş", 70},
                {"seksen", 80},
                {"doksan", 90},
                {"yüz", 100},
                {"bin", 1000},
                {"milyon", 1000000}

        };
        public static string ConvertTextToNumber(string? numberString)
        {
            string[] words = numberString.Split(' ');

            StringBuilder resultSentence = new StringBuilder();

            if (words == null || words.Length == 0)
                return "Invalid input. Please provide a valid UserText.";

            int i = 0;
            while (i < words.Length)
            {
                var word = words[i];

                if (numberTable.ContainsKey(word.ToLower()))
                {
                    long acc = 0, total = 0L;

                    do
                    {
                        var n = numberTable[words[i].ToLower()];

                        if (n >= 1000)
                        {
                            if (acc == 0)
                            {
                                acc = 1;
                            }
                            total += (acc * n);
                            acc = 0;
                        }
                        else if (n >= 100)
                        {
                            acc *= n;
                        }
                        else
                        {
                            acc += n;
                        }

                        i++;
                    } while (i < words.Length && numberTable.ContainsKey(words[i].ToLower()));

                    resultSentence.Append((total + acc).ToString()).Append(" ");
                }
                else
                {
                    resultSentence.Append(word).Append(" ");
                    i++;
                }
            }

            return resultSentence.ToString().Trim();
        }


    }

}
