using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBattle.Application.Features.AnswerQuestion
{
    public class AnswerQuestionResult
    {
        public AnswerQuestionResult(bool isCorrect)
        {
            IsCorrect = isCorrect;
        }
        public bool IsCorrect { get; }
    }
}
