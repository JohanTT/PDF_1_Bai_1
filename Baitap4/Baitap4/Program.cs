using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            /*Console.WriteLine("Nhap Ho, Ten lot va ten. Xuat ra ho ten day du.");
            Console.WriteLine();

            Console.Write("Nhap Ho: ");
            string ho = Console.ReadLine();

            Console.Write("Nhap Ten lot: ");
            string tenlot = Console.ReadLine();

            Console.Write("Nhap Ten: ");
            string ten = Console.ReadLine();

            Console.WriteLine("Ho va ten day du: {0} {1} {2}", ho, tenlot, ten);*/

            // 2

            /*Console.WriteLine("Nhap Ho va Ten day du. Xuat tung phan.");
            Console.WriteLine();

            Console.Write("Nhap Ho va Ten: ");
            string tendaydu = Console.ReadLine();

            string space = " ";
            string[] parts = tendaydu.Split(new string[] { space }, StringSplitOptions.None);
            // Ham Split(new kieu_du_lieu[] { ky tu n can tach } se tu dong tach ky tu n moi khi gap.
            // StringSplitOptions.None - gia tri tra ve co the bao gom ca mang chua cac phan tu co chua ky tu null.
            Console.WriteLine("Ho: {0}, Ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);*/

            // 3

            Console.WriteLine("Nhap Ho va Ten khong theo chuan. Chinh lai theo chuan va xuat ra.");
            Console.WriteLine();

            Console.Write("Nhap Ho va Ten (khong can theo chuan): ");
            string tendaydu = Console.ReadLine();

            string Spaceator = " ";

            string[] parts = tendaydu.Split(new string[] { Spaceator }, StringSplitOptions.RemoveEmptyEntries);
            // StringSplitOptions.RemoveEmptyEntries - tra ve gia tri khong bao gom mang chua cac phan tu co ky tu null.

            Console.Write("Ho va Ten dang chuan la:");

            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Substring(0, 1).ToUpper() +
                parts[i].Substring(1, parts[i].Length - 1).ToLower();
                Console.Write(" " + parts[i]);
            }
        }
    }
}
