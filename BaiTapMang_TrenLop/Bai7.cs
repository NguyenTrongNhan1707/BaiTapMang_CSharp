using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMang_TrenLop
{
    internal class Bai7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ và tên: Nguyễn Trọng Nhân - Mã sv: 23115053122125 - BaiTap7");
            Console.Write("Nhập họ và tên: ");
            string hoTen = Console.ReadLine();

            if (string.IsNullOrEmpty(hoTen))
            {
                Console.WriteLine("Chuoi null hoac rong, khong tach.");
                return;
            }

            string[] mangTu = hoTen.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (mangTu == null || mangTu.Length == 0)
            {
                Console.WriteLine("Mảng có kết quả null");
                return;
            }

            Console.WriteLine("Mảng được tách ra:");
            foreach (string tu in mangTu)
            {
                Console.WriteLine(tu);
            }
        }
    }
}
