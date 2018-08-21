using System;
using System.Text;

namespace CodeChallenge
{
    class KaprekarsConstant
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GO(2341);
        }

        public static void GO(int num)
        {
            //create an int array
            int[] newIntArr = CovertToIntArray(num);

    
            int ascNum = Arrange(newIntArr, ArrangeOrder.Asc);
            int desNum = Arrange(newIntArr, ArrangeOrder.Des);

            int newNum =  desNum - ascNum;

            if (newNum == 6174)
                return;

            GO(newNum); //This makes the method recursive
        }

        public static int[] CovertToIntArray(int num)
        {
            char[] origCharArr = num.ToString().ToCharArray();
            int[] newIntArr = new int[origCharArr.Length];

            for (int i = 0; i < origCharArr.Length; i++)
            {
                char outerChar = origCharArr[i];
                int outerInt;
                int.TryParse(outerChar.ToString(), out outerInt);

                newIntArr[i] = outerInt;
            }

            return newIntArr;
        }

        public static int Arrange(int[] intArr, ArrangeOrder arrOrder)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int x = i +1; x < intArr.Length; x++)
                {
                    int i_ndx = intArr[i];
                    int x_indx = intArr[x];

                    if (arrOrder == ArrangeOrder.Asc)
                    {
                        if (i_ndx > x_indx)
                        {
                            int temp = intArr[i];
                            intArr[i] = intArr[x];
                            intArr[x] = temp;
                        }
                    }else
                    {
                        if (i_ndx < x_indx)
                        {
                            int temp = intArr[i];
                            intArr[i] = intArr[x];
                            intArr[x] = temp;
                        }
                    }
                }
            }

            return ConvertArrayToInt(intArr);
        }

        public static int ConvertArrayToInt(int[] intArr)
        {
            StringBuilder strBld = new StringBuilder();

            for (int i = 0; i < intArr.Length; i++)
            {
                strBld.Append(intArr[i]);
            }

            int result;
            int.TryParse(strBld.ToString(), out result);

            return result;
        }
    }

    public enum ArrangeOrder
    {
        Asc,
        Des
    }
}
