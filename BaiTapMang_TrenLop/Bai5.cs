//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BaiTapMang_TrenLop
//{
//    internal class Bai5
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.WriteLine("Họ và tên: Nguyễn Trọng Nhân - Mã sv: 23115053122125 - BaiTap5");
//            Console.WriteLine("Chọn cách nhập mảng:");
//            Console.WriteLine("1. Nhập mảng từ bàn phím");
//            Console.WriteLine("2. Sử dụng mảng mẫu có sẵn");
//            Console.Write("Lựa chọn của bạn (1/2): ");
//            string choice = Console.ReadLine();
//            int[] arr = null;
//            if (choice == "1")
//            {
//                Console.Write("Nhập số phần tử n: ");
//                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//                {
//                    arr = new int[n];
//                    for (int i = 1; i <= n; i++)
//                    {
//                        Console.Write($"Nhập phần tử thứ {i}: ");
//                        arr[i-1] = int.Parse(Console.ReadLine());
//                    }
//                }
//            }
//            else if (choice == "2")
//            {
//                arr = new int[] { 23, 11, 50, 53, 12, 25 };
//                Console.WriteLine("Mảng mẫu: " + string.Join(", ", arr));
//            }

//            if (arr == null || arr.Length == 0)
//            {
//                Console.WriteLine("Lỗi: Mảng chưa được khởi tạo hoặc rỗng");
//                return;
//            }

//            int max = arr[0];
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] > max)
//                {
//                    max = arr[i];
//                }
//            }
//            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
//        }
//        }
//}
