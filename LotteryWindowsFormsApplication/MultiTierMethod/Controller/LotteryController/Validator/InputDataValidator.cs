using System;
using System.Collections.Generic;
using LotteryWindowsFormsApplication.MultiTierMethod.Dto.FormData;
using LotteryWindowsFormsApplication.MultiTierMethod.Util.Enum;

namespace LotteryWindowsFormsApplication.MultiTierMethod.Controller.LotteryController.Validator
{
    public class InputDataValidator : IInputDataValidator
    {
        private int _minSourceNumberCount = 1;

        public int MinSourceNumberCount
        {
            set { _minSourceNumberCount = value; }
        }

        private int _minGettingNumberCount = 1;

        public int MinGettingNumberCount
        {
            set { _minGettingNumberCount = value; }
        }

        private readonly IValidatorMessage _validatorMessage = new ValidatorMessage();

        private EnumNumberSourceType _tempNumberSourceType;
        private int _tempSourceNumberCount;
        private int _tempStartNumber;
        private int _tempEndNumber;
        private int _tempGettingNumberCount;
        private bool _tempHasSpecialNumber;

        private readonly List<String> _errorMessages;

        /// <summary>
        ///
        /// </summary>
        /// <param name="lotteryFormData"></param>
        ///<param name="errorMessages">輸出的錯誤訊息</param>
        ///<returns>true Pass,false Fail</returns>
        public virtual bool Validate(LotteryFormInputData lotteryFormData, out IList<String> errorMessages)
        {
            //1.驗證格式
            //2.驗證業務邏輯
            _errorMessages.Clear();
            errorMessages = _errorMessages;
            if (!CheckFormat(lotteryFormData))
            {
                //如果驗證失敗，進行業務邏輯的驗證會發生異常
                return false;
            }
            return CheckLogic(lotteryFormData);
        }

        private bool CheckLogic(LotteryFormInputData lotteryFormData)
        {
            if (_tempGettingNumberCount < _minGettingNumberCount)
            {
                CommonWriteMustGraterThan(lotteryFormData.GettingNumberCountTuple.Item1, _minGettingNumberCount);
                return false;
            }
            if (_tempNumberSourceType == EnumNumberSourceType.Count)
            {
                return CommonLogicValidate(_tempSourceNumberCount,
                                           lotteryFormData.SourceNumberCountTuple.Item1,
                                           lotteryFormData.GettingNumberCountTuple.Item1);
            }
            if (_tempNumberSourceType == EnumNumberSourceType.NumberRange)
            {
                if (_tempStartNumber > _tempEndNumber)
                {
                    CommonWriteMustGraterEqual(lotteryFormData.StartNumberTuple.Item1,
                                               lotteryFormData.EndNumberTuple.Item1);
                }

                return CommonLogicValidate(_tempEndNumber - _tempStartNumber + 1,
                           _validatorMessage.SourceNumberConut,
                           lotteryFormData.GettingNumberCountTuple.Item1);
            }
            _errorMessages.Add(_validatorMessage.Field + " " + lotteryFormData.NumberSourceTypeTuple.Item1 + " " + _validatorMessage.InputDataAbnormal);
            return false;
        }

        private bool CommonLogicValidate(int sourceCount, String sourceFieldName, String gettingNumberCountFieldName)
        {
            if (_tempHasSpecialNumber && sourceCount <= _tempGettingNumberCount + 1)
            {
                CommonWriteMustGraterThan(sourceFieldName, gettingNumberCountFieldName + _validatorMessage.PlusOne);
                return false;
            }
            if (sourceCount <= _tempGettingNumberCount)
            {
                CommonWriteMustGraterThan(sourceFieldName, gettingNumberCountFieldName);
                return false;
            }
            if (sourceCount < _minSourceNumberCount)
            {
                CommonWriteMustGraterEqual(sourceFieldName, _minSourceNumberCount);
                return false;
            }
            return true;
        }

        private void CommonWriteMustGraterEqual(String fieldName1, int greaterNumber)
        {
            _errorMessages.Add(fieldName1 + " " + _validatorMessage.MustGreaterEqual + " " + greaterNumber);
        }

        private void CommonWriteMustGraterEqual(String fieldName1, String fieldName2)
        {
            _errorMessages.Add(fieldName1 + " " + _validatorMessage.MustGreaterEqual + " " + fieldName2);
        }

        private void CommonWriteMustGraterThan(String fieldName1, String fieldName2)
        {
            _errorMessages.Add(fieldName1 + " " + _validatorMessage.MustGreaterThan + " " + fieldName2);
        }

        private void CommonWriteMustGraterThan(String fieldName1, int greaterNumber)
        {
            _errorMessages.Add(fieldName1 + " " + _validatorMessage.MustGreaterThan + " " + greaterNumber);
        }

        private bool CheckFormat(LotteryFormInputData lotteryFormData)
        {
            //^[0-9]+$
            //直接把數字轉出來，存入實體變數
            _tempNumberSourceType = lotteryFormData.NumberSourceTypeTuple.Item2;
            if (_tempNumberSourceType == EnumNumberSourceType.Count)
            {
                if (!VerifyTupleAndGetNumber(lotteryFormData.SourceNumberCountTuple, ref _tempSourceNumberCount))
                {
                    return false;
                }
            }
            else if (_tempNumberSourceType == EnumNumberSourceType.NumberRange)
            {
                if (!(VerifyTupleAndGetNumber(lotteryFormData.StartNumberTuple, ref _tempStartNumber) &&
                    VerifyTupleAndGetNumber(lotteryFormData.EndNumberTuple, ref _tempEndNumber)))
                {
                    return false;
                }
            }
            else
            {
                //除非程式異常，否則不可能出現的錯誤
                _errorMessages.Add(_validatorMessage.Field + " " + lotteryFormData.NumberSourceTypeTuple.Item1 + " " + _validatorMessage.InputDataAbnormal);
                return false;
            }
            if (!VerifyTupleAndGetNumber(lotteryFormData.GettingNumberCountTuple, ref _tempGettingNumberCount))
            {
                return false;
            }

            //此項目沒有格式的驗證
            _tempHasSpecialNumber = lotteryFormData.HasSpecialNumberTuple.Item2;
            return true;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="tuple"></param>
        /// <param name="instanceNumber"></param>
        /// <returns>true Pass,false Fail</returns>
        private bool VerifyTupleAndGetNumber(Tuple<String, String> tuple, ref int instanceNumber)
        {
            try
            {
                instanceNumber = int.Parse(tuple.Item2);
            }
            catch (Exception)
            {
                CommonWriteFormatError(tuple.Item1);
                return false;
            }
            return true;
        }

        private void CommonWriteFormatError(String fieldName)
        {
            _errorMessages.Add(_validatorMessage.Field + " " + fieldName + " " + _validatorMessage.FormatError);
        }

        public InputDataValidator()
        {
            _errorMessages = new List<string>();
        }
    }
}