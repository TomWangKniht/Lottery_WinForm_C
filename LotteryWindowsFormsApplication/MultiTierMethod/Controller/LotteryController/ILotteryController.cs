using LotteryWindowsFormsApplication.MultiTierMethod.Dto.FormData;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController
{
    public interface ILotteryController
    {
        LotteryFormOutputData GenerateLotteryNumber(LotteryFormInputData lotteryFormData);
    }
}