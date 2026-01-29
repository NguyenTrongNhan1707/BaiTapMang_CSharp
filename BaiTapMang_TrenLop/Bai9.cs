using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMang_TrenLop
{
    internal class Bai9
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ và tên: Nguyễn Trọng Nhân - MSV: 23115053122125 - BaiTap9");
            Console.Write("Nhập số lượng phần tử chuỗi: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ!");
                return;
            }

            string[] mangChuoi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập chuỗi thứ {i + 1} (nhấn Enter để để trống): ");
                mangChuoi[i] = Console.ReadLine();
            }
            int dem = 0;
            foreach (string s in mangChuoi)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    dem++;
                }
            }

            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine($"Có {dem} chuỗi hợp lệ (khác null/rỗng).");
        }
    }
}
