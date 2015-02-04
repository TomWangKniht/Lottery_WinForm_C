using System;

namespace LotteryWindowsFormsApplication.staticMethod
{
    static class StaticValidator
    {
        public static bool VerifyNumber(String text)
        {
            int number=0;
            try
            {
                number = int.Parse(text);
            }
            catch (Exception)
            {

                return false;
            }
            return number > 0;
        }
        public static bool VerifyNumberRange(String startNumberText,String endNumberText)
        {
            if (!(VerifyNumber(startNumberText) && (VerifyNumber(endNumberText))))
            {
                return false;
            }
            int startNumber=int.Parse(startNumberText);
            int endNumber=int.Parse(endNumberText);
            if(startNumber>endNumber)
            {
                return false;
            }
            return true;
        }
        public static bool VerifyGetNumberSetting(bool hasSpecialNumber,String getNumberCountText)
        {
            if (!VerifyNumber(getNumberCountText))
            {
                return false;
            }
            int getNumberCount=int.Parse(getNumberCountText);
            if(hasSpecialNumber&&getNumberCount<1)
            {
                return false;
            }
            return true;
        }
        private static bool VerifyNumberRelationship(int sourceNumberCount,int getNumberCount)
        {
            return sourceNumberCount >= getNumberCount;
        }
        public static bool VerifyNumberRelationship(String sourceNumberCountText, String getNumberCountText)
        {
            int sourceNumberCount = int.Parse(sourceNumberCountText);
            int getNumberCount = int.Parse(getNumberCountText);
            return VerifyNumberRelationship(sourceNumberCount, getNumberCount);
        }
        public static bool VerifyNumberRelationship(String startNumberText,String endNumberText,String getNumberCountText)
        {
            int startNumber = int.Parse(startNumberText);
            int endNumber = int.Parse(endNumberText);
            int getNumberCount = int.Parse(getNumberCountText);
            int sourceNumberCount = endNumber - startNumber + 1;
            return VerifyNumberRelationship(sourceNumberCount, getNumberCount);
        }
    }
}
