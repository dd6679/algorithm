using System;
namespace PS_Repository_CSharp
{
    public class _1721_TenPrintOut
    {
        static void Main(String[] args)
        {
            string input = Console.ReadLine();
            int len = input.Length;
            int i = 0;
            // 0 ~ 9, 10 ~ 19
            // 10으로 나눈 줄 수 만큼 반복
            while(i <= len / 10)
            {
                string input_1 = input;

                if ((i + 1) * 10 - 1 >= len)
                {
                    Console.WriteLine(input_1.Substring(i * 10, len - (i * 10)));
                }
                else
                {
                    Console.WriteLine(input_1.Substring(i * 10, 10));
                }
                i++;
            }
        }
    }
}
