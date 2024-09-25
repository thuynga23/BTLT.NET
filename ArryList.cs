using System;
using System.Collections;
using System.Collections.Generic;

class SapXepArrayList
{
    static void Main()
    {
        // Khoi tao ArrayList
        ArrayList dsSoNguyen = new ArrayList();

        // Nhap so phan tu tu nguoi dung
        Console.WriteLine("Nhap so luong so nguyen can them vao danh sach: ");
        int soLuong = int.Parse(Console.ReadLine());

        // Nhap tung so nguyen vao danh sach
        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine("Nhap so nguyen thu " + (i + 1) + ": ");
            int soNguyen = int.Parse(Console.ReadLine());
            dsSoNguyen.Add(soNguyen);
        }

        // Sap xep danh sach theo thu tu tang dan
        dsSoNguyen.Sort();

        // In ra danh sach sau khi sap xep
        Console.WriteLine("Danh sach so nguyen sau khi sap xep tang dan: ");
        foreach (int so in dsSoNguyen)
        {
            Console.Write(so + " ");
        }
    }
}
