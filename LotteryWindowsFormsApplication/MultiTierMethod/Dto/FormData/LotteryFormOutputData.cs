using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Dto.FormData
{
    public class LotteryFormOutputData
    {
        public IList<String> ErrorMessageList
        {
            get;
            set;
        }

        public bool IsSuccess
        {
            get;
            set;
        }

        public bool HasSpecialNumber
        {
            get;
            set;
        }

        public int SpecialNumber
        {
            get;
            set;
        }

        public List<int> LotteryNumbers
        {
            get;
            set;
        }
    }
}