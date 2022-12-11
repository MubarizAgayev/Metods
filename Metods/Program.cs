// See https://aka.ms/new-console-template for more information

// task1-verilmis n-ededinin 3-e ve 7-e bolunub-bolunmemesini tapin.
//Divide(63);
//static void Divide(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine($"{n} 3-e ve 7-e bolunur");
//    }
//    else
//    {
//        Console.WriteLine($"{n} 3-e ve 7-e bolunmur");
//    }
//}



//task2-n ve m ededleri verilir.Eger n ve m ededleri her ikisi cutdurse n ve m ededlerinin cemini tapin.
//Sum(10,22);
//static void Sum(int n,int m)
//{
//    int sum1;
//    if(n%2==0 && m % 2 == 0)
//    {
//        sum1 = n + m;
//        Console.WriteLine(sum1);
//    }
//    else
//    {
//        Console.WriteLine("duzgun ededler daxil edin");
//    }
//}



//task3-verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin
//Sum(3, 9);
//static void Sum(int n,int m)
//{
//    int sum1=0;
//    for(int i = n; i < m; i++)
//    {
//        if(i%2==1)
//        {
//            sum1 = sum1+i;
//        }  
//    }
//    Console.WriteLine(sum1);
//}



//task4-verilmis arrayin icindeki tek ededlerin cemini tapin
//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//Sum(arr);
//static void Sum(int[] arr)
//{
//    int sum1=0;
//    for(int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum1 += arr[i];
//        }
//    }
//    Console.WriteLine(sum1);
//}



//task5-verilmis arrayin icindeki cut ededlerin sayini tapin
//int[] arr = { 1, 2, 3, 4, 5, 6, 7};
//Count(arr);
//static void Count(int[] arr)
//{
//    int count1 = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count1++;
//        }
//    }
//    Console.WriteLine(count1);
//}



//task6-verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin
//Count(1,8);
//static void Count(int n,int m)
//{
//    int count1 = 0;
//    for(int i = n; i < m; i++)
//    {
//        if(i % 2 == 1)
//        {
//            count1++;
//        }
//    }
//    Console.WriteLine(count1);
//}



//task7-verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin 
//Sum(2, 9);
//static void Sum(int n,int m)
//{
//    int sum1 = 0;
//    for(int i = n; i < m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum1 += i;
//        }
//    }
//    Console.WriteLine(sum1);
//}



//task8-verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin
//Count(2, 13);
//static void Count(int n,int m)
//{
//    int count1 = 0;
//    for(int i = n; i < m; i++)
//    {
//        if (i % 2 ==0)
//        {
//            count1++;
//        }
//    }
//    Console.WriteLine(count1);
//}



//task9-verilmis n tam ededinin sade ve ya murekkeb olduqunu tapin
//Complex(16);
//static void Complex(int n)
//{
//    int count = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//    }
//    if (count > 2)
//    {
//        Console.WriteLine($"{n} murekkeb ededdir");
//    }
//    else if (count == 2)
//    {
//        Console.WriteLine($"{n} sade ededdir");
//    }
//    else
//    {
//        Console.WriteLine($"{n} ne sadedir ne de murekkeb");
//    }
//}



//task10-n ededinin faktorialini hesablayin
//Factorial(4);
//static void Factorial(int n)
//{
//    int result = 1;
//    for(int i = 1; i <= n; i++)
//    {
//        result *= i;
//    }
//    Console.WriteLine(result);
//}
