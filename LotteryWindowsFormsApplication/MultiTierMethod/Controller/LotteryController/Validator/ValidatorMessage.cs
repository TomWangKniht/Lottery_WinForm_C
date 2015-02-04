using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController.Validator
{
    public class ValidatorMessage : IValidatorMessage
    {
        public virtual string Field
        {
            get { return "欄位"; }
        }

        public virtual string FormatError
        {
            get { return "格式錯誤"; }
        }

        public virtual string InputDataAbnormal
        {
            get { return "輸入資料異常"; }
        }

        public virtual string MustGreaterEqual
        {
            get { return "必須大於等於"; }
        }

        public virtual string MustGreaterThan
        {
            get { return "必須大於"; }
        }

        public virtual string PlusOne
        {
            get { return "加1"; }
        }

        public virtual string SourceNumber
        {
            get { return "來源號碼"; }
        }

        public virtual string SourceNumberConut
        {
            get { return "來源號碼的個數"; }
        }
    }
}