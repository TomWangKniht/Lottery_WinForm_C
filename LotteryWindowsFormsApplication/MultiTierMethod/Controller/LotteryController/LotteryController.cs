using System;
using System.Collections.Generic;
using System.Linq;
using LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController.Validator;
using LotteryWindowsFormsApplication.MultiTierMethod.Dto.FormData;
using LotteryWindowsFormsApplication.MultiTierMethod.Service;
using LotteryWindowsFormsApplication.MultiTierMethod.Util.Enum;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController
{
    public class LotteryController : ILotteryController
    {
        private readonly IInputDataValidator _inputDataValidator;

        private readonly IGenerateNumbersByRandomService _generateNumbersService;

        private readonly Random _random;

        public LotteryFormOutputData GenerateLotteryNumber(LotteryFormInputData lotteryFormData)
        {
            var outputData = new LotteryFormOutputData();
            IList<String> errorList;
            if (!_inputDataValidator.Validate(lotteryFormData, out errorList))
            {
                outputData.ErrorMessageList = errorList;
                outputData.IsSuccess = false;
                //做失敗處理
            }
            else
            {
                //因為已經對資料做過驗證，所以不做資料異常的判斷與錯誤處理
                IEnumerable<int> gettingNumbers;
                EnumNumberSourceType numberSourceType = lotteryFormData.NumberSourceTypeTuple.Item2;
                int gettingNumberCount = int.Parse(lotteryFormData.GettingNumberCountTuple.Item2);
                bool hasSpecialNumber = lotteryFormData.HasSpecialNumberTuple.Item2;
                gettingNumberCount = hasSpecialNumber
                                         ? gettingNumberCount + 1
                                         : gettingNumberCount;
                if (numberSourceType == EnumNumberSourceType.Count)
                {
                    int sourceNumberCount = int.Parse(lotteryFormData.SourceNumberCountTuple.Item2);
                    gettingNumbers = _generateNumbersService.GenerateRandomsNumbersByCount(sourceNumberCount,
                                                                                           gettingNumberCount);
                }
                else
                {
                    int startNumber = int.Parse(lotteryFormData.StartNumberTuple.Item2);
                    int endNumber = int.Parse(lotteryFormData.EndNumberTuple.Item2);
                    gettingNumbers = _generateNumbersService.GenerateRandomNumbersByNumberRange(startNumber, endNumber,
                                                                                                gettingNumberCount);
                }

                List<int> randomList = gettingNumbers.ToList();
                if (hasSpecialNumber)
                {
                    //取出亂數一開始的寫法是
                    //取出的亂數結果本身是沒有經過排序的
                    //所以隨便取固定位置(如第一個)就可以了
                    //但是取出亂數的實作方式應該要是可以改變的
                    //不該假定結果一定沒有排序過
                    //所以這裡還是用比較麻煩的方式:使用亂數抽一個數出來當特別號
                    int removeIndex = _random.Next(randomList.Count);
                    int specialNumber = randomList[removeIndex];
                    //這裡不驗證是否移除成功
                    randomList.RemoveAt(removeIndex);
                    outputData.HasSpecialNumber = true;
                    outputData.SpecialNumber = specialNumber;
                }
                else
                {
                    outputData.HasSpecialNumber = false;
                }
                randomList.Sort();
                outputData.LotteryNumbers = randomList;
                //計算結果
                outputData.IsSuccess = true;
            }
            return outputData;
        }

        public LotteryController()
        {
            _inputDataValidator = new InputDataValidator();
            _generateNumbersService = new GenerateNumbersByRandomService();
            _random = new Random();
        }
    }
}