using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULL_Console_APP_Dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            mang2chieu();
            Console.ReadKey();
        }
        static void Bai6()
        {
            int i, j, so_hang;
            Console.Write("\n");
            Console.Write("Vẽ tam giác trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhập chiều cao: ");
            so_hang = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.WriteLine("-------------------------");
            for (i = so_hang; i >= 1; --i)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write("$");
                }
                Console.Write("\n");
            }
            Console.WriteLine("-------------------------");
            int k = 0;
            for (i = 1; i <= so_hang; ++i, k = 0)
            {
                for (j = 1; j <= so_hang - i; ++j)
                {
                    Console.Write(" ");
                }
                while (k != 2 * i - 1)
                {
                    Console.Write("*");
                    ++k;
                }
                Console.WriteLine("");
            }
        }
        static void Bai7()
        {
            float dcb, dnc, dtb;
            Console.Write("Nhập điểm cơ bản: ");
            dcb = float.Parse(Console.ReadLine());

            Console.Write("Nhập điểm nâng cao: ");
            dnc = float.Parse(Console.ReadLine());

            dtb = (dcb + dnc) / 2;

            if (dtb >= 9)
            {
                Console.Write("Xuất sắc: ");
            }
            else if (dtb >= 8)
            {
                Console.Write("Giỏi: ");
            }
            else if (dtb >= 7)
            {
                Console.Write("Khá: ");
            }
            else if (dtb >= 5)
            {
                Console.Write("Trung bình: ");
            }
            else
            {
                Console.Write("Không đạt");
            }
        }
        static void Bai8()
        {
            bool DoneLuaChon = false;
            bool DoneGame = false;
            string PhepTinh = "";
            int SoThuNhat = 0;
            int SoThuHai = 0;
            string BieuThuc = "";
            while (!DoneGame)
            {
                while (!DoneLuaChon)
                {
                    Console.Write("Nhập lựa chọn của bạn (+, -, *, /): ");
                    PhepTinh = Console.ReadLine();
                    if (PhepTinh == "+" || PhepTinh == "-" || PhepTinh == "*" || PhepTinh == "/" +
                        "")
                    {
                        DoneLuaChon = true;
                    }
                }
                Console.WriteLine(string.Format("Bạn chọn phép tính {0}", PhepTinh));
                Console.Write("Nhập số thứ nhất: ");
                SoThuNhat = Int32.Parse(Console.ReadLine());
                Console.Write("Nhập số thứ hai: ");
                SoThuHai = Int32.Parse(Console.ReadLine());
                DataTable dt = new DataTable();
                BieuThuc = SoThuNhat.ToString() + PhepTinh + SoThuHai.ToString();
                var kq = dt.Compute(BieuThuc, "");
                Console.WriteLine("Kết quả của phép tính {0} là: {1} ", BieuThuc, kq);
                Console.Write("Nhập TT nếu muốn tính tiếp, còn không muốn tính nữa thì bấm gì cũng được: ");
                string ChoiTiep = Console.ReadLine();
                if (ChoiTiep == "TT")
                {
                    DoneGame = false;
                    DoneLuaChon = false;
                }
                else
                {
                    DoneGame = true;
                }
            }
        }
        static void Bai10()
        {

            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC 1");
            Console.Write("NHẬP A: ");
            int soa = Convert.ToInt32(Console.ReadLine());
            Console.Write("NHẬP B: ");
            int sob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PHƯƠNG TRÌNH: {0}x + {1} = 0", soa, sob);
            if (soa == 0)
                if (sob == 0)
                    Console.WriteLine("KẾT LUẬN => Phương trình có vô số nghiệm");
                else
                    Console.WriteLine("KẾT LUẬN => Phương trình vô nghiệm");
            else
                Console.WriteLine("KẾT LUẬN => Phương trình có nghiệm x= {0}", (float)-sob / soa);
        }
        static void Bai11()
        {
            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC 2");
            Console.Write("Nhập  a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhập  b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Nhập  c = ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("PT vô số nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("PT vô nghiệm");
                    }
                }
                else
                {
                    Console.WriteLine("PT có 1 nghiệm: x = {0}", (float)-c / b);
                }
            }
            else
            {

                float delta = b * b - 4 * a * c;
                float x1;
                float x2;

                if (delta > 0)
                {
                    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("PT có 2 nghiệm là: x1 = {0} và x2 = {1}", x1, x2);

                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.WriteLine("PT có nghiệm kép: x1 = x2 = {0} ", x1);

                }
                else
                {
                    Console.WriteLine("PT vô nghiệm");
                }
            }
        }
        static void Bai12()
        {
            Console.WriteLine("TÍNH CHU VI & DIỆN TÍCH CÁC HÌNH SAU");
            Console.WriteLine("1. Hình tròn");
            Console.WriteLine("2. Hình chữ nhật");
            Console.WriteLine("3. Hình thang");
            Console.WriteLine("4. Hình tam giác");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k) // giá trị biểu thức là giá trị của biến k (kiểu số nguyên)
            {
                case 1:
                    Console.WriteLine("Nhập đường kính hình tròn: ");
                    float d = float.Parse(Console.ReadLine());
                    Console.WriteLine("Chu vi hình tròn là: {0}", d * 3, 14);
                    Console.WriteLine("Nhập bán kính hình tròn: ");
                    float r = float.Parse(Console.ReadLine());
                    Console.WriteLine("Bán kính hình tròn là {0}", (float)r * 2 + 3, 14);
                    break; // lệnh thoát ra khỏi cấu trúc
                case 2:
                    Console.WriteLine("Nhập chiều dài hình chữ nhật: ");
                    int dai = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhập chiều rộng hình chữ nhật");
                    int rong = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tính chu vi HCN: {0}", dai * rong);
                    Console.WriteLine("Tính diện tích HCN: {0}", dai * rong * 2);
                    break; // lệnh thoát ra khỏi cấu trúc


            }
        }
        static void Bai14()
        {
            int N, S = 0;

            Console.Write("Nhập N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSố N bạn vừa nhập là: " + N);

            for (int i = 1; i <= N; i++)
            {
                if (i % 3 != 0) S = S + i;
                else S = S - i;
            }

            Console.WriteLine("S= {0}", (float)S);

        }
        static bool KiemTraNguyenTo(int n)
        {
            //nếu n < 2 thì không phải là số nguyên tố
            if (n < 2)
            {
                return false;
            }
            //nếu n > 2 thì ta tiếp tục xét
            else
            {
                //nếu n % 2 == 0 thì không phải là số nguyên tố
                if (n % 2 == 0)
                {
                    return false;
                }
                //ta sử dụng vòng lặp for lặp từ 3 đến căn bậc hai của n, với bước nhảy += 2
                for (int i = 3; i <= Math.Sqrt((float)n); i += 2)
                {
                    //nếu n chia hết cho i thì không phải là số nguyên tố
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            //còn lại là số nguyên tố
            return true;
        }

        static int demnguyento(int[] a, int n)
        {
            int dem = 0;
            //ta sử dụng vòng lặp for để duyệt từng phần tử trong mảng
            //cứ mỗi vòng lặp ta gọi hàm KiemTraNguyenTo() để kiểm tra phần tử đó, nếu phải thì biến dem++
            for (int i = 0; i < n; i++)
            {
                if (KiemTraNguyenTo(a[i]) == true && a[i] < 100)
                {
                    dem++;
                }
            }
            //sau khi kết thúc vòng lặp thì ta return dem (số phần tử trong mảng là số nguyên tố)
            return dem;
        }
        static void Bai23()
        {
            Console.Write("Nhập số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Hiển thị mảng thứ tự ngược: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            int dem = demnguyento(a, n);

            Console.Write("\nCó {0} phần tử là số nguyên tố", dem);

            int k;
            long P = 1;
            //sử dụng dowhile để yêu cầu người dùng nhập vào số lớn hơn 0
            //nếu n < 0 thì yêu cầu nhập lại
            do
            {
                Console.Write("\nNhập vào ước số k: ");
                k = int.Parse(Console.ReadLine());

                if (k <= 0)
                {
                    Console.Write("\nSố n phải lớn hơn 0, vui lòng nhập lại !");
                }
            } while (k <= 0);
            //sử dụng vòng lặp for để tính tích các ước số của n
            Console.Write("\nCác ước số của {0} là: ", k);
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                {
                    Console.Write("{0} ", i);
                    P = P * i;
                }
            }
            Console.Write("\nTích các ước số của k là: {0}\t", P);

            Console.Write("\nNhập x: ");
            int x = int.Parse(Console.ReadLine());

            int m = 0;
            for (int i = 0; i < n; i++)
                if (x == a[i])
                {
                    Console.Write("\nX ở vị trí thứ: {0}\n", i);
                    m++; // m là biến đếm xem X xuất hiện bao nhiêu lần
                }
            Console.Write("\nSố lần x xuất hiện trong mảng là {0}\n", m);

            Console.WriteLine("\n Sắp xếp mảng giảm dần");
            int tg;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        // Hoan vi 2 so a[i] va a[j]
                        tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;
                    }
                }
            }
            Console.Write("\n Mảng đã sắp xếp giảm là: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}\t", a[i]);
            }
        }
        static void mang2chieuvuong()
        {
            int[,] mang = new int[100, 100];
            int so;
            Console.Write("Bạn nhập ma vuông cấp mấy:");
            so = int.Parse(Console.ReadLine());

            //Nhap gia tri cho mang
            for (int i = 0; i < so; i++)//Phan tu dau tien bat dau =0
            {
                for (int j = 0; j < so; j++)
                {
                    Console.Write("Phần tử thứ [{0},{1}]: ", i + 1, j + 1);
                    mang[i, j] = int.Parse(Console.ReadLine());
                }

            }
            //Xuat gia tri da nhap
            Console.WriteLine("Ma trận bạn đã nhập là:");
            for (int i = 0; i < so; i++)//Phan tu dau tien bat dau =0
            {
                for (int j = 0; j < so; j++)
                {
                    Console.Write("{0} ", mang[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void mang2chieu()
        {
            int[,] mang = new int[100, 100];
            int dong, cot;
            Console.Write("Nhập số dòng ma trận:");
            dong = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột ma trận:");
            cot = int.Parse(Console.ReadLine());
            Console.WriteLine("Ma trận {0}x{1}", dong, cot);
            //Nhap gia tri cho mang
            for (int i = 0; i < dong; i++)//Phan tu dau tien bat dau =0
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write("Phần tử thứ [{0},{1}]: ", i + 1, j + 1);
                    mang[i, j] = int.Parse(Console.ReadLine());
                }

            }
            //Xuat gia tri da nhap
            Console.WriteLine("Ma trận bạn đã nhập là:");
            for (int i = 0; i < dong; i++)//Phan tu dau tien bat dau =0
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write("{0} ", mang[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
