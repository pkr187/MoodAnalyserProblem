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
        //Refactor code
        // Refactor TC 1.1 Given “I am in Sad Mood” message Should Return SAD.
        [TestMethod]
        public void GivenSadMood_WhenAnalyse_ShouldReturnSAD()
        {
            string expectedValue = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string result = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(expectedValue, result);
        }
        // Refactor TC 1.2 Given “I am in Happy Mood” message Should Return SAD.
        [TestMethod]
        public void GivenAnyMood_ShouldReturnHAPPY()
        {
            string expectedValue = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(expectedValue, mood);
        }
    }
}