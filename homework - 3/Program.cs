using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            #region stringChar
            // 1. Verilmis string deyerinde verilmis charin hansi indexde yerlesdiyini tapib qaytaran metod.Misalcun metodu call edib "salam" ve 'l' deyerleri gondersek geriye 2 qaytarmalidir amma char hemin stringde olmasa -1 qaytarmalidir.
            int deyer = stringChar("elnur", 'l');
            if (deyer != -1)
            {
                Console.WriteLine($"Tapilan charin indexi: {deyer}");
            }   
            else
            {
                Console.WriteLine($"Tapilan charin indexi: {deyer}");
            }
            #endregion

            #region squareRoot
            //2. Verilmis ededin en yaxin asagi kokaltisini tapib qaytaran
            int square = squareRoot(155);
            if (square > 0)
            {
                Console.WriteLine($"Verilmis ededin kokaltisi = { square}");
            }
            else
            {
                Console.WriteLine("Menfi kok alti olmur");
            }
            #endregion

            #region sumDigit
            //3. Verilmis ededin reqemleri cemini tapib qaytaran metod.
            int sumresult = sumDigit(542);
            if (sumresult > 0)
            {
                Console.WriteLine($"Ededin reqemlerinin cemi {sumresult}");
            }

            #endregion

            #region arrayMaxs
            //4. Verilmis indeger arrayinin icindeki en boyuk deyeri tapan metod
            int[] numbers = { 12, 32, 45, 643, 13, 34, 65, 43, 200 };

            int arrayMax = numbersMax(numbers);
            if (numbers.Length > 0)
            {
                Console.WriteLine($"Verilmis arraydeki en boyuk eded = {arrayMax}");
            }
            else
            {
                Console.WriteLine("Arrayin ici bosdur!!!");
            }
            #endregion

            #region negativeValue
            //5.Verilmis integer arrayindeki butun elementleri musbet sekilder qaytaran metod.Misalcun parametr olaraq {1,-4,9,-8} deyerleri olan array daxil edilse arqument kimi metod bize {1,4,9,8} deyerleri olan array qaytarmalidir
            int[] values = { 1, -2, -5, 56, -100, 300, -23, -444 };

            int[] valuePositive = aryValues(values);
            Console.WriteLine("Arraydeki ededler:");
            foreach (int item in valuePositive)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        #region stringChar1

        static int stringChar(string mainString, char chr)
        {
            int resultFind = -1;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] == chr)
                {
                    resultFind = i;
                    break;
                }
            }
            return resultFind;
        }
        #endregion

        #region squareRoot1
        static int squareRoot(int value)
        {
            int a = 0;
            int squareResult = 0;
            while (a * a <= value)
            {
                a++;
            }
            squareResult = a - 1;
            return squareResult;

        }
        #endregion

        #region sumDigit1

        static int sumDigit(int value)
        {
            int sum = 0;
            int digit = 0;
            int M = value;

            while (M > 0)
            {
                digit = M % 10;
                sum += digit;
                M = (M - digit) / 10;

            }
            return sum;

        }

        #endregion

        #region arrayMax1
        static int numbersMax(int[] numbers)
        {
            int i = 0;
            int max = numbers[0];
            while (i < numbers.Length - 1)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                i++;
            }
            return max;
        }
        #endregion

        #region negativeValue1

        static int[] aryValues(int[] values)
        {
            for (int j = 0; j < values.Length; j++)
            {
                if (values[j] < 0)
                {
                    values[j] = values[j] * (-1);
                }
                else
                {
                    continue;
                }
            }
            return values;
        }

        #endregion



    }
}