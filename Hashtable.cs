using System;
using System.Collections;

class LuuTruTenVaTuoi
{
    static void Main()
    {
        // Khoi tao Hashtable
        Hashtable dsTenTuoi = new Hashtable();

        // Nhap so luong nguoi tu nguoi dung
        Console.WriteLine("Nhap so luong nguoi: ");
        int soLuong = int.Parse(Console.ReadLine());

        // Nhap ten va tuoi vao Hashtable
        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine("Nhap ten nguoi thu " + (i + 1) + ": ");
            string ten = Console.ReadLine();

            Console.WriteLine("Nhap tuoi cua " + ten + ": ");
            int tuoi = int.Parse(Console.ReadLine());

            dsTenTuoi.Add(ten, tuoi);
        }

        // In ra danh sach ten va tuoi
        Console.WriteLine("\nDanh sach ten va tuoi da nhap: ");
        foreach (DictionaryEntry entry in dsTenTuoi)
        {
            Console.WriteLine("Ten: " + entry.Key + ", Tuoi: " + entry.Value);
        }
    }
}
