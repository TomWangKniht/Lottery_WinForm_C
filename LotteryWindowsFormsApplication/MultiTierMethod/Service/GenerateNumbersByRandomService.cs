using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Service
{
    public class GenerateNumbersByRandomService : IGenerateNumbersByRandomService
    {
        private readonly static Random _random = new Random();
        private const int DefaultStartNumber = 1;

        public IEnumerable<int> GenerateRandomsNumbersByCount(int sourceNumberCount, int gettingNumberCount)
        {
            int[] computArray = Enumerable.Range(1, sourceNumberCount).ToArray();
            return GenerateRandomNumbersByComputArray(computArray, gettingNumberCount);

            //return GenerateRandomNumbersByNumberRange(DefaultStartNumber,
            //    DefaultStartNumber + sourceNumberCount - 1,
            //    gettingNumberCount);
        }

        public IEnumerable<int> GenerateRandomNumbersByNumberRange(int sourceStartNumber, int sourceEndNumber, int gettingNumberCount)
        {
            int[] computArray = Enumerable.Range(sourceStartNumber, sourceEndNumber - sourceStartNumber + 1).ToArray();
            return GenerateRandomNumbersByComputArray(computArray, gettingNumberCount);

            //int[] computArray = Enumerable.Range(sourceStartNumber, sourceEndNumber).ToArray();
            //UpsetRandomArray(computArray);
            //int count = 0;
            //return computArray.TakeWhile(o => count++ < gettingNumberCount);
        }

        private IEnumerable<int> GenerateRandomNumbersByComputArray(int[] computArray, int gettingNumberCount)
        {
            UpsetRandomArray(computArray);
            int count = 0;
            return computArray.TakeWhile(o => count++ < gettingNumberCount);
        }

        /// <summary>
        /// 將Int的List的資料內容打亂
        /// </summary>
        /// <param name="computIntArray">要打亂的</param>
        /// <returns></returns>
        private void UpsetRandomArray(int[] computIntArray)
        {
            for (int i = 0; i < computIntArray.Length; i++)
            {
                int tempIndex = _random.Next(computIntArray.Length);
                int tempInt = computIntArray[i];
                computIntArray[i] = computIntArray[tempIndex];
                computIntArray[tempIndex] = tempInt;
            }
        }
    }
}