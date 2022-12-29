namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            ////Cüt yerdə duran rəqəmlər
            ////Verilmiş ədədin cüt yerdə duran rəqəmlərinin kvadratını hesablayan proqramı yazın.

            //int number = int.Parse(Console.ReadLine());
            //int count = (int)Math.Log10(number) + 1;
            //int r, i = 0;

            //i = count % 2 == 0 ? 0 : 1;

            //while (number != 0)
            //{
            //    r = number % 10;
            //    number /= 10;

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(r);
            //    }

            //    i++;
            //}
            #endregion
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region Task2
            //Daxil edilən ədədin rəqəmləri və onların sıra nömrələrinə olan hasilinin cəmini hesablayan proqram yazın

            //Console.Write("Ededi qeyd edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());  //2345  row 5 ,  row 4 ,  row 3,  row 2
            ////Example1:

            //int lenght = number.ToString().Length;
            //int sum=0;

            //for (int i = lenght-1; i >= 0; i--)
            //{
            //    sum = sum + (i + 1) * (number % 10);
            //    number /= 10;
            //}
            //Console.WriteLine(sum);

            /////Example2:

            //int lenght = 0;
            //int dublicate = number;
            //while (dublicate>0)
            //{
            //    lenght++;
            //    dublicate /= 10;
            //}
            //int sum = 0;
            //for (int i = lenght-1; i >=0; i--)
            //{
            //    sum = sum + (i + 1) * (number % 10);
            //    number /= 10;
            //}
            //Console.WriteLine(sum);

            //while (0<number)
            //{
            //    row = number % 10;
            //    number /= 10;
            //    Console.WriteLine(row);
            //}


            //Console.WriteLine(row);
            #endregion
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region Task3
            //5 reqemli eded verilib. Bu ededin evveline 4 reqemini , axirinada 2 reqemini artir.

            ////Reqemli:
            //    Console.Write("5 reqemli ededi qeyd edin: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    if (number.ToString().Length != 5)
            //    {
            //        Console.WriteLine("Reqem 5 reqemli olmalidir!! ");
            //        goto Reqemli;
            //    }
            //    sum = (400000 + number) * 10 + 2;

            //    Console.Write(sum);
            #endregion
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region Task4
            //Verilmiş n ədədin rəqəmlərinin müxtəlif olduğunu yoxlayan proqram yazın


            //Console.Write("Ededi qeyd edin: ");//12546
            //int number = Convert.ToInt32(Console.ReadLine()); // 1 2 5 4 6
            //bool duplicate = false;

            //while (number>0)
            //{
            //    int temp = number / 10;

            //    while (temp > 0)
            //    {
            //        if (temp % 10 == number % 10)
            //        {
            //            duplicate = true;
            //            break;
            //        }
            //        temp /= 10;
            //    }

            //    if (duplicate) break;
            //    number /= 10;
            //}
            //if (duplicate == true)
            //{
            //    Console.WriteLine("Eyni reqem movcuddur!");
            //}
            //else
            //{
            //    Console.WriteLine("Muxtelifreqemlidir!");
            //}
            #endregion
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region Task5

            //Console.Write("1-ci ededi daxil edin: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2-ci ededi daxil edin: ");
            //int b = int.Parse(Console.ReadLine());
            //int count = 0;

            //for (int i = a; i <= b; i++)
            //{
            //    if (Math.Sqrt(i) == (int)Math.Sqrt(i))
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}

            //Console.WriteLine("Koku olanlarin sayi: " + count);
            #endregion
            #region Task 8
            ////nnn.ddd formatında verilmiş həqiqi ədədi  kəsr və tam hissısi ilə yerini dəyişən(ddd.nnn) proqramı yazın
            //Console.Write("Reqemi yazin: ");
            //decimal number = decimal.Parse(Console.ReadLine());
            //decimal a = (decimal)(int)number;
            //decimal b = number % 1.0m;

            //while (a / 10 > 1)
            //{
            //    a = a / 10;
            //}
            //a = a / 10;

            //while (b % 1 != 0)
            //{
            //    b = b * 10;
            //}

            //decimal result = b + a;
            //Console.WriteLine("b: " + b);
            //Console.WriteLine("a: " + a);

            //Console.WriteLine("Cavab: " + result);
            #endregion
        }
    }
}