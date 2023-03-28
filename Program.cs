using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int designerPdfViewer(List<int> h, string word)
    {
        Dictionary<char, int> letterHeights = new Dictionary<char, int>();
        for (int i = 0; i < h.Count; i++)
        {
            char letter = (char)('a' + i);
            letterHeights.Add(letter, h[i]);
        }

        int maxHeight = 0;
        foreach (char c in word)
        {
            int height = letterHeights[c];
            if (height > maxHeight)
            {
                maxHeight = height;
            }
        }
        return maxHeight * word.Length;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);

        Console.WriteLine(result);
    }
}
