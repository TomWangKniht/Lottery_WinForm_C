using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LotteryWindowsFormsApplication.staticMethod;

namespace LotteryWindowsFormsApplication
{
    public partial class LotteryForm : Form
    {
        public LotteryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void radioButtonNumber_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumberCount.ReadOnly = true;
            textBoxStartNumber.ReadOnly = false;
            textBoxEndNumber.ReadOnly = false;
           
        }

        private void radioButtonCount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumberCount.ReadOnly = false;
            textBoxStartNumber.ReadOnly = true;
            textBoxEndNumber.ReadOnly = true;
        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                return;
            }
            int[] result;
            if(radioButtonCount.Checked)
            {
                int sourceNumberCount = int.Parse(textBoxNumberCount.Text);
                int getNumberCount = int.Parse(textBoxGetCount.Text);
                result = StaticLotteryNumberGenerator.Generator(sourceNumberCount, getNumberCount);
            }
           
            else
            {
                int startNumber = int.Parse(textBoxStartNumber.Text);
                int endNumber = int.Parse(textBoxEndNumber.Text);
                int getNumberCount = int.Parse(textBoxGetCount.Text);
                result = StaticLotteryNumberGenerator.Generator(startNumber, endNumber, getNumberCount);
            }
            //int startNumber, int endNumber, int getNumberCount
            int endIndex = CheckBoxSpecialNumber.Checked ? result.Length - 2 : result.Length - 1;

            String rsultString = "產生號碼:\r\n";
            for (int i = 0; i < endIndex; i++)
            {
                rsultString += result[i] + ",";
            }
            rsultString += result[endIndex];
            if (CheckBoxSpecialNumber.Checked)
            {
                rsultString += "\r\n特別號碼:\r\n";
                rsultString += result[endIndex+1];
            }
            textBoxResult.Text = rsultString;
        }
        private bool Validate()
        {
             if(!StaticValidator.VerifyGetNumberSetting(CheckBoxSpecialNumber.Checked, textBoxGetCount.Text))
             {
                 String showString = "取得號碼的個數設定值必須為數字，且數值大於0。";
                 if (CheckBoxSpecialNumber.Checked==true)
                 {
                     showString += "設定有特別號時，取得號碼的個數設定值必須大於等於1";
                 }
                 MessageBox.Show(showString);
                 return false;
             }
            if(radioButtonCount.Checked)
            {
                if(!StaticValidator.VerifyNumber(textBoxNumberCount.Text))
                {
                    MessageBox.Show("來源號碼的個數必須為數字，且數值大於0");
                    return false;
                }
                if(!StaticValidator.VerifyNumberRelationship(textBoxNumberCount.Text,textBoxGetCount.Text))
                {
                    MessageBox.Show("取得的個數必須小於等於來源號碼的個數");
                    return false;
                }
            }
            else
            {
                if (!StaticValidator.VerifyNumberRange(textBoxStartNumber.Text,textBoxEndNumber.Text))
                {
                    MessageBox.Show("來源號碼的範圍數值必須為數字，且開始號碼必須小於等於結束號碼");
                    return false;
                }
                if (!StaticValidator.VerifyNumberRelationship(textBoxStartNumber.Text, textBoxEndNumber.Text, textBoxGetCount.Text))
                {
                    MessageBox.Show("取得的個數必須小於等於來源號碼的個數");
                    return false;
                }
            }
            return true;
        }



    }
}
