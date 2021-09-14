using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tam;
            bool Check = false;
            double A;

            Console.Write("Nhap tham so A: ");
            Tam = Console.ReadLine();
            Check = double.TryParse(Tam, out A);

            while (Check == false)
            {
                Console.Write("Tham so A khong hop le xin vui long nhap lai: ");
                Tam = Console.ReadLine();
                Check = double.TryParse(Tam, out A);
                
            }
            
            Check = false;
            double B;
            Console.Write("Nhap tham so B: ");
            Tam = Console.ReadLine();
            Check = double.TryParse(Tam, out B);

            while (Check == false)
            {
                Console.Write("Tham so B khong hop le xin vui long nhap lai: ");
                Tam = Console.ReadLine();
                Check = double.TryParse(Tam, out B);

            }

            if (A == 0)
            {
                if (B == 0) Console.Write("Phuong trinh co vo so nghiem");
                else Console.Write("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -B / A;
                Console.Write("Phuong trinh co nghiem x = " + x.ToString());
            }
        }
    }
}
