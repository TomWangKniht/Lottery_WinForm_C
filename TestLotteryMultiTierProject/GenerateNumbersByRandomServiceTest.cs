using System;
using System.Collections.Generic;
using System.Linq;
using LotteryWindowsFormsApplication.MultiTierMethod.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLotteryMultiTierProject
{
    /// <summary>
    ///This is a test class for GenerateNumbersByRandomServiceTest and is intended
    ///to contain all GenerateNumbersByRandomServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GenerateNumbersByRandomServiceTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        //
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //

        #endregion Additional test attributes

        /// <summary>
        ///A test for GenerateRandomsNumbersByCount
        /// 測試結果是否都在範圍內
        ///</summary>
        [TestMethod()]
        public void GenerateRandomsNumbersByCountTest_InRange()
        {
            GenerateNumbersByRandomService target = new GenerateNumbersByRandomService(); // TODO: Initialize to an appropriate value
            Random _random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int sourceNumberCount = _random.Next(100) + 1; // TODO: Initialize to an appropriate value
                int gettingNumberCount = _random.Next(sourceNumberCount) + 1; // TODO: Initialize to an appropriate value
                IEnumerable<int> actual;
                actual = target.GenerateRandomsNumbersByCount(sourceNumberCount, gettingNumberCount);
                Assert.IsTrue(actual.All(o => o >= 1 && o <= sourceNumberCount));
            }
            //int sourceNumberCount = _random.Next(100); // TODO: Initialize to an appropriate value
            //int gettingNumberCount = _random.Next(sourceNumberCount) + 1; // TODO: Initialize to an appropriate value
            //IEnumerable<int> actual;
            //actual = target.GenerateRandomsNumbersByCount(sourceNumberCount, gettingNumberCount);
            //正確應該是o <= sourceNumberCount
            //Assert.IsTrue(actual.All(o => o >= 1 && o < sourceNumberCount));
        }

        /// <summary>
        ///A test for GenerateRandomsNumbersByCount
        /// 測試數量是否正確
        ///</summary>
        [TestMethod()]
        public void GenerateRandomsNumbersByCountTest_CountRight()
        {
            GenerateNumbersByRandomService target = new GenerateNumbersByRandomService(); // TODO: Initialize to an appropriate value
            Random _random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int sourceNumberCount = _random.Next(100) + 1; // TODO: Initialize to an appropriate value
                int gettingNumberCount = _random.Next(sourceNumberCount) + 1;
                // TODO: Initialize to an appropriate value
                IEnumerable<int> actual;
                actual = target.GenerateRandomsNumbersByCount(sourceNumberCount, gettingNumberCount);
                Assert.IsTrue(actual.Count() == gettingNumberCount,
                    sourceNumberCount + "," + gettingNumberCount + ":" + actual.Count());
            }
            //如果sourceNumberCount為0就會出錯
            //int sourceNumberCount = _random.Next(100); // TODO: Initialize to an appropriate value
            //int gettingNumberCount = _random.Next(sourceNumberCount) + 1; // TODO: Initialize to an appropriate value
            //IEnumerable<int> actual;
            //actual = target.GenerateRandomsNumbersByCount(sourceNumberCount, gettingNumberCount);
            //Assert.IsTrue(actual.Count() == gettingNumberCount);
        }

        /// <summary>
        ///A test for GenerateRandomsNumbersByCount
        ///測試結果是否不連續
        ///</summary>
        [TestMethod()]
        public void GenerateRandomsNumbersByCountTest_NotContinuous()
        {
            GenerateNumbersByRandomService target = new GenerateNumbersByRandomService(); // TODO: Initialize to an appropriate value
            Random _random = new Random();
            for (int j = 0; j < 100; j++)
            {
                int sourceNumberCount = _random.Next(100) + 11; // TODO: Initialize to an appropriate value
                int gettingNumberCount = _random.Next(sourceNumberCount) + 10; // TODO: Initialize to an appropriate value
                IEnumerable<int> actual;
                actual = target.GenerateRandomsNumbersByCount(sourceNumberCount, gettingNumberCount);
                List<int> actualList = actual.ToList();
                bool flag = false;
                int lastValue = actualList.First();
                for (int i = 1; i < actualList.Count; i++)
                {
                    if (lastValue + 1 != actualList[i])
                    {
                        flag = true;
                        break;
                    }
                    lastValue = actualList[i];
                }
                Assert.IsTrue(flag);
            }
            //int sourceNumberCount = _random.Next(100) + 11; // TODO: Initialize to an appropriate value
            //int gettingNumberCount = _random.Next(sourceNumberCount) + 10; // TODO: Initialize to an appropriate value
            //IEnumerable<int> actual;
            //actual = target.GenerateRandomsNumbersByCount(sourceNumberCount, gettingNumberCount);
            //List<int> actualList = actual.ToList();
            //bool flag = false;
            //int lastValue = actualList.First();
            //for (int i = 1; i < actualList.Count; i++)
            //{
            //    if (lastValue + 1 != actualList[i])
            //    {
            //        flag = true;
            //        break;
            //    }
            //    lastValue = actualList[i];
            //}
            //Assert.IsTrue(flag);
        }

        /// <summary>
        ///A test for GenerateRandomNumbersByNumberRange
        ///</summary>
        [TestMethod()]
        public void GenerateRandomNumbersByNumberRangeTest_InRange()
        {
            GenerateNumbersByRandomService target = new GenerateNumbersByRandomService(); // TODO: Initialize to an appropriate value
            Random _random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int count = _random.Next(100) + 1;
                int sourceStartNumber = _random.Next(100); // TODO: Initialize to an appropriate value
                int sourceEndNumber = sourceStartNumber + count - 1; // TODO: Initialize to an appropriate value
                int gettingNumberCount = _random.Next(count) + 1; // TODO: Initialize to an appropriate value
                IEnumerable<int> expected = null; // TODO: Initialize to an appropriate value
                IEnumerable<int> actual;
                actual = target.GenerateRandomNumbersByNumberRange(sourceStartNumber, sourceEndNumber, gettingNumberCount);
                //String tempString = String.Join(",", actual.Where(o => o < sourceStartNumber || o > sourceEndNumber));
                //        Assert.IsTrue(actual.All(o => o >= sourceStartNumber && o <= sourceEndNumber),
                //sourceStartNumber + "," + sourceEndNumber + ":" + tempString);
                Assert.IsTrue(actual.All(o => o >= sourceStartNumber && o <= sourceEndNumber),
                    sourceStartNumber + "," + sourceEndNumber + "," + gettingNumberCount);
            }
            //        int count = _random.Next(100) + 1;
            //        int sourceStartNumber = _random.Next(100); // TODO: Initialize to an appropriate value
            //        int sourceEndNumber = sourceStartNumber + count - 1; // TODO: Initialize to an appropriate value
            //        int gettingNumberCount = _random.Next(count) + 1; // TODO: Initialize to an appropriate value
            //        IEnumerable<int> expected = null; // TODO: Initialize to an appropriate value
            //        IEnumerable<int> actual;
            //        actual = target.GenerateRandomNumbersByNumberRange(sourceStartNumber, sourceEndNumber, gettingNumberCount);
            //        String tempString = String.Join(",", actual.Where(o => o < sourceStartNumber || o > sourceEndNumber));
            //        Assert.IsTrue(actual.All(o => o >= sourceStartNumber && o <= sourceEndNumber),
            //sourceStartNumber + "," + sourceEndNumber + ":" + tempString);

            //Assert.IsTrue(actual.All(o => o >= sourceStartNumber && o <= sourceEndNumber),
            //    sourceStartNumber + "," + sourceEndNumber);
        }

        /// <summary>
        ///A test for GenerateRandomNumbersByNumberRange
        ///</summary>
        [TestMethod()]
        public void GenerateRandomNumbersByNumberRangeTest_Count()
        {
            GenerateNumbersByRandomService target = new GenerateNumbersByRandomService(); // TODO: Initialize to an appropriate value
            Random _random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int count = _random.Next(100) + 1;
                int sourceStartNumber = _random.Next(100); // TODO: Initialize to an appropriate value
                int sourceEndNumber = sourceStartNumber + count - 1; // TODO: Initialize to an appropriate value
                int gettingNumberCount = _random.Next(count) + 1; // TODO: Initialize to an appropriate value
                IEnumerable<int> actual;
                actual = target.GenerateRandomNumbersByNumberRange(sourceStartNumber, sourceEndNumber, gettingNumberCount);
                Assert.IsTrue(actual.Count() == gettingNumberCount,
                      sourceStartNumber + "," + sourceEndNumber + "," + gettingNumberCount + ":" + actual.Count());
            }

            //int count = _random.Next(100) + 1;
            //int sourceStartNumber = _random.Next(100); // TODO: Initialize to an appropriate value
            //int sourceEndNumber = sourceStartNumber + count - 1; // TODO: Initialize to an appropriate value
            //int gettingNumberCount = _random.Next(count) + 1; // TODO: Initialize to an appropriate value
            //IEnumerable<int> actual;
            //actual = target.GenerateRandomNumbersByNumberRange(sourceStartNumber, sourceEndNumber, gettingNumberCount);
            // sourceEndNumber - sourceStartNumber + 1應該是gettingNumberCount
            //Assert.IsTrue(actual.Count() == sourceEndNumber - sourceStartNumber + 1,
            //      sourceStartNumber + "," + sourceEndNumber + "," + gettingNumberCount + ":" + actual.Count());
        }

        /// <summary>
        ///A test for GenerateRandomNumbersByNumberRange
        ///</summary>
        [TestMethod()]
        public void GenerateRandomNumbersByNumberRangeTest_NotContinuous()
        {
            GenerateNumbersByRandomService target = new GenerateNumbersByRandomService(); // TODO: Initialize to an appropriate value
            Random _random = new Random();
            for (int j = 0; j < 100; j++)
            {
                int count = _random.Next(100) + 11;
                int sourceStartNumber = _random.Next(100); // TODO: Initialize to an appropriate value
                int sourceEndNumber = sourceStartNumber + count - 1; // TODO: Initialize to an appropriate value
                int gettingNumberCount = _random.Next(count) + 10; // TODO: Initialize to an appropriate value
                IEnumerable<int> actual;
                actual = target.GenerateRandomNumbersByNumberRange(sourceStartNumber, sourceEndNumber, gettingNumberCount);
                List<int> actualList = actual.ToList();
                bool flag = false;
                int lastValue = actualList.First();
                for (int i = 1; i < actualList.Count; i++)
                {
                    if (lastValue + 1 != actualList[i])
                    {
                        flag = true;
                        break;
                    }
                    lastValue = actualList[i];
                }
                String tempString = String.Join(",", actual.Where(o => o < sourceStartNumber || o > sourceEndNumber));
                Assert.IsTrue(flag, tempString);
            }
            //int count = _random.Next(100) + 1;
            //int sourceStartNumber = _random.Next(100); // TODO: Initialize to an appropriate value
            //int sourceEndNumber = sourceStartNumber + count - 1; // TODO: Initialize to an appropriate value
            //int gettingNumberCount = _random.Next(count) + 1; // TODO: Initialize to an appropriate value
            //IEnumerable<int> actual;
            //actual = target.GenerateRandomNumbersByNumberRange(sourceStartNumber, sourceEndNumber, gettingNumberCount);
            //List<int> actualList = actual.ToList();
            //bool flag = false;
            //int lastValue = actualList.First();
            //for (int i = 1; i < actualList.Count; i++)
            //{
            //    if (lastValue + 1 != actualList[i])
            //    {
            //        flag = true;
            //        break;
            //    }
            //    lastValue = actualList[i];
            //}
            //Assert.IsTrue(flag);
        }
    }
}