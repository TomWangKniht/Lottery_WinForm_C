using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Service
{
    public interface IGenerateNumbersByRandomService
    {
        IEnumerable<int> GenerateRandomsNumbersByCount(int sourceNumberCount, int gettingNumberCount);

        IEnumerable<int> GenerateRandomNumbersByNumberRange(int sourceStartNumber, int sourceEndNumber, int gettingNumberCount);
    }
}