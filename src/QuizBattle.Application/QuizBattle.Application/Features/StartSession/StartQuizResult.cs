using QuizBattle.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBattle.Application.Features.StartSession
{
    public class StartQuizResult
    {
        public StartQuizResult(Guid sessionId, IEnumerable<Domain.Question> questions)
        {
            SessionId = sessionId;
            Questions = questions;
        }
        public Guid SessionId { get; }
        public IEnumerable<Domain.Question> Questions { get; set; }
        }
}
