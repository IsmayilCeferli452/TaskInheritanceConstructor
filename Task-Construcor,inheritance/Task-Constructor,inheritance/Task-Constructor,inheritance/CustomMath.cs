

namespace Task_Constructor_inheritance
{
    public class CustomMath
    {
        ////1) Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.

        public int SumOfOddNumbersInArray(int[] array)
        {
            int sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(i%2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }


        ////2) Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
    
        public string OddOrEven(int n)
        {
            if(n%2 == 1)
            {
                return "Odd";
            }
            return "Even";
        }


        ////3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

        public int SquareOfNumbers(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2 == 0)
                {
                    sum += array[i];
                }
            }
            int result = sum * sum;
            return result;
        }


        ////4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.

        public int ResultOfNumbers(int n)
        {
            int result = 1;

            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
