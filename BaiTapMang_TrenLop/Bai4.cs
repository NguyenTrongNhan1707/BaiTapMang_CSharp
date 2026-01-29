using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMang_TrenLop
{
    internal class Bai4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ và tên: Nguyễn Trọng Nhân - Mã sv: 23115053122125 - BaiTap4");
            Console.Write("Nhập số phần tử n: ");
            string n = Console.ReadLine();

            if (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Lỗi: Mảng chưa được khởi tạo");
                return;
            }

            int m = int.Parse(n);
            int[] arr = new int[m];
            int i;
            int tong = 0;

            for (i = 0; i < m; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                tong += arr[i];
            }

            Console.WriteLine($"Tổng là: {tong}");
        }
    }
}
