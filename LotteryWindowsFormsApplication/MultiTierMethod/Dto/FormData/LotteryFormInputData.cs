using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LotteryWindowsFormsApplication.MultiTierMethod.Util.Enum;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Dto.FormData
{
    public class LotteryFormInputData
    {
        public Tuple<String, String> SourceNumberCountTuple
        {
            get;
            set;
        }

        public Tuple<String, String> StartNumberTuple
        {
            get;
            set;
        }

        public Tuple<String, String> EndNumberTuple
        {
            get;
            set;
        }

        public Tuple<String, Boolean> HasSpecialNumberTuple
        {
            get;
            set;
        }

        public Tuple<String, String> GettingNumberCountTuple
        {
            get;
            set;
        }

        public Tuple<String, EnumNumberSourceType> NumberSourceTypeTuple
        {
            get;
            set;
        }
    }
}