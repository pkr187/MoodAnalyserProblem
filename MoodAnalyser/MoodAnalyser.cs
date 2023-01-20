using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Message is Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Message is ull");
            }
        }
    }
}