using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMang_TrenLop
{
    internal class Bai8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ và tên: Nguyễn Trọng Nhân - Mã sv: 23115053122125 - BaiTap8");
            Console.Write("Nhập: ");
            string input = Console.ReadLine();

            if (input == null){
                return;
            }
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                Console.WriteLine("Chuỗi không chứa từ hợp lệ.");
                return;
            }
            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine($"Từ dài nhất là \"{longestWord}\"");
        }
    }
}
