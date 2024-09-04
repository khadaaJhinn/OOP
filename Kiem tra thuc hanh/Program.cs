internal class Program
{
    static void BT1()
    {
        Console.WriteLine("Nhap n "); 
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i < n; i++)
        {
            if(i %3 == 0)
            {
                Console.Write($"{i}  ");
            }
        }
    }

    static void BT2()
    {
        Console.WriteLine("Nhap x so nguyen duong ");
        int x = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i = 0;i < x;i++)
        {
            if(i %2 == 0 )
            {
                sum = sum + i;
            }
            if (sum > x)
            {
                sum = sum - i;
            }
        }
        
        Console.WriteLine(sum);
    }

    static void NhapMang(ref int[] ai )
    {
        for (int i = 0; i < ai.Length; i++)
        {
            Console.WriteLine($"nhap gia tri cua phan tu a[{i}]");
            ai[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void InMang(ref int[] ai )
    {
        for (int i = 0; i < ai.Length; i++)
        {
            Console.Write($"{ai[i]}  ");
        }
    }
    static void BT3()
    {
        Console.WriteLine("Nhap x ");
        int x  = Convert.ToInt32(Console.ReadLine());
        int[] ai = { 9, 10, 4, 5, 6, 7, 3, 5, 8, 12, 14, 16 };
        int Sum = 0;    
        for(int i = 0; i < ai.Length; i++)
        {
            if (ai[i]  % x == 0)
            {
                Sum = Sum + ai[i]; 
               
            }
        }
        Console.WriteLine(Sum);
    }

    static void ThayTrungBinhCong(ref int[] ai, ref int x)
    {
        int Sum = 0; 

        for (int i = 0; i < ai.Length;i++)
        {
            Sum = Sum + ai[i]  ;
           

        }
        int average = Sum / ai.Length; 

        for (int i = 0; i < ai.Length; i++)
        {
            if (ai[i] < average)
            {
                ai[i]  = x; 
                
            }
        }
        for (int i = 0;i < ai.Length;i++)
        {
            Console.Write($"{ai[i]} "); 
        }
        

    }
    static void BT4() 
    {
        Console.WriteLine("nhap n ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ai = new int[n];
        NhapMang(ref  ai);
        InMang(ref ai);
        Console.WriteLine("Nhap x");
        int x = Convert.ToInt32(Console.ReadLine());
        ThayTrungBinhCong (ref ai, ref x);
       
       


    }
    //static void Dem(ref int[] ai ,   int n, int[] count )
    //{



    //    for (int i = 0; i < n; i++)
    //    {
    //        count[ai[i]]++;
    //    }
    //    for (int i = 0; i < n; ++i)
    //    {

    //        for (int j = 0; j < n - i - 1; j++)
    //        {
    //            if (ai[j] > ai[j + 1]) 
    //            {
                  
    //            }
    //        }
    //    }
       
           
            
           
        
    //}
    //static void BT5()
    //{
    //    Console.WriteLine("Nhap n ");
    //    int n = Convert.ToInt32(Console.ReadLine());
    //    int[] ai = new int[n];
    //    int[] count = new int[1000000];
    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.WriteLine($"nhap gia tri cua phan tu a[{i}]");
    //        ai[i] = Convert.ToInt32(Console.ReadLine());
    //    }
    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write($"{ai[i]}  ");
    //    }
    //    Dem(ref ai, n, count);

    //}
    static void Main(string[] args)
    {
        BT4();
    }
}