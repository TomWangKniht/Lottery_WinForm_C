using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LotteryWindowsFormsApplication.MultiTierMethod.Dto.FormData;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController.Validator
{
    public interface IInputDataValidator
    {
        int MinSourceNumberCount { set; }

        int MinGettingNumberCount { set; }

        bool Validate(LotteryFormInputData lotteryFormData, out IList<String> errorMessages);
    }
}