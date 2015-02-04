using System;

namespace LotteryWindowsFormsApplication.staticMethod
{
    public static class StaticLotteryNumberGenerator
    {
        private static Random _random = new Random();

        /// <summary>
        /// 初始化一個int的Array，使其內容為由參數的最小值到最大值
        /// 供getRandomIntList使用
        /// </summary>
        /// <param name="minValue">List的最小值</param>
        /// <param name="maxValue">List的最大值</param>
        /// <returns></returns>
        private static int[] GenerateNewArray(int minValue, int maxValue)
        {
            int count = maxValue - minValue + 1;
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                //考慮到最小值不一定為0
                result[i] = i + minValue;
            }
            return result;
        }

        /// <summary>
        /// 將Int的List的資料內容打亂
        /// </summary>
        /// <param name="inputIntList">要打亂的</param>
        /// <returns></returns>
        private static int[] UpsetRandomArray(int[] inputIntList)
        {
            for (int i = 0; i < inputIntList.Length; i++)
            {
                int tempIndex = _random.Next(inputIntList.Length);
                int tempInt = inputIntList[i];
                inputIntList[i] = inputIntList[tempIndex];
                inputIntList[tempIndex] = tempInt;
            }
            return inputIntList;
        }

        public static int[] Generator(int startNumber, int endNumber, int getNumberCount)
        {
            int[] result = new int[getNumberCount];
            int[] source = UpsetRandomArray(GenerateNewArray(startNumber, endNumber));
            Array.Copy(source, result, getNumberCount);
            return result;
        }

        public static int[] Generator(int sourceNumberCount, int getNumberCount)
        {
            return Generator(1, 1 + sourceNumberCount, getNumberCount);
        }
    }
}