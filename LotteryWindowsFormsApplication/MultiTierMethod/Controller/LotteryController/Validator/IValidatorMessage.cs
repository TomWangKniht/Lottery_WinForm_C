using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController.Validator
{
    public interface IValidatorMessage
    {
        string FormatError { get; }

        string Field { get; }

        string SourceNumber { get; }

        string InputDataAbnormal { get; }

        string MustGreaterThan { get; }

        string MustGreaterEqual { get; }

        string PlusOne { get; }

        string SourceNumberConut { get; }
    }
}