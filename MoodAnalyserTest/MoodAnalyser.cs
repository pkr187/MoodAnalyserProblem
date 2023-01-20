using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestMethod]
        public void GivenSadMoodMessage_WhenAnalyse_ShouldReturnSAD()
        {

            string message = "I am sad mood";
            string expectedValue = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string result = moodAnalyser.AnalyseMood(message);

            Assert.AreEqual(expectedValue, result);
        }
        //Display Happy message
        //TC 1.2
        [TestMethod]
        public void GivenSadMoodMessage_WhenAnalyse_ShouldReturnHAPPY()
        {

            string message = "I am happy mood";
            string expectedValue = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string result = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(expectedValue, result);
        }
    }
}