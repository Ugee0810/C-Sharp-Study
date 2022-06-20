using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://programmers.co.kr/learn/courses/30/lessons/42748
namespace Programmers.Lv1
{
    internal class _42748
    {
        static void Main1(string[] args)
        {
        }
    }
}
/*
public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int a = commands[i, 0];
            int b = commands[i, 1] + 1;
            int c = commands[i, 2];
            int[] sub = new int[b - a];

            Array.Copy(array, a-1, sub, 0, b-a);

            Array.Sort(sub);
            answer[i] = sub[c - 1];
        }
        return answer;
    }
}
*/