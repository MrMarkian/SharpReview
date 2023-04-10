using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpReview.Data
{
    public class FlashCard
    {
        public String QuestionText;
        public String CorrectSingleAnswer;
        public List<(bool isCorrect, string AnswerText)> CorrectMultiAnswers;
        public List<String> PossibleAnswers;

        public AnswerType AnswerType;
        public String Subject;

        public FlashCard()
        {
            
 
        }

        public FlashCard(string questionText, string correctSingleAnswer, AnswerType answerType, string subject)
        {
            QuestionText = questionText;
            CorrectSingleAnswer = correctSingleAnswer;
            AnswerType = answerType;
            Subject = subject;
        }

        public bool CheckSingleAnswer(String answerText)
        {
            return CorrectSingleAnswer.Equals(answerText);
        }

        public override string ToString()
        {
            return QuestionText;
        }
    }
}
