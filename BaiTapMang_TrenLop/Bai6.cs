using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMang_TrenLop
{
    internal class Bai6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ và tên: Nguyễn Trọng Nhân - Mã sv: 23115053122125 - BaiTap6");
            Console.WriteLine("Chọn cách nhập mảng:");
            Console.WriteLine("1. Nhập mảng từ bàn phím");
            Console.WriteLine("2. Sử dụng mảng mẫu có sẵn");
            Console.Write("Lựa chọn của bạn (1/2): ");
            string choice = Console.ReadLine();
            int[] arr = null;
            if (choice == "1"){
                Console.Write("Nhập số phần tử n: ");
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0){
                    arr = new int[n];
                    for (int i = 1; i <= n; i++){
                        Console.Write($"Nhập phần tử thứ {i}: ");
                        arr[i-1] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else if (choice == "2")
            {
                arr = new int[] { 10, 15, 20, 25, 30, 35, 40 };
                Console.WriteLine("Mảng mẫu đang dùng: " + string.Join(", ", arr));
            }
            int soLuongChan = DemSoChan(arr);
            Console.WriteLine($"Số phần tử chẵn trong mảng là {soLuongChan}");
        }
        static int DemSoChan(int[] mảng)
        {
            if (mảng == null) return 0;
            int count = 0;
            foreach (int x in mảng){
                if (x % 2 == 0) count++;
            }
            return count;
        }
    }
}
