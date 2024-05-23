using System;
using System.Text;

public class baitap18
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] N = { 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10};
        Console.WriteLine("Mảng ban đầu:");
        inmang(N);
        Console.Write("Nhập số cần chèn (X): ");
        int X = int.Parse(Console.ReadLine());
        Console.Write("Nhập vị trí index cần chèn X vào trong mảng: ");
        int index = int.Parse(Console.ReadLine());
        if (index < 0 || index > N.Length - 1)
        {
            Console.WriteLine("Không chèn được phần tử vào mảng.");
            return;
        }
        chienphantu(N, X, index);
        Console.WriteLine("Mảng sau khi chèn:");
        inmang(N);
    }
    public static void inmang(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    public static void chienphantu(int[] a, int X, int index)
    {
        Array.Resize(ref a, a.Length + 1);
        for (int i = a.Length - 1; i > index; i--)
        {
            a[i] = a[i - 1];
        }
        a[index] = X;
    }
}

    

