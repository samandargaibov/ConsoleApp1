namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cüt yerdə duran rəqəmlər
            //Verilmiş ədədin cüt yerdə duran rəqəmlərinin kvadratını hesablayan proqramı yazın.
            Reqem:
            Console.Write(" 6 reqemli ededi qeyd edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number.ToString().Length != 6)
            {
                Console.WriteLine("Reqem 6 reqemli olmalidir!! ");
                goto Reqem;
            }

            int last;
            int last1;
            int last2;
            double sum;



            ////soldan saga
            last2 = number / 10000;
            last2 = last2 % 10;

            last1 = number / 100;
            last1 = last1 % 10;

            last = number % 10;

            //alternativ
            //sum = last * last + last1 * last1 + last2 + last2;
            sum = Math.Pow(last, 2) + Math.Pow(last1, 2) + Math.Pow(last2, 2);

            Console.WriteLine(sum);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //5 reqemli eded verilib. Bu ededin evveline 4 reqemini , axirinada 2 reqemini artir.
            //Reqemli:
            //Console.Write("5 reqemli ededi qeyd edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number.ToString().Length != 5)
            //{
            //    Console.WriteLine("Reqem 5 reqemli olmalidir!! ");
            //    goto Reqemli;
            //}
            //Console.Write("4" + number + "2\n");//1ci usul

            ////int first = 4;
            ////int last = 2;

            ////Console.Write($"{first}{number}{last}");//2ci usul

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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


        }
    }
}