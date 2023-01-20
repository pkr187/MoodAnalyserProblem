using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestMethod]
        //UC2
        // TC 2.1: Given null mood Should Return HAPPY
        [TestMethod]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
            try
            {
                string actutal = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
    }
}
