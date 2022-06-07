using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{//Ваш номер 21 
    class Vector
    {
        int[] arr;

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Індекс за межами діапазону масиву");
                }
            }
            set
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        #region Methods
        public bool IsPalindrome() //palindrome#1
        {
            bool result = false;
            int count = 0;
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[j]) count++;
                j--;
            }
            if (count == arr.Length / 2) result = true;
            return result;
        }
        public void RandomInit(int a, int b)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(a, b);
            }
        }

        public void Counting()//pidrahynok#2
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            int[] temp = new int[max - min + 1];


            for (int i = 0; i < arr.Length; i++)
            {
                temp[arr[i] - min]++;
            }
            int k = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i]; j++)
                {
                    arr[k] = i + min;
                    k++;
                }
            }
        }

        public void Reversal()//revers#2
        {
            int[] resultArr = new int[arr.Length];
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                resultArr[i] = arr[j];
                j--;
            }
            arr = resultArr;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }
        public void RandomInit()
        {
            Random random = new Random();
            int h;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] == 0)
                {
                    h = random.Next(1, arr.Length + 1);
                    bool b = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (h == arr[j])
                        {
                            b = true;
                            break;
                        }
                    }
                    if (!b)
                    {
                        arr[i] = h;
                        break;
                    }
                }
            }
        }

        public Pair[] CalculateFreq() //rozrah chastoty#3
        {

            Pair[] pair = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pair[i] = new Pair(0, 0);

            }
            int countdiff = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countdiff; j++)
                {
                    if (arr[i] == pair[j].Number)
                    {
                        pair[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pair[countdiff].Freq++;
                    pair[countdiff].Number = arr[i];
                    countdiff++;
                }
            }

            Pair[] result = new Pair[countdiff];
            for (int i = 0; i < countdiff; i++)
            {
                result[i] = pair[i];
            }

            return result;
        }

       

        public Pair LongestSubseqSameNum() //poslidovnist#3
        {
            Pair[] pairs = new Pair[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                pairs[j] = new Pair(0, 0);
            }
            int count;
            int i = 0;
            while (i < arr.Length)
            {
                count = 1;
                while (arr[i] == arr[i + 1])
                {
                    count++;
                    i++;
                    if (i >= arr.Length - 1) break;
                }
                pairs[i].Number = arr[i];
                pairs[i].Freq = count;
                i++;
            }

            Pair result = new Pair(0, 0);
            for (int j = 0; j < pairs.Length; j++)
            {
                if (pairs[j].Freq > result.Freq)
                {
                    result.Number = pairs[j].Number;
                    result.Freq = pairs[j].Freq;
                }
            }

            return result;
        }

        #endregion
    }
}
